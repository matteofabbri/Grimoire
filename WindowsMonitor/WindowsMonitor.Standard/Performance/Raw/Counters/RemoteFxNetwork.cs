using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.Counters
{
    /// <summary>
    /// </summary>
    public sealed class RemoteFxNetwork
    {
		public uint BaseTcprtt { get; private set; }
		public uint BaseUdprtt { get; private set; }
		public string Caption { get; private set; }
		public uint CurrentTcpBandwidth { get; private set; }
		public uint CurrentTcprtt { get; private set; }
		public uint CurrentUdpBandwidth { get; private set; }
		public uint CurrentUdprtt { get; private set; }
		public string Description { get; private set; }
		public uint FecRate { get; private set; }
		public uint FecRateBase { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public uint LossRate { get; private set; }
		public uint LossRateBase { get; private set; }
		public string Name { get; private set; }
		public uint RetransmissionRate { get; private set; }
		public uint RetransmissionRateBase { get; private set; }
		public uint SentRateP0 { get; private set; }
		public uint SentRateP1 { get; private set; }
		public uint SentRateP2 { get; private set; }
		public uint SentRateP3 { get; private set; }
		public uint TcpReceivedRate { get; private set; }
		public uint TcpSentRate { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public uint TotalReceivedBytes { get; private set; }
		public uint TotalReceivedRate { get; private set; }
		public uint TotalSentBytes { get; private set; }
		public uint TotalSentRate { get; private set; }
		public uint UdpPacketsReceivedPersec { get; private set; }
		public uint UdpPacketsSentPersec { get; private set; }
		public uint UdpReceivedRate { get; private set; }
		public uint UdpSentRate { get; private set; }

        public static IEnumerable<RemoteFxNetwork> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<RemoteFxNetwork> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<RemoteFxNetwork> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_Counters_RemoteFXNetwork");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new RemoteFxNetwork
                {
                     BaseTcprtt = (uint) (managementObject.Properties["BaseTCPRTT"]?.Value ?? default(uint)),
		 BaseUdprtt = (uint) (managementObject.Properties["BaseUDPRTT"]?.Value ?? default(uint)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CurrentTcpBandwidth = (uint) (managementObject.Properties["CurrentTCPBandwidth"]?.Value ?? default(uint)),
		 CurrentTcprtt = (uint) (managementObject.Properties["CurrentTCPRTT"]?.Value ?? default(uint)),
		 CurrentUdpBandwidth = (uint) (managementObject.Properties["CurrentUDPBandwidth"]?.Value ?? default(uint)),
		 CurrentUdprtt = (uint) (managementObject.Properties["CurrentUDPRTT"]?.Value ?? default(uint)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FecRate = (uint) (managementObject.Properties["FECRate"]?.Value ?? default(uint)),
		 FecRateBase = (uint) (managementObject.Properties["FECRate_Base"]?.Value ?? default(uint)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 LossRate = (uint) (managementObject.Properties["LossRate"]?.Value ?? default(uint)),
		 LossRateBase = (uint) (managementObject.Properties["LossRate_Base"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 RetransmissionRate = (uint) (managementObject.Properties["RetransmissionRate"]?.Value ?? default(uint)),
		 RetransmissionRateBase = (uint) (managementObject.Properties["RetransmissionRate_Base"]?.Value ?? default(uint)),
		 SentRateP0 = (uint) (managementObject.Properties["SentRateP0"]?.Value ?? default(uint)),
		 SentRateP1 = (uint) (managementObject.Properties["SentRateP1"]?.Value ?? default(uint)),
		 SentRateP2 = (uint) (managementObject.Properties["SentRateP2"]?.Value ?? default(uint)),
		 SentRateP3 = (uint) (managementObject.Properties["SentRateP3"]?.Value ?? default(uint)),
		 TcpReceivedRate = (uint) (managementObject.Properties["TCPReceivedRate"]?.Value ?? default(uint)),
		 TcpSentRate = (uint) (managementObject.Properties["TCPSentRate"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 TotalReceivedBytes = (uint) (managementObject.Properties["TotalReceivedBytes"]?.Value ?? default(uint)),
		 TotalReceivedRate = (uint) (managementObject.Properties["TotalReceivedRate"]?.Value ?? default(uint)),
		 TotalSentBytes = (uint) (managementObject.Properties["TotalSentBytes"]?.Value ?? default(uint)),
		 TotalSentRate = (uint) (managementObject.Properties["TotalSentRate"]?.Value ?? default(uint)),
		 UdpPacketsReceivedPersec = (uint) (managementObject.Properties["UDPPacketsReceivedPersec"]?.Value ?? default(uint)),
		 UdpPacketsSentPersec = (uint) (managementObject.Properties["UDPPacketsSentPersec"]?.Value ?? default(uint)),
		 UdpReceivedRate = (uint) (managementObject.Properties["UDPReceivedRate"]?.Value ?? default(uint)),
		 UdpSentRate = (uint) (managementObject.Properties["UDPSentRate"]?.Value ?? default(uint))
                };
        }
    }
}