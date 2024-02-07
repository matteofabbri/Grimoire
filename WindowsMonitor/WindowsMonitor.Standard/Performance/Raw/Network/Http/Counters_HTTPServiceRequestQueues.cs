using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.Network.Http
{
    /// <summary>
    /// </summary>
    public sealed class CountersHttpServiceRequestQueues
    {
		public ulong ArrivalRate { get; private set; }
		public ulong CacheHitRate { get; private set; }
		public string Caption { get; private set; }
		public uint CurrentQueueSize { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public ulong MaxQueueItemAge { get; private set; }
		public string Name { get; private set; }
		public ulong RejectedRequests { get; private set; }
		public ulong RejectionRate { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<CountersHttpServiceRequestQueues> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<CountersHttpServiceRequestQueues> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<CountersHttpServiceRequestQueues> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_Counters_HTTPServiceRequestQueues");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new CountersHttpServiceRequestQueues
                {
                     ArrivalRate = (ulong) (managementObject.Properties["ArrivalRate"]?.Value ?? default(ulong)),
		 CacheHitRate = (ulong) (managementObject.Properties["CacheHitRate"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CurrentQueueSize = (uint) (managementObject.Properties["CurrentQueueSize"]?.Value ?? default(uint)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 MaxQueueItemAge = (ulong) (managementObject.Properties["MaxQueueItemAge"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 RejectedRequests = (ulong) (managementObject.Properties["RejectedRequests"]?.Value ?? default(ulong)),
		 RejectionRate = (ulong) (managementObject.Properties["RejectionRate"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}