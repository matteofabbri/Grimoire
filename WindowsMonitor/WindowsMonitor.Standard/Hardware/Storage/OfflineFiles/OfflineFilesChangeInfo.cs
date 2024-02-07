using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.OfflineFiles
{
    /// <summary>
    /// </summary>
    public sealed class OfflineFilesChangeInfo
    {
		public bool CreatedOffline { get; private set; }
		public bool DeletedOffline { get; private set; }
		public bool Dirty { get; private set; }
		public bool ModifiedAttributes { get; private set; }
		public bool ModifiedData { get; private set; }
		public bool ModifiedTime { get; private set; }

        public static IEnumerable<OfflineFilesChangeInfo> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<OfflineFilesChangeInfo> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<OfflineFilesChangeInfo> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_OfflineFilesChangeInfo");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new OfflineFilesChangeInfo
                {
                     CreatedOffline = (bool) (managementObject.Properties["CreatedOffline"]?.Value ?? default(bool)),
		 DeletedOffline = (bool) (managementObject.Properties["DeletedOffline"]?.Value ?? default(bool)),
		 Dirty = (bool) (managementObject.Properties["Dirty"]?.Value ?? default(bool)),
		 ModifiedAttributes = (bool) (managementObject.Properties["ModifiedAttributes"]?.Value ?? default(bool)),
		 ModifiedData = (bool) (managementObject.Properties["ModifiedData"]?.Value ?? default(bool)),
		 ModifiedTime = (bool) (managementObject.Properties["ModifiedTime"]?.Value ?? default(bool))
                };
        }
    }
}