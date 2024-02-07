using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted.Counters
{
    /// <summary>
    /// </summary>
    public sealed class PacketDirectReceiveCounters
    {
		public ulong BytesReceived { get; private set; }
		public ulong BytesReceivedPersec { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public ulong PacketsDropped { get; private set; }
		public ulong PacketsDroppedPersec { get; private set; }
		public ulong PacketsReceived { get; private set; }
		public ulong PacketsReceivedPersec { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<PacketDirectReceiveCounters> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<PacketDirectReceiveCounters> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<PacketDirectReceiveCounters> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_Counters_PacketDirectReceiveCounters");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new PacketDirectReceiveCounters
                {
                     BytesReceived = (ulong) (managementObject.Properties["BytesReceived"]?.Value ?? default(ulong)),
		 BytesReceivedPersec = (ulong) (managementObject.Properties["BytesReceivedPersec"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 PacketsDropped = (ulong) (managementObject.Properties["PacketsDropped"]?.Value ?? default(ulong)),
		 PacketsDroppedPersec = (ulong) (managementObject.Properties["PacketsDroppedPersec"]?.Value ?? default(ulong)),
		 PacketsReceived = (ulong) (managementObject.Properties["PacketsReceived"]?.Value ?? default(ulong)),
		 PacketsReceivedPersec = (ulong) (managementObject.Properties["PacketsReceivedPersec"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}