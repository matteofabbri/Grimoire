using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.OfflineFiles
{
    /// <summary>
    /// </summary>
    public sealed class OfflineFilesDirtyInfo
    {
		public long LocalDirtyByteCount { get; private set; }
		public long RemoteDirtyByteCount { get; private set; }

        public static IEnumerable<OfflineFilesDirtyInfo> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<OfflineFilesDirtyInfo> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<OfflineFilesDirtyInfo> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_OfflineFilesDirtyInfo");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new OfflineFilesDirtyInfo
                {
                     LocalDirtyByteCount = (long) (managementObject.Properties["LocalDirtyByteCount"]?.Value ?? default(long)),
		 RemoteDirtyByteCount = (long) (managementObject.Properties["RemoteDirtyByteCount"]?.Value ?? default(long))
                };
        }
    }
}