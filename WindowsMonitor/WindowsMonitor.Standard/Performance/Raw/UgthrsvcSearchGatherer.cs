using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw
{
    /// <summary>
    /// </summary>
    public sealed class UgthrsvcSearchGatherer
    {
		public uint ActiveQueueLength { get; private set; }
		public uint AdminClients { get; private set; }
		public uint AllNotificationsReceived { get; private set; }
		public string Caption { get; private set; }
		public uint DelayedDocuments { get; private set; }
		public string Description { get; private set; }
		public uint DocumentEntries { get; private set; }
		public uint DocumentsDelayedRetry { get; private set; }
		public uint DocumentsFiltered { get; private set; }
		public uint DocumentsFilteredRate { get; private set; }
		public uint DocumentsSuccessfullyFiltered { get; private set; }
		public uint DocumentsSuccessfullyFilteredRate { get; private set; }
		public uint ExtNotificationsRate { get; private set; }
		public uint ExtNotificationsReceived { get; private set; }
		public uint FilteringThreads { get; private set; }
		public uint FilterObjects { get; private set; }
		public uint FilterProcessCreated { get; private set; }
		public uint FilterProcesses { get; private set; }
		public uint FilterProcessesMax { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public uint Heartbeats { get; private set; }
		public uint HeartbeatsRate { get; private set; }
		public uint IdleThreads { get; private set; }
		public string Name { get; private set; }
		public uint NotificationSources { get; private set; }
		public uint NotificationsRate { get; private set; }
		public uint PerformanceLevel { get; private set; }
		public uint Reasontobackoff { get; private set; }
		public uint ServerObjects { get; private set; }
		public uint ServerObjectsCreated { get; private set; }
		public uint ServersCurrentlyUnavailable { get; private set; }
		public uint ServersUnavailable { get; private set; }
		public uint StemmersCached { get; private set; }
		public uint SystemIOtrafficrate { get; private set; }
		public uint ThreadsAccessingNetwork { get; private set; }
		public uint Threadsblockedduetobackoff { get; private set; }
		public uint ThreadsInPlugins { get; private set; }
		public uint TimeOuts { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public uint WordBreakersCached { get; private set; }

        public static IEnumerable<UgthrsvcSearchGatherer> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<UgthrsvcSearchGatherer> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<UgthrsvcSearchGatherer> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_UGTHRSVC_SearchGatherer");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new UgthrsvcSearchGatherer
                {
                     ActiveQueueLength = (uint) (managementObject.Properties["ActiveQueueLength"]?.Value ?? default(uint)),
		 AdminClients = (uint) (managementObject.Properties["AdminClients"]?.Value ?? default(uint)),
		 AllNotificationsReceived = (uint) (managementObject.Properties["AllNotificationsReceived"]?.Value ?? default(uint)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 DelayedDocuments = (uint) (managementObject.Properties["DelayedDocuments"]?.Value ?? default(uint)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DocumentEntries = (uint) (managementObject.Properties["DocumentEntries"]?.Value ?? default(uint)),
		 DocumentsDelayedRetry = (uint) (managementObject.Properties["DocumentsDelayedRetry"]?.Value ?? default(uint)),
		 DocumentsFiltered = (uint) (managementObject.Properties["DocumentsFiltered"]?.Value ?? default(uint)),
		 DocumentsFilteredRate = (uint) (managementObject.Properties["DocumentsFilteredRate"]?.Value ?? default(uint)),
		 DocumentsSuccessfullyFiltered = (uint) (managementObject.Properties["DocumentsSuccessfullyFiltered"]?.Value ?? default(uint)),
		 DocumentsSuccessfullyFilteredRate = (uint) (managementObject.Properties["DocumentsSuccessfullyFilteredRate"]?.Value ?? default(uint)),
		 ExtNotificationsRate = (uint) (managementObject.Properties["ExtNotificationsRate"]?.Value ?? default(uint)),
		 ExtNotificationsReceived = (uint) (managementObject.Properties["ExtNotificationsReceived"]?.Value ?? default(uint)),
		 FilteringThreads = (uint) (managementObject.Properties["FilteringThreads"]?.Value ?? default(uint)),
		 FilterObjects = (uint) (managementObject.Properties["FilterObjects"]?.Value ?? default(uint)),
		 FilterProcessCreated = (uint) (managementObject.Properties["FilterProcessCreated"]?.Value ?? default(uint)),
		 FilterProcesses = (uint) (managementObject.Properties["FilterProcesses"]?.Value ?? default(uint)),
		 FilterProcessesMax = (uint) (managementObject.Properties["FilterProcessesMax"]?.Value ?? default(uint)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Heartbeats = (uint) (managementObject.Properties["Heartbeats"]?.Value ?? default(uint)),
		 HeartbeatsRate = (uint) (managementObject.Properties["HeartbeatsRate"]?.Value ?? default(uint)),
		 IdleThreads = (uint) (managementObject.Properties["IdleThreads"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 NotificationSources = (uint) (managementObject.Properties["NotificationSources"]?.Value ?? default(uint)),
		 NotificationsRate = (uint) (managementObject.Properties["NotificationsRate"]?.Value ?? default(uint)),
		 PerformanceLevel = (uint) (managementObject.Properties["PerformanceLevel"]?.Value ?? default(uint)),
		 Reasontobackoff = (uint) (managementObject.Properties["Reasontobackoff"]?.Value ?? default(uint)),
		 ServerObjects = (uint) (managementObject.Properties["ServerObjects"]?.Value ?? default(uint)),
		 ServerObjectsCreated = (uint) (managementObject.Properties["ServerObjectsCreated"]?.Value ?? default(uint)),
		 ServersCurrentlyUnavailable = (uint) (managementObject.Properties["ServersCurrentlyUnavailable"]?.Value ?? default(uint)),
		 ServersUnavailable = (uint) (managementObject.Properties["ServersUnavailable"]?.Value ?? default(uint)),
		 StemmersCached = (uint) (managementObject.Properties["StemmersCached"]?.Value ?? default(uint)),
		 SystemIOtrafficrate = (uint) (managementObject.Properties["SystemIOtrafficrate"]?.Value ?? default(uint)),
		 ThreadsAccessingNetwork = (uint) (managementObject.Properties["ThreadsAccessingNetwork"]?.Value ?? default(uint)),
		 Threadsblockedduetobackoff = (uint) (managementObject.Properties["Threadsblockedduetobackoff"]?.Value ?? default(uint)),
		 ThreadsInPlugins = (uint) (managementObject.Properties["ThreadsInPlugins"]?.Value ?? default(uint)),
		 TimeOuts = (uint) (managementObject.Properties["TimeOuts"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 WordBreakersCached = (uint) (managementObject.Properties["WordBreakersCached"]?.Value ?? default(uint))
                };
        }
    }
}