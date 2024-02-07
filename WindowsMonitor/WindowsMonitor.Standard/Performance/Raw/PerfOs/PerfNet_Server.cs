using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.PerfOs
{
    /// <summary>
    /// </summary>
    public sealed class PerfNetServer
    {
		public uint BlockingRequestsRejected { get; private set; }
		public ulong BytesReceivedPersec { get; private set; }
		public ulong BytesTotalPersec { get; private set; }
		public ulong BytesTransmittedPersec { get; private set; }
		public string Caption { get; private set; }
		public uint ContextBlocksQueuedPersec { get; private set; }
		public string Description { get; private set; }
		public uint ErrorsAccessPermissions { get; private set; }
		public uint ErrorsGrantedAccess { get; private set; }
		public uint ErrorsLogon { get; private set; }
		public uint ErrorsSystem { get; private set; }
		public uint FileDirectorySearches { get; private set; }
		public uint FilesOpen { get; private set; }
		public uint FilesOpenedTotal { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public uint LogonPersec { get; private set; }
		public uint LogonTotal { get; private set; }
		public string Name { get; private set; }
		public uint PoolNonpagedBytes { get; private set; }
		public uint PoolNonpagedFailures { get; private set; }
		public uint PoolNonpagedPeak { get; private set; }
		public uint PoolPagedBytes { get; private set; }
		public uint PoolPagedFailures { get; private set; }
		public uint PoolPagedPeak { get; private set; }
		public uint ReconnectedDurableHandles { get; private set; }
		public uint ReconnectedResilientHandles { get; private set; }
		public uint ServerSessions { get; private set; }
		public uint SessionsErroredOut { get; private set; }
		public uint SessionsForcedOff { get; private set; }
		public uint SessionsLoggedOff { get; private set; }
		public uint SessionsTimedOut { get; private set; }
		public ulong SmbBranchCacheHashBytesSent { get; private set; }
		public uint SmbBranchCacheHashGenerationRequests { get; private set; }
		public uint SmbBranchCacheHashHeaderRequests { get; private set; }
		public uint SmbBranchCacheHashRequestsReceived { get; private set; }
		public uint SmbBranchCacheHashResponsesSent { get; private set; }
		public ulong SmbBranchCacheHashV2BytesSent { get; private set; }
		public uint SmbBranchCacheHashV2GenerationRequests { get; private set; }
		public uint SmbBranchCacheHashV2HeaderRequests { get; private set; }
		public uint SmbBranchCacheHashV2RequestsReceived { get; private set; }
		public uint SmbBranchCacheHashV2RequestsServedFromDedup { get; private set; }
		public uint SmbBranchCacheHashV2ResponsesSent { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public uint TotalDurableHandles { get; private set; }
		public uint TotalResilientHandles { get; private set; }
		public uint WorkItemShortages { get; private set; }

        public static IEnumerable<PerfNetServer> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<PerfNetServer> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<PerfNetServer> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_PerfNet_Server");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new PerfNetServer
                {
                     BlockingRequestsRejected = (uint) (managementObject.Properties["BlockingRequestsRejected"]?.Value ?? default(uint)),
		 BytesReceivedPersec = (ulong) (managementObject.Properties["BytesReceivedPersec"]?.Value ?? default(ulong)),
		 BytesTotalPersec = (ulong) (managementObject.Properties["BytesTotalPersec"]?.Value ?? default(ulong)),
		 BytesTransmittedPersec = (ulong) (managementObject.Properties["BytesTransmittedPersec"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 ContextBlocksQueuedPersec = (uint) (managementObject.Properties["ContextBlocksQueuedPersec"]?.Value ?? default(uint)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 ErrorsAccessPermissions = (uint) (managementObject.Properties["ErrorsAccessPermissions"]?.Value ?? default(uint)),
		 ErrorsGrantedAccess = (uint) (managementObject.Properties["ErrorsGrantedAccess"]?.Value ?? default(uint)),
		 ErrorsLogon = (uint) (managementObject.Properties["ErrorsLogon"]?.Value ?? default(uint)),
		 ErrorsSystem = (uint) (managementObject.Properties["ErrorsSystem"]?.Value ?? default(uint)),
		 FileDirectorySearches = (uint) (managementObject.Properties["FileDirectorySearches"]?.Value ?? default(uint)),
		 FilesOpen = (uint) (managementObject.Properties["FilesOpen"]?.Value ?? default(uint)),
		 FilesOpenedTotal = (uint) (managementObject.Properties["FilesOpenedTotal"]?.Value ?? default(uint)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 LogonPersec = (uint) (managementObject.Properties["LogonPersec"]?.Value ?? default(uint)),
		 LogonTotal = (uint) (managementObject.Properties["LogonTotal"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 PoolNonpagedBytes = (uint) (managementObject.Properties["PoolNonpagedBytes"]?.Value ?? default(uint)),
		 PoolNonpagedFailures = (uint) (managementObject.Properties["PoolNonpagedFailures"]?.Value ?? default(uint)),
		 PoolNonpagedPeak = (uint) (managementObject.Properties["PoolNonpagedPeak"]?.Value ?? default(uint)),
		 PoolPagedBytes = (uint) (managementObject.Properties["PoolPagedBytes"]?.Value ?? default(uint)),
		 PoolPagedFailures = (uint) (managementObject.Properties["PoolPagedFailures"]?.Value ?? default(uint)),
		 PoolPagedPeak = (uint) (managementObject.Properties["PoolPagedPeak"]?.Value ?? default(uint)),
		 ReconnectedDurableHandles = (uint) (managementObject.Properties["ReconnectedDurableHandles"]?.Value ?? default(uint)),
		 ReconnectedResilientHandles = (uint) (managementObject.Properties["ReconnectedResilientHandles"]?.Value ?? default(uint)),
		 ServerSessions = (uint) (managementObject.Properties["ServerSessions"]?.Value ?? default(uint)),
		 SessionsErroredOut = (uint) (managementObject.Properties["SessionsErroredOut"]?.Value ?? default(uint)),
		 SessionsForcedOff = (uint) (managementObject.Properties["SessionsForcedOff"]?.Value ?? default(uint)),
		 SessionsLoggedOff = (uint) (managementObject.Properties["SessionsLoggedOff"]?.Value ?? default(uint)),
		 SessionsTimedOut = (uint) (managementObject.Properties["SessionsTimedOut"]?.Value ?? default(uint)),
		 SmbBranchCacheHashBytesSent = (ulong) (managementObject.Properties["SMBBranchCacheHashBytesSent"]?.Value ?? default(ulong)),
		 SmbBranchCacheHashGenerationRequests = (uint) (managementObject.Properties["SMBBranchCacheHashGenerationRequests"]?.Value ?? default(uint)),
		 SmbBranchCacheHashHeaderRequests = (uint) (managementObject.Properties["SMBBranchCacheHashHeaderRequests"]?.Value ?? default(uint)),
		 SmbBranchCacheHashRequestsReceived = (uint) (managementObject.Properties["SMBBranchCacheHashRequestsReceived"]?.Value ?? default(uint)),
		 SmbBranchCacheHashResponsesSent = (uint) (managementObject.Properties["SMBBranchCacheHashResponsesSent"]?.Value ?? default(uint)),
		 SmbBranchCacheHashV2BytesSent = (ulong) (managementObject.Properties["SMBBranchCacheHashV2BytesSent"]?.Value ?? default(ulong)),
		 SmbBranchCacheHashV2GenerationRequests = (uint) (managementObject.Properties["SMBBranchCacheHashV2GenerationRequests"]?.Value ?? default(uint)),
		 SmbBranchCacheHashV2HeaderRequests = (uint) (managementObject.Properties["SMBBranchCacheHashV2HeaderRequests"]?.Value ?? default(uint)),
		 SmbBranchCacheHashV2RequestsReceived = (uint) (managementObject.Properties["SMBBranchCacheHashV2RequestsReceived"]?.Value ?? default(uint)),
		 SmbBranchCacheHashV2RequestsServedFromDedup = (uint) (managementObject.Properties["SMBBranchCacheHashV2RequestsServedFromDedup"]?.Value ?? default(uint)),
		 SmbBranchCacheHashV2ResponsesSent = (uint) (managementObject.Properties["SMBBranchCacheHashV2ResponsesSent"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 TotalDurableHandles = (uint) (managementObject.Properties["TotalDurableHandles"]?.Value ?? default(uint)),
		 TotalResilientHandles = (uint) (managementObject.Properties["TotalResilientHandles"]?.Value ?? default(uint)),
		 WorkItemShortages = (uint) (managementObject.Properties["WorkItemShortages"]?.Value ?? default(uint))
                };
        }
    }
}