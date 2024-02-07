/*
 
  This Source Code Form is subject to the terms of the Mozilla Public
  License, v. 2.0. If a copy of the MPL was not distributed with this
  file, You can obtain one at http://mozilla.org/MPL/2.0/.
 
  Copyright (C) 2009-2012 Michael Möller <mmoeller@openhardwaremonitor.org>
	
*/

using System;
using System.Collections.Generic;
using System.Text;
using WindowsMonitor.Hardware.Bios;

namespace WindowsMonitor.Bios
{
    public class Smbios
    {
        private readonly byte[] _raw;

        private Structure[] Table { get; }

        public Version Version { get; }

        public BiosInformation Bios { get; }

        public SystemInformation System { get; }

        public BaseBoardInformation Board { get; }

        public ProcessorInformation Processor { get; }

        public MemoryDevice[] MemoryDevices { get; }

        public Smbios()
        {
            var structureList = new List<Structure>();
            var memoryDeviceList = new List<MemoryDevice>();

            _raw = null;
            byte majorVersion = 0;
            byte minorVersion = 0;
            try
            {
                foreach (var mo in SmBiosRawSmBiosTables.Retrieve())
                {
                    _raw = mo.SmBiosData;
                    majorVersion = mo.SmbiosMajorVersion;
                    minorVersion = mo.SmbiosMinorVersion;
                    break;
                }
            }
            catch
            {
            }

            if (majorVersion > 0 || minorVersion > 0)
                Version = new Version(majorVersion, minorVersion);

            if (_raw != null && _raw.Length > 0)
            {
                var offset = 0;
                var type = _raw[offset];
                while (offset + 4 < _raw.Length && type != 127)
                {
                    type = _raw[offset];
                    int length = _raw[offset + 1];
                    var handle = (ushort) ((_raw[offset + 2] << 8) | _raw[offset + 3]);

                    if (offset + length > _raw.Length)
                        break;
                    var data = new byte[length];
                    Array.Copy(_raw, offset, data, 0, length);
                    offset += length;

                    var stringsList = new List<string>();
                    if (offset < _raw.Length && _raw[offset] == 0)
                        offset++;

                    while (offset < _raw.Length && _raw[offset] != 0)
                    {
                        var sb = new StringBuilder();
                        while (offset < _raw.Length && _raw[offset] != 0)
                        {
                            sb.Append((char) _raw[offset]);
                            offset++;
                        }

                        offset++;
                        stringsList.Add(sb.ToString());
                    }

                    offset++;
                    switch (type)
                    {
                        case 0x00:
                            Bios = new BiosInformation(type, handle, data, stringsList.ToArray());
                            structureList.Add(Bios);
                            break;
                        case 0x01:
                            System = new SystemInformation(type, handle, data, stringsList.ToArray());
                            structureList.Add(System);
                            break;
                        case 0x02:
                            Board = new BaseBoardInformation(type, handle, data, stringsList.ToArray());
                            structureList.Add(Board);
                            break;
                        case 0x04:
                            Processor = new ProcessorInformation(type, handle, data, stringsList.ToArray());
                            structureList.Add(Processor);
                            break;
                        case 0x11:
                            var m = new MemoryDevice(type, handle, data, stringsList.ToArray());
                            memoryDeviceList.Add(m);
                            structureList.Add(m);
                            break;
                        default:
                            structureList.Add(new Structure(type, handle, data, stringsList.ToArray()));
                            break;
                    }
                }
            }

            MemoryDevices = memoryDeviceList.ToArray();
            Table = structureList.ToArray();
        }
    }
}