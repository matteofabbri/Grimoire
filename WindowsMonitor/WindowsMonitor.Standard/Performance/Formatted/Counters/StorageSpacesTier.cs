using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted.Counters
{
    /// <summary>
    /// </summary>
    public sealed class StorageSpacesTier
    {
		public ulong AvgTierBytesPerRead { get; private set; }
		public ulong AvgTierBytesPerTransfer { get; private set; }
		public ulong AvgTierBytesPerWrite { get; private set; }
		public ulong AvgTierQueueLength { get; private set; }
		public ulong AvgTierReadQueueLength { get; private set; }
		public uint AvgTiersecPerRead { get; private set; }
		public uint AvgTiersecPerTransfer { get; private set; }
		public uint AvgTiersecPerWrite { get; private set; }
		public ulong AvgTierWriteQueueLength { get; private set; }
		public string Caption { get; private set; }
		public uint CurrentTierQueueLength { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public ulong TierReadBytesPersec { get; private set; }
		public ulong TierReadsPersec { get; private set; }
		public ulong TierTransferBytesPersec { get; private set; }
		public ulong TierTransfersPersec { get; private set; }
		public ulong TierWriteBytesPersec { get; private set; }
		public ulong TierWritesPersec { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<StorageSpacesTier> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<StorageSpacesTier> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<StorageSpacesTier> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_Counters_StorageSpacesTier");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new StorageSpacesTier
                {
                     AvgTierBytesPerRead = (ulong) (managementObject.Properties["AvgTierBytesPerRead"]?.Value ?? default(ulong)),
		 AvgTierBytesPerTransfer = (ulong) (managementObject.Properties["AvgTierBytesPerTransfer"]?.Value ?? default(ulong)),
		 AvgTierBytesPerWrite = (ulong) (managementObject.Properties["AvgTierBytesPerWrite"]?.Value ?? default(ulong)),
		 AvgTierQueueLength = (ulong) (managementObject.Properties["AvgTierQueueLength"]?.Value ?? default(ulong)),
		 AvgTierReadQueueLength = (ulong) (managementObject.Properties["AvgTierReadQueueLength"]?.Value ?? default(ulong)),
		 AvgTiersecPerRead = (uint) (managementObject.Properties["AvgTiersecPerRead"]?.Value ?? default(uint)),
		 AvgTiersecPerTransfer = (uint) (managementObject.Properties["AvgTiersecPerTransfer"]?.Value ?? default(uint)),
		 AvgTiersecPerWrite = (uint) (managementObject.Properties["AvgTiersecPerWrite"]?.Value ?? default(uint)),
		 AvgTierWriteQueueLength = (ulong) (managementObject.Properties["AvgTierWriteQueueLength"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CurrentTierQueueLength = (uint) (managementObject.Properties["CurrentTierQueueLength"]?.Value ?? default(uint)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 TierReadBytesPersec = (ulong) (managementObject.Properties["TierReadBytesPersec"]?.Value ?? default(ulong)),
		 TierReadsPersec = (ulong) (managementObject.Properties["TierReadsPersec"]?.Value ?? default(ulong)),
		 TierTransferBytesPersec = (ulong) (managementObject.Properties["TierTransferBytesPersec"]?.Value ?? default(ulong)),
		 TierTransfersPersec = (ulong) (managementObject.Properties["TierTransfersPersec"]?.Value ?? default(ulong)),
		 TierWriteBytesPersec = (ulong) (managementObject.Properties["TierWriteBytesPersec"]?.Value ?? default(ulong)),
		 TierWritesPersec = (ulong) (managementObject.Properties["TierWritesPersec"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}