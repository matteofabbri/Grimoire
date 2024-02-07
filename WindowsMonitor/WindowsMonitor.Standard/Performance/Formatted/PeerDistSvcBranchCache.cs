using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted
{
    /// <summary>
    /// </summary>
    public sealed class PeerDistSvcBranchCache
    {
		public ulong BitsBytesfromcache { get; private set; }
		public ulong BitsBytesfromserver { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public uint DiscoveryAttempteddiscoveries { get; private set; }
		public uint DiscoverySuccessfuldiscoveries { get; private set; }
		public uint DiscoveryWeightedaveragediscoverytime { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public uint HostedCacheClientfilesegmentoffersmade { get; private set; }
		public uint HostedCacheSegmentoffersqueuesize { get; private set; }
		public uint LocalCacheAverageaccesstime { get; private set; }
		public uint LocalCacheCachecompletefilesegments { get; private set; }
		public uint LocalCacheCachepartialfilesegments { get; private set; }
		public string Name { get; private set; }
		public ulong OtherBytesfromcache { get; private set; }
		public ulong OtherBytesfromserver { get; private set; }
		public uint PublicationCachePublishedcontents { get; private set; }
		public ulong RetrievalAveragebranchrate { get; private set; }
		public ulong RetrievalBytesfromcache { get; private set; }
		public ulong RetrievalBytesfromserver { get; private set; }
		public ulong RetrievalBytesserved { get; private set; }
		public ulong SmbBytesfromcache { get; private set; }
		public ulong SmbBytesfromserver { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public ulong WinhttpBytesfromcache { get; private set; }
		public ulong WinhttpBytesfromserver { get; private set; }
		public ulong WininetBytesfromcache { get; private set; }
		public ulong WininetBytesfromserver { get; private set; }

        public static IEnumerable<PeerDistSvcBranchCache> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<PeerDistSvcBranchCache> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<PeerDistSvcBranchCache> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_PeerDistSvc_BranchCache");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new PeerDistSvcBranchCache
                {
                     BitsBytesfromcache = (ulong) (managementObject.Properties["BITSBytesfromcache"]?.Value ?? default(ulong)),
		 BitsBytesfromserver = (ulong) (managementObject.Properties["BITSBytesfromserver"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DiscoveryAttempteddiscoveries = (uint) (managementObject.Properties["DiscoveryAttempteddiscoveries"]?.Value ?? default(uint)),
		 DiscoverySuccessfuldiscoveries = (uint) (managementObject.Properties["DiscoverySuccessfuldiscoveries"]?.Value ?? default(uint)),
		 DiscoveryWeightedaveragediscoverytime = (uint) (managementObject.Properties["DiscoveryWeightedaveragediscoverytime"]?.Value ?? default(uint)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 HostedCacheClientfilesegmentoffersmade = (uint) (managementObject.Properties["HostedCacheClientfilesegmentoffersmade"]?.Value ?? default(uint)),
		 HostedCacheSegmentoffersqueuesize = (uint) (managementObject.Properties["HostedCacheSegmentoffersqueuesize"]?.Value ?? default(uint)),
		 LocalCacheAverageaccesstime = (uint) (managementObject.Properties["LocalCacheAverageaccesstime"]?.Value ?? default(uint)),
		 LocalCacheCachecompletefilesegments = (uint) (managementObject.Properties["LocalCacheCachecompletefilesegments"]?.Value ?? default(uint)),
		 LocalCacheCachepartialfilesegments = (uint) (managementObject.Properties["LocalCacheCachepartialfilesegments"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 OtherBytesfromcache = (ulong) (managementObject.Properties["OTHERBytesfromcache"]?.Value ?? default(ulong)),
		 OtherBytesfromserver = (ulong) (managementObject.Properties["OTHERBytesfromserver"]?.Value ?? default(ulong)),
		 PublicationCachePublishedcontents = (uint) (managementObject.Properties["PublicationCachePublishedcontents"]?.Value ?? default(uint)),
		 RetrievalAveragebranchrate = (ulong) (managementObject.Properties["RetrievalAveragebranchrate"]?.Value ?? default(ulong)),
		 RetrievalBytesfromcache = (ulong) (managementObject.Properties["RetrievalBytesfromcache"]?.Value ?? default(ulong)),
		 RetrievalBytesfromserver = (ulong) (managementObject.Properties["RetrievalBytesfromserver"]?.Value ?? default(ulong)),
		 RetrievalBytesserved = (ulong) (managementObject.Properties["RetrievalBytesserved"]?.Value ?? default(ulong)),
		 SmbBytesfromcache = (ulong) (managementObject.Properties["SMBBytesfromcache"]?.Value ?? default(ulong)),
		 SmbBytesfromserver = (ulong) (managementObject.Properties["SMBBytesfromserver"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 WinhttpBytesfromcache = (ulong) (managementObject.Properties["WINHTTPBytesfromcache"]?.Value ?? default(ulong)),
		 WinhttpBytesfromserver = (ulong) (managementObject.Properties["WINHTTPBytesfromserver"]?.Value ?? default(ulong)),
		 WininetBytesfromcache = (ulong) (managementObject.Properties["WININETBytesfromcache"]?.Value ?? default(ulong)),
		 WininetBytesfromserver = (ulong) (managementObject.Properties["WININETBytesfromserver"]?.Value ?? default(ulong))
                };
        }
    }
}