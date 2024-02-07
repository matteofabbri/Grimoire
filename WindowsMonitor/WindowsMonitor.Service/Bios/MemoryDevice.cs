/*
 
  This Source Code Form is subject to the terms of the Mozilla Public
  License, v. 2.0. If a copy of the MPL was not distributed with this
  file, You can obtain one at http://mozilla.org/MPL/2.0/.
 
  Copyright (C) 2009-2012 Michael Möller <mmoeller@openhardwaremonitor.org>
	
*/


namespace WindowsMonitor.Bios
{
    public class MemoryDevice : Structure
    {
        public string DeviceLocator { get; }

        public string BankLocator { get; }

        public string ManufacturerName { get; }

        public string SerialNumber { get; }

        public string PartNumber { get; }

        public int Speed { get; }

        public MemoryDevice(byte type, ushort handle, byte[] data,
            string[] strings)
            : base(type, handle, data, strings)
        {
            DeviceLocator = GetString(0x10).Trim();
            BankLocator = GetString(0x11).Trim();
            ManufacturerName = GetString(0x17).Trim();
            SerialNumber = GetString(0x18).Trim();
            PartNumber = GetString(0x1A).Trim();
            Speed = GetWord(0x15);
        }
    }
}