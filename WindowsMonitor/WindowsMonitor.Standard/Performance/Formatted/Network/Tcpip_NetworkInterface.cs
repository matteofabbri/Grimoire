using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted.Network
{
    /// <summary>
    /// </summary>
    public sealed class TcpipNetworkInterface
    {
		public ulong BytesReceivedPersec { get; private set; }
		public ulong BytesSentPersec { get; private set; }
		public ulong BytesTotalPersec { get; private set; }
		public string Caption { get; private set; }
		public ulong CurrentBandwidth { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public ulong OffloadedConnections { get; private set; }
		public ulong OutputQueueLength { get; private set; }
		public ulong PacketsOutboundDiscarded { get; private set; }
		public ulong PacketsOutboundErrors { get; private set; }
		public ulong PacketsPersec { get; private set; }
		public ulong PacketsReceivedDiscarded { get; private set; }
		public ulong PacketsReceivedErrors { get; private set; }
		public ulong PacketsReceivedNonUnicastPersec { get; private set; }
		public ulong PacketsReceivedPersec { get; private set; }
		public ulong PacketsReceivedUnicastPersec { get; private set; }
		public ulong PacketsReceivedUnknown { get; private set; }
		public ulong PacketsSentNonUnicastPersec { get; private set; }
		public ulong PacketsSentPersec { get; private set; }
		public ulong PacketsSentUnicastPersec { get; private set; }
		public ulong TcpActiveRscConnections { get; private set; }
		public ulong TcprscAveragePacketSize { get; private set; }
		public ulong TcprscCoalescedPacketsPersec { get; private set; }
		public ulong TcprscExceptionsPersec { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<TcpipNetworkInterface> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<TcpipNetworkInterface> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<TcpipNetworkInterface> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_Tcpip_NetworkInterface");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new TcpipNetworkInterface
                {
                     BytesReceivedPersec = (ulong) (managementObject.Properties["BytesReceivedPersec"]?.Value ?? default(ulong)),
		 BytesSentPersec = (ulong) (managementObject.Properties["BytesSentPersec"]?.Value ?? default(ulong)),
		 BytesTotalPersec = (ulong) (managementObject.Properties["BytesTotalPersec"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CurrentBandwidth = (ulong) (managementObject.Properties["CurrentBandwidth"]?.Value ?? default(ulong)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 OffloadedConnections = (ulong) (managementObject.Properties["OffloadedConnections"]?.Value ?? default(ulong)),
		 OutputQueueLength = (ulong) (managementObject.Properties["OutputQueueLength"]?.Value ?? default(ulong)),
		 PacketsOutboundDiscarded = (ulong) (managementObject.Properties["PacketsOutboundDiscarded"]?.Value ?? default(ulong)),
		 PacketsOutboundErrors = (ulong) (managementObject.Properties["PacketsOutboundErrors"]?.Value ?? default(ulong)),
		 PacketsPersec = (ulong) (managementObject.Properties["PacketsPersec"]?.Value ?? default(ulong)),
		 PacketsReceivedDiscarded = (ulong) (managementObject.Properties["PacketsReceivedDiscarded"]?.Value ?? default(ulong)),
		 PacketsReceivedErrors = (ulong) (managementObject.Properties["PacketsReceivedErrors"]?.Value ?? default(ulong)),
		 PacketsReceivedNonUnicastPersec = (ulong) (managementObject.Properties["PacketsReceivedNonUnicastPersec"]?.Value ?? default(ulong)),
		 PacketsReceivedPersec = (ulong) (managementObject.Properties["PacketsReceivedPersec"]?.Value ?? default(ulong)),
		 PacketsReceivedUnicastPersec = (ulong) (managementObject.Properties["PacketsReceivedUnicastPersec"]?.Value ?? default(ulong)),
		 PacketsReceivedUnknown = (ulong) (managementObject.Properties["PacketsReceivedUnknown"]?.Value ?? default(ulong)),
		 PacketsSentNonUnicastPersec = (ulong) (managementObject.Properties["PacketsSentNonUnicastPersec"]?.Value ?? default(ulong)),
		 PacketsSentPersec = (ulong) (managementObject.Properties["PacketsSentPersec"]?.Value ?? default(ulong)),
		 PacketsSentUnicastPersec = (ulong) (managementObject.Properties["PacketsSentUnicastPersec"]?.Value ?? default(ulong)),
		 TcpActiveRscConnections = (ulong) (managementObject.Properties["TCPActiveRSCConnections"]?.Value ?? default(ulong)),
		 TcprscAveragePacketSize = (ulong) (managementObject.Properties["TCPRSCAveragePacketSize"]?.Value ?? default(ulong)),
		 TcprscCoalescedPacketsPersec = (ulong) (managementObject.Properties["TCPRSCCoalescedPacketsPersec"]?.Value ?? default(ulong)),
		 TcprscExceptionsPersec = (ulong) (managementObject.Properties["TCPRSCExceptionsPersec"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}