using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw
{
    /// <summary>
    /// </summary>
    public sealed class WSearchIdxPiSearchIndexer
    {
		public uint ActiveConnections { get; private set; }
		public string Caption { get; private set; }
		public uint CleanWidSets { get; private set; }
		public string Description { get; private set; }
		public uint DirtyWidSets { get; private set; }
		public uint DocumentsFiltered { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public uint IndexSize { get; private set; }
		public uint L0IndexesWordlists { get; private set; }
		public uint L0MergeFlushCount { get; private set; }
		public uint L0MergeFlushSpeedAverage { get; private set; }
		public uint L0MergeFlushSpeedLast { get; private set; }
		public uint L0MergesflushesNow { get; private set; }
		public uint L1MergeCount { get; private set; }
		public uint L1MergesNow { get; private set; }
		public uint L1MergeSpeedaverage { get; private set; }
		public uint L1MergeSpeedlast { get; private set; }
		public uint L2MergeCount { get; private set; }
		public uint L2MergesNow { get; private set; }
		public uint L2MergeSpeedaverage { get; private set; }
		public uint L2MergeSpeedlast { get; private set; }
		public uint L3MergeCount { get; private set; }
		public uint L3MergesNow { get; private set; }
		public uint L3MergeSpeedaverage { get; private set; }
		public uint L3MergeSpeedlast { get; private set; }
		public uint L4MergeCount { get; private set; }
		public uint L4MergesNow { get; private set; }
		public uint L4MergeSpeedaverage { get; private set; }
		public uint L4MergeSpeedlast { get; private set; }
		public uint L5MergeCount { get; private set; }
		public uint L5MergesNow { get; private set; }
		public uint L5MergeSpeedaverage { get; private set; }
		public uint L5MergeSpeedlast { get; private set; }
		public uint L6MergeCount { get; private set; }
		public uint L6MergesNow { get; private set; }
		public uint L6MergeSpeedaverage { get; private set; }
		public uint L6MergeSpeedlast { get; private set; }
		public uint L7MergeCount { get; private set; }
		public uint L7MergesNow { get; private set; }
		public uint L7MergeSpeedaverage { get; private set; }
		public uint L7MergeSpeedlast { get; private set; }
		public uint L8MergeCount { get; private set; }
		public uint L8MergesNow { get; private set; }
		public uint L8MergeSpeedaverage { get; private set; }
		public uint L8MergeSpeedlast { get; private set; }
		public uint MasterIndexLevel { get; private set; }
		public uint MasterMergeProgress { get; private set; }
		public uint MasterMergesNow { get; private set; }
		public uint MasterMergestoDate { get; private set; }
		public string Name { get; private set; }
		public uint PersistentIndexes { get; private set; }
		public uint PersistentIndexesL1 { get; private set; }
		public uint PersistentIndexesL2 { get; private set; }
		public uint PersistentIndexesL3 { get; private set; }
		public uint PersistentIndexesL4 { get; private set; }
		public uint PersistentIndexesL5 { get; private set; }
		public uint PersistentIndexesL6 { get; private set; }
		public uint PersistentIndexesL7 { get; private set; }
		public uint PersistentIndexesL8 { get; private set; }
		public uint Queries { get; private set; }
		public uint QueriesFailed { get; private set; }
		public uint QueriesSucceeded { get; private set; }
		public uint ShadowMergeLevels { get; private set; }
		public uint ShadowMergeLevelsThreshold { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public uint UniqueKeys { get; private set; }
		public uint WorkItemsCreated { get; private set; }
		public uint WorkItemsDeleted { get; private set; }

        public static IEnumerable<WSearchIdxPiSearchIndexer> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<WSearchIdxPiSearchIndexer> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<WSearchIdxPiSearchIndexer> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_WSearchIdxPi_SearchIndexer");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new WSearchIdxPiSearchIndexer
                {
                     ActiveConnections = (uint) (managementObject.Properties["ActiveConnections"]?.Value ?? default(uint)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CleanWidSets = (uint) (managementObject.Properties["CleanWidSets"]?.Value ?? default(uint)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DirtyWidSets = (uint) (managementObject.Properties["DirtyWidSets"]?.Value ?? default(uint)),
		 DocumentsFiltered = (uint) (managementObject.Properties["DocumentsFiltered"]?.Value ?? default(uint)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 IndexSize = (uint) (managementObject.Properties["IndexSize"]?.Value ?? default(uint)),
		 L0IndexesWordlists = (uint) (managementObject.Properties["L0IndexesWordlists"]?.Value ?? default(uint)),
		 L0MergeFlushCount = (uint) (managementObject.Properties["L0MergeFlushCount"]?.Value ?? default(uint)),
		 L0MergeFlushSpeedAverage = (uint) (managementObject.Properties["L0MergeFlushSpeedAverage"]?.Value ?? default(uint)),
		 L0MergeFlushSpeedLast = (uint) (managementObject.Properties["L0MergeFlushSpeedLast"]?.Value ?? default(uint)),
		 L0MergesflushesNow = (uint) (managementObject.Properties["L0MergesflushesNow"]?.Value ?? default(uint)),
		 L1MergeCount = (uint) (managementObject.Properties["L1MergeCount"]?.Value ?? default(uint)),
		 L1MergesNow = (uint) (managementObject.Properties["L1MergesNow"]?.Value ?? default(uint)),
		 L1MergeSpeedaverage = (uint) (managementObject.Properties["L1MergeSpeedaverage"]?.Value ?? default(uint)),
		 L1MergeSpeedlast = (uint) (managementObject.Properties["L1MergeSpeedlast"]?.Value ?? default(uint)),
		 L2MergeCount = (uint) (managementObject.Properties["L2MergeCount"]?.Value ?? default(uint)),
		 L2MergesNow = (uint) (managementObject.Properties["L2MergesNow"]?.Value ?? default(uint)),
		 L2MergeSpeedaverage = (uint) (managementObject.Properties["L2MergeSpeedaverage"]?.Value ?? default(uint)),
		 L2MergeSpeedlast = (uint) (managementObject.Properties["L2MergeSpeedlast"]?.Value ?? default(uint)),
		 L3MergeCount = (uint) (managementObject.Properties["L3MergeCount"]?.Value ?? default(uint)),
		 L3MergesNow = (uint) (managementObject.Properties["L3MergesNow"]?.Value ?? default(uint)),
		 L3MergeSpeedaverage = (uint) (managementObject.Properties["L3MergeSpeedaverage"]?.Value ?? default(uint)),
		 L3MergeSpeedlast = (uint) (managementObject.Properties["L3MergeSpeedlast"]?.Value ?? default(uint)),
		 L4MergeCount = (uint) (managementObject.Properties["L4MergeCount"]?.Value ?? default(uint)),
		 L4MergesNow = (uint) (managementObject.Properties["L4MergesNow"]?.Value ?? default(uint)),
		 L4MergeSpeedaverage = (uint) (managementObject.Properties["L4MergeSpeedaverage"]?.Value ?? default(uint)),
		 L4MergeSpeedlast = (uint) (managementObject.Properties["L4MergeSpeedlast"]?.Value ?? default(uint)),
		 L5MergeCount = (uint) (managementObject.Properties["L5MergeCount"]?.Value ?? default(uint)),
		 L5MergesNow = (uint) (managementObject.Properties["L5MergesNow"]?.Value ?? default(uint)),
		 L5MergeSpeedaverage = (uint) (managementObject.Properties["L5MergeSpeedaverage"]?.Value ?? default(uint)),
		 L5MergeSpeedlast = (uint) (managementObject.Properties["L5MergeSpeedlast"]?.Value ?? default(uint)),
		 L6MergeCount = (uint) (managementObject.Properties["L6MergeCount"]?.Value ?? default(uint)),
		 L6MergesNow = (uint) (managementObject.Properties["L6MergesNow"]?.Value ?? default(uint)),
		 L6MergeSpeedaverage = (uint) (managementObject.Properties["L6MergeSpeedaverage"]?.Value ?? default(uint)),
		 L6MergeSpeedlast = (uint) (managementObject.Properties["L6MergeSpeedlast"]?.Value ?? default(uint)),
		 L7MergeCount = (uint) (managementObject.Properties["L7MergeCount"]?.Value ?? default(uint)),
		 L7MergesNow = (uint) (managementObject.Properties["L7MergesNow"]?.Value ?? default(uint)),
		 L7MergeSpeedaverage = (uint) (managementObject.Properties["L7MergeSpeedaverage"]?.Value ?? default(uint)),
		 L7MergeSpeedlast = (uint) (managementObject.Properties["L7MergeSpeedlast"]?.Value ?? default(uint)),
		 L8MergeCount = (uint) (managementObject.Properties["L8MergeCount"]?.Value ?? default(uint)),
		 L8MergesNow = (uint) (managementObject.Properties["L8MergesNow"]?.Value ?? default(uint)),
		 L8MergeSpeedaverage = (uint) (managementObject.Properties["L8MergeSpeedaverage"]?.Value ?? default(uint)),
		 L8MergeSpeedlast = (uint) (managementObject.Properties["L8MergeSpeedlast"]?.Value ?? default(uint)),
		 MasterIndexLevel = (uint) (managementObject.Properties["MasterIndexLevel"]?.Value ?? default(uint)),
		 MasterMergeProgress = (uint) (managementObject.Properties["MasterMergeProgress"]?.Value ?? default(uint)),
		 MasterMergesNow = (uint) (managementObject.Properties["MasterMergesNow"]?.Value ?? default(uint)),
		 MasterMergestoDate = (uint) (managementObject.Properties["MasterMergestoDate"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 PersistentIndexes = (uint) (managementObject.Properties["PersistentIndexes"]?.Value ?? default(uint)),
		 PersistentIndexesL1 = (uint) (managementObject.Properties["PersistentIndexesL1"]?.Value ?? default(uint)),
		 PersistentIndexesL2 = (uint) (managementObject.Properties["PersistentIndexesL2"]?.Value ?? default(uint)),
		 PersistentIndexesL3 = (uint) (managementObject.Properties["PersistentIndexesL3"]?.Value ?? default(uint)),
		 PersistentIndexesL4 = (uint) (managementObject.Properties["PersistentIndexesL4"]?.Value ?? default(uint)),
		 PersistentIndexesL5 = (uint) (managementObject.Properties["PersistentIndexesL5"]?.Value ?? default(uint)),
		 PersistentIndexesL6 = (uint) (managementObject.Properties["PersistentIndexesL6"]?.Value ?? default(uint)),
		 PersistentIndexesL7 = (uint) (managementObject.Properties["PersistentIndexesL7"]?.Value ?? default(uint)),
		 PersistentIndexesL8 = (uint) (managementObject.Properties["PersistentIndexesL8"]?.Value ?? default(uint)),
		 Queries = (uint) (managementObject.Properties["Queries"]?.Value ?? default(uint)),
		 QueriesFailed = (uint) (managementObject.Properties["QueriesFailed"]?.Value ?? default(uint)),
		 QueriesSucceeded = (uint) (managementObject.Properties["QueriesSucceeded"]?.Value ?? default(uint)),
		 ShadowMergeLevels = (uint) (managementObject.Properties["ShadowMergeLevels"]?.Value ?? default(uint)),
		 ShadowMergeLevelsThreshold = (uint) (managementObject.Properties["ShadowMergeLevelsThreshold"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 UniqueKeys = (uint) (managementObject.Properties["UniqueKeys"]?.Value ?? default(uint)),
		 WorkItemsCreated = (uint) (managementObject.Properties["WorkItemsCreated"]?.Value ?? default(uint)),
		 WorkItemsDeleted = (uint) (managementObject.Properties["WorkItemsDeleted"]?.Value ?? default(uint))
                };
        }
    }
}