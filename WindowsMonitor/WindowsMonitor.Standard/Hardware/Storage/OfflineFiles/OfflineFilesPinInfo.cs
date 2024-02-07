using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.OfflineFiles
{
    /// <summary>
    /// </summary>
    public sealed class OfflineFilesPinInfo
    {
		public bool Pinned { get; private set; }
		public uint PinnedForComputer { get; private set; }
		public uint PinnedForFolderRedirection { get; private set; }
		public uint PinnedForUser { get; private set; }
		public uint PinnedForUserByPolicy { get; private set; }

        public static IEnumerable<OfflineFilesPinInfo> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<OfflineFilesPinInfo> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<OfflineFilesPinInfo> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_OfflineFilesPinInfo");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new OfflineFilesPinInfo
                {
                     Pinned = (bool) (managementObject.Properties["Pinned"]?.Value ?? default(bool)),
		 PinnedForComputer = (uint) (managementObject.Properties["PinnedForComputer"]?.Value ?? default(uint)),
		 PinnedForFolderRedirection = (uint) (managementObject.Properties["PinnedForFolderRedirection"]?.Value ?? default(uint)),
		 PinnedForUser = (uint) (managementObject.Properties["PinnedForUser"]?.Value ?? default(uint)),
		 PinnedForUserByPolicy = (uint) (managementObject.Properties["PinnedForUserByPolicy"]?.Value ?? default(uint))
                };
        }
    }
}