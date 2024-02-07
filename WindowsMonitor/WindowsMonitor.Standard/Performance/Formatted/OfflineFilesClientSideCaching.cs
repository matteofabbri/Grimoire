using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted
{
    /// <summary>
    /// </summary>
    public sealed class OfflineFilesClientSideCaching
    {
		public ulong ApplicationBytesReadFromCache { get; private set; }
		public ulong ApplicationBytesReadFromServer { get; private set; }
		public ulong ApplicationBytesReadFromServerNotCached { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public ulong PrefetchBytesReadFromCache { get; private set; }
		public ulong PrefetchBytesReadFromServer { get; private set; }
		public uint PrefetchOperationsQueued { get; private set; }
		public ulong SmbBranchCacheBytesPublished { get; private set; }
		public ulong SmbBranchCacheBytesReceived { get; private set; }
		public ulong SmbBranchCacheBytesRequested { get; private set; }
		public ulong SmbBranchCacheBytesRequestedFromServer { get; private set; }
		public ulong SmbBranchCacheHashBytesReceived { get; private set; }
		public uint SmbBranchCacheHashesReceived { get; private set; }
		public uint SmbBranchCacheHashesRequested { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<OfflineFilesClientSideCaching> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<OfflineFilesClientSideCaching> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<OfflineFilesClientSideCaching> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_OfflineFiles_ClientSideCaching");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new OfflineFilesClientSideCaching
                {
                     ApplicationBytesReadFromCache = (ulong) (managementObject.Properties["ApplicationBytesReadFromCache"]?.Value ?? default(ulong)),
		 ApplicationBytesReadFromServer = (ulong) (managementObject.Properties["ApplicationBytesReadFromServer"]?.Value ?? default(ulong)),
		 ApplicationBytesReadFromServerNotCached = (ulong) (managementObject.Properties["ApplicationBytesReadFromServerNotCached"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 PrefetchBytesReadFromCache = (ulong) (managementObject.Properties["PrefetchBytesReadFromCache"]?.Value ?? default(ulong)),
		 PrefetchBytesReadFromServer = (ulong) (managementObject.Properties["PrefetchBytesReadFromServer"]?.Value ?? default(ulong)),
		 PrefetchOperationsQueued = (uint) (managementObject.Properties["PrefetchOperationsQueued"]?.Value ?? default(uint)),
		 SmbBranchCacheBytesPublished = (ulong) (managementObject.Properties["SMBBranchCacheBytesPublished"]?.Value ?? default(ulong)),
		 SmbBranchCacheBytesReceived = (ulong) (managementObject.Properties["SMBBranchCacheBytesReceived"]?.Value ?? default(ulong)),
		 SmbBranchCacheBytesRequested = (ulong) (managementObject.Properties["SMBBranchCacheBytesRequested"]?.Value ?? default(ulong)),
		 SmbBranchCacheBytesRequestedFromServer = (ulong) (managementObject.Properties["SMBBranchCacheBytesRequestedFromServer"]?.Value ?? default(ulong)),
		 SmbBranchCacheHashBytesReceived = (ulong) (managementObject.Properties["SMBBranchCacheHashBytesReceived"]?.Value ?? default(ulong)),
		 SmbBranchCacheHashesReceived = (uint) (managementObject.Properties["SMBBranchCacheHashesReceived"]?.Value ?? default(uint)),
		 SmbBranchCacheHashesRequested = (uint) (managementObject.Properties["SMBBranchCacheHashesRequested"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}