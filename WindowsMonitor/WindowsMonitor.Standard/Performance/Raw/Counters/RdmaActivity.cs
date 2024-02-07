using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.Counters
{
    /// <summary>
    /// </summary>
    public sealed class RdmaActivity
    {
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public uint RdmaAcceptedConnections { get; private set; }
		public uint RdmaActiveConnections { get; private set; }
		public uint RdmaCompletionQueueErrors { get; private set; }
		public uint RdmaConnectionErrors { get; private set; }
		public uint RdmaFailedConnectionAttempts { get; private set; }
		public ulong RdmaInboundBytesPersec { get; private set; }
		public ulong RdmaInboundFramesPersec { get; private set; }
		public uint RdmaInitiatedConnections { get; private set; }
		public ulong RdmaOutboundBytesPersec { get; private set; }
		public ulong RdmaOutboundFramesPersec { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<RdmaActivity> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<RdmaActivity> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<RdmaActivity> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_Counters_RDMAActivity");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new RdmaActivity
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 RdmaAcceptedConnections = (uint) (managementObject.Properties["RDMAAcceptedConnections"]?.Value ?? default(uint)),
		 RdmaActiveConnections = (uint) (managementObject.Properties["RDMAActiveConnections"]?.Value ?? default(uint)),
		 RdmaCompletionQueueErrors = (uint) (managementObject.Properties["RDMACompletionQueueErrors"]?.Value ?? default(uint)),
		 RdmaConnectionErrors = (uint) (managementObject.Properties["RDMAConnectionErrors"]?.Value ?? default(uint)),
		 RdmaFailedConnectionAttempts = (uint) (managementObject.Properties["RDMAFailedConnectionAttempts"]?.Value ?? default(uint)),
		 RdmaInboundBytesPersec = (ulong) (managementObject.Properties["RDMAInboundBytesPersec"]?.Value ?? default(ulong)),
		 RdmaInboundFramesPersec = (ulong) (managementObject.Properties["RDMAInboundFramesPersec"]?.Value ?? default(ulong)),
		 RdmaInitiatedConnections = (uint) (managementObject.Properties["RDMAInitiatedConnections"]?.Value ?? default(uint)),
		 RdmaOutboundBytesPersec = (ulong) (managementObject.Properties["RDMAOutboundBytesPersec"]?.Value ?? default(ulong)),
		 RdmaOutboundFramesPersec = (ulong) (managementObject.Properties["RDMAOutboundFramesPersec"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}