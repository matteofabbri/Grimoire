﻿/*
 
  This Source Code Form is subject to the terms of the Mozilla Public
  License, v. 2.0. If a copy of the MPL was not distributed with this
  file, You can obtain one at http://mozilla.org/MPL/2.0/.
 
  Copyright (C) 2009-2012 Michael Möller <mmoeller@openhardwaremonitor.org>
	Copyright (C) 2010 Paul Werelds
  Copyright (C) 2011 Roland Reinl <roland-reinl@gmx.de>
	
*/

using System;
using System.Collections.Generic;
using System.Management;
using System.Runtime.InteropServices;

namespace HardwareProviders.HDD
{
    internal class WindowsSmart : ISmart
    {
        private const byte SMART_LBA_MID = 0x4F;
        private const byte SMART_LBA_HI = 0xC2;

        private const int MAX_DRIVE_ATTRIBUTES = 512;

        public IntPtr InvalidHandle => (IntPtr) (-1);

        public IntPtr OpenDrive(int driveNumber)
        {
            return SystemCall.CreateFile(@"\\.\PhysicalDrive" + driveNumber,
                AccessMode.Read | AccessMode.Write, ShareMode.Read | ShareMode.Write,
                IntPtr.Zero, CreationMode.OpenExisting, FileAttribute.Device,
                IntPtr.Zero);
        }

        public bool EnableSmart(IntPtr handle, int driveNumber)
        {
            var parameter = new DriveCommandParameter
            {
                DriveNumber = (byte) driveNumber,
                Registers =
                {
                    Features = RegisterFeature.SmartEnableOperations,
                    LBAMid = SMART_LBA_MID,
                    LBAHigh = SMART_LBA_HI,
                    Command = RegisterCommand.SmartCmd
                }
            };


            return SystemCall.DeviceIoControl(handle, DriveCommand.SendDriveCommand,
                ref parameter, Marshal.SizeOf(typeof(DriveCommandParameter)), out DriveCommandResult _,
                Marshal.SizeOf(typeof(DriveCommandResult)), out _,
                IntPtr.Zero);
        }

        public DriveAttributeValue[] ReadSmartData(IntPtr handle, int driveNumber)
        {
            var parameter = new DriveCommandParameter
            {
                DriveNumber = (byte) driveNumber,
                Registers =
                {
                    Features = RegisterFeature.SmartReadData,
                    LBAMid = SMART_LBA_MID,
                    LBAHigh = SMART_LBA_HI,
                    Command = RegisterCommand.SmartCmd
                }
            };


            var isValid = SystemCall.DeviceIoControl(handle,
                DriveCommand.ReceiveDriveData, ref parameter, Marshal.SizeOf(parameter),
                out DriveSmartReadDataResult result, Marshal.SizeOf(typeof(DriveSmartReadDataResult)),
                out _, IntPtr.Zero);

            return isValid ? result.Attributes : new DriveAttributeValue[0];
        }

        public DriveThresholdValue[] ReadSmartThresholds(IntPtr handle,
            int driveNumber)
        {
            var parameter = new DriveCommandParameter
            {
                DriveNumber = (byte) driveNumber,
                Registers =
                {
                    Features = RegisterFeature.SmartReadThresholds,
                    LBAMid = SMART_LBA_MID,
                    LBAHigh = SMART_LBA_HI,
                    Command = RegisterCommand.SmartCmd
                }
            };


            var isValid = SystemCall.DeviceIoControl(handle,
                DriveCommand.ReceiveDriveData, ref parameter, Marshal.SizeOf(parameter),
                out DriveSmartReadThresholdsResult result, Marshal.SizeOf(typeof(DriveSmartReadThresholdsResult)),
                out _, IntPtr.Zero);

            return isValid ? result.Thresholds : new DriveThresholdValue[0];
        }

        public bool ReadNameAndFirmwareRevision(IntPtr handle, int driveNumber,
            out string name, out string firmwareRevision)
        {
            var parameter = new DriveCommandParameter
            {
                DriveNumber = (byte) driveNumber,
                Registers = {Command = RegisterCommand.IdCmd}
            };


            var valid = SystemCall.DeviceIoControl(handle,
                DriveCommand.ReceiveDriveData, ref parameter, Marshal.SizeOf(parameter),
                out DriveIdentifyResult result, Marshal.SizeOf(typeof(DriveIdentifyResult)),
                out _, IntPtr.Zero);

            if (!valid)
            {
                name = null;
                firmwareRevision = null;
                return false;
            }

            name = GetString(result.Identify.ModelNumber);
            firmwareRevision = GetString(result.Identify.FirmwareRevision);
            return true;
        }

        public void CloseHandle(IntPtr handle)
        {
            SystemCall.CloseHandle(handle);
        }

        public string[] GetLogicalDrives(int driveIndex)
        {
            var list = new List<string>();
            try
            {
                using (var s = new ManagementObjectSearcher(
                    "root\\CIMV2",
                    "SELECT * FROM Win32_DiskPartition " +
                    "WHERE DiskIndex = " + driveIndex))
                using (var dpc = s.Get())
                {
                    foreach (ManagementObject dp in dpc)
                        using (var ldc =
                            dp.GetRelated("Win32_LogicalDisk"))
                        {
                            foreach (var ld in ldc)
                                list.Add(((string) ld["Name"]).TrimEnd(':'));
                        }
                }
            }
            catch
            {
            }

            return list.ToArray();
        }

        private string GetString(byte[] bytes)
        {
            var chars = new char[bytes.Length];
            for (var i = 0; i < bytes.Length; i += 2)
            {
                chars[i] = (char) bytes[i + 1];
                chars[i + 1] = (char) bytes[i];
            }

            return new string(chars).Trim(' ', '\0');
        }

        [Flags]
        protected internal enum AccessMode : uint
        {
            Read = 0x80000000,
            Write = 0x40000000,
            Execute = 0x20000000,
            All = 0x10000000
        }

        [Flags]
        public enum ShareMode : uint
        {
            None = 0,
            Read = 1,
            Write = 2,
            Delete = 4
        }

        public enum CreationMode : uint
        {
            New = 1,
            CreateAlways = 2,
            OpenExisting = 3,
            OpenAlways = 4,
            TruncateExisting = 5
        }

        [Flags]
        public enum FileAttribute : uint
        {
            Readonly = 0x00000001,
            Hidden = 0x00000002,
            System = 0x00000004,
            Directory = 0x00000010,
            Archive = 0x00000020,
            Device = 0x00000040,
            Normal = 0x00000080,
            Temporary = 0x00000100,
            SparseFile = 0x00000200,
            ReparsePoint = 0x00000400,
            Compressed = 0x00000800,
            Offline = 0x00001000,
            NotContentIndexed = 0x00002000,
            Encrypted = 0x00004000
        }

        public enum DriveCommand : uint
        {
            GetVersion = 0x00074080,
            SendDriveCommand = 0x0007c084,
            ReceiveDriveData = 0x0007c088
        }

        public enum RegisterCommand : byte
        {
            /// <summary>
            ///     SMART data requested.
            /// </summary>
            SmartCmd = 0xB0,

            /// <summary>
            ///     Identify data is requested.
            /// </summary>
            IdCmd = 0xEC
        }

        public enum RegisterFeature : byte
        {
            /// <summary>
            ///     Read SMART data.
            /// </summary>
            SmartReadData = 0xD0,

            /// <summary>
            ///     Read SMART thresholds.
            /// </summary>
            SmartReadThresholds = 0xD1, /* obsolete */

            /// <summary>
            ///     Autosave SMART data.
            /// </summary>
            SmartAutosave = 0xD2,

            /// <summary>
            ///     Save SMART attributes.
            /// </summary>
            SmartSaveAttr = 0xD3,

            /// <summary>
            ///     Set SMART to offline immediately.
            /// </summary>
            SmartImmediateOffline = 0xD4,

            /// <summary>
            ///     Read SMART log.
            /// </summary>
            SmartReadLog = 0xD5,

            /// <summary>
            ///     Write SMART log.
            /// </summary>
            SmartWriteLog = 0xD6,

            /// <summary>
            ///     Write SMART thresholds.
            /// </summary>
            SmartWriteThresholds = 0xD7, /* obsolete */

            /// <summary>
            ///     Enable SMART.
            /// </summary>
            SmartEnableOperations = 0xD8,

            /// <summary>
            ///     Disable SMART.
            /// </summary>
            SmartDisableOperations = 0xD9,

            /// <summary>
            ///     Get SMART status.
            /// </summary>
            SmartStatus = 0xDA,

            /// <summary>
            ///     Set SMART to offline automatically.
            /// </summary>
            SmartAutoOffline = 0xDB /* obsolete */
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct CommandBlockRegisters
        {
            public RegisterFeature Features;
            public byte SectorCount;
            public byte LBALow;
            public byte LBAMid;
            public byte LBAHigh;
            public byte Device;
            public RegisterCommand Command;
            public byte Reserved;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct DriveCommandParameter
        {
            public uint BufferSize;
            public CommandBlockRegisters Registers;
            public byte DriveNumber;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
            public byte[] Reserved;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct DriverStatus
        {
            public byte DriverError;
            public byte IDEError;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public byte[] Reserved;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct DriveCommandResult
        {
            public uint BufferSize;
            public DriverStatus DriverStatus;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct DriveSmartReadDataResult
        {
            public uint BufferSize;
            public DriverStatus DriverStatus;
            public byte Version;
            public byte Reserved;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = MAX_DRIVE_ATTRIBUTES)]
            public DriveAttributeValue[] Attributes;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct DriveSmartReadThresholdsResult
        {
            public uint BufferSize;
            public DriverStatus DriverStatus;
            public byte Version;
            public byte Reserved;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = MAX_DRIVE_ATTRIBUTES)]
            public DriveThresholdValue[] Thresholds;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct Identify
        {
            public ushort GeneralConfiguration;
            public ushort NumberOfCylinders;
            public ushort Reserved;
            public ushort NumberOfHeads;
            public ushort UnformattedBytesPerTrack;
            public ushort UnformattedBytesPerSector;
            public ushort SectorsPerTrack;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public ushort[] VendorUnique;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
            public byte[] SerialNumber;

            public ushort BufferType;
            public ushort BufferSectorSize;
            public ushort NumberOfEccBytes;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] FirmwareRevision;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
            public byte[] ModelNumber;

            public ushort MoreVendorUnique;
            public ushort DoubleWordIo;
            public ushort Capabilities;
            public ushort MoreReserved;
            public ushort PioCycleTimingMode;
            public ushort DmaCycleTimingMode;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 406)]
            public byte[] More;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct DriveIdentifyResult
        {
            public uint BufferSize;
            public DriverStatus DriverStatus;
            public Identify Identify;
        }
    }
}