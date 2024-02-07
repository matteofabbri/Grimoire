using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted.Counters
{
    /// <summary>
    /// </summary>
    public sealed class StorageSpacesWriteCache
    {
		public ulong AvgCacheBytesPerEvict { get; private set; }
		public ulong AvgCacheBytesPerOverwrite { get; private set; }
		public ulong AvgCacheBytesPerWrite { get; private set; }
		public ulong AvgDestageBytesPerEvict { get; private set; }
		public ulong AvgDestageBytesPerTransfer { get; private set; }
		public ulong AvgDestageEvictBytesPerOperation { get; private set; }
		public ulong AvgDestageEvictsPerOperation { get; private set; }
		public ulong AvgDestageQueueLength { get; private set; }
		public uint AvgDestagesecPerOperation { get; private set; }
		public ulong AvgDestageTransferBytesPerOperation { get; private set; }
		public ulong AvgDestageTransfersPerEvict { get; private set; }
		public ulong AvgDestageTransfersPerOperation { get; private set; }
		public ulong BytesCached { get; private set; }
		public ulong BytesReclaimable { get; private set; }
		public ulong BytesReserved { get; private set; }
		public ulong BytesUsed { get; private set; }
		public ulong CacheEvictBytesPersec { get; private set; }
		public ulong CacheEvictsPersec { get; private set; }
		public ulong CacheOverwriteBytesPersec { get; private set; }
		public ulong CacheOverwritesPersec { get; private set; }
		public ulong CacheSize { get; private set; }
		public ulong CacheWriteBytesPersec { get; private set; }
		public ulong CacheWritesPersec { get; private set; }
		public string Caption { get; private set; }
		public uint CurrentDestageQueueLength { get; private set; }
		public string Description { get; private set; }
		public ulong DestageEvictBytesPersec { get; private set; }
		public ulong DestageEvictsPersec { get; private set; }
		public ulong DestageOperationsPersec { get; private set; }
		public ulong DestageOptimizedOperationsPersec { get; private set; }
		public ulong DestageTransferBytesPersec { get; private set; }
		public ulong DestageTransfersPersec { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<StorageSpacesWriteCache> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<StorageSpacesWriteCache> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<StorageSpacesWriteCache> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_Counters_StorageSpacesWriteCache");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new StorageSpacesWriteCache
                {
                     AvgCacheBytesPerEvict = (ulong) (managementObject.Properties["AvgCacheBytesPerEvict"]?.Value ?? default(ulong)),
		 AvgCacheBytesPerOverwrite = (ulong) (managementObject.Properties["AvgCacheBytesPerOverwrite"]?.Value ?? default(ulong)),
		 AvgCacheBytesPerWrite = (ulong) (managementObject.Properties["AvgCacheBytesPerWrite"]?.Value ?? default(ulong)),
		 AvgDestageBytesPerEvict = (ulong) (managementObject.Properties["AvgDestageBytesPerEvict"]?.Value ?? default(ulong)),
		 AvgDestageBytesPerTransfer = (ulong) (managementObject.Properties["AvgDestageBytesPerTransfer"]?.Value ?? default(ulong)),
		 AvgDestageEvictBytesPerOperation = (ulong) (managementObject.Properties["AvgDestageEvictBytesPerOperation"]?.Value ?? default(ulong)),
		 AvgDestageEvictsPerOperation = (ulong) (managementObject.Properties["AvgDestageEvictsPerOperation"]?.Value ?? default(ulong)),
		 AvgDestageQueueLength = (ulong) (managementObject.Properties["AvgDestageQueueLength"]?.Value ?? default(ulong)),
		 AvgDestagesecPerOperation = (uint) (managementObject.Properties["AvgDestagesecPerOperation"]?.Value ?? default(uint)),
		 AvgDestageTransferBytesPerOperation = (ulong) (managementObject.Properties["AvgDestageTransferBytesPerOperation"]?.Value ?? default(ulong)),
		 AvgDestageTransfersPerEvict = (ulong) (managementObject.Properties["AvgDestageTransfersPerEvict"]?.Value ?? default(ulong)),
		 AvgDestageTransfersPerOperation = (ulong) (managementObject.Properties["AvgDestageTransfersPerOperation"]?.Value ?? default(ulong)),
		 BytesCached = (ulong) (managementObject.Properties["BytesCached"]?.Value ?? default(ulong)),
		 BytesReclaimable = (ulong) (managementObject.Properties["BytesReclaimable"]?.Value ?? default(ulong)),
		 BytesReserved = (ulong) (managementObject.Properties["BytesReserved"]?.Value ?? default(ulong)),
		 BytesUsed = (ulong) (managementObject.Properties["BytesUsed"]?.Value ?? default(ulong)),
		 CacheEvictBytesPersec = (ulong) (managementObject.Properties["CacheEvictBytesPersec"]?.Value ?? default(ulong)),
		 CacheEvictsPersec = (ulong) (managementObject.Properties["CacheEvictsPersec"]?.Value ?? default(ulong)),
		 CacheOverwriteBytesPersec = (ulong) (managementObject.Properties["CacheOverwriteBytesPersec"]?.Value ?? default(ulong)),
		 CacheOverwritesPersec = (ulong) (managementObject.Properties["CacheOverwritesPersec"]?.Value ?? default(ulong)),
		 CacheSize = (ulong) (managementObject.Properties["CacheSize"]?.Value ?? default(ulong)),
		 CacheWriteBytesPersec = (ulong) (managementObject.Properties["CacheWriteBytesPersec"]?.Value ?? default(ulong)),
		 CacheWritesPersec = (ulong) (managementObject.Properties["CacheWritesPersec"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CurrentDestageQueueLength = (uint) (managementObject.Properties["CurrentDestageQueueLength"]?.Value ?? default(uint)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DestageEvictBytesPersec = (ulong) (managementObject.Properties["DestageEvictBytesPersec"]?.Value ?? default(ulong)),
		 DestageEvictsPersec = (ulong) (managementObject.Properties["DestageEvictsPersec"]?.Value ?? default(ulong)),
		 DestageOperationsPersec = (ulong) (managementObject.Properties["DestageOperationsPersec"]?.Value ?? default(ulong)),
		 DestageOptimizedOperationsPersec = (ulong) (managementObject.Properties["DestageOptimizedOperationsPersec"]?.Value ?? default(ulong)),
		 DestageTransferBytesPersec = (ulong) (managementObject.Properties["DestageTransferBytesPersec"]?.Value ?? default(ulong)),
		 DestageTransfersPersec = (ulong) (managementObject.Properties["DestageTransfersPersec"]?.Value ?? default(ulong)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}