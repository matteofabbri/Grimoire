using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Drives
{
    /// <summary>
    /// </summary>
    public sealed class DiskDriverPerformanceData
    {
		public long BytesRead { get; private set; }
		public long BytesWritten { get; private set; }
		public long IdleTime { get; private set; }
		public long QueryTime { get; private set; }
		public uint QueueDepth { get; private set; }
		public uint ReadCount { get; private set; }
		public long ReadTime { get; private set; }
		public uint SplitCount { get; private set; }
		public uint StorageDeviceNumber { get; private set; }
		public ushort[] StorageManagerName { get; private set; }
		public uint WriteCount { get; private set; }
		public long WriteTime { get; private set; }

        public static IEnumerable<DiskDriverPerformanceData> Retrieve(string remote, string username, string password)
        {
            var options = new ConnectionOptions
            {
                Impersonation = ImpersonationLevel.Impersonate,
                Username = username,
                Password = password
            };

            var managementScope = new ManagementScope(new ManagementPath($"\\\\{remote}\\root\\wmi"), options);
            managementScope.Connect();

            return Retrieve(managementScope);
        }

        public static IEnumerable<DiskDriverPerformanceData> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<DiskDriverPerformanceData> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSDiskDriver_PerformanceData");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new DiskDriverPerformanceData
                {
                     BytesRead = (long) (managementObject.Properties["BytesRead"]?.Value ?? default(long)),
		 BytesWritten = (long) (managementObject.Properties["BytesWritten"]?.Value ?? default(long)),
		 IdleTime = (long) (managementObject.Properties["IdleTime"]?.Value ?? default(long)),
		 QueryTime = (long) (managementObject.Properties["QueryTime"]?.Value ?? default(long)),
		 QueueDepth = (uint) (managementObject.Properties["QueueDepth"]?.Value ?? default(uint)),
		 ReadCount = (uint) (managementObject.Properties["ReadCount"]?.Value ?? default(uint)),
		 ReadTime = (long) (managementObject.Properties["ReadTime"]?.Value ?? default(long)),
		 SplitCount = (uint) (managementObject.Properties["SplitCount"]?.Value ?? default(uint)),
		 StorageDeviceNumber = (uint) (managementObject.Properties["StorageDeviceNumber"]?.Value ?? default(uint)),
		 StorageManagerName = (ushort[]) (managementObject.Properties["StorageManagerName"]?.Value ?? new ushort[0]),
		 WriteCount = (uint) (managementObject.Properties["WriteCount"]?.Value ?? default(uint)),
		 WriteTime = (long) (managementObject.Properties["WriteTime"]?.Value ?? default(long))
                };
        }
    }
}