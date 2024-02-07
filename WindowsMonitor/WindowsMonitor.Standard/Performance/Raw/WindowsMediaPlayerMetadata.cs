using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw
{
    /// <summary>
    /// </summary>
    public sealed class WindowsMediaPlayerMetadata
    {
		public uint AftsExecutionTimems { get; private set; }
		public uint ArtExtractionTimems { get; private set; }
		public string Caption { get; private set; }
		public uint CommitTimems { get; private set; }
		public string Description { get; private set; }
		public uint DirectoryChangeQueueLength { get; private set; }
		public uint DirtyDirectoryHitCount { get; private set; }
		public uint FileScanningThreadPrioirty { get; private set; }
		public ulong FilesScannedPerMinute { get; private set; }
		public uint FilesScannedPerMinuteBase { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public ulong GrovelerServiceRoutineExecutionsPerSecond { get; private set; }
		public uint GrovelerServiceRoutineExecutionsPerSecondBase { get; private set; }
		public ulong LibraryDescriptionChangeNotificationsPerSecond { get; private set; }
		public uint LibraryDescriptionChangeNotificationsPerSecondBase { get; private set; }
		public ulong LibraryDescriptionUpdatesPerSecond { get; private set; }
		public uint LibraryDescriptionUpdatesPerSecondBase { get; private set; }
		public ulong MonitoredFolderUpdatesPerSecond { get; private set; }
		public uint MonitoredFolderUpdatesPerSecondBase { get; private set; }
		public string Name { get; private set; }
		public uint NormalizationTimems { get; private set; }
		public uint PropertyExtractionTimems { get; private set; }
		public uint ReorganizeTimems { get; private set; }
		public uint ScanningState { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public uint TimestampDirectoryHitCount { get; private set; }
		public uint UrlClassificationTimems { get; private set; }

        public static IEnumerable<WindowsMediaPlayerMetadata> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<WindowsMediaPlayerMetadata> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<WindowsMediaPlayerMetadata> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_WindowsMediaPlayer_WindowsMediaPlayerMetadata");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new WindowsMediaPlayerMetadata
                {
                     AftsExecutionTimems = (uint) (managementObject.Properties["AFTSExecutionTimems"]?.Value ?? default(uint)),
		 ArtExtractionTimems = (uint) (managementObject.Properties["ArtExtractionTimems"]?.Value ?? default(uint)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CommitTimems = (uint) (managementObject.Properties["CommitTimems"]?.Value ?? default(uint)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DirectoryChangeQueueLength = (uint) (managementObject.Properties["DirectoryChangeQueueLength"]?.Value ?? default(uint)),
		 DirtyDirectoryHitCount = (uint) (managementObject.Properties["DirtyDirectoryHitCount"]?.Value ?? default(uint)),
		 FileScanningThreadPrioirty = (uint) (managementObject.Properties["FileScanningThreadPrioirty"]?.Value ?? default(uint)),
		 FilesScannedPerMinute = (ulong) (managementObject.Properties["FilesScannedPerMinute"]?.Value ?? default(ulong)),
		 FilesScannedPerMinuteBase = (uint) (managementObject.Properties["FilesScannedPerMinute_Base"]?.Value ?? default(uint)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 GrovelerServiceRoutineExecutionsPerSecond = (ulong) (managementObject.Properties["GrovelerServiceRoutineExecutionsPerSecond"]?.Value ?? default(ulong)),
		 GrovelerServiceRoutineExecutionsPerSecondBase = (uint) (managementObject.Properties["GrovelerServiceRoutineExecutionsPerSecond_Base"]?.Value ?? default(uint)),
		 LibraryDescriptionChangeNotificationsPerSecond = (ulong) (managementObject.Properties["LibraryDescriptionChangeNotificationsPerSecond"]?.Value ?? default(ulong)),
		 LibraryDescriptionChangeNotificationsPerSecondBase = (uint) (managementObject.Properties["LibraryDescriptionChangeNotificationsPerSecond_Base"]?.Value ?? default(uint)),
		 LibraryDescriptionUpdatesPerSecond = (ulong) (managementObject.Properties["LibraryDescriptionUpdatesPerSecond"]?.Value ?? default(ulong)),
		 LibraryDescriptionUpdatesPerSecondBase = (uint) (managementObject.Properties["LibraryDescriptionUpdatesPerSecond_Base"]?.Value ?? default(uint)),
		 MonitoredFolderUpdatesPerSecond = (ulong) (managementObject.Properties["MonitoredFolderUpdatesPerSecond"]?.Value ?? default(ulong)),
		 MonitoredFolderUpdatesPerSecondBase = (uint) (managementObject.Properties["MonitoredFolderUpdatesPerSecond_Base"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 NormalizationTimems = (uint) (managementObject.Properties["NormalizationTimems"]?.Value ?? default(uint)),
		 PropertyExtractionTimems = (uint) (managementObject.Properties["PropertyExtractionTimems"]?.Value ?? default(uint)),
		 ReorganizeTimems = (uint) (managementObject.Properties["ReorganizeTimems"]?.Value ?? default(uint)),
		 ScanningState = (uint) (managementObject.Properties["ScanningState"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 TimestampDirectoryHitCount = (uint) (managementObject.Properties["TimestampDirectoryHitCount"]?.Value ?? default(uint)),
		 UrlClassificationTimems = (uint) (managementObject.Properties["URLClassificationTimems"]?.Value ?? default(uint))
                };
        }
    }
}