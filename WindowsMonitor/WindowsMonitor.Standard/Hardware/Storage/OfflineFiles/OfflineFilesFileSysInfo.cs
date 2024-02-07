using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.OfflineFiles
{
    /// <summary>
    /// </summary>
    public sealed class OfflineFilesFileSysInfo
    {
		public uint LocalAttributes { get; private set; }
		public DateTime LocalChangeTime { get; private set; }
		public DateTime LocalCreationTime { get; private set; }
		public DateTime LocalLastAccessTime { get; private set; }
		public DateTime LocalLastWriteTime { get; private set; }
		public long LocalSize { get; private set; }
		public uint OriginalAttributes { get; private set; }
		public DateTime OriginalChangeTime { get; private set; }
		public DateTime OriginalCreationTime { get; private set; }
		public DateTime OriginalLastAccessTime { get; private set; }
		public DateTime OriginalLastWriteTime { get; private set; }
		public long OriginalSize { get; private set; }
		public uint RemoteAttributes { get; private set; }
		public DateTime RemoteChangeTime { get; private set; }
		public DateTime RemoteCreationTime { get; private set; }
		public DateTime RemoteLastAccessTime { get; private set; }
		public DateTime RemoteLastWriteTime { get; private set; }
		public long RemoteSize { get; private set; }

        public static IEnumerable<OfflineFilesFileSysInfo> Retrieve(string remote, string username, string password)
        {
            var options = new ConnectionOptions
            {
                Impersonation = ImpersonationLevel.Impersonate,
                Username = username,
                Password = password
            };

            var managementScope = new ManagementScope(new ManagementPath($"\\\\{remote}\\root\\cimv2"), options);
            managementScope.Connect();

            return Retrieve(managementScope);
        }

        public static IEnumerable<OfflineFilesFileSysInfo> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<OfflineFilesFileSysInfo> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_OfflineFilesFileSysInfo");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new OfflineFilesFileSysInfo
                {
                     LocalAttributes = (uint) (managementObject.Properties["LocalAttributes"]?.Value ?? default(uint)),
		 LocalChangeTime = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["LocalChangeTime"]?.Value as string ?? "00010102000000.000000+060"),
		 LocalCreationTime = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["LocalCreationTime"]?.Value as string ?? "00010102000000.000000+060"),
		 LocalLastAccessTime = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["LocalLastAccessTime"]?.Value as string ?? "00010102000000.000000+060"),
		 LocalLastWriteTime = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["LocalLastWriteTime"]?.Value as string ?? "00010102000000.000000+060"),
		 LocalSize = (long) (managementObject.Properties["LocalSize"]?.Value ?? default(long)),
		 OriginalAttributes = (uint) (managementObject.Properties["OriginalAttributes"]?.Value ?? default(uint)),
		 OriginalChangeTime = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["OriginalChangeTime"]?.Value as string ?? "00010102000000.000000+060"),
		 OriginalCreationTime = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["OriginalCreationTime"]?.Value as string ?? "00010102000000.000000+060"),
		 OriginalLastAccessTime = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["OriginalLastAccessTime"]?.Value as string ?? "00010102000000.000000+060"),
		 OriginalLastWriteTime = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["OriginalLastWriteTime"]?.Value as string ?? "00010102000000.000000+060"),
		 OriginalSize = (long) (managementObject.Properties["OriginalSize"]?.Value ?? default(long)),
		 RemoteAttributes = (uint) (managementObject.Properties["RemoteAttributes"]?.Value ?? default(uint)),
		 RemoteChangeTime = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["RemoteChangeTime"]?.Value as string ?? "00010102000000.000000+060"),
		 RemoteCreationTime = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["RemoteCreationTime"]?.Value as string ?? "00010102000000.000000+060"),
		 RemoteLastAccessTime = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["RemoteLastAccessTime"]?.Value as string ?? "00010102000000.000000+060"),
		 RemoteLastWriteTime = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["RemoteLastWriteTime"]?.Value as string ?? "00010102000000.000000+060"),
		 RemoteSize = (long) (managementObject.Properties["RemoteSize"]?.Value ?? default(long))
                };
        }
    }
}