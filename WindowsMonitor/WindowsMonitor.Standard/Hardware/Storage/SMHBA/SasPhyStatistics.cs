using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.SMHBA
{
    /// <summary>
    /// </summary>
    public sealed class SasPhyStatistics
    {
		public long InvalidDwordCount { get; private set; }
		public long LossofDwordSyncCount { get; private set; }
		public long PhyResetProblemCount { get; private set; }
		public long RunningDisparityErrorCount { get; private set; }
		public long RxFrames { get; private set; }
		public long RxWords { get; private set; }
		public long SecondsSinceLastReset { get; private set; }
		public long TxFrames { get; private set; }
		public long TxWords { get; private set; }

        public static IEnumerable<SasPhyStatistics> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SasPhyStatistics> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SasPhyStatistics> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MS_SMHBA_SASPHYSTATISTICS");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SasPhyStatistics
                {
                     InvalidDwordCount = (long) (managementObject.Properties["InvalidDwordCount"]?.Value ?? default(long)),
		 LossofDwordSyncCount = (long) (managementObject.Properties["LossofDwordSyncCount"]?.Value ?? default(long)),
		 PhyResetProblemCount = (long) (managementObject.Properties["PhyResetProblemCount"]?.Value ?? default(long)),
		 RunningDisparityErrorCount = (long) (managementObject.Properties["RunningDisparityErrorCount"]?.Value ?? default(long)),
		 RxFrames = (long) (managementObject.Properties["RxFrames"]?.Value ?? default(long)),
		 RxWords = (long) (managementObject.Properties["RxWords"]?.Value ?? default(long)),
		 SecondsSinceLastReset = (long) (managementObject.Properties["SecondsSinceLastReset"]?.Value ?? default(long)),
		 TxFrames = (long) (managementObject.Properties["TxFrames"]?.Value ?? default(long)),
		 TxWords = (long) (managementObject.Properties["TxWords"]?.Value ?? default(long))
                };
        }
    }
}