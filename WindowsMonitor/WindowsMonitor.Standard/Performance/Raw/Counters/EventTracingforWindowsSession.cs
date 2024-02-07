using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.Counters
{
    /// <summary>
    /// </summary>
    public sealed class EventTracingforWindowsSession
    {
		public uint BufferMemoryUsageNonPagedPool { get; private set; }
		public uint BufferMemoryUsagePagedPool { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong EventsLoggedpersec { get; private set; }
		public uint EventsLost { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public uint NumberofRealTimeConsumers { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<EventTracingforWindowsSession> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<EventTracingforWindowsSession> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<EventTracingforWindowsSession> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_Counters_EventTracingforWindowsSession");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new EventTracingforWindowsSession
                {
                     BufferMemoryUsageNonPagedPool = (uint) (managementObject.Properties["BufferMemoryUsageNonPagedPool"]?.Value ?? default(uint)),
		 BufferMemoryUsagePagedPool = (uint) (managementObject.Properties["BufferMemoryUsagePagedPool"]?.Value ?? default(uint)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 EventsLoggedpersec = (ulong) (managementObject.Properties["EventsLoggedpersec"]?.Value ?? default(ulong)),
		 EventsLost = (uint) (managementObject.Properties["EventsLost"]?.Value ?? default(uint)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 NumberofRealTimeConsumers = (uint) (managementObject.Properties["NumberofRealTimeConsumers"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}