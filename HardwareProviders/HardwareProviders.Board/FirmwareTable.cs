﻿/*
 
  This Source Code Form is subject to the terms of the Mozilla Public
  License, v. 2.0. If a copy of the MPL was not distributed with this
  file, You can obtain one at http://mozilla.org/MPL/2.0/.
 
  Copyright (C) 2011 Michael Möller <mmoeller@openhardwaremonitor.org>
	
*/

using System;
using System.Runtime.InteropServices;
using System.Text;

namespace HardwareProviders.Board
{
    public static class FirmwareTable
    {
        public enum Provider
        {
            ACPI = ((byte) 'A' << 24) | ((byte) 'C' << 16) | ((byte) 'P' << 8) | (byte) 'I',
            FIRM = ((byte) 'F' << 24) | ((byte) 'I' << 16) | ((byte) 'R' << 8) | (byte) 'M',
            RSMB = ((byte) 'R' << 24) | ((byte) 'S' << 16) | ((byte) 'M' << 8) | (byte) 'B'
        }

        public static byte[] GetTable(Provider provider, string table)
        {
            var id = (table[3] << 24) | (table[2] << 16) | (table[1] << 8) | table[0];
            return GetTable(provider, id);
        }

        public static byte[] GetTable(Provider provider, int table)
        {
            int size;
            try
            {
                size = SystemCall.GetSystemFirmwareTable(provider, table,
                    IntPtr.Zero, 0);
            }
            catch (DllNotFoundException)
            {
                return null;
            }
            catch (EntryPointNotFoundException)
            {
                return null;
            }

            if (size <= 0)
                return null;

            var nativeBuffer = Marshal.AllocHGlobal(size);
            SystemCall.GetSystemFirmwareTable(provider, table, nativeBuffer, size);

            if (Marshal.GetLastWin32Error() != 0)
                return null;

            var buffer = new byte[size];
            Marshal.Copy(nativeBuffer, buffer, 0, size);
            Marshal.FreeHGlobal(nativeBuffer);

            return buffer;
        }

        public static string[] EnumerateTables(Provider provider)
        {
            int size;
            try
            {
                size = SystemCall.EnumSystemFirmwareTables(
                    provider, IntPtr.Zero, 0);
            }
            catch (DllNotFoundException)
            {
                return null;
            }
            catch (EntryPointNotFoundException)
            {
                return null;
            }

            var nativeBuffer = Marshal.AllocHGlobal(size);
            SystemCall.EnumSystemFirmwareTables(
                provider, nativeBuffer, size);
            var buffer = new byte[size];
            Marshal.Copy(nativeBuffer, buffer, 0, size);
            Marshal.FreeHGlobal(nativeBuffer);

            var result = new string[size / 4];
            for (var i = 0; i < result.Length; i++)
                result[i] = Encoding.ASCII.GetString(buffer, 4 * i, 4);

            return result;
        }
    }
}