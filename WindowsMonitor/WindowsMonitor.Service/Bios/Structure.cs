/*
 
  This Source Code Form is subject to the terms of the Mozilla Public
  License, v. 2.0. If a copy of the MPL was not distributed with this
  file, You can obtain one at http://mozilla.org/MPL/2.0/.
 
  Copyright (C) 2009-2012 Michael Möller <mmoeller@openhardwaremonitor.org>
	
*/


namespace WindowsMonitor.Bios
{
    public class Structure
    {
        private readonly byte[] _data;
        private readonly string[] _strings;

        public Structure(byte type, ushort handle, byte[] data, string[] strings)
        {
            Type = type;
            Handle = handle;
            this._data = data;
            this._strings = strings;
        }

        public byte Type { get; }

        public ushort Handle { get; }

        protected int GetByte(int offset)
        {
            if (offset < _data.Length && offset >= 0)
                return _data[offset];
            return 0;
        }

        protected int GetWord(int offset)
        {
            if (offset + 1 < _data.Length && offset >= 0)
                return (_data[offset + 1] << 8) | _data[offset];
            return 0;
        }

        protected string GetString(int offset)
        {
            if (offset < _data.Length && _data[offset] > 0 &&
                _data[offset] <= _strings.Length)
                return _strings[_data[offset] - 1];
            return "";
        }
    }
}