/*
 
  This Source Code Form is subject to the terms of the Mozilla Public
  License, v. 2.0. If a copy of the MPL was not distributed with this
  file, You can obtain one at http://mozilla.org/MPL/2.0/.
 
  Copyright (C) 2011 Michael Möller <mmoeller@openhardwaremonitor.org>
	
*/

using System;
using System.IO;
using System.Text;

namespace HardwareProviders.Board
{
    public class GigabyteTAMG
    {
        private readonly TamgSensor[] _tamgSensors;
        private readonly byte[] table;

        public GigabyteTAMG(byte[] table)
        {
            this.table = table ?? throw new ArgumentNullException(nameof(table));

            var index = IndexOf(table, Encoding.ASCII.GetBytes("$HEALTH$"), 0);

            if (index >= 0)
            {
                index += 8;
                using (var m =
                    new MemoryStream(table, index, table.Length - index))
                using (var r = new BinaryReader(m))
                {
                    try
                    {
                        r.ReadInt64();
                        var count = r.ReadInt32();
                        r.ReadInt64();
                        r.ReadInt32();
                        _tamgSensors = new TamgSensor[count];
                        for (var i = 0; i < _tamgSensors.Length; i++)
                        {
                            _tamgSensors[i].Name = new string(r.ReadChars(32)).TrimEnd('\0');
                            _tamgSensors[i].Type = (TamgSensorType) r.ReadByte();
                            _tamgSensors[i].Channel = r.ReadInt16();
                            _tamgSensors[i].Channel |= r.ReadByte() << 24;
                            r.ReadInt64();
                            var value = r.ReadInt32();
                            switch (_tamgSensors[i].Type)
                            {
                                case TamgSensorType.Voltage:
                                    _tamgSensors[i].Value = 1e-3f * value;
                                    break;
                                default:
                                    _tamgSensors[i].Value = value;
                                    break;
                            }

                            r.ReadInt64();
                        }
                    }
                    catch (IOException)
                    {
                        _tamgSensors = new TamgSensor[0];
                    }
                }
            }
            else
            {
                _tamgSensors = new TamgSensor[0];
            }
        }

        public static int IndexOf(byte[] array, byte[] pattern, int startIndex)
        {
            if (array == null || pattern == null || pattern.Length > array.Length)
                return -1;

            for (var i = startIndex; i < array.Length - pattern.Length; i++)
            {
                var found = true;
                for (var j = 0; j < pattern.Length; j++)
                    if (array[i + j] != pattern[j])
                    {
                        found = false;
                        break;
                    }

                if (found)
                    return i;
            }

            return -1;
        }
    }
}