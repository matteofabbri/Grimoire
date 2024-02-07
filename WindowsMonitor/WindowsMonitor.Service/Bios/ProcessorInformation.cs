/*
 
  This Source Code Form is subject to the terms of the Mozilla Public
  License, v. 2.0. If a copy of the MPL was not distributed with this
  file, You can obtain one at http://mozilla.org/MPL/2.0/.
 
  Copyright (C) 2009-2012 Michael Möller <mmoeller@openhardwaremonitor.org>
	
*/


namespace WindowsMonitor.Bios
{
    public class ProcessorInformation : Structure
    {
        public string ManufacturerName { get; }

        public string Version { get; }

        public int CoreCount { get; }

        public int CoreEnabled { get; }

        public int ThreadCount { get; }

        public int ExternalClock { get; }

        public ProcessorInformation(byte type, ushort handle, byte[] data,
            string[] strings)
            : base(type, handle, data, strings)
        {
            ManufacturerName = GetString(0x07).Trim();
            Version = GetString(0x10).Trim();
            CoreCount = GetByte(0x23);
            CoreEnabled = GetByte(0x24);
            ThreadCount = GetByte(0x25);
            ExternalClock = GetWord(0x12);
        }
    }
}