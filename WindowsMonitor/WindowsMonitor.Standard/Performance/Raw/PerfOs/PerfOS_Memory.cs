using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.PerfOs
{
    /// <summary>
    /// </summary>
    public sealed class PerfOsMemory
    {
		public ulong AvailableBytes { get; private set; }
		public ulong AvailableKBytes { get; private set; }
		public ulong AvailableMBytes { get; private set; }
		public ulong CacheBytes { get; private set; }
		public ulong CacheBytesPeak { get; private set; }
		public uint CacheFaultsPersec { get; private set; }
		public string Caption { get; private set; }
		public ulong CommitLimit { get; private set; }
		public ulong CommittedBytes { get; private set; }
		public uint DemandZeroFaultsPersec { get; private set; }
		public string Description { get; private set; }
		public ulong FreeAndZeroPageListBytes { get; private set; }
		public uint FreeSystemPageTableEntries { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public uint LongTermAverageStandbyCacheLifetimes { get; private set; }
		public ulong ModifiedPageListBytes { get; private set; }
		public string Name { get; private set; }
		public uint PageFaultsPersec { get; private set; }
		public uint PageReadsPersec { get; private set; }
		public uint PagesInputPersec { get; private set; }
		public uint PagesOutputPersec { get; private set; }
		public uint PagesPersec { get; private set; }
		public uint PageWritesPersec { get; private set; }
		public uint PercentCommittedBytesInUse { get; private set; }
		public uint PercentCommittedBytesInUseBase { get; private set; }
		public uint PoolNonpagedAllocs { get; private set; }
		public ulong PoolNonpagedBytes { get; private set; }
		public uint PoolPagedAllocs { get; private set; }
		public ulong PoolPagedBytes { get; private set; }
		public ulong PoolPagedResidentBytes { get; private set; }
		public ulong StandbyCacheCoreBytes { get; private set; }
		public ulong StandbyCacheNormalPriorityBytes { get; private set; }
		public ulong StandbyCacheReserveBytes { get; private set; }
		public ulong SystemCacheResidentBytes { get; private set; }
		public ulong SystemCodeResidentBytes { get; private set; }
		public ulong SystemCodeTotalBytes { get; private set; }
		public ulong SystemDriverResidentBytes { get; private set; }
		public ulong SystemDriverTotalBytes { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public uint TransitionFaultsPersec { get; private set; }
		public uint TransitionPagesRePurposedPersec { get; private set; }
		public uint WriteCopiesPersec { get; private set; }

        public static IEnumerable<PerfOsMemory> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<PerfOsMemory> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<PerfOsMemory> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_PerfOS_Memory");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new PerfOsMemory
                {
                     AvailableBytes = (ulong) (managementObject.Properties["AvailableBytes"]?.Value ?? default(ulong)),
		 AvailableKBytes = (ulong) (managementObject.Properties["AvailableKBytes"]?.Value ?? default(ulong)),
		 AvailableMBytes = (ulong) (managementObject.Properties["AvailableMBytes"]?.Value ?? default(ulong)),
		 CacheBytes = (ulong) (managementObject.Properties["CacheBytes"]?.Value ?? default(ulong)),
		 CacheBytesPeak = (ulong) (managementObject.Properties["CacheBytesPeak"]?.Value ?? default(ulong)),
		 CacheFaultsPersec = (uint) (managementObject.Properties["CacheFaultsPersec"]?.Value ?? default(uint)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CommitLimit = (ulong) (managementObject.Properties["CommitLimit"]?.Value ?? default(ulong)),
		 CommittedBytes = (ulong) (managementObject.Properties["CommittedBytes"]?.Value ?? default(ulong)),
		 DemandZeroFaultsPersec = (uint) (managementObject.Properties["DemandZeroFaultsPersec"]?.Value ?? default(uint)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FreeAndZeroPageListBytes = (ulong) (managementObject.Properties["FreeAndZeroPageListBytes"]?.Value ?? default(ulong)),
		 FreeSystemPageTableEntries = (uint) (managementObject.Properties["FreeSystemPageTableEntries"]?.Value ?? default(uint)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 LongTermAverageStandbyCacheLifetimes = (uint) (managementObject.Properties["LongTermAverageStandbyCacheLifetimes"]?.Value ?? default(uint)),
		 ModifiedPageListBytes = (ulong) (managementObject.Properties["ModifiedPageListBytes"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 PageFaultsPersec = (uint) (managementObject.Properties["PageFaultsPersec"]?.Value ?? default(uint)),
		 PageReadsPersec = (uint) (managementObject.Properties["PageReadsPersec"]?.Value ?? default(uint)),
		 PagesInputPersec = (uint) (managementObject.Properties["PagesInputPersec"]?.Value ?? default(uint)),
		 PagesOutputPersec = (uint) (managementObject.Properties["PagesOutputPersec"]?.Value ?? default(uint)),
		 PagesPersec = (uint) (managementObject.Properties["PagesPersec"]?.Value ?? default(uint)),
		 PageWritesPersec = (uint) (managementObject.Properties["PageWritesPersec"]?.Value ?? default(uint)),
		 PercentCommittedBytesInUse = (uint) (managementObject.Properties["PercentCommittedBytesInUse"]?.Value ?? default(uint)),
		 PercentCommittedBytesInUseBase = (uint) (managementObject.Properties["PercentCommittedBytesInUse_Base"]?.Value ?? default(uint)),
		 PoolNonpagedAllocs = (uint) (managementObject.Properties["PoolNonpagedAllocs"]?.Value ?? default(uint)),
		 PoolNonpagedBytes = (ulong) (managementObject.Properties["PoolNonpagedBytes"]?.Value ?? default(ulong)),
		 PoolPagedAllocs = (uint) (managementObject.Properties["PoolPagedAllocs"]?.Value ?? default(uint)),
		 PoolPagedBytes = (ulong) (managementObject.Properties["PoolPagedBytes"]?.Value ?? default(ulong)),
		 PoolPagedResidentBytes = (ulong) (managementObject.Properties["PoolPagedResidentBytes"]?.Value ?? default(ulong)),
		 StandbyCacheCoreBytes = (ulong) (managementObject.Properties["StandbyCacheCoreBytes"]?.Value ?? default(ulong)),
		 StandbyCacheNormalPriorityBytes = (ulong) (managementObject.Properties["StandbyCacheNormalPriorityBytes"]?.Value ?? default(ulong)),
		 StandbyCacheReserveBytes = (ulong) (managementObject.Properties["StandbyCacheReserveBytes"]?.Value ?? default(ulong)),
		 SystemCacheResidentBytes = (ulong) (managementObject.Properties["SystemCacheResidentBytes"]?.Value ?? default(ulong)),
		 SystemCodeResidentBytes = (ulong) (managementObject.Properties["SystemCodeResidentBytes"]?.Value ?? default(ulong)),
		 SystemCodeTotalBytes = (ulong) (managementObject.Properties["SystemCodeTotalBytes"]?.Value ?? default(ulong)),
		 SystemDriverResidentBytes = (ulong) (managementObject.Properties["SystemDriverResidentBytes"]?.Value ?? default(ulong)),
		 SystemDriverTotalBytes = (ulong) (managementObject.Properties["SystemDriverTotalBytes"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 TransitionFaultsPersec = (uint) (managementObject.Properties["TransitionFaultsPersec"]?.Value ?? default(uint)),
		 TransitionPagesRePurposedPersec = (uint) (managementObject.Properties["TransitionPagesRePurposedPersec"]?.Value ?? default(uint)),
		 WriteCopiesPersec = (uint) (managementObject.Properties["WriteCopiesPersec"]?.Value ?? default(uint))
                };
        }
    }
}