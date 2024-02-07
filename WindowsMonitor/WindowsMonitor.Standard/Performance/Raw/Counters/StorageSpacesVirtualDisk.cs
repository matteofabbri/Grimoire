
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.Counters
{
    /// <summary>
    /// </summary>
    public sealed class StorageSpacesVirtualDisk
    {
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public ulong VirtualDiskActive { get; private set; }
		public ulong VirtualDiskActiveBytes { get; private set; }
		public ulong VirtualDiskMissing { get; private set; }
		public ulong VirtualDiskMissingBytes { get; private set; }
		public ulong VirtualDiskNeedReallocation { get; private set; }
		public ulong VirtualDiskNeedReallocationBytes { get; private set; }
		public ulong VirtualDiskNeedRegeneration { get; private set; }
		public ulong VirtualDiskNeedRegenerationBytes { get; private set; }
		public ulong VirtualDiskPendingDeletion { get; private set; }
		public ulong VirtualDiskPendingDeletionBytes { get; private set; }
		public ulong VirtualDiskRegenerating { get; private set; }
		public ulong VirtualDiskRegeneratingBytes { get; private set; }
		public ulong VirtualDiskStale { get; private set; }
		public ulong VirtualDiskStaleBytes { get; private set; }
		public ulong VirtualDiskTotal { get; private set; }
		public ulong VirtualDiskTotalBytes { get; private set; }

        public static IEnumerable<StorageSpacesVirtualDisk> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<StorageSpacesVirtualDisk> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<StorageSpacesVirtualDisk> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_Counters_StorageSpacesVirtualDisk");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new StorageSpacesVirtualDisk
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 VirtualDiskActive = (ulong) (managementObject.Properties["VirtualDiskActive"]?.Value ?? default(ulong)),
		 VirtualDiskActiveBytes = (ulong) (managementObject.Properties["VirtualDiskActiveBytes"]?.Value ?? default(ulong)),
		 VirtualDiskMissing = (ulong) (managementObject.Properties["VirtualDiskMissing"]?.Value ?? default(ulong)),
		 VirtualDiskMissingBytes = (ulong) (managementObject.Properties["VirtualDiskMissingBytes"]?.Value ?? default(ulong)),
		 VirtualDiskNeedReallocation = (ulong) (managementObject.Properties["VirtualDiskNeedReallocation"]?.Value ?? default(ulong)),
		 VirtualDiskNeedReallocationBytes = (ulong) (managementObject.Properties["VirtualDiskNeedReallocationBytes"]?.Value ?? default(ulong)),
		 VirtualDiskNeedRegeneration = (ulong) (managementObject.Properties["VirtualDiskNeedRegeneration"]?.Value ?? default(ulong)),
		 VirtualDiskNeedRegenerationBytes = (ulong) (managementObject.Properties["VirtualDiskNeedRegenerationBytes"]?.Value ?? default(ulong)),
		 VirtualDiskPendingDeletion = (ulong) (managementObject.Properties["VirtualDiskPendingDeletion"]?.Value ?? default(ulong)),
		 VirtualDiskPendingDeletionBytes = (ulong) (managementObject.Properties["VirtualDiskPendingDeletionBytes"]?.Value ?? default(ulong)),
		 VirtualDiskRegenerating = (ulong) (managementObject.Properties["VirtualDiskRegenerating"]?.Value ?? default(ulong)),
		 VirtualDiskRegeneratingBytes = (ulong) (managementObject.Properties["VirtualDiskRegeneratingBytes"]?.Value ?? default(ulong)),
		 VirtualDiskStale = (ulong) (managementObject.Properties["VirtualDiskStale"]?.Value ?? default(ulong)),
		 VirtualDiskStaleBytes = (ulong) (managementObject.Properties["VirtualDiskStaleBytes"]?.Value ?? default(ulong)),
		 VirtualDiskTotal = (ulong) (managementObject.Properties["VirtualDiskTotal"]?.Value ?? default(ulong)),
		 VirtualDiskTotalBytes = (ulong) (managementObject.Properties["VirtualDiskTotalBytes"]?.Value ?? default(ulong))
                };
        }
    }
}