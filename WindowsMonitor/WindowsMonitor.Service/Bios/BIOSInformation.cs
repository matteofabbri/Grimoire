/*
 
  This Source Code Form is subject to the terms of the Mozilla Public
  License, v. 2.0. If a copy of the MPL was not distributed with this
  file, You can obtain one at http://mozilla.org/MPL/2.0/.
 
  Copyright (C) 2009-2012 Michael Möller <mmoeller@openhardwaremonitor.org>
	
*/


namespace WindowsMonitor.Bios
{
    public class BiosInformation : Structure
    {
        public string Vendor { get; }

        public string Version { get; }

        public BiosInformation(string vendor, string version)
            : base(0x00, 0, null, null)
        {
            Vendor = vendor;
            Version = version;
        }

        public BiosInformation(byte type, ushort handle, byte[] data,
            string[] strings)
            : base(type, handle, data, strings)
        {
            Vendor = GetString(0x04);
            Version = GetString(0x05);
        }
    }
}