using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted
{
    /// <summary>
    /// </summary>
    public sealed class W3SvcWebServiceCache
    {
		public uint ActiveFlushedEntries { get; private set; }
		public string Caption { get; private set; }
		public ulong CurrentFileCacheMemoryUsage { get; private set; }
		public uint CurrentFilesCached { get; private set; }
		public uint CurrentMetadataCached { get; private set; }
		public uint CurrentUrIsCached { get; private set; }
		public string Description { get; private set; }
		public uint FileCacheFlushes { get; private set; }
		public uint FileCacheHits { get; private set; }
		public uint FileCacheHitsPercent { get; private set; }
		public uint FileCacheMisses { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public uint KernelCurrentUrIsCached { get; private set; }
		public uint KernelTotalFlushedUrIs { get; private set; }
		public uint KernelTotalUrIsCached { get; private set; }
		public uint KernelUriCacheFlushes { get; private set; }
		public uint KernelUriCacheHits { get; private set; }
		public uint KernelUriCacheHitsPercent { get; private set; }
		public uint KernelUriCacheHitsPersec { get; private set; }
		public uint KernelUriCacheMisses { get; private set; }
		public ulong MaximumFileCacheMemoryUsage { get; private set; }
		public uint MetadataCacheFlushes { get; private set; }
		public uint MetadataCacheHits { get; private set; }
		public uint MetadataCacheHitsPercent { get; private set; }
		public uint MetadataCacheMisses { get; private set; }
		public string Name { get; private set; }
		public uint OutputCacheCurrentFlushedItems { get; private set; }
		public uint OutputCacheCurrentHitsPercent { get; private set; }
		public uint OutputCacheCurrentItems { get; private set; }
		public ulong OutputCacheCurrentMemoryUsage { get; private set; }
		public uint OutputCacheTotalFlushedItems { get; private set; }
		public uint OutputCacheTotalFlushes { get; private set; }
		public uint OutputCacheTotalHits { get; private set; }
		public uint OutputCacheTotalMisses { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public uint TotalFilesCached { get; private set; }
		public uint TotalFlushedFiles { get; private set; }
		public uint TotalFlushedMetadata { get; private set; }
		public uint TotalFlushedUrIs { get; private set; }
		public uint TotalMetadataCached { get; private set; }
		public uint TotalUrIsCached { get; private set; }
		public uint UriCacheFlushes { get; private set; }
		public uint UriCacheHits { get; private set; }
		public uint UriCacheHitsPercent { get; private set; }
		public uint UriCacheMisses { get; private set; }

        public static IEnumerable<W3SvcWebServiceCache> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<W3SvcWebServiceCache> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<W3SvcWebServiceCache> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_W3SVC_WebServiceCache");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new W3SvcWebServiceCache
                {
                     ActiveFlushedEntries = (uint) (managementObject.Properties["ActiveFlushedEntries"]?.Value ?? default(uint)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CurrentFileCacheMemoryUsage = (ulong) (managementObject.Properties["CurrentFileCacheMemoryUsage"]?.Value ?? default(ulong)),
		 CurrentFilesCached = (uint) (managementObject.Properties["CurrentFilesCached"]?.Value ?? default(uint)),
		 CurrentMetadataCached = (uint) (managementObject.Properties["CurrentMetadataCached"]?.Value ?? default(uint)),
		 CurrentUrIsCached = (uint) (managementObject.Properties["CurrentURIsCached"]?.Value ?? default(uint)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FileCacheFlushes = (uint) (managementObject.Properties["FileCacheFlushes"]?.Value ?? default(uint)),
		 FileCacheHits = (uint) (managementObject.Properties["FileCacheHits"]?.Value ?? default(uint)),
		 FileCacheHitsPercent = (uint) (managementObject.Properties["FileCacheHitsPercent"]?.Value ?? default(uint)),
		 FileCacheMisses = (uint) (managementObject.Properties["FileCacheMisses"]?.Value ?? default(uint)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 KernelCurrentUrIsCached = (uint) (managementObject.Properties["KernelCurrentURIsCached"]?.Value ?? default(uint)),
		 KernelTotalFlushedUrIs = (uint) (managementObject.Properties["KernelTotalFlushedURIs"]?.Value ?? default(uint)),
		 KernelTotalUrIsCached = (uint) (managementObject.Properties["KernelTotalURIsCached"]?.Value ?? default(uint)),
		 KernelUriCacheFlushes = (uint) (managementObject.Properties["KernelURICacheFlushes"]?.Value ?? default(uint)),
		 KernelUriCacheHits = (uint) (managementObject.Properties["KernelURICacheHits"]?.Value ?? default(uint)),
		 KernelUriCacheHitsPercent = (uint) (managementObject.Properties["KernelURICacheHitsPercent"]?.Value ?? default(uint)),
		 KernelUriCacheHitsPersec = (uint) (managementObject.Properties["KernelUriCacheHitsPersec"]?.Value ?? default(uint)),
		 KernelUriCacheMisses = (uint) (managementObject.Properties["KernelURICacheMisses"]?.Value ?? default(uint)),
		 MaximumFileCacheMemoryUsage = (ulong) (managementObject.Properties["MaximumFileCacheMemoryUsage"]?.Value ?? default(ulong)),
		 MetadataCacheFlushes = (uint) (managementObject.Properties["MetadataCacheFlushes"]?.Value ?? default(uint)),
		 MetadataCacheHits = (uint) (managementObject.Properties["MetadataCacheHits"]?.Value ?? default(uint)),
		 MetadataCacheHitsPercent = (uint) (managementObject.Properties["MetadataCacheHitsPercent"]?.Value ?? default(uint)),
		 MetadataCacheMisses = (uint) (managementObject.Properties["MetadataCacheMisses"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 OutputCacheCurrentFlushedItems = (uint) (managementObject.Properties["OutputCacheCurrentFlushedItems"]?.Value ?? default(uint)),
		 OutputCacheCurrentHitsPercent = (uint) (managementObject.Properties["OutputCacheCurrentHitsPercent"]?.Value ?? default(uint)),
		 OutputCacheCurrentItems = (uint) (managementObject.Properties["OutputCacheCurrentItems"]?.Value ?? default(uint)),
		 OutputCacheCurrentMemoryUsage = (ulong) (managementObject.Properties["OutputCacheCurrentMemoryUsage"]?.Value ?? default(ulong)),
		 OutputCacheTotalFlushedItems = (uint) (managementObject.Properties["OutputCacheTotalFlushedItems"]?.Value ?? default(uint)),
		 OutputCacheTotalFlushes = (uint) (managementObject.Properties["OutputCacheTotalFlushes"]?.Value ?? default(uint)),
		 OutputCacheTotalHits = (uint) (managementObject.Properties["OutputCacheTotalHits"]?.Value ?? default(uint)),
		 OutputCacheTotalMisses = (uint) (managementObject.Properties["OutputCacheTotalMisses"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 TotalFilesCached = (uint) (managementObject.Properties["TotalFilesCached"]?.Value ?? default(uint)),
		 TotalFlushedFiles = (uint) (managementObject.Properties["TotalFlushedFiles"]?.Value ?? default(uint)),
		 TotalFlushedMetadata = (uint) (managementObject.Properties["TotalFlushedMetadata"]?.Value ?? default(uint)),
		 TotalFlushedUrIs = (uint) (managementObject.Properties["TotalFlushedURIs"]?.Value ?? default(uint)),
		 TotalMetadataCached = (uint) (managementObject.Properties["TotalMetadataCached"]?.Value ?? default(uint)),
		 TotalUrIsCached = (uint) (managementObject.Properties["TotalURIsCached"]?.Value ?? default(uint)),
		 UriCacheFlushes = (uint) (managementObject.Properties["URICacheFlushes"]?.Value ?? default(uint)),
		 UriCacheHits = (uint) (managementObject.Properties["URICacheHits"]?.Value ?? default(uint)),
		 UriCacheHitsPercent = (uint) (managementObject.Properties["URICacheHitsPercent"]?.Value ?? default(uint)),
		 UriCacheMisses = (uint) (managementObject.Properties["URICacheMisses"]?.Value ?? default(uint))
                };
        }
    }
}