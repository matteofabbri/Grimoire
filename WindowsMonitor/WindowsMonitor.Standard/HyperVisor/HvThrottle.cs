using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.HyperVisor
{
    /// <summary>
    /// </summary>
    public sealed class HvThrottle
    {
		public ulong EndTime { get; private set; }
		public ulong PartitionId { get; private set; }
		public ulong PhysicalVector { get; private set; }
		public ulong VirtualVector { get; private set; }

        public static IEnumerable<HvThrottle> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HvThrottle> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HvThrottle> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HvThrottle");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HvThrottle
                {
                     EndTime = (ulong) (managementObject.Properties["EndTime"]?.Value ?? default(ulong)),
		 PartitionId = (ulong) (managementObject.Properties["PartitionId"]?.Value ?? default(ulong)),
		 PhysicalVector = (ulong) (managementObject.Properties["PhysicalVector"]?.Value ?? default(ulong)),
		 VirtualVector = (ulong) (managementObject.Properties["VirtualVector"]?.Value ?? default(ulong))
                };
        }
    }
}