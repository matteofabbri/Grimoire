using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.Counters
{
    /// <summary>
    /// </summary>
    public sealed class PerProcessorNetworkInterfaceCardActivity
    {
		public ulong BuildScatterGatherListCallsPersec { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong DpCsDeferredPersec { get; private set; }
		public ulong DpCsQueuedonOtherCpUsPersec { get; private set; }
		public ulong DpCsQueuedPersec { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public ulong InterruptsPersec { get; private set; }
		public ulong LowResourceReceivedPacketsPersec { get; private set; }
		public ulong LowResourceReceiveIndicationsPersec { get; private set; }
		public string Name { get; private set; }
		public ulong PacketsCoalescedPersec { get; private set; }
		public ulong ReceivedPacketsPersec { get; private set; }
		public ulong ReceiveIndicationsPersec { get; private set; }
		public ulong ReturnedPacketsPersec { get; private set; }
		public ulong ReturnPacketCallsPersec { get; private set; }
		public ulong RssIndirectionTableChangeCallsPersec { get; private set; }
		public ulong SendCompleteCallsPersec { get; private set; }
		public ulong SendRequestCallsPersec { get; private set; }
		public ulong SentCompletePacketsPersec { get; private set; }
		public ulong SentPacketsPersec { get; private set; }
		public ulong TcpOffloadReceivebytesPersec { get; private set; }
		public ulong TcpOffloadReceiveIndicationsPersec { get; private set; }
		public ulong TcpOffloadSendbytesPersec { get; private set; }
		public ulong TcpOffloadSendRequestCallsPersec { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<PerProcessorNetworkInterfaceCardActivity> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<PerProcessorNetworkInterfaceCardActivity> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<PerProcessorNetworkInterfaceCardActivity> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_Counters_PerProcessorNetworkInterfaceCardActivity");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new PerProcessorNetworkInterfaceCardActivity
                {
                     BuildScatterGatherListCallsPersec = (ulong) (managementObject.Properties["BuildScatterGatherListCallsPersec"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DpCsDeferredPersec = (ulong) (managementObject.Properties["DPCsDeferredPersec"]?.Value ?? default(ulong)),
		 DpCsQueuedonOtherCpUsPersec = (ulong) (managementObject.Properties["DPCsQueuedonOtherCPUsPersec"]?.Value ?? default(ulong)),
		 DpCsQueuedPersec = (ulong) (managementObject.Properties["DPCsQueuedPersec"]?.Value ?? default(ulong)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 InterruptsPersec = (ulong) (managementObject.Properties["InterruptsPersec"]?.Value ?? default(ulong)),
		 LowResourceReceivedPacketsPersec = (ulong) (managementObject.Properties["LowResourceReceivedPacketsPersec"]?.Value ?? default(ulong)),
		 LowResourceReceiveIndicationsPersec = (ulong) (managementObject.Properties["LowResourceReceiveIndicationsPersec"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 PacketsCoalescedPersec = (ulong) (managementObject.Properties["PacketsCoalescedPersec"]?.Value ?? default(ulong)),
		 ReceivedPacketsPersec = (ulong) (managementObject.Properties["ReceivedPacketsPersec"]?.Value ?? default(ulong)),
		 ReceiveIndicationsPersec = (ulong) (managementObject.Properties["ReceiveIndicationsPersec"]?.Value ?? default(ulong)),
		 ReturnedPacketsPersec = (ulong) (managementObject.Properties["ReturnedPacketsPersec"]?.Value ?? default(ulong)),
		 ReturnPacketCallsPersec = (ulong) (managementObject.Properties["ReturnPacketCallsPersec"]?.Value ?? default(ulong)),
		 RssIndirectionTableChangeCallsPersec = (ulong) (managementObject.Properties["RSSIndirectionTableChangeCallsPersec"]?.Value ?? default(ulong)),
		 SendCompleteCallsPersec = (ulong) (managementObject.Properties["SendCompleteCallsPersec"]?.Value ?? default(ulong)),
		 SendRequestCallsPersec = (ulong) (managementObject.Properties["SendRequestCallsPersec"]?.Value ?? default(ulong)),
		 SentCompletePacketsPersec = (ulong) (managementObject.Properties["SentCompletePacketsPersec"]?.Value ?? default(ulong)),
		 SentPacketsPersec = (ulong) (managementObject.Properties["SentPacketsPersec"]?.Value ?? default(ulong)),
		 TcpOffloadReceivebytesPersec = (ulong) (managementObject.Properties["TcpOffloadReceivebytesPersec"]?.Value ?? default(ulong)),
		 TcpOffloadReceiveIndicationsPersec = (ulong) (managementObject.Properties["TcpOffloadReceiveIndicationsPersec"]?.Value ?? default(ulong)),
		 TcpOffloadSendbytesPersec = (ulong) (managementObject.Properties["TcpOffloadSendbytesPersec"]?.Value ?? default(ulong)),
		 TcpOffloadSendRequestCallsPersec = (ulong) (managementObject.Properties["TcpOffloadSendRequestCallsPersec"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}