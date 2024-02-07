using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.OfflineFiles
{
    /// <summary>
    /// </summary>
    public sealed class OfflineFilesSuspendInfo
    {
		public bool Suspended { get; private set; }
		public bool SuspendedRoot { get; private set; }

        public static IEnumerable<OfflineFilesSuspendInfo> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<OfflineFilesSuspendInfo> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<OfflineFilesSuspendInfo> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_OfflineFilesSuspendInfo");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new OfflineFilesSuspendInfo
                {
                     Suspended = (bool) (managementObject.Properties["Suspended"]?.Value ?? default(bool)),
		 SuspendedRoot = (bool) (managementObject.Properties["SuspendedRoot"]?.Value ?? default(bool))
                };
        }
    }
}