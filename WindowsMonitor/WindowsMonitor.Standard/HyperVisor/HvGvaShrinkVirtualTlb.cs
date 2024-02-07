using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.HyperVisor
{
    /// <summary>
    /// </summary>
    public sealed class HvGvaShrinkVirtualTlb
    {
		public ulong FreeCount { get; private set; }
		public ulong NewCount { get; private set; }
		public ulong OldCount { get; private set; }

        public static IEnumerable<HvGvaShrinkVirtualTlb> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HvGvaShrinkVirtualTlb> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HvGvaShrinkVirtualTlb> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HvGvaShrinkVirtualTlb");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HvGvaShrinkVirtualTlb
                {
                     FreeCount = (ulong) (managementObject.Properties["FreeCount"]?.Value ?? default(ulong)),
		 NewCount = (ulong) (managementObject.Properties["NewCount"]?.Value ?? default(ulong)),
		 OldCount = (ulong) (managementObject.Properties["OldCount"]?.Value ?? default(ulong))
                };
        }
    }
}