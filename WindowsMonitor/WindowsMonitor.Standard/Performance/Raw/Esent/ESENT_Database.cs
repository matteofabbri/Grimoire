using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.Esent
{
    /// <summary>
    /// </summary>
    public sealed class EsentDatabase
    {
		public string Caption { get; private set; }
		public ulong DatabaseCacheMemoryCommitted { get; private set; }
		public ulong DatabaseCacheMemoryCommittedMb { get; private set; }
		public ulong DatabaseCacheMemoryReserved { get; private set; }
		public ulong DatabaseCacheMemoryReservedMb { get; private set; }
		public ulong DatabaseCacheMissAttachedAverageLatency { get; private set; }
		public uint DatabaseCacheMissAttachedAverageLatencyBase { get; private set; }
		public uint DatabaseCacheMissesPersec { get; private set; }
		public uint DatabaseCachePercentDehydrated { get; private set; }
		public uint DatabaseCachePercentDehydratedBase { get; private set; }
		public uint DatabaseCachePercentHit { get; private set; }
		public uint DatabaseCachePercentHitBase { get; private set; }
		public uint DatabaseCachePercentHitUncorrelated { get; private set; }
		public uint DatabaseCachePercentHitUncorrelatedBase { get; private set; }
		public uint DatabaseCacheRequestsPersec { get; private set; }
		public ulong DatabaseCacheSize { get; private set; }
		public ulong DatabaseCacheSizeEffective { get; private set; }
		public ulong DatabaseCacheSizeEffectiveMb { get; private set; }
		public ulong DatabaseCacheSizeMb { get; private set; }
		public ulong DatabaseCacheSizeResident { get; private set; }
		public ulong DatabaseCacheSizeResidentMb { get; private set; }
		public uint DatabaseMaintenanceDuration { get; private set; }
		public uint DatabaseMaintenancePagesBadChecksums { get; private set; }
		public uint DatabasePageEvictionsPersec { get; private set; }
		public uint DatabasePageFaultsPersec { get; private set; }
		public uint DatabasePageFaultStallsPersec { get; private set; }
		public uint DefragmentationTasks { get; private set; }
		public uint DefragmentationTasksPending { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public ulong IoDatabaseReadsAttachedAverageLatency { get; private set; }
		public uint IoDatabaseReadsAttachedAverageLatencyBase { get; private set; }
		public uint IoDatabaseReadsAttachedPersec { get; private set; }
		public ulong IoDatabaseReadsAverageLatency { get; private set; }
		public uint IoDatabaseReadsAverageLatencyBase { get; private set; }
		public uint IoDatabaseReadsPersec { get; private set; }
		public ulong IoDatabaseReadsRecoveryAverageLatency { get; private set; }
		public uint IoDatabaseReadsRecoveryAverageLatencyBase { get; private set; }
		public uint IoDatabaseReadsRecoveryPersec { get; private set; }
		public ulong IoDatabaseWritesAttachedAverageLatency { get; private set; }
		public uint IoDatabaseWritesAttachedAverageLatencyBase { get; private set; }
		public uint IoDatabaseWritesAttachedPersec { get; private set; }
		public ulong IoDatabaseWritesAverageLatency { get; private set; }
		public uint IoDatabaseWritesAverageLatencyBase { get; private set; }
		public uint IoDatabaseWritesPersec { get; private set; }
		public ulong IoDatabaseWritesRecoveryAverageLatency { get; private set; }
		public uint IoDatabaseWritesRecoveryAverageLatencyBase { get; private set; }
		public uint IoDatabaseWritesRecoveryPersec { get; private set; }
		public ulong IoFlushMapWritesAverageLatency { get; private set; }
		public uint IoFlushMapWritesAverageLatencyBase { get; private set; }
		public uint IoFlushMapWritesPersec { get; private set; }
		public ulong IoLogReadsAverageLatency { get; private set; }
		public uint IoLogReadsAverageLatencyBase { get; private set; }
		public uint IoLogReadsPersec { get; private set; }
		public ulong IoLogWritesAverageLatency { get; private set; }
		public uint IoLogWritesAverageLatencyBase { get; private set; }
		public uint IoLogWritesPersec { get; private set; }
		public uint LogBytesGeneratedPersec { get; private set; }
		public uint LogBytesWritePersec { get; private set; }
		public uint LogRecordStallsPersec { get; private set; }
		public uint LogThreadsWaiting { get; private set; }
		public uint LogWritesPersec { get; private set; }
		public string Name { get; private set; }
		public uint SessionsInUse { get; private set; }
		public uint SessionsPercentUsed { get; private set; }
		public uint SessionsPercentUsedBase { get; private set; }
		public uint TableClosesPersec { get; private set; }
		public uint TableOpenCacheHitsPersec { get; private set; }
		public uint TableOpenCacheMissesPersec { get; private set; }
		public uint TableOpenCachePercentHit { get; private set; }
		public uint TableOpenCachePercentHitBase { get; private set; }
		public uint TableOpensPersec { get; private set; }
		public uint TablesOpen { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public uint VersionBucketsAllocated { get; private set; }

        public static IEnumerable<EsentDatabase> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<EsentDatabase> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<EsentDatabase> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_ESENT_Database");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new EsentDatabase
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 DatabaseCacheMemoryCommitted = (ulong) (managementObject.Properties["DatabaseCacheMemoryCommitted"]?.Value ?? default(ulong)),
		 DatabaseCacheMemoryCommittedMb = (ulong) (managementObject.Properties["DatabaseCacheMemoryCommittedMB"]?.Value ?? default(ulong)),
		 DatabaseCacheMemoryReserved = (ulong) (managementObject.Properties["DatabaseCacheMemoryReserved"]?.Value ?? default(ulong)),
		 DatabaseCacheMemoryReservedMb = (ulong) (managementObject.Properties["DatabaseCacheMemoryReservedMB"]?.Value ?? default(ulong)),
		 DatabaseCacheMissAttachedAverageLatency = (ulong) (managementObject.Properties["DatabaseCacheMissAttachedAverageLatency"]?.Value ?? default(ulong)),
		 DatabaseCacheMissAttachedAverageLatencyBase = (uint) (managementObject.Properties["DatabaseCacheMissAttachedAverageLatency_Base"]?.Value ?? default(uint)),
		 DatabaseCacheMissesPersec = (uint) (managementObject.Properties["DatabaseCacheMissesPersec"]?.Value ?? default(uint)),
		 DatabaseCachePercentDehydrated = (uint) (managementObject.Properties["DatabaseCachePercentDehydrated"]?.Value ?? default(uint)),
		 DatabaseCachePercentDehydratedBase = (uint) (managementObject.Properties["DatabaseCachePercentDehydrated_Base"]?.Value ?? default(uint)),
		 DatabaseCachePercentHit = (uint) (managementObject.Properties["DatabaseCachePercentHit"]?.Value ?? default(uint)),
		 DatabaseCachePercentHitBase = (uint) (managementObject.Properties["DatabaseCachePercentHit_Base"]?.Value ?? default(uint)),
		 DatabaseCachePercentHitUncorrelated = (uint) (managementObject.Properties["DatabaseCachePercentHitUncorrelated"]?.Value ?? default(uint)),
		 DatabaseCachePercentHitUncorrelatedBase = (uint) (managementObject.Properties["DatabaseCachePercentHitUncorrelated_Base"]?.Value ?? default(uint)),
		 DatabaseCacheRequestsPersec = (uint) (managementObject.Properties["DatabaseCacheRequestsPersec"]?.Value ?? default(uint)),
		 DatabaseCacheSize = (ulong) (managementObject.Properties["DatabaseCacheSize"]?.Value ?? default(ulong)),
		 DatabaseCacheSizeEffective = (ulong) (managementObject.Properties["DatabaseCacheSizeEffective"]?.Value ?? default(ulong)),
		 DatabaseCacheSizeEffectiveMb = (ulong) (managementObject.Properties["DatabaseCacheSizeEffectiveMB"]?.Value ?? default(ulong)),
		 DatabaseCacheSizeMb = (ulong) (managementObject.Properties["DatabaseCacheSizeMB"]?.Value ?? default(ulong)),
		 DatabaseCacheSizeResident = (ulong) (managementObject.Properties["DatabaseCacheSizeResident"]?.Value ?? default(ulong)),
		 DatabaseCacheSizeResidentMb = (ulong) (managementObject.Properties["DatabaseCacheSizeResidentMB"]?.Value ?? default(ulong)),
		 DatabaseMaintenanceDuration = (uint) (managementObject.Properties["DatabaseMaintenanceDuration"]?.Value ?? default(uint)),
		 DatabaseMaintenancePagesBadChecksums = (uint) (managementObject.Properties["DatabaseMaintenancePagesBadChecksums"]?.Value ?? default(uint)),
		 DatabasePageEvictionsPersec = (uint) (managementObject.Properties["DatabasePageEvictionsPersec"]?.Value ?? default(uint)),
		 DatabasePageFaultsPersec = (uint) (managementObject.Properties["DatabasePageFaultsPersec"]?.Value ?? default(uint)),
		 DatabasePageFaultStallsPersec = (uint) (managementObject.Properties["DatabasePageFaultStallsPersec"]?.Value ?? default(uint)),
		 DefragmentationTasks = (uint) (managementObject.Properties["DefragmentationTasks"]?.Value ?? default(uint)),
		 DefragmentationTasksPending = (uint) (managementObject.Properties["DefragmentationTasksPending"]?.Value ?? default(uint)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 IoDatabaseReadsAttachedAverageLatency = (ulong) (managementObject.Properties["IODatabaseReadsAttachedAverageLatency"]?.Value ?? default(ulong)),
		 IoDatabaseReadsAttachedAverageLatencyBase = (uint) (managementObject.Properties["IODatabaseReadsAttachedAverageLatency_Base"]?.Value ?? default(uint)),
		 IoDatabaseReadsAttachedPersec = (uint) (managementObject.Properties["IODatabaseReadsAttachedPersec"]?.Value ?? default(uint)),
		 IoDatabaseReadsAverageLatency = (ulong) (managementObject.Properties["IODatabaseReadsAverageLatency"]?.Value ?? default(ulong)),
		 IoDatabaseReadsAverageLatencyBase = (uint) (managementObject.Properties["IODatabaseReadsAverageLatency_Base"]?.Value ?? default(uint)),
		 IoDatabaseReadsPersec = (uint) (managementObject.Properties["IODatabaseReadsPersec"]?.Value ?? default(uint)),
		 IoDatabaseReadsRecoveryAverageLatency = (ulong) (managementObject.Properties["IODatabaseReadsRecoveryAverageLatency"]?.Value ?? default(ulong)),
		 IoDatabaseReadsRecoveryAverageLatencyBase = (uint) (managementObject.Properties["IODatabaseReadsRecoveryAverageLatency_Base"]?.Value ?? default(uint)),
		 IoDatabaseReadsRecoveryPersec = (uint) (managementObject.Properties["IODatabaseReadsRecoveryPersec"]?.Value ?? default(uint)),
		 IoDatabaseWritesAttachedAverageLatency = (ulong) (managementObject.Properties["IODatabaseWritesAttachedAverageLatency"]?.Value ?? default(ulong)),
		 IoDatabaseWritesAttachedAverageLatencyBase = (uint) (managementObject.Properties["IODatabaseWritesAttachedAverageLatency_Base"]?.Value ?? default(uint)),
		 IoDatabaseWritesAttachedPersec = (uint) (managementObject.Properties["IODatabaseWritesAttachedPersec"]?.Value ?? default(uint)),
		 IoDatabaseWritesAverageLatency = (ulong) (managementObject.Properties["IODatabaseWritesAverageLatency"]?.Value ?? default(ulong)),
		 IoDatabaseWritesAverageLatencyBase = (uint) (managementObject.Properties["IODatabaseWritesAverageLatency_Base"]?.Value ?? default(uint)),
		 IoDatabaseWritesPersec = (uint) (managementObject.Properties["IODatabaseWritesPersec"]?.Value ?? default(uint)),
		 IoDatabaseWritesRecoveryAverageLatency = (ulong) (managementObject.Properties["IODatabaseWritesRecoveryAverageLatency"]?.Value ?? default(ulong)),
		 IoDatabaseWritesRecoveryAverageLatencyBase = (uint) (managementObject.Properties["IODatabaseWritesRecoveryAverageLatency_Base"]?.Value ?? default(uint)),
		 IoDatabaseWritesRecoveryPersec = (uint) (managementObject.Properties["IODatabaseWritesRecoveryPersec"]?.Value ?? default(uint)),
		 IoFlushMapWritesAverageLatency = (ulong) (managementObject.Properties["IOFlushMapWritesAverageLatency"]?.Value ?? default(ulong)),
		 IoFlushMapWritesAverageLatencyBase = (uint) (managementObject.Properties["IOFlushMapWritesAverageLatency_Base"]?.Value ?? default(uint)),
		 IoFlushMapWritesPersec = (uint) (managementObject.Properties["IOFlushMapWritesPersec"]?.Value ?? default(uint)),
		 IoLogReadsAverageLatency = (ulong) (managementObject.Properties["IOLogReadsAverageLatency"]?.Value ?? default(ulong)),
		 IoLogReadsAverageLatencyBase = (uint) (managementObject.Properties["IOLogReadsAverageLatency_Base"]?.Value ?? default(uint)),
		 IoLogReadsPersec = (uint) (managementObject.Properties["IOLogReadsPersec"]?.Value ?? default(uint)),
		 IoLogWritesAverageLatency = (ulong) (managementObject.Properties["IOLogWritesAverageLatency"]?.Value ?? default(ulong)),
		 IoLogWritesAverageLatencyBase = (uint) (managementObject.Properties["IOLogWritesAverageLatency_Base"]?.Value ?? default(uint)),
		 IoLogWritesPersec = (uint) (managementObject.Properties["IOLogWritesPersec"]?.Value ?? default(uint)),
		 LogBytesGeneratedPersec = (uint) (managementObject.Properties["LogBytesGeneratedPersec"]?.Value ?? default(uint)),
		 LogBytesWritePersec = (uint) (managementObject.Properties["LogBytesWritePersec"]?.Value ?? default(uint)),
		 LogRecordStallsPersec = (uint) (managementObject.Properties["LogRecordStallsPersec"]?.Value ?? default(uint)),
		 LogThreadsWaiting = (uint) (managementObject.Properties["LogThreadsWaiting"]?.Value ?? default(uint)),
		 LogWritesPersec = (uint) (managementObject.Properties["LogWritesPersec"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 SessionsInUse = (uint) (managementObject.Properties["SessionsInUse"]?.Value ?? default(uint)),
		 SessionsPercentUsed = (uint) (managementObject.Properties["SessionsPercentUsed"]?.Value ?? default(uint)),
		 SessionsPercentUsedBase = (uint) (managementObject.Properties["SessionsPercentUsed_Base"]?.Value ?? default(uint)),
		 TableClosesPersec = (uint) (managementObject.Properties["TableClosesPersec"]?.Value ?? default(uint)),
		 TableOpenCacheHitsPersec = (uint) (managementObject.Properties["TableOpenCacheHitsPersec"]?.Value ?? default(uint)),
		 TableOpenCacheMissesPersec = (uint) (managementObject.Properties["TableOpenCacheMissesPersec"]?.Value ?? default(uint)),
		 TableOpenCachePercentHit = (uint) (managementObject.Properties["TableOpenCachePercentHit"]?.Value ?? default(uint)),
		 TableOpenCachePercentHitBase = (uint) (managementObject.Properties["TableOpenCachePercentHit_Base"]?.Value ?? default(uint)),
		 TableOpensPersec = (uint) (managementObject.Properties["TableOpensPersec"]?.Value ?? default(uint)),
		 TablesOpen = (uint) (managementObject.Properties["TablesOpen"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 VersionBucketsAllocated = (uint) (managementObject.Properties["VersionBucketsAllocated"]?.Value ?? default(uint))
                };
        }
    }
}