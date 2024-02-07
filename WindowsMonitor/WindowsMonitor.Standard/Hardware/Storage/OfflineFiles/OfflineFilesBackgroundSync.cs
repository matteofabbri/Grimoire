using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.OfflineFiles
{
    /// <summary>
    /// </summary>
    public sealed class OfflineFilesBackgroundSync
    {
		public bool BackgroundSyncWorkOfflineSharesEnabled { get; private set; }
		public ushort BlockOutDurationMin { get; private set; }
		public ushort BlockOutStartTimeHoursMinutes { get; private set; }
		public ushort MaxTimeBetweenSyncs { get; private set; }
		public ushort SyncInterval { get; private set; }
		public ushort SyncVariance { get; private set; }

        public static IEnumerable<OfflineFilesBackgroundSync> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<OfflineFilesBackgroundSync> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<OfflineFilesBackgroundSync> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_OfflineFilesBackgroundSync");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new OfflineFilesBackgroundSync
                {
                     BackgroundSyncWorkOfflineSharesEnabled = (bool) (managementObject.Properties["BackgroundSyncWorkOfflineSharesEnabled"]?.Value ?? default(bool)),
		 BlockOutDurationMin = (ushort) (managementObject.Properties["BlockOutDurationMin"]?.Value ?? default(ushort)),
		 BlockOutStartTimeHoursMinutes = (ushort) (managementObject.Properties["BlockOutStartTimeHoursMinutes"]?.Value ?? default(ushort)),
		 MaxTimeBetweenSyncs = (ushort) (managementObject.Properties["MaxTimeBetweenSyncs"]?.Value ?? default(ushort)),
		 SyncInterval = (ushort) (managementObject.Properties["SyncInterval"]?.Value ?? default(ushort)),
		 SyncVariance = (ushort) (managementObject.Properties["SyncVariance"]?.Value ?? default(ushort))
                };
        }
    }
}