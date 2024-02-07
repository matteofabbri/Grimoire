/*
 
  This Source Code Form is subject to the terms of the Mozilla Public
  License, v. 2.0. If a copy of the MPL was not distributed with this
  file, You can obtain one at http://mozilla.org/MPL/2.0/.
 
  Copyright (C) 2009-2012 Michael Möller <mmoeller@openhardwaremonitor.org>
	
*/


using WindowsMonitor.Bios;

namespace WindowsMonitor
{
    public class BaseBoardInformation : Structure
    {
        public string ManufacturerName { get; }

        public string ProductName { get; }

        public string Version { get; }

        public string SerialNumber { get; }

        public BaseBoardInformation(string manufacturerName, string productName,
            string version, string serialNumber)
            : base(0x02, 0, null, null)
        {
            ManufacturerName = manufacturerName;
            ProductName = productName;
            Version = version;
            SerialNumber = serialNumber;
        }

        public BaseBoardInformation(byte type, ushort handle, byte[] data,
            string[] strings)
            : base(type, handle, data, strings)
        {
            ManufacturerName = GetString(0x04).Trim();
            ProductName = GetString(0x05).Trim();
            Version = GetString(0x06).Trim();
            SerialNumber = GetString(0x07).Trim();
        }
    }
}