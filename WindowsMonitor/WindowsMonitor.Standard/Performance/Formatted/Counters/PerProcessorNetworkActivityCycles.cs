using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted.Counters
{
    /// <summary>
    /// </summary>
    public sealed class PerProcessorNetworkActivityCycles
    {
		public ulong BuildScatterGatherCyclesPersec { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public ulong InterruptCyclesPersec { get; private set; }
		public ulong InterruptDpcCyclesPersec { get; private set; }
		public ulong InterruptDpcLatencyCyclesPersec { get; private set; }
		public ulong MiniportReturnPacketCyclesPersec { get; private set; }
		public ulong MiniportRssIndirectionTableChangeCycles { get; private set; }
		public ulong MiniportSendCyclesPersec { get; private set; }
		public string Name { get; private set; }
		public ulong NdisReceiveIndicationCyclesPersec { get; private set; }
		public ulong NdisReturnPacketCyclesPersec { get; private set; }
		public ulong NdisSendCompleteCyclesPersec { get; private set; }
		public ulong NdisSendCyclesPersec { get; private set; }
		public ulong StackReceiveIndicationCyclesPersec { get; private set; }
		public ulong StackSendCompleteCyclesPersec { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<PerProcessorNetworkActivityCycles> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<PerProcessorNetworkActivityCycles> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<PerProcessorNetworkActivityCycles> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_Counters_PerProcessorNetworkActivityCycles");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new PerProcessorNetworkActivityCycles
                {
                     BuildScatterGatherCyclesPersec = (ulong) (managementObject.Properties["BuildScatterGatherCyclesPersec"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 InterruptCyclesPersec = (ulong) (managementObject.Properties["InterruptCyclesPersec"]?.Value ?? default(ulong)),
		 InterruptDpcCyclesPersec = (ulong) (managementObject.Properties["InterruptDPCCyclesPersec"]?.Value ?? default(ulong)),
		 InterruptDpcLatencyCyclesPersec = (ulong) (managementObject.Properties["InterruptDPCLatencyCyclesPersec"]?.Value ?? default(ulong)),
		 MiniportReturnPacketCyclesPersec = (ulong) (managementObject.Properties["MiniportReturnPacketCyclesPersec"]?.Value ?? default(ulong)),
		 MiniportRssIndirectionTableChangeCycles = (ulong) (managementObject.Properties["MiniportRSSIndirectionTableChangeCycles"]?.Value ?? default(ulong)),
		 MiniportSendCyclesPersec = (ulong) (managementObject.Properties["MiniportSendCyclesPersec"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 NdisReceiveIndicationCyclesPersec = (ulong) (managementObject.Properties["NDISReceiveIndicationCyclesPersec"]?.Value ?? default(ulong)),
		 NdisReturnPacketCyclesPersec = (ulong) (managementObject.Properties["NDISReturnPacketCyclesPersec"]?.Value ?? default(ulong)),
		 NdisSendCompleteCyclesPersec = (ulong) (managementObject.Properties["NDISSendCompleteCyclesPersec"]?.Value ?? default(ulong)),
		 NdisSendCyclesPersec = (ulong) (managementObject.Properties["NDISSendCyclesPersec"]?.Value ?? default(ulong)),
		 StackReceiveIndicationCyclesPersec = (ulong) (managementObject.Properties["StackReceiveIndicationCyclesPersec"]?.Value ?? default(ulong)),
		 StackSendCompleteCyclesPersec = (ulong) (managementObject.Properties["StackSendCompleteCyclesPersec"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}