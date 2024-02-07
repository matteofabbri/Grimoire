using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted.Network
{
    /// <summary>
    /// </summary>
    public sealed class TcpipIcmPv6
    {
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public uint MessagesOutboundErrors { get; private set; }
		public uint MessagesPersec { get; private set; }
		public uint MessagesReceivedErrors { get; private set; }
		public uint MessagesReceivedPersec { get; private set; }
		public uint MessagesSentPersec { get; private set; }
		public string Name { get; private set; }
		public uint ReceivedDestUnreachable { get; private set; }
		public uint ReceivedEchoPersec { get; private set; }
		public uint ReceivedEchoReplyPersec { get; private set; }
		public uint ReceivedMembershipQuery { get; private set; }
		public uint ReceivedMembershipReduction { get; private set; }
		public uint ReceivedMembershipReport { get; private set; }
		public uint ReceivedNeighborAdvert { get; private set; }
		public uint ReceivedNeighborSolicit { get; private set; }
		public uint ReceivedPacketTooBig { get; private set; }
		public uint ReceivedParameterProblem { get; private set; }
		public uint ReceivedRedirectPersec { get; private set; }
		public uint ReceivedRouterAdvert { get; private set; }
		public uint ReceivedRouterSolicit { get; private set; }
		public uint ReceivedTimeExceeded { get; private set; }
		public uint SentDestinationUnreachable { get; private set; }
		public uint SentEchoPersec { get; private set; }
		public uint SentEchoReplyPersec { get; private set; }
		public uint SentMembershipQuery { get; private set; }
		public uint SentMembershipReduction { get; private set; }
		public uint SentMembershipReport { get; private set; }
		public uint SentNeighborAdvert { get; private set; }
		public uint SentNeighborSolicit { get; private set; }
		public uint SentPacketTooBig { get; private set; }
		public uint SentParameterProblem { get; private set; }
		public uint SentRedirectPersec { get; private set; }
		public uint SentRouterAdvert { get; private set; }
		public uint SentRouterSolicit { get; private set; }
		public uint SentTimeExceeded { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<TcpipIcmPv6> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<TcpipIcmPv6> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<TcpipIcmPv6> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_Tcpip_ICMPv6");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new TcpipIcmPv6
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 MessagesOutboundErrors = (uint) (managementObject.Properties["MessagesOutboundErrors"]?.Value ?? default(uint)),
		 MessagesPersec = (uint) (managementObject.Properties["MessagesPersec"]?.Value ?? default(uint)),
		 MessagesReceivedErrors = (uint) (managementObject.Properties["MessagesReceivedErrors"]?.Value ?? default(uint)),
		 MessagesReceivedPersec = (uint) (managementObject.Properties["MessagesReceivedPersec"]?.Value ?? default(uint)),
		 MessagesSentPersec = (uint) (managementObject.Properties["MessagesSentPersec"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 ReceivedDestUnreachable = (uint) (managementObject.Properties["ReceivedDestUnreachable"]?.Value ?? default(uint)),
		 ReceivedEchoPersec = (uint) (managementObject.Properties["ReceivedEchoPersec"]?.Value ?? default(uint)),
		 ReceivedEchoReplyPersec = (uint) (managementObject.Properties["ReceivedEchoReplyPersec"]?.Value ?? default(uint)),
		 ReceivedMembershipQuery = (uint) (managementObject.Properties["ReceivedMembershipQuery"]?.Value ?? default(uint)),
		 ReceivedMembershipReduction = (uint) (managementObject.Properties["ReceivedMembershipReduction"]?.Value ?? default(uint)),
		 ReceivedMembershipReport = (uint) (managementObject.Properties["ReceivedMembershipReport"]?.Value ?? default(uint)),
		 ReceivedNeighborAdvert = (uint) (managementObject.Properties["ReceivedNeighborAdvert"]?.Value ?? default(uint)),
		 ReceivedNeighborSolicit = (uint) (managementObject.Properties["ReceivedNeighborSolicit"]?.Value ?? default(uint)),
		 ReceivedPacketTooBig = (uint) (managementObject.Properties["ReceivedPacketTooBig"]?.Value ?? default(uint)),
		 ReceivedParameterProblem = (uint) (managementObject.Properties["ReceivedParameterProblem"]?.Value ?? default(uint)),
		 ReceivedRedirectPersec = (uint) (managementObject.Properties["ReceivedRedirectPersec"]?.Value ?? default(uint)),
		 ReceivedRouterAdvert = (uint) (managementObject.Properties["ReceivedRouterAdvert"]?.Value ?? default(uint)),
		 ReceivedRouterSolicit = (uint) (managementObject.Properties["ReceivedRouterSolicit"]?.Value ?? default(uint)),
		 ReceivedTimeExceeded = (uint) (managementObject.Properties["ReceivedTimeExceeded"]?.Value ?? default(uint)),
		 SentDestinationUnreachable = (uint) (managementObject.Properties["SentDestinationUnreachable"]?.Value ?? default(uint)),
		 SentEchoPersec = (uint) (managementObject.Properties["SentEchoPersec"]?.Value ?? default(uint)),
		 SentEchoReplyPersec = (uint) (managementObject.Properties["SentEchoReplyPersec"]?.Value ?? default(uint)),
		 SentMembershipQuery = (uint) (managementObject.Properties["SentMembershipQuery"]?.Value ?? default(uint)),
		 SentMembershipReduction = (uint) (managementObject.Properties["SentMembershipReduction"]?.Value ?? default(uint)),
		 SentMembershipReport = (uint) (managementObject.Properties["SentMembershipReport"]?.Value ?? default(uint)),
		 SentNeighborAdvert = (uint) (managementObject.Properties["SentNeighborAdvert"]?.Value ?? default(uint)),
		 SentNeighborSolicit = (uint) (managementObject.Properties["SentNeighborSolicit"]?.Value ?? default(uint)),
		 SentPacketTooBig = (uint) (managementObject.Properties["SentPacketTooBig"]?.Value ?? default(uint)),
		 SentParameterProblem = (uint) (managementObject.Properties["SentParameterProblem"]?.Value ?? default(uint)),
		 SentRedirectPersec = (uint) (managementObject.Properties["SentRedirectPersec"]?.Value ?? default(uint)),
		 SentRouterAdvert = (uint) (managementObject.Properties["SentRouterAdvert"]?.Value ?? default(uint)),
		 SentRouterSolicit = (uint) (managementObject.Properties["SentRouterSolicit"]?.Value ?? default(uint)),
		 SentTimeExceeded = (uint) (managementObject.Properties["SentTimeExceeded"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}