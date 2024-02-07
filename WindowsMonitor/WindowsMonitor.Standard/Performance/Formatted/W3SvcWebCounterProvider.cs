using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted
{
    /// <summary>
    /// </summary>
    public sealed class W3SvcWebCounterProvider
    {
		public uint ActiveFlushedEntries { get; private set; }
		public uint ActiveRequests { get; private set; }
		public uint ActiveThreadsCount { get; private set; }
		public string Caption { get; private set; }
		public ulong CurrentFileCacheMemoryUsage { get; private set; }
		public uint CurrentFilesCached { get; private set; }
		public uint CurrentMetadataCached { get; private set; }
		public uint CurrentUrIsCached { get; private set; }
		public string Description { get; private set; }
		public uint FileCacheFlushes { get; private set; }
		public uint FileCacheHits { get; private set; }
		public uint FileCacheHitsPersec { get; private set; }
		public uint FileCacheMisses { get; private set; }
		public uint FileCacheMissesPersec { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public ulong MaximumFileCacheMemoryUsage { get; private set; }
		public uint MaximumThreadsCount { get; private set; }
		public uint MetadataCacheFlushes { get; private set; }
		public uint MetadataCacheHits { get; private set; }
		public uint MetadataCacheHitsPersec { get; private set; }
		public uint MetadataCacheMisses { get; private set; }
		public uint MetadataCacheMissesPersec { get; private set; }
		public string Name { get; private set; }
		public uint OutputCacheCurrentFlushedItems { get; private set; }
		public uint OutputCacheCurrentItems { get; private set; }
		public ulong OutputCacheCurrentMemoryUsage { get; private set; }
		public uint OutputCacheHitsPersec { get; private set; }
		public uint OutputCacheMissesPersec { get; private set; }
		public uint OutputCacheTotalFlushedItems { get; private set; }
		public uint OutputCacheTotalFlushes { get; private set; }
		public uint OutputCacheTotalHits { get; private set; }
		public uint OutputCacheTotalMisses { get; private set; }
		public uint Percent401HttpResponseSent { get; private set; }
		public uint Percent403HttpResponseSent { get; private set; }
		public uint Percent404HttpResponseSent { get; private set; }
		public uint Percent500HttpResponseSent { get; private set; }
		public uint RequestsPerSec { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public uint TotalFilesCached { get; private set; }
		public uint TotalFlushedFiles { get; private set; }
		public uint TotalFlushedMetadata { get; private set; }
		public uint TotalFlushedUrIs { get; private set; }
		public uint TotalHttpRequestsServed { get; private set; }
		public uint TotalMetadataCached { get; private set; }
		public uint TotalThreads { get; private set; }
		public uint TotalUrIsCached { get; private set; }
		public uint UriCacheFlushes { get; private set; }
		public uint UriCacheHits { get; private set; }
		public uint UriCacheHitsPersec { get; private set; }
		public uint UriCacheMisses { get; private set; }
		public uint UriCacheMissesPersec { get; private set; }
		public uint WebSocketActiveRequests { get; private set; }
		public uint WebSocketConnectionAttemptsPerSec { get; private set; }
		public uint WebSocketConnectionsAcceptedPerSec { get; private set; }
		public uint WebSocketConnectionsRejectedPerSec { get; private set; }

        public static IEnumerable<W3SvcWebCounterProvider> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<W3SvcWebCounterProvider> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<W3SvcWebCounterProvider> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_W3SVCW3WPCounterProvider_W3SVCW3WP");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new W3SvcWebCounterProvider
                {
                     ActiveFlushedEntries = (uint) (managementObject.Properties["ActiveFlushedEntries"]?.Value ?? default(uint)),
		 ActiveRequests = (uint) (managementObject.Properties["ActiveRequests"]?.Value ?? default(uint)),
		 ActiveThreadsCount = (uint) (managementObject.Properties["ActiveThreadsCount"]?.Value ?? default(uint)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CurrentFileCacheMemoryUsage = (ulong) (managementObject.Properties["CurrentFileCacheMemoryUsage"]?.Value ?? default(ulong)),
		 CurrentFilesCached = (uint) (managementObject.Properties["CurrentFilesCached"]?.Value ?? default(uint)),
		 CurrentMetadataCached = (uint) (managementObject.Properties["CurrentMetadataCached"]?.Value ?? default(uint)),
		 CurrentUrIsCached = (uint) (managementObject.Properties["CurrentURIsCached"]?.Value ?? default(uint)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FileCacheFlushes = (uint) (managementObject.Properties["FileCacheFlushes"]?.Value ?? default(uint)),
		 FileCacheHits = (uint) (managementObject.Properties["FileCacheHits"]?.Value ?? default(uint)),
		 FileCacheHitsPersec = (uint) (managementObject.Properties["FileCacheHitsPersec"]?.Value ?? default(uint)),
		 FileCacheMisses = (uint) (managementObject.Properties["FileCacheMisses"]?.Value ?? default(uint)),
		 FileCacheMissesPersec = (uint) (managementObject.Properties["FileCacheMissesPersec"]?.Value ?? default(uint)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 MaximumFileCacheMemoryUsage = (ulong) (managementObject.Properties["MaximumFileCacheMemoryUsage"]?.Value ?? default(ulong)),
		 MaximumThreadsCount = (uint) (managementObject.Properties["MaximumThreadsCount"]?.Value ?? default(uint)),
		 MetadataCacheFlushes = (uint) (managementObject.Properties["MetadataCacheFlushes"]?.Value ?? default(uint)),
		 MetadataCacheHits = (uint) (managementObject.Properties["MetadataCacheHits"]?.Value ?? default(uint)),
		 MetadataCacheHitsPersec = (uint) (managementObject.Properties["MetadataCacheHitsPersec"]?.Value ?? default(uint)),
		 MetadataCacheMisses = (uint) (managementObject.Properties["MetadataCacheMisses"]?.Value ?? default(uint)),
		 MetadataCacheMissesPersec = (uint) (managementObject.Properties["MetadataCacheMissesPersec"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 OutputCacheCurrentFlushedItems = (uint) (managementObject.Properties["OutputCacheCurrentFlushedItems"]?.Value ?? default(uint)),
		 OutputCacheCurrentItems = (uint) (managementObject.Properties["OutputCacheCurrentItems"]?.Value ?? default(uint)),
		 OutputCacheCurrentMemoryUsage = (ulong) (managementObject.Properties["OutputCacheCurrentMemoryUsage"]?.Value ?? default(ulong)),
		 OutputCacheHitsPersec = (uint) (managementObject.Properties["OutputCacheHitsPersec"]?.Value ?? default(uint)),
		 OutputCacheMissesPersec = (uint) (managementObject.Properties["OutputCacheMissesPersec"]?.Value ?? default(uint)),
		 OutputCacheTotalFlushedItems = (uint) (managementObject.Properties["OutputCacheTotalFlushedItems"]?.Value ?? default(uint)),
		 OutputCacheTotalFlushes = (uint) (managementObject.Properties["OutputCacheTotalFlushes"]?.Value ?? default(uint)),
		 OutputCacheTotalHits = (uint) (managementObject.Properties["OutputCacheTotalHits"]?.Value ?? default(uint)),
		 OutputCacheTotalMisses = (uint) (managementObject.Properties["OutputCacheTotalMisses"]?.Value ?? default(uint)),
		 Percent401HttpResponseSent = (uint) (managementObject.Properties["Percent401HTTPResponseSent"]?.Value ?? default(uint)),
		 Percent403HttpResponseSent = (uint) (managementObject.Properties["Percent403HTTPResponseSent"]?.Value ?? default(uint)),
		 Percent404HttpResponseSent = (uint) (managementObject.Properties["Percent404HTTPResponseSent"]?.Value ?? default(uint)),
		 Percent500HttpResponseSent = (uint) (managementObject.Properties["Percent500HTTPResponseSent"]?.Value ?? default(uint)),
		 RequestsPerSec = (uint) (managementObject.Properties["RequestsPerSec"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 TotalFilesCached = (uint) (managementObject.Properties["TotalFilesCached"]?.Value ?? default(uint)),
		 TotalFlushedFiles = (uint) (managementObject.Properties["TotalFlushedFiles"]?.Value ?? default(uint)),
		 TotalFlushedMetadata = (uint) (managementObject.Properties["TotalFlushedMetadata"]?.Value ?? default(uint)),
		 TotalFlushedUrIs = (uint) (managementObject.Properties["TotalFlushedURIs"]?.Value ?? default(uint)),
		 TotalHttpRequestsServed = (uint) (managementObject.Properties["TotalHTTPRequestsServed"]?.Value ?? default(uint)),
		 TotalMetadataCached = (uint) (managementObject.Properties["TotalMetadataCached"]?.Value ?? default(uint)),
		 TotalThreads = (uint) (managementObject.Properties["TotalThreads"]?.Value ?? default(uint)),
		 TotalUrIsCached = (uint) (managementObject.Properties["TotalURIsCached"]?.Value ?? default(uint)),
		 UriCacheFlushes = (uint) (managementObject.Properties["URICacheFlushes"]?.Value ?? default(uint)),
		 UriCacheHits = (uint) (managementObject.Properties["URICacheHits"]?.Value ?? default(uint)),
		 UriCacheHitsPersec = (uint) (managementObject.Properties["UriCacheHitsPersec"]?.Value ?? default(uint)),
		 UriCacheMisses = (uint) (managementObject.Properties["URICacheMisses"]?.Value ?? default(uint)),
		 UriCacheMissesPersec = (uint) (managementObject.Properties["UriCacheMissesPersec"]?.Value ?? default(uint)),
		 WebSocketActiveRequests = (uint) (managementObject.Properties["WebSocketActiveRequests"]?.Value ?? default(uint)),
		 WebSocketConnectionAttemptsPerSec = (uint) (managementObject.Properties["WebSocketConnectionAttemptsPerSec"]?.Value ?? default(uint)),
		 WebSocketConnectionsAcceptedPerSec = (uint) (managementObject.Properties["WebSocketConnectionsAcceptedPerSec"]?.Value ?? default(uint)),
		 WebSocketConnectionsRejectedPerSec = (uint) (managementObject.Properties["WebSocketConnectionsRejectedPerSec"]?.Value ?? default(uint))
                };
        }
    }
}