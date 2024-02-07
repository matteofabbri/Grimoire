using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.OfflineFiles
{
    /// <summary>
    /// </summary>
    public sealed class OfflineFilesDiskSpaceLimit
    {
		public uint AutoCacheSizeInMb { get; private set; }
		public uint TotalSizeInMb { get; private set; }

        public static IEnumerable<OfflineFilesDiskSpaceLimit> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<OfflineFilesDiskSpaceLimit> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<OfflineFilesDiskSpaceLimit> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_OfflineFilesDiskSpaceLimit");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new OfflineFilesDiskSpaceLimit
                {
                     AutoCacheSizeInMb = (uint) (managementObject.Properties["AutoCacheSizeInMB"]?.Value ?? default(uint)),
		 TotalSizeInMb = (uint) (managementObject.Properties["TotalSizeInMB"]?.Value ?? default(uint))
                };
        }
    }
}