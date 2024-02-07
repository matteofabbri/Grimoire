using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.HBA.Msfc
{
    /// <summary>
    /// </summary>
    public sealed class HbaPortStatistics
    {
		public long DumpedFrames { get; private set; }
		public long ErrorFrames { get; private set; }
		public long InvalidCrcCount { get; private set; }
		public long InvalidTxWordCount { get; private set; }
		public long LinkFailureCount { get; private set; }
		public long LipCount { get; private set; }
		public long LossOfSignalCount { get; private set; }
		public long LossOfSyncCount { get; private set; }
		public long NosCount { get; private set; }
		public long PrimitiveSeqProtocolErrCount { get; private set; }
		public long RxFrames { get; private set; }
		public long RxWords { get; private set; }
		public long SecondsSinceLastReset { get; private set; }
		public long TxFrames { get; private set; }
		public long TxWords { get; private set; }

        public static IEnumerable<HbaPortStatistics> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HbaPortStatistics> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HbaPortStatistics> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSFC_HBAPortStatistics");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HbaPortStatistics
                {
                     DumpedFrames = (long) (managementObject.Properties["DumpedFrames"]?.Value ?? default(long)),
		 ErrorFrames = (long) (managementObject.Properties["ErrorFrames"]?.Value ?? default(long)),
		 InvalidCrcCount = (long) (managementObject.Properties["InvalidCRCCount"]?.Value ?? default(long)),
		 InvalidTxWordCount = (long) (managementObject.Properties["InvalidTxWordCount"]?.Value ?? default(long)),
		 LinkFailureCount = (long) (managementObject.Properties["LinkFailureCount"]?.Value ?? default(long)),
		 LipCount = (long) (managementObject.Properties["LIPCount"]?.Value ?? default(long)),
		 LossOfSignalCount = (long) (managementObject.Properties["LossOfSignalCount"]?.Value ?? default(long)),
		 LossOfSyncCount = (long) (managementObject.Properties["LossOfSyncCount"]?.Value ?? default(long)),
		 NosCount = (long) (managementObject.Properties["NOSCount"]?.Value ?? default(long)),
		 PrimitiveSeqProtocolErrCount = (long) (managementObject.Properties["PrimitiveSeqProtocolErrCount"]?.Value ?? default(long)),
		 RxFrames = (long) (managementObject.Properties["RxFrames"]?.Value ?? default(long)),
		 RxWords = (long) (managementObject.Properties["RxWords"]?.Value ?? default(long)),
		 SecondsSinceLastReset = (long) (managementObject.Properties["SecondsSinceLastReset"]?.Value ?? default(long)),
		 TxFrames = (long) (managementObject.Properties["TxFrames"]?.Value ?? default(long)),
		 TxWords = (long) (managementObject.Properties["TxWords"]?.Value ?? default(long))
                };
        }
    }
}