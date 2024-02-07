using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.PerfOs
{
    /// <summary>
    /// </summary>
    public sealed class PerfOsCache
    {
		public uint AsyncCopyReadsPersec { get; private set; }
		public uint AsyncDataMapsPersec { get; private set; }
		public uint AsyncFastReadsPersec { get; private set; }
		public uint AsyncMdlReadsPersec { get; private set; }
		public uint AsyncPinReadsPersec { get; private set; }
		public string Caption { get; private set; }
		public uint CopyReadHitsPercent { get; private set; }
		public uint CopyReadHitsPercentBase { get; private set; }
		public uint CopyReadsPersec { get; private set; }
		public uint DataFlushesPersec { get; private set; }
		public uint DataFlushPagesPersec { get; private set; }
		public uint DataMapHitsPercent { get; private set; }
		public uint DataMapHitsPercentBase { get; private set; }
		public uint DataMapPinsPersec { get; private set; }
		public uint DataMapPinsPersecBase { get; private set; }
		public uint DataMapsPersec { get; private set; }
		public string Description { get; private set; }
		public ulong DirtyPages { get; private set; }
		public ulong DirtyPageThreshold { get; private set; }
		public uint FastReadNotPossiblesPersec { get; private set; }
		public uint FastReadResourceMissesPersec { get; private set; }
		public uint FastReadsPersec { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public uint LazyWriteFlushesPersec { get; private set; }
		public uint LazyWritePagesPersec { get; private set; }
		public uint MdlReadHitsPercent { get; private set; }
		public uint MdlReadHitsPercentBase { get; private set; }
		public uint MdlReadsPersec { get; private set; }
		public string Name { get; private set; }
		public uint PinReadHitsPercent { get; private set; }
		public uint PinReadHitsPercentBase { get; private set; }
		public uint PinReadsPersec { get; private set; }
		public uint ReadAheadsPersec { get; private set; }
		public uint SyncCopyReadsPersec { get; private set; }
		public uint SyncDataMapsPersec { get; private set; }
		public uint SyncFastReadsPersec { get; private set; }
		public uint SyncMdlReadsPersec { get; private set; }
		public uint SyncPinReadsPersec { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<PerfOsCache> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<PerfOsCache> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<PerfOsCache> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_PerfOS_Cache");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new PerfOsCache
                {
                     AsyncCopyReadsPersec = (uint) (managementObject.Properties["AsyncCopyReadsPersec"]?.Value ?? default(uint)),
		 AsyncDataMapsPersec = (uint) (managementObject.Properties["AsyncDataMapsPersec"]?.Value ?? default(uint)),
		 AsyncFastReadsPersec = (uint) (managementObject.Properties["AsyncFastReadsPersec"]?.Value ?? default(uint)),
		 AsyncMdlReadsPersec = (uint) (managementObject.Properties["AsyncMDLReadsPersec"]?.Value ?? default(uint)),
		 AsyncPinReadsPersec = (uint) (managementObject.Properties["AsyncPinReadsPersec"]?.Value ?? default(uint)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CopyReadHitsPercent = (uint) (managementObject.Properties["CopyReadHitsPercent"]?.Value ?? default(uint)),
		 CopyReadHitsPercentBase = (uint) (managementObject.Properties["CopyReadHitsPercent_Base"]?.Value ?? default(uint)),
		 CopyReadsPersec = (uint) (managementObject.Properties["CopyReadsPersec"]?.Value ?? default(uint)),
		 DataFlushesPersec = (uint) (managementObject.Properties["DataFlushesPersec"]?.Value ?? default(uint)),
		 DataFlushPagesPersec = (uint) (managementObject.Properties["DataFlushPagesPersec"]?.Value ?? default(uint)),
		 DataMapHitsPercent = (uint) (managementObject.Properties["DataMapHitsPercent"]?.Value ?? default(uint)),
		 DataMapHitsPercentBase = (uint) (managementObject.Properties["DataMapHitsPercent_Base"]?.Value ?? default(uint)),
		 DataMapPinsPersec = (uint) (managementObject.Properties["DataMapPinsPersec"]?.Value ?? default(uint)),
		 DataMapPinsPersecBase = (uint) (managementObject.Properties["DataMapPinsPersec_Base"]?.Value ?? default(uint)),
		 DataMapsPersec = (uint) (managementObject.Properties["DataMapsPersec"]?.Value ?? default(uint)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DirtyPages = (ulong) (managementObject.Properties["DirtyPages"]?.Value ?? default(ulong)),
		 DirtyPageThreshold = (ulong) (managementObject.Properties["DirtyPageThreshold"]?.Value ?? default(ulong)),
		 FastReadNotPossiblesPersec = (uint) (managementObject.Properties["FastReadNotPossiblesPersec"]?.Value ?? default(uint)),
		 FastReadResourceMissesPersec = (uint) (managementObject.Properties["FastReadResourceMissesPersec"]?.Value ?? default(uint)),
		 FastReadsPersec = (uint) (managementObject.Properties["FastReadsPersec"]?.Value ?? default(uint)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 LazyWriteFlushesPersec = (uint) (managementObject.Properties["LazyWriteFlushesPersec"]?.Value ?? default(uint)),
		 LazyWritePagesPersec = (uint) (managementObject.Properties["LazyWritePagesPersec"]?.Value ?? default(uint)),
		 MdlReadHitsPercent = (uint) (managementObject.Properties["MDLReadHitsPercent"]?.Value ?? default(uint)),
		 MdlReadHitsPercentBase = (uint) (managementObject.Properties["MDLReadHitsPercent_Base"]?.Value ?? default(uint)),
		 MdlReadsPersec = (uint) (managementObject.Properties["MDLReadsPersec"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 PinReadHitsPercent = (uint) (managementObject.Properties["PinReadHitsPercent"]?.Value ?? default(uint)),
		 PinReadHitsPercentBase = (uint) (managementObject.Properties["PinReadHitsPercent_Base"]?.Value ?? default(uint)),
		 PinReadsPersec = (uint) (managementObject.Properties["PinReadsPersec"]?.Value ?? default(uint)),
		 ReadAheadsPersec = (uint) (managementObject.Properties["ReadAheadsPersec"]?.Value ?? default(uint)),
		 SyncCopyReadsPersec = (uint) (managementObject.Properties["SyncCopyReadsPersec"]?.Value ?? default(uint)),
		 SyncDataMapsPersec = (uint) (managementObject.Properties["SyncDataMapsPersec"]?.Value ?? default(uint)),
		 SyncFastReadsPersec = (uint) (managementObject.Properties["SyncFastReadsPersec"]?.Value ?? default(uint)),
		 SyncMdlReadsPersec = (uint) (managementObject.Properties["SyncMDLReadsPersec"]?.Value ?? default(uint)),
		 SyncPinReadsPersec = (uint) (managementObject.Properties["SyncPinReadsPersec"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}