using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.OfflineFiles
{
    /// <summary>
    /// </summary>
    public sealed class OfflineFilesMachineConfiguration
    {
		public bool BackgroundSyncEnabled { get; private set; }
		public dynamic BackgroundSyncParams { get; private set; }
		public bool DiskSpaceLimitEnabled { get; private set; }
		public dynamic DiskSpaceLimitParams { get; private set; }
		public bool EconomicalAdminPinningEnabled { get; private set; }
		public bool Enabled { get; private set; }
		public string[] ExcludedFileTypes { get; private set; }
		public bool IsConfiguredByWmi { get; private set; }
		public bool MakeAvailableOfflineButtonRemoved { get; private set; }
		public bool OfflineFilesCacheEncrypted { get; private set; }
		public bool SlowLinkEnabled { get; private set; }
		public string[] SlowLinkParams { get; private set; }
		public bool SyncOnCostedNetworkEnabled { get; private set; }
		public uint TransparentCachingLatencyThreshold { get; private set; }
		public bool WorkOfflineButtonRemoved { get; private set; }

        public static IEnumerable<OfflineFilesMachineConfiguration> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<OfflineFilesMachineConfiguration> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<OfflineFilesMachineConfiguration> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_OfflineFilesMachineConfiguration");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new OfflineFilesMachineConfiguration
                {
                     BackgroundSyncEnabled = (bool) (managementObject.Properties["BackgroundSyncEnabled"]?.Value ?? default(bool)),
		 BackgroundSyncParams = (dynamic) (managementObject.Properties["BackgroundSyncParams"]?.Value ?? default(dynamic)),
		 DiskSpaceLimitEnabled = (bool) (managementObject.Properties["DiskSpaceLimitEnabled"]?.Value ?? default(bool)),
		 DiskSpaceLimitParams = (dynamic) (managementObject.Properties["DiskSpaceLimitParams"]?.Value ?? default(dynamic)),
		 EconomicalAdminPinningEnabled = (bool) (managementObject.Properties["EconomicalAdminPinningEnabled"]?.Value ?? default(bool)),
		 Enabled = (bool) (managementObject.Properties["Enabled"]?.Value ?? default(bool)),
		 ExcludedFileTypes = (string[]) (managementObject.Properties["ExcludedFileTypes"]?.Value ?? new string[0]),
		 IsConfiguredByWmi = (bool) (managementObject.Properties["IsConfiguredByWMI"]?.Value ?? default(bool)),
		 MakeAvailableOfflineButtonRemoved = (bool) (managementObject.Properties["MakeAvailableOfflineButtonRemoved"]?.Value ?? default(bool)),
		 OfflineFilesCacheEncrypted = (bool) (managementObject.Properties["OfflineFilesCacheEncrypted"]?.Value ?? default(bool)),
		 SlowLinkEnabled = (bool) (managementObject.Properties["SlowLinkEnabled"]?.Value ?? default(bool)),
		 SlowLinkParams = (string[]) (managementObject.Properties["SlowLinkParams"]?.Value ?? new string[0]),
		 SyncOnCostedNetworkEnabled = (bool) (managementObject.Properties["SyncOnCostedNetworkEnabled"]?.Value ?? default(bool)),
		 TransparentCachingLatencyThreshold = (uint) (managementObject.Properties["TransparentCachingLatencyThreshold"]?.Value ?? default(uint)),
		 WorkOfflineButtonRemoved = (bool) (managementObject.Properties["WorkOfflineButtonRemoved"]?.Value ?? default(bool))
                };
        }
    }
}