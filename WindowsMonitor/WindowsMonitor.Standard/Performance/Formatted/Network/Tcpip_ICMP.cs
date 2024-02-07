using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted.Network
{
    /// <summary>
    /// </summary>
    public sealed class TcpipIcmp
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
		public uint ReceivedAddressMask { get; private set; }
		public uint ReceivedAddressMaskReply { get; private set; }
		public uint ReceivedDestUnreachable { get; private set; }
		public uint ReceivedEchoPersec { get; private set; }
		public uint ReceivedEchoReplyPersec { get; private set; }
		public uint ReceivedParameterProblem { get; private set; }
		public uint ReceivedRedirectPersec { get; private set; }
		public uint ReceivedSourceQuench { get; private set; }
		public uint ReceivedTimeExceeded { get; private set; }
		public uint ReceivedTimestampPersec { get; private set; }
		public uint ReceivedTimestampReplyPersec { get; private set; }
		public uint SentAddressMask { get; private set; }
		public uint SentAddressMaskReply { get; private set; }
		public uint SentDestinationUnreachable { get; private set; }
		public uint SentEchoPersec { get; private set; }
		public uint SentEchoReplyPersec { get; private set; }
		public uint SentParameterProblem { get; private set; }
		public uint SentRedirectPersec { get; private set; }
		public uint SentSourceQuench { get; private set; }
		public uint SentTimeExceeded { get; private set; }
		public uint SentTimestampPersec { get; private set; }
		public uint SentTimestampReplyPersec { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<TcpipIcmp> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<TcpipIcmp> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<TcpipIcmp> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_Tcpip_ICMP");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new TcpipIcmp
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
		 ReceivedAddressMask = (uint) (managementObject.Properties["ReceivedAddressMask"]?.Value ?? default(uint)),
		 ReceivedAddressMaskReply = (uint) (managementObject.Properties["ReceivedAddressMaskReply"]?.Value ?? default(uint)),
		 ReceivedDestUnreachable = (uint) (managementObject.Properties["ReceivedDestUnreachable"]?.Value ?? default(uint)),
		 ReceivedEchoPersec = (uint) (managementObject.Properties["ReceivedEchoPersec"]?.Value ?? default(uint)),
		 ReceivedEchoReplyPersec = (uint) (managementObject.Properties["ReceivedEchoReplyPersec"]?.Value ?? default(uint)),
		 ReceivedParameterProblem = (uint) (managementObject.Properties["ReceivedParameterProblem"]?.Value ?? default(uint)),
		 ReceivedRedirectPersec = (uint) (managementObject.Properties["ReceivedRedirectPersec"]?.Value ?? default(uint)),
		 ReceivedSourceQuench = (uint) (managementObject.Properties["ReceivedSourceQuench"]?.Value ?? default(uint)),
		 ReceivedTimeExceeded = (uint) (managementObject.Properties["ReceivedTimeExceeded"]?.Value ?? default(uint)),
		 ReceivedTimestampPersec = (uint) (managementObject.Properties["ReceivedTimestampPersec"]?.Value ?? default(uint)),
		 ReceivedTimestampReplyPersec = (uint) (managementObject.Properties["ReceivedTimestampReplyPersec"]?.Value ?? default(uint)),
		 SentAddressMask = (uint) (managementObject.Properties["SentAddressMask"]?.Value ?? default(uint)),
		 SentAddressMaskReply = (uint) (managementObject.Properties["SentAddressMaskReply"]?.Value ?? default(uint)),
		 SentDestinationUnreachable = (uint) (managementObject.Properties["SentDestinationUnreachable"]?.Value ?? default(uint)),
		 SentEchoPersec = (uint) (managementObject.Properties["SentEchoPersec"]?.Value ?? default(uint)),
		 SentEchoReplyPersec = (uint) (managementObject.Properties["SentEchoReplyPersec"]?.Value ?? default(uint)),
		 SentParameterProblem = (uint) (managementObject.Properties["SentParameterProblem"]?.Value ?? default(uint)),
		 SentRedirectPersec = (uint) (managementObject.Properties["SentRedirectPersec"]?.Value ?? default(uint)),
		 SentSourceQuench = (uint) (managementObject.Properties["SentSourceQuench"]?.Value ?? default(uint)),
		 SentTimeExceeded = (uint) (managementObject.Properties["SentTimeExceeded"]?.Value ?? default(uint)),
		 SentTimestampPersec = (uint) (managementObject.Properties["SentTimestampPersec"]?.Value ?? default(uint)),
		 SentTimestampReplyPersec = (uint) (managementObject.Properties["SentTimestampReplyPersec"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}