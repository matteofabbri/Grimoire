using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted.Network.IpSec
{
    /// <summary>
    /// </summary>
    public sealed class CountersIPsecDriver
    {
		public uint ActiveSecurityAssociations { get; private set; }
		public uint BytesReceivedinTransportModePersec { get; private set; }
		public uint BytesReceivedinTunnelModePersec { get; private set; }
		public uint BytesSentinTransportModePersec { get; private set; }
		public uint BytesSentinTunnelModePersec { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public uint InboundPacketsDroppedPersec { get; private set; }
		public uint InboundPacketsReceivedPersec { get; private set; }
		public uint IncorrectSpiPackets { get; private set; }
		public uint IncorrectSpiPacketsPersec { get; private set; }
		public string Name { get; private set; }
		public uint OffloadedBytesReceivedPersec { get; private set; }
		public uint OffloadedBytesSentPersec { get; private set; }
		public uint OffloadedSecurityAssociations { get; private set; }
		public uint PacketsNotAuthenticated { get; private set; }
		public uint PacketsNotAuthenticatedPersec { get; private set; }
		public uint PacketsNotDecrypted { get; private set; }
		public uint PacketsNotDecryptedPersec { get; private set; }
		public uint PacketsReceivedOverWrongSa { get; private set; }
		public uint PacketsReceivedOverWrongSaPersec { get; private set; }
		public uint PacketsThatFailedEspValidation { get; private set; }
		public uint PacketsThatFailedEspValidationPersec { get; private set; }
		public uint PacketsThatFailedReplayDetection { get; private set; }
		public uint PacketsThatFailedReplayDetectionPersec { get; private set; }
		public uint PacketsThatFailedUdpespValidation { get; private set; }
		public uint PacketsThatFailedUdpespValidationPersec { get; private set; }
		public uint PendingSecurityAssociations { get; private set; }
		public uint PlaintextPacketsReceived { get; private set; }
		public uint PlaintextPacketsReceivedPersec { get; private set; }
		public uint SaRekeys { get; private set; }
		public uint SecurityAssociationsAdded { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public uint TotalInboundPacketsDropped { get; private set; }
		public uint TotalInboundPacketsReceived { get; private set; }

        public static IEnumerable<CountersIPsecDriver> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<CountersIPsecDriver> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<CountersIPsecDriver> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_Counters_IPsecDriver");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new CountersIPsecDriver
                {
                     ActiveSecurityAssociations = (uint) (managementObject.Properties["ActiveSecurityAssociations"]?.Value ?? default(uint)),
		 BytesReceivedinTransportModePersec = (uint) (managementObject.Properties["BytesReceivedinTransportModePersec"]?.Value ?? default(uint)),
		 BytesReceivedinTunnelModePersec = (uint) (managementObject.Properties["BytesReceivedinTunnelModePersec"]?.Value ?? default(uint)),
		 BytesSentinTransportModePersec = (uint) (managementObject.Properties["BytesSentinTransportModePersec"]?.Value ?? default(uint)),
		 BytesSentinTunnelModePersec = (uint) (managementObject.Properties["BytesSentinTunnelModePersec"]?.Value ?? default(uint)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 InboundPacketsDroppedPersec = (uint) (managementObject.Properties["InboundPacketsDroppedPersec"]?.Value ?? default(uint)),
		 InboundPacketsReceivedPersec = (uint) (managementObject.Properties["InboundPacketsReceivedPersec"]?.Value ?? default(uint)),
		 IncorrectSpiPackets = (uint) (managementObject.Properties["IncorrectSPIPackets"]?.Value ?? default(uint)),
		 IncorrectSpiPacketsPersec = (uint) (managementObject.Properties["IncorrectSPIPacketsPersec"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 OffloadedBytesReceivedPersec = (uint) (managementObject.Properties["OffloadedBytesReceivedPersec"]?.Value ?? default(uint)),
		 OffloadedBytesSentPersec = (uint) (managementObject.Properties["OffloadedBytesSentPersec"]?.Value ?? default(uint)),
		 OffloadedSecurityAssociations = (uint) (managementObject.Properties["OffloadedSecurityAssociations"]?.Value ?? default(uint)),
		 PacketsNotAuthenticated = (uint) (managementObject.Properties["PacketsNotAuthenticated"]?.Value ?? default(uint)),
		 PacketsNotAuthenticatedPersec = (uint) (managementObject.Properties["PacketsNotAuthenticatedPersec"]?.Value ?? default(uint)),
		 PacketsNotDecrypted = (uint) (managementObject.Properties["PacketsNotDecrypted"]?.Value ?? default(uint)),
		 PacketsNotDecryptedPersec = (uint) (managementObject.Properties["PacketsNotDecryptedPersec"]?.Value ?? default(uint)),
		 PacketsReceivedOverWrongSa = (uint) (managementObject.Properties["PacketsReceivedOverWrongSA"]?.Value ?? default(uint)),
		 PacketsReceivedOverWrongSaPersec = (uint) (managementObject.Properties["PacketsReceivedOverWrongSAPersec"]?.Value ?? default(uint)),
		 PacketsThatFailedEspValidation = (uint) (managementObject.Properties["PacketsThatFailedESPValidation"]?.Value ?? default(uint)),
		 PacketsThatFailedEspValidationPersec = (uint) (managementObject.Properties["PacketsThatFailedESPValidationPersec"]?.Value ?? default(uint)),
		 PacketsThatFailedReplayDetection = (uint) (managementObject.Properties["PacketsThatFailedReplayDetection"]?.Value ?? default(uint)),
		 PacketsThatFailedReplayDetectionPersec = (uint) (managementObject.Properties["PacketsThatFailedReplayDetectionPersec"]?.Value ?? default(uint)),
		 PacketsThatFailedUdpespValidation = (uint) (managementObject.Properties["PacketsThatFailedUDPESPValidation"]?.Value ?? default(uint)),
		 PacketsThatFailedUdpespValidationPersec = (uint) (managementObject.Properties["PacketsThatFailedUDPESPValidationPersec"]?.Value ?? default(uint)),
		 PendingSecurityAssociations = (uint) (managementObject.Properties["PendingSecurityAssociations"]?.Value ?? default(uint)),
		 PlaintextPacketsReceived = (uint) (managementObject.Properties["PlaintextPacketsReceived"]?.Value ?? default(uint)),
		 PlaintextPacketsReceivedPersec = (uint) (managementObject.Properties["PlaintextPacketsReceivedPersec"]?.Value ?? default(uint)),
		 SaRekeys = (uint) (managementObject.Properties["SARekeys"]?.Value ?? default(uint)),
		 SecurityAssociationsAdded = (uint) (managementObject.Properties["SecurityAssociationsAdded"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 TotalInboundPacketsDropped = (uint) (managementObject.Properties["TotalInboundPacketsDropped"]?.Value ?? default(uint)),
		 TotalInboundPacketsReceived = (uint) (managementObject.Properties["TotalInboundPacketsReceived"]?.Value ?? default(uint))
                };
        }
    }
}