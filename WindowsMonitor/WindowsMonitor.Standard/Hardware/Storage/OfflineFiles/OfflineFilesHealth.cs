using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.OfflineFiles
{
    /// <summary>
    /// </summary>
    public sealed class OfflineFilesHealth
    {
		public string LastSuccessfulSyncTime { get; private set; }
		public byte LastSyncStatus { get; private set; }
		public string LastSyncTime { get; private set; }
		public bool OfflineAccessEnabled { get; private set; }
		public bool OnlineMode { get; private set; }

        public static IEnumerable<OfflineFilesHealth> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<OfflineFilesHealth> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<OfflineFilesHealth> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_OfflineFilesHealth");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new OfflineFilesHealth
                {
                     LastSuccessfulSyncTime = (string) (managementObject.Properties["LastSuccessfulSyncTime"]?.Value),
		 LastSyncStatus = (byte) (managementObject.Properties["LastSyncStatus"]?.Value ?? default(byte)),
		 LastSyncTime = (string) (managementObject.Properties["LastSyncTime"]?.Value),
		 OfflineAccessEnabled = (bool) (managementObject.Properties["OfflineAccessEnabled"]?.Value ?? default(bool)),
		 OnlineMode = (bool) (managementObject.Properties["OnlineMode"]?.Value ?? default(bool))
                };
        }
    }
}