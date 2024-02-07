using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted
{
    /// <summary>
    /// </summary>
    public sealed class W3SvcWebService
    {
		public uint AnonymousUsersPersec { get; private set; }
		public ulong BytesReceivedPersec { get; private set; }
		public ulong BytesSentPersec { get; private set; }
		public ulong BytesTotalPersec { get; private set; }
		public string Caption { get; private set; }
		public uint CgiRequestsPersec { get; private set; }
		public uint ConnectionAttemptsPersec { get; private set; }
		public uint CopyRequestsPersec { get; private set; }
		public uint CurrentAnonymousUsers { get; private set; }
		public uint CurrentBlockedAsyncIoRequests { get; private set; }
		public uint Currentblockedbandwidthbytes { get; private set; }
		public uint CurrentCaLcountforauthenticatedusers { get; private set; }
		public uint CurrentCaLcountforSsLconnections { get; private set; }
		public uint CurrentCgiRequests { get; private set; }
		public uint CurrentConnections { get; private set; }
		public uint CurrentIsapiExtensionRequests { get; private set; }
		public uint CurrentNonAnonymousUsers { get; private set; }
		public uint DeleteRequestsPersec { get; private set; }
		public string Description { get; private set; }
		public uint FilesPersec { get; private set; }
		public uint FilesReceivedPersec { get; private set; }
		public uint FilesSentPersec { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public uint GetRequestsPersec { get; private set; }
		public uint HeadRequestsPersec { get; private set; }
		public uint IsapiExtensionRequestsPersec { get; private set; }
		public uint LockedErrorsPersec { get; private set; }
		public uint LockRequestsPersec { get; private set; }
		public uint LogonAttemptsPersec { get; private set; }
		public uint MaximumAnonymousUsers { get; private set; }
		public uint MaximumCaLcountforauthenticatedusers { get; private set; }
		public uint MaximumCaLcountforSsLconnections { get; private set; }
		public uint MaximumCgiRequests { get; private set; }
		public uint MaximumConnections { get; private set; }
		public uint MaximumIsapiExtensionRequests { get; private set; }
		public uint MaximumNonAnonymousUsers { get; private set; }
		public uint MeasuredAsyncIoBandwidthUsage { get; private set; }
		public uint MkcolRequestsPersec { get; private set; }
		public uint MoveRequestsPersec { get; private set; }
		public string Name { get; private set; }
		public uint NonAnonymousUsersPersec { get; private set; }
		public uint NotFoundErrorsPersec { get; private set; }
		public uint OptionsRequestsPersec { get; private set; }
		public uint OtherRequestMethodsPersec { get; private set; }
		public uint PostRequestsPersec { get; private set; }
		public uint PropfindRequestsPersec { get; private set; }
		public uint ProppatchRequestsPersec { get; private set; }
		public uint PutRequestsPersec { get; private set; }
		public uint SearchRequestsPersec { get; private set; }
		public uint ServiceUptime { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public uint TotalAllowedAsyncIoRequests { get; private set; }
		public uint TotalAnonymousUsers { get; private set; }
		public uint TotalBlockedAsyncIoRequests { get; private set; }
		public uint Totalblockedbandwidthbytes { get; private set; }
		public ulong TotalBytesReceived { get; private set; }
		public ulong TotalBytesSent { get; private set; }
		public ulong TotalBytesTransferred { get; private set; }
		public uint TotalCgiRequests { get; private set; }
		public uint TotalConnectionAttemptsallinstances { get; private set; }
		public uint TotalCopyRequests { get; private set; }
		public uint TotalcountoffailedCaLrequestsforauthenticatedusers { get; private set; }
		public uint TotalcountoffailedCaLrequestsforSsLconnections { get; private set; }
		public uint TotalDeleteRequests { get; private set; }
		public uint TotalFilesReceived { get; private set; }
		public uint TotalFilesSent { get; private set; }
		public uint TotalFilesTransferred { get; private set; }
		public uint TotalGetRequests { get; private set; }
		public uint TotalHeadRequests { get; private set; }
		public uint TotalIsapiExtensionRequests { get; private set; }
		public uint TotalLockedErrors { get; private set; }
		public uint TotalLockRequests { get; private set; }
		public uint TotalLogonAttempts { get; private set; }
		public uint TotalMethodRequests { get; private set; }
		public uint TotalMethodRequestsPersec { get; private set; }
		public uint TotalMkcolRequests { get; private set; }
		public uint TotalMoveRequests { get; private set; }
		public uint TotalNonAnonymousUsers { get; private set; }
		public uint TotalNotFoundErrors { get; private set; }
		public uint TotalOptionsRequests { get; private set; }
		public uint TotalOtherRequestMethods { get; private set; }
		public uint TotalPostRequests { get; private set; }
		public uint TotalPropfindRequests { get; private set; }
		public uint TotalProppatchRequests { get; private set; }
		public uint TotalPutRequests { get; private set; }
		public uint TotalRejectedAsyncIoRequests { get; private set; }
		public uint TotalSearchRequests { get; private set; }
		public uint TotalTraceRequests { get; private set; }
		public uint TotalUnlockRequests { get; private set; }
		public uint TraceRequestsPersec { get; private set; }
		public uint UnlockRequestsPersec { get; private set; }

        public static IEnumerable<W3SvcWebService> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<W3SvcWebService> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<W3SvcWebService> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_W3SVC_WebService");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new W3SvcWebService
                {
                     AnonymousUsersPersec = (uint) (managementObject.Properties["AnonymousUsersPersec"]?.Value ?? default(uint)),
		 BytesReceivedPersec = (ulong) (managementObject.Properties["BytesReceivedPersec"]?.Value ?? default(ulong)),
		 BytesSentPersec = (ulong) (managementObject.Properties["BytesSentPersec"]?.Value ?? default(ulong)),
		 BytesTotalPersec = (ulong) (managementObject.Properties["BytesTotalPersec"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CgiRequestsPersec = (uint) (managementObject.Properties["CGIRequestsPersec"]?.Value ?? default(uint)),
		 ConnectionAttemptsPersec = (uint) (managementObject.Properties["ConnectionAttemptsPersec"]?.Value ?? default(uint)),
		 CopyRequestsPersec = (uint) (managementObject.Properties["CopyRequestsPersec"]?.Value ?? default(uint)),
		 CurrentAnonymousUsers = (uint) (managementObject.Properties["CurrentAnonymousUsers"]?.Value ?? default(uint)),
		 CurrentBlockedAsyncIoRequests = (uint) (managementObject.Properties["CurrentBlockedAsyncIORequests"]?.Value ?? default(uint)),
		 Currentblockedbandwidthbytes = (uint) (managementObject.Properties["Currentblockedbandwidthbytes"]?.Value ?? default(uint)),
		 CurrentCaLcountforauthenticatedusers = (uint) (managementObject.Properties["CurrentCALcountforauthenticatedusers"]?.Value ?? default(uint)),
		 CurrentCaLcountforSsLconnections = (uint) (managementObject.Properties["CurrentCALcountforSSLconnections"]?.Value ?? default(uint)),
		 CurrentCgiRequests = (uint) (managementObject.Properties["CurrentCGIRequests"]?.Value ?? default(uint)),
		 CurrentConnections = (uint) (managementObject.Properties["CurrentConnections"]?.Value ?? default(uint)),
		 CurrentIsapiExtensionRequests = (uint) (managementObject.Properties["CurrentISAPIExtensionRequests"]?.Value ?? default(uint)),
		 CurrentNonAnonymousUsers = (uint) (managementObject.Properties["CurrentNonAnonymousUsers"]?.Value ?? default(uint)),
		 DeleteRequestsPersec = (uint) (managementObject.Properties["DeleteRequestsPersec"]?.Value ?? default(uint)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FilesPersec = (uint) (managementObject.Properties["FilesPersec"]?.Value ?? default(uint)),
		 FilesReceivedPersec = (uint) (managementObject.Properties["FilesReceivedPersec"]?.Value ?? default(uint)),
		 FilesSentPersec = (uint) (managementObject.Properties["FilesSentPersec"]?.Value ?? default(uint)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 GetRequestsPersec = (uint) (managementObject.Properties["GetRequestsPersec"]?.Value ?? default(uint)),
		 HeadRequestsPersec = (uint) (managementObject.Properties["HeadRequestsPersec"]?.Value ?? default(uint)),
		 IsapiExtensionRequestsPersec = (uint) (managementObject.Properties["ISAPIExtensionRequestsPersec"]?.Value ?? default(uint)),
		 LockedErrorsPersec = (uint) (managementObject.Properties["LockedErrorsPersec"]?.Value ?? default(uint)),
		 LockRequestsPersec = (uint) (managementObject.Properties["LockRequestsPersec"]?.Value ?? default(uint)),
		 LogonAttemptsPersec = (uint) (managementObject.Properties["LogonAttemptsPersec"]?.Value ?? default(uint)),
		 MaximumAnonymousUsers = (uint) (managementObject.Properties["MaximumAnonymousUsers"]?.Value ?? default(uint)),
		 MaximumCaLcountforauthenticatedusers = (uint) (managementObject.Properties["MaximumCALcountforauthenticatedusers"]?.Value ?? default(uint)),
		 MaximumCaLcountforSsLconnections = (uint) (managementObject.Properties["MaximumCALcountforSSLconnections"]?.Value ?? default(uint)),
		 MaximumCgiRequests = (uint) (managementObject.Properties["MaximumCGIRequests"]?.Value ?? default(uint)),
		 MaximumConnections = (uint) (managementObject.Properties["MaximumConnections"]?.Value ?? default(uint)),
		 MaximumIsapiExtensionRequests = (uint) (managementObject.Properties["MaximumISAPIExtensionRequests"]?.Value ?? default(uint)),
		 MaximumNonAnonymousUsers = (uint) (managementObject.Properties["MaximumNonAnonymousUsers"]?.Value ?? default(uint)),
		 MeasuredAsyncIoBandwidthUsage = (uint) (managementObject.Properties["MeasuredAsyncIOBandwidthUsage"]?.Value ?? default(uint)),
		 MkcolRequestsPersec = (uint) (managementObject.Properties["MkcolRequestsPersec"]?.Value ?? default(uint)),
		 MoveRequestsPersec = (uint) (managementObject.Properties["MoveRequestsPersec"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 NonAnonymousUsersPersec = (uint) (managementObject.Properties["NonAnonymousUsersPersec"]?.Value ?? default(uint)),
		 NotFoundErrorsPersec = (uint) (managementObject.Properties["NotFoundErrorsPersec"]?.Value ?? default(uint)),
		 OptionsRequestsPersec = (uint) (managementObject.Properties["OptionsRequestsPersec"]?.Value ?? default(uint)),
		 OtherRequestMethodsPersec = (uint) (managementObject.Properties["OtherRequestMethodsPersec"]?.Value ?? default(uint)),
		 PostRequestsPersec = (uint) (managementObject.Properties["PostRequestsPersec"]?.Value ?? default(uint)),
		 PropfindRequestsPersec = (uint) (managementObject.Properties["PropfindRequestsPersec"]?.Value ?? default(uint)),
		 ProppatchRequestsPersec = (uint) (managementObject.Properties["ProppatchRequestsPersec"]?.Value ?? default(uint)),
		 PutRequestsPersec = (uint) (managementObject.Properties["PutRequestsPersec"]?.Value ?? default(uint)),
		 SearchRequestsPersec = (uint) (managementObject.Properties["SearchRequestsPersec"]?.Value ?? default(uint)),
		 ServiceUptime = (uint) (managementObject.Properties["ServiceUptime"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 TotalAllowedAsyncIoRequests = (uint) (managementObject.Properties["TotalAllowedAsyncIORequests"]?.Value ?? default(uint)),
		 TotalAnonymousUsers = (uint) (managementObject.Properties["TotalAnonymousUsers"]?.Value ?? default(uint)),
		 TotalBlockedAsyncIoRequests = (uint) (managementObject.Properties["TotalBlockedAsyncIORequests"]?.Value ?? default(uint)),
		 Totalblockedbandwidthbytes = (uint) (managementObject.Properties["Totalblockedbandwidthbytes"]?.Value ?? default(uint)),
		 TotalBytesReceived = (ulong) (managementObject.Properties["TotalBytesReceived"]?.Value ?? default(ulong)),
		 TotalBytesSent = (ulong) (managementObject.Properties["TotalBytesSent"]?.Value ?? default(ulong)),
		 TotalBytesTransferred = (ulong) (managementObject.Properties["TotalBytesTransferred"]?.Value ?? default(ulong)),
		 TotalCgiRequests = (uint) (managementObject.Properties["TotalCGIRequests"]?.Value ?? default(uint)),
		 TotalConnectionAttemptsallinstances = (uint) (managementObject.Properties["TotalConnectionAttemptsallinstances"]?.Value ?? default(uint)),
		 TotalCopyRequests = (uint) (managementObject.Properties["TotalCopyRequests"]?.Value ?? default(uint)),
		 TotalcountoffailedCaLrequestsforauthenticatedusers = (uint) (managementObject.Properties["TotalcountoffailedCALrequestsforauthenticatedusers"]?.Value ?? default(uint)),
		 TotalcountoffailedCaLrequestsforSsLconnections = (uint) (managementObject.Properties["TotalcountoffailedCALrequestsforSSLconnections"]?.Value ?? default(uint)),
		 TotalDeleteRequests = (uint) (managementObject.Properties["TotalDeleteRequests"]?.Value ?? default(uint)),
		 TotalFilesReceived = (uint) (managementObject.Properties["TotalFilesReceived"]?.Value ?? default(uint)),
		 TotalFilesSent = (uint) (managementObject.Properties["TotalFilesSent"]?.Value ?? default(uint)),
		 TotalFilesTransferred = (uint) (managementObject.Properties["TotalFilesTransferred"]?.Value ?? default(uint)),
		 TotalGetRequests = (uint) (managementObject.Properties["TotalGetRequests"]?.Value ?? default(uint)),
		 TotalHeadRequests = (uint) (managementObject.Properties["TotalHeadRequests"]?.Value ?? default(uint)),
		 TotalIsapiExtensionRequests = (uint) (managementObject.Properties["TotalISAPIExtensionRequests"]?.Value ?? default(uint)),
		 TotalLockedErrors = (uint) (managementObject.Properties["TotalLockedErrors"]?.Value ?? default(uint)),
		 TotalLockRequests = (uint) (managementObject.Properties["TotalLockRequests"]?.Value ?? default(uint)),
		 TotalLogonAttempts = (uint) (managementObject.Properties["TotalLogonAttempts"]?.Value ?? default(uint)),
		 TotalMethodRequests = (uint) (managementObject.Properties["TotalMethodRequests"]?.Value ?? default(uint)),
		 TotalMethodRequestsPersec = (uint) (managementObject.Properties["TotalMethodRequestsPersec"]?.Value ?? default(uint)),
		 TotalMkcolRequests = (uint) (managementObject.Properties["TotalMkcolRequests"]?.Value ?? default(uint)),
		 TotalMoveRequests = (uint) (managementObject.Properties["TotalMoveRequests"]?.Value ?? default(uint)),
		 TotalNonAnonymousUsers = (uint) (managementObject.Properties["TotalNonAnonymousUsers"]?.Value ?? default(uint)),
		 TotalNotFoundErrors = (uint) (managementObject.Properties["TotalNotFoundErrors"]?.Value ?? default(uint)),
		 TotalOptionsRequests = (uint) (managementObject.Properties["TotalOptionsRequests"]?.Value ?? default(uint)),
		 TotalOtherRequestMethods = (uint) (managementObject.Properties["TotalOtherRequestMethods"]?.Value ?? default(uint)),
		 TotalPostRequests = (uint) (managementObject.Properties["TotalPostRequests"]?.Value ?? default(uint)),
		 TotalPropfindRequests = (uint) (managementObject.Properties["TotalPropfindRequests"]?.Value ?? default(uint)),
		 TotalProppatchRequests = (uint) (managementObject.Properties["TotalProppatchRequests"]?.Value ?? default(uint)),
		 TotalPutRequests = (uint) (managementObject.Properties["TotalPutRequests"]?.Value ?? default(uint)),
		 TotalRejectedAsyncIoRequests = (uint) (managementObject.Properties["TotalRejectedAsyncIORequests"]?.Value ?? default(uint)),
		 TotalSearchRequests = (uint) (managementObject.Properties["TotalSearchRequests"]?.Value ?? default(uint)),
		 TotalTraceRequests = (uint) (managementObject.Properties["TotalTraceRequests"]?.Value ?? default(uint)),
		 TotalUnlockRequests = (uint) (managementObject.Properties["TotalUnlockRequests"]?.Value ?? default(uint)),
		 TraceRequestsPersec = (uint) (managementObject.Properties["TraceRequestsPersec"]?.Value ?? default(uint)),
		 UnlockRequestsPersec = (uint) (managementObject.Properties["UnlockRequestsPersec"]?.Value ?? default(uint))
                };
        }
    }
}