/*
 
  This Source Code Form is subject to the terms of the Mozilla Public
  License, v. 2.0. If a copy of the MPL was not distributed with this
  file, You can obtain one at http://mozilla.org/MPL/2.0/.
 
  Copyright (C) 2009-2012 Michael Möller <mmoeller@openhardwaremonitor.org>
	
*/


namespace WindowsMonitor.Bios
{
    public class SystemInformation : Structure
    {
        public SystemInformation(string manufacturerName, string productName,
            string version, string serialNumber, string family)
            : base(0x01, 0, null, null)
        {
            ManufacturerName = manufacturerName;
            ProductName = productName;
            Version = version;
            SerialNumber = serialNumber;
            Family = family;
        }

        public SystemInformation(byte type, ushort handle, byte[] data,
            string[] strings)
            : base(type, handle, data, strings)
        {
            ManufacturerName = GetString(0x04);
            ProductName = GetString(0x05);
            Version = GetString(0x06);
            SerialNumber = GetString(0x07);
            Family = GetString(0x1A);
        }

        public string ManufacturerName { get; }

        public string ProductName { get; }

        public string Version { get; }

        public string SerialNumber { get; }

        public string Family { get; }
    }
}