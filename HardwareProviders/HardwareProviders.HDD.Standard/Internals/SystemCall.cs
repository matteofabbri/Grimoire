using System;
using System.Runtime.InteropServices;

namespace HardwareProviders.HDD
{
    static class SystemCall
    {
        private const string KERNEL = "kernel32.dll";

        [DllImport(KERNEL, CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWow64Process(IntPtr hProcess, out bool wow64Process);

        [DllImport(KERNEL, CallingConvention = CallingConvention.Winapi,
            CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateFile(string fileName,
            WindowsSmart.AccessMode desiredAccess, WindowsSmart.ShareMode shareMode, IntPtr securityAttributes,
            WindowsSmart.CreationMode creationDisposition, WindowsSmart.FileAttribute flagsAndAttributes,
            IntPtr templateFilehandle);

        [DllImport(KERNEL, CallingConvention = CallingConvention.Winapi)]
        public static extern int CloseHandle(IntPtr handle);

        [DllImport(KERNEL, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeviceIoControl(IntPtr handle,
            WindowsSmart.DriveCommand command, ref WindowsSmart.DriveCommandParameter parameter,
            int parameterSize, out WindowsSmart.DriveSmartReadDataResult result, int resultSize,
            out uint bytesReturned, IntPtr overlapped);

        [DllImport(KERNEL, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeviceIoControl(IntPtr handle,
            WindowsSmart.DriveCommand command, ref WindowsSmart.DriveCommandParameter parameter,
            int parameterSize, out WindowsSmart.DriveSmartReadThresholdsResult result,
            int resultSize, out uint bytesReturned, IntPtr overlapped);

        [DllImport(KERNEL, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeviceIoControl(IntPtr handle,
            WindowsSmart.DriveCommand command, ref WindowsSmart.DriveCommandParameter parameter,
            int parameterSize, out WindowsSmart.DriveCommandResult result, int resultSize,
            out uint bytesReturned, IntPtr overlapped);

        [DllImport(KERNEL, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeviceIoControl(IntPtr handle,
            WindowsSmart.DriveCommand command, ref WindowsSmart.DriveCommandParameter parameter,
            int parameterSize, out WindowsSmart.DriveIdentifyResult result, int resultSize,
            out uint bytesReturned, IntPtr overlapped);
    }
}
