using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted.HyperV
{
    /// <summary>
    /// </summary>
    public sealed class HyperVHypervisor
    {
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public ulong HypervisorStartupCost { get; private set; }
		public ulong LogicalProcessors { get; private set; }
		public ulong ModernStandbyEntries { get; private set; }
		public ulong MonitoredNotifications { get; private set; }
		public string Name { get; private set; }
		public ulong Partitions { get; private set; }
		public ulong PlatformIdleTransitions { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public ulong TotalPages { get; private set; }
		public ulong VirtualProcessors { get; private set; }

        public static IEnumerable<HyperVHypervisor> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HyperVHypervisor> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HyperVHypervisor> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_HvStats_HyperVHypervisor");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HyperVHypervisor
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 HypervisorStartupCost = (ulong) (managementObject.Properties["HypervisorStartupCost"]?.Value ?? default(ulong)),
		 LogicalProcessors = (ulong) (managementObject.Properties["LogicalProcessors"]?.Value ?? default(ulong)),
		 ModernStandbyEntries = (ulong) (managementObject.Properties["ModernStandbyEntries"]?.Value ?? default(ulong)),
		 MonitoredNotifications = (ulong) (managementObject.Properties["MonitoredNotifications"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 Partitions = (ulong) (managementObject.Properties["Partitions"]?.Value ?? default(ulong)),
		 PlatformIdleTransitions = (ulong) (managementObject.Properties["PlatformIdleTransitions"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 TotalPages = (ulong) (managementObject.Properties["TotalPages"]?.Value ?? default(ulong)),
		 VirtualProcessors = (ulong) (managementObject.Properties["VirtualProcessors"]?.Value ?? default(ulong))
                };
        }
    }
}