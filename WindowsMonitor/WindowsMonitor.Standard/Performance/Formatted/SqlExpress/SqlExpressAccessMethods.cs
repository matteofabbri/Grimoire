using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted.SqlExpress
{
    /// <summary>
    /// </summary>
    public sealed class SqlExpressAccessMethods
    {
		public ulong AUcleanupbatchesPersec { get; private set; }
		public ulong AUcleanupsPersec { get; private set; }
		public ulong ByreferenceLobCreateCount { get; private set; }
		public ulong ByreferenceLobUseCount { get; private set; }
		public string Caption { get; private set; }
		public ulong CountLobReadahead { get; private set; }
		public ulong CountPullInRow { get; private set; }
		public ulong CountPushOffRow { get; private set; }
		public ulong DeferreddroppedAUs { get; private set; }
		public ulong DeferredDroppedrowsets { get; private set; }
		public string Description { get; private set; }
		public ulong DroppedrowsetcleanupsPersec { get; private set; }
		public ulong DroppedrowsetsskippedPersec { get; private set; }
		public ulong ExtentDeallocationsPersec { get; private set; }
		public ulong ExtentsAllocatedPersec { get; private set; }
		public ulong FailedAUcleanupbatchesPersec { get; private set; }
		public ulong Failedleafpagecookie { get; private set; }
		public ulong Failedtreepagecookie { get; private set; }
		public ulong ForwardedRecordsPersec { get; private set; }
		public ulong FreeSpacePageFetchesPersec { get; private set; }
		public ulong FreeSpaceScansPersec { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public ulong FullScansPersec { get; private set; }
		public ulong IndexSearchesPersec { get; private set; }
		public ulong InSysXactwaitsPersec { get; private set; }
		public ulong LobHandleCreateCount { get; private set; }
		public ulong LobHandleDestroyCount { get; private set; }
		public ulong LobSsProviderCreateCount { get; private set; }
		public ulong LobSsProviderDestroyCount { get; private set; }
		public ulong LobSsProviderTruncationCount { get; private set; }
		public ulong MixedpageallocationsPersec { get; private set; }
		public string Name { get; private set; }
		public ulong PagecompressionattemptsPersec { get; private set; }
		public ulong PageDeallocationsPersec { get; private set; }
		public ulong PagesAllocatedPersec { get; private set; }
		public ulong PagescompressedPersec { get; private set; }
		public ulong PageSplitsPersec { get; private set; }
		public ulong ProbeScansPersec { get; private set; }
		public ulong RangeScansPersec { get; private set; }
		public ulong ScanPointRevalidationsPersec { get; private set; }
		public ulong SkippedGhostedRecordsPersec { get; private set; }
		public ulong TableLockEscalationsPersec { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public ulong Usedleafpagecookie { get; private set; }
		public ulong Usedtreepagecookie { get; private set; }
		public ulong WorkfilesCreatedPersec { get; private set; }
		public ulong WorktablesCreatedPersec { get; private set; }
		public ulong WorktablesFromCacheRatio { get; private set; }

        public static IEnumerable<SqlExpressAccessMethods> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SqlExpressAccessMethods> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SqlExpressAccessMethods> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_MSSQLSQLEXPRESS_MSSQLSQLEXPRESSAccessMethods");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SqlExpressAccessMethods
                {
                     AUcleanupbatchesPersec = (ulong) (managementObject.Properties["AUcleanupbatchesPersec"]?.Value ?? default(ulong)),
		 AUcleanupsPersec = (ulong) (managementObject.Properties["AUcleanupsPersec"]?.Value ?? default(ulong)),
		 ByreferenceLobCreateCount = (ulong) (managementObject.Properties["ByreferenceLobCreateCount"]?.Value ?? default(ulong)),
		 ByreferenceLobUseCount = (ulong) (managementObject.Properties["ByreferenceLobUseCount"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CountLobReadahead = (ulong) (managementObject.Properties["CountLobReadahead"]?.Value ?? default(ulong)),
		 CountPullInRow = (ulong) (managementObject.Properties["CountPullInRow"]?.Value ?? default(ulong)),
		 CountPushOffRow = (ulong) (managementObject.Properties["CountPushOffRow"]?.Value ?? default(ulong)),
		 DeferreddroppedAUs = (ulong) (managementObject.Properties["DeferreddroppedAUs"]?.Value ?? default(ulong)),
		 DeferredDroppedrowsets = (ulong) (managementObject.Properties["DeferredDroppedrowsets"]?.Value ?? default(ulong)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DroppedrowsetcleanupsPersec = (ulong) (managementObject.Properties["DroppedrowsetcleanupsPersec"]?.Value ?? default(ulong)),
		 DroppedrowsetsskippedPersec = (ulong) (managementObject.Properties["DroppedrowsetsskippedPersec"]?.Value ?? default(ulong)),
		 ExtentDeallocationsPersec = (ulong) (managementObject.Properties["ExtentDeallocationsPersec"]?.Value ?? default(ulong)),
		 ExtentsAllocatedPersec = (ulong) (managementObject.Properties["ExtentsAllocatedPersec"]?.Value ?? default(ulong)),
		 FailedAUcleanupbatchesPersec = (ulong) (managementObject.Properties["FailedAUcleanupbatchesPersec"]?.Value ?? default(ulong)),
		 Failedleafpagecookie = (ulong) (managementObject.Properties["Failedleafpagecookie"]?.Value ?? default(ulong)),
		 Failedtreepagecookie = (ulong) (managementObject.Properties["Failedtreepagecookie"]?.Value ?? default(ulong)),
		 ForwardedRecordsPersec = (ulong) (managementObject.Properties["ForwardedRecordsPersec"]?.Value ?? default(ulong)),
		 FreeSpacePageFetchesPersec = (ulong) (managementObject.Properties["FreeSpacePageFetchesPersec"]?.Value ?? default(ulong)),
		 FreeSpaceScansPersec = (ulong) (managementObject.Properties["FreeSpaceScansPersec"]?.Value ?? default(ulong)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 FullScansPersec = (ulong) (managementObject.Properties["FullScansPersec"]?.Value ?? default(ulong)),
		 IndexSearchesPersec = (ulong) (managementObject.Properties["IndexSearchesPersec"]?.Value ?? default(ulong)),
		 InSysXactwaitsPersec = (ulong) (managementObject.Properties["InSysXactwaitsPersec"]?.Value ?? default(ulong)),
		 LobHandleCreateCount = (ulong) (managementObject.Properties["LobHandleCreateCount"]?.Value ?? default(ulong)),
		 LobHandleDestroyCount = (ulong) (managementObject.Properties["LobHandleDestroyCount"]?.Value ?? default(ulong)),
		 LobSsProviderCreateCount = (ulong) (managementObject.Properties["LobSSProviderCreateCount"]?.Value ?? default(ulong)),
		 LobSsProviderDestroyCount = (ulong) (managementObject.Properties["LobSSProviderDestroyCount"]?.Value ?? default(ulong)),
		 LobSsProviderTruncationCount = (ulong) (managementObject.Properties["LobSSProviderTruncationCount"]?.Value ?? default(ulong)),
		 MixedpageallocationsPersec = (ulong) (managementObject.Properties["MixedpageallocationsPersec"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 PagecompressionattemptsPersec = (ulong) (managementObject.Properties["PagecompressionattemptsPersec"]?.Value ?? default(ulong)),
		 PageDeallocationsPersec = (ulong) (managementObject.Properties["PageDeallocationsPersec"]?.Value ?? default(ulong)),
		 PagesAllocatedPersec = (ulong) (managementObject.Properties["PagesAllocatedPersec"]?.Value ?? default(ulong)),
		 PagescompressedPersec = (ulong) (managementObject.Properties["PagescompressedPersec"]?.Value ?? default(ulong)),
		 PageSplitsPersec = (ulong) (managementObject.Properties["PageSplitsPersec"]?.Value ?? default(ulong)),
		 ProbeScansPersec = (ulong) (managementObject.Properties["ProbeScansPersec"]?.Value ?? default(ulong)),
		 RangeScansPersec = (ulong) (managementObject.Properties["RangeScansPersec"]?.Value ?? default(ulong)),
		 ScanPointRevalidationsPersec = (ulong) (managementObject.Properties["ScanPointRevalidationsPersec"]?.Value ?? default(ulong)),
		 SkippedGhostedRecordsPersec = (ulong) (managementObject.Properties["SkippedGhostedRecordsPersec"]?.Value ?? default(ulong)),
		 TableLockEscalationsPersec = (ulong) (managementObject.Properties["TableLockEscalationsPersec"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 Usedleafpagecookie = (ulong) (managementObject.Properties["Usedleafpagecookie"]?.Value ?? default(ulong)),
		 Usedtreepagecookie = (ulong) (managementObject.Properties["Usedtreepagecookie"]?.Value ?? default(ulong)),
		 WorkfilesCreatedPersec = (ulong) (managementObject.Properties["WorkfilesCreatedPersec"]?.Value ?? default(ulong)),
		 WorktablesCreatedPersec = (ulong) (managementObject.Properties["WorktablesCreatedPersec"]?.Value ?? default(ulong)),
		 WorktablesFromCacheRatio = (ulong) (managementObject.Properties["WorktablesFromCacheRatio"]?.Value ?? default(ulong))
                };
        }
    }
}