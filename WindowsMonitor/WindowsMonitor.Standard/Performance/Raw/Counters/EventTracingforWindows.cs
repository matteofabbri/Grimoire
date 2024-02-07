using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.Counters
{
    /// <summary>
    /// </summary>
    public sealed class EventTracingforWindows
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
		public uint TotalMemoryUsageNonPagedPool { get; private set; }
		public uint TotalMemoryUsagePagedPool { get; private set; }
		public uint TotalNumberofActiveSessions { get; private set; }
		public uint TotalNumberofDistinctDisabledProviders { get; private set; }
		public uint TotalNumberofDistinctEnabledProviders { get; private set; }
		public uint TotalNumberofDistinctPreEnabledProviders { get; private set; }

        public static IEnumerable<EventTracingforWindows> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<EventTracingforWindows> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<EventTracingforWindows> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_Counters_EventTracingforWindows");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new EventTracingforWindows
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
		 TotalMemoryUsageNonPagedPool = (uint) (managementObject.Properties["TotalMemoryUsageNonPagedPool"]?.Value ?? default(uint)),
		 TotalMemoryUsagePagedPool = (uint) (managementObject.Properties["TotalMemoryUsagePagedPool"]?.Value ?? default(uint)),
		 TotalNumberofActiveSessions = (uint) (managementObject.Properties["TotalNumberofActiveSessions"]?.Value ?? default(uint)),
		 TotalNumberofDistinctDisabledProviders = (uint) (managementObject.Properties["TotalNumberofDistinctDisabledProviders"]?.Value ?? default(uint)),
		 TotalNumberofDistinctEnabledProviders = (uint) (managementObject.Properties["TotalNumberofDistinctEnabledProviders"]?.Value ?? default(uint)),
		 TotalNumberofDistinctPreEnabledProviders = (uint) (managementObject.Properties["TotalNumberofDistinctPreEnabledProviders"]?.Value ?? default(uint))
                };
        }
    }
}