using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network
{
    /// <summary>
    /// </summary>
    public sealed class NetworkAdapterConfiguration
    {
		public bool ArpAlwaysSourceRoute { get; private set; }
		public bool ArpUseEtherSnap { get; private set; }
		public string Caption { get; private set; }
		public string DatabasePath { get; private set; }
		public bool DeadGwDetectEnabled { get; private set; }
		public string[] DefaultIpGateway { get; private set; }
		public byte DefaultTos { get; private set; }
		public byte DefaultTtl { get; private set; }
		public string Description { get; private set; }
		public bool DhcpEnabled { get; private set; }
		public DateTime DhcpLeaseExpires { get; private set; }
		public DateTime DhcpLeaseObtained { get; private set; }
		public string DhcpServer { get; private set; }
		public string DnsDomain { get; private set; }
		public string[] DnsDomainSuffixSearchOrder { get; private set; }
		public bool DnsEnabledForWinsResolution { get; private set; }
		public string DnsHostName { get; private set; }
		public string[] DnsServerSearchOrder { get; private set; }
		public bool DomainDnsRegistrationEnabled { get; private set; }
		public uint ForwardBufferMemory { get; private set; }
		public bool FullDnsRegistrationEnabled { get; private set; }
		public ushort[] GatewayCostMetric { get; private set; }
		public byte IgmpLevel { get; private set; }
		public uint Index { get; private set; }
		public uint InterfaceIndex { get; private set; }
		public string[] IpAddress { get; private set; }
		public uint IpConnectionMetric { get; private set; }
		public bool IpEnabled { get; private set; }
		public bool IpFilterSecurityEnabled { get; private set; }
		public bool IpPortSecurityEnabled { get; private set; }
		public string[] IpSecPermitIpProtocols { get; private set; }
		public string[] IpSecPermitTcpPorts { get; private set; }
		public string[] IpSecPermitUdpPorts { get; private set; }
		public string[] IpSubnet { get; private set; }
		public bool IpUseZeroBroadcast { get; private set; }
		public string IpxAddress { get; private set; }
		public bool IpxEnabled { get; private set; }
		public uint[] IpxFrameType { get; private set; }
		public uint IpxMediaType { get; private set; }
		public string[] IpxNetworkNumber { get; private set; }
		public string IpxVirtualNetNumber { get; private set; }
		public uint KeepAliveInterval { get; private set; }
		public uint KeepAliveTime { get; private set; }
		public string MacAddress { get; private set; }
		public uint Mtu { get; private set; }
		public uint NumForwardPackets { get; private set; }
		public bool PmtubhDetectEnabled { get; private set; }
		public bool PmtuDiscoveryEnabled { get; private set; }
		public string ServiceName { get; private set; }
		public string SettingId { get; private set; }
		public uint TcpipNetbiosOptions { get; private set; }
		public uint TcpMaxConnectRetransmissions { get; private set; }
		public uint TcpMaxDataRetransmissions { get; private set; }
		public uint TcpNumConnections { get; private set; }
		public bool TcpUseRfc1122UrgentPointer { get; private set; }
		public ushort TcpWindowSize { get; private set; }
		public bool WinsEnableLmHostsLookup { get; private set; }
		public string WinsHostLookupFile { get; private set; }
		public string WinsPrimaryServer { get; private set; }
		public string WinsScopeId { get; private set; }
		public string WinsSecondaryServer { get; private set; }

        public static IEnumerable<NetworkAdapterConfiguration> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<NetworkAdapterConfiguration> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<NetworkAdapterConfiguration> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_NetworkAdapterConfiguration");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new NetworkAdapterConfiguration
                {
                     ArpAlwaysSourceRoute = (bool) (managementObject.Properties["ArpAlwaysSourceRoute"]?.Value ?? default(bool)),
		 ArpUseEtherSnap = (bool) (managementObject.Properties["ArpUseEtherSNAP"]?.Value ?? default(bool)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 DatabasePath = (string) (managementObject.Properties["DatabasePath"]?.Value),
		 DeadGwDetectEnabled = (bool) (managementObject.Properties["DeadGWDetectEnabled"]?.Value ?? default(bool)),
		 DefaultIpGateway = (string[]) (managementObject.Properties["DefaultIPGateway"]?.Value ?? new string[0]),
		 DefaultTos = (byte) (managementObject.Properties["DefaultTOS"]?.Value ?? default(byte)),
		 DefaultTtl = (byte) (managementObject.Properties["DefaultTTL"]?.Value ?? default(byte)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DhcpEnabled = (bool) (managementObject.Properties["DHCPEnabled"]?.Value ?? default(bool)),
		 DhcpLeaseExpires = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["DHCPLeaseExpires"]?.Value as string ?? "00010102000000.000000+060"),
		 DhcpLeaseObtained = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["DHCPLeaseObtained"]?.Value as string ?? "00010102000000.000000+060"),
		 DhcpServer = (string) (managementObject.Properties["DHCPServer"]?.Value),
		 DnsDomain = (string) (managementObject.Properties["DNSDomain"]?.Value),
		 DnsDomainSuffixSearchOrder = (string[]) (managementObject.Properties["DNSDomainSuffixSearchOrder"]?.Value ?? new string[0]),
		 DnsEnabledForWinsResolution = (bool) (managementObject.Properties["DNSEnabledForWINSResolution"]?.Value ?? default(bool)),
		 DnsHostName = (string) (managementObject.Properties["DNSHostName"]?.Value),
		 DnsServerSearchOrder = (string[]) (managementObject.Properties["DNSServerSearchOrder"]?.Value ?? new string[0]),
		 DomainDnsRegistrationEnabled = (bool) (managementObject.Properties["DomainDNSRegistrationEnabled"]?.Value ?? default(bool)),
		 ForwardBufferMemory = (uint) (managementObject.Properties["ForwardBufferMemory"]?.Value ?? default(uint)),
		 FullDnsRegistrationEnabled = (bool) (managementObject.Properties["FullDNSRegistrationEnabled"]?.Value ?? default(bool)),
		 GatewayCostMetric = (ushort[]) (managementObject.Properties["GatewayCostMetric"]?.Value ?? new ushort[0]),
		 IgmpLevel = (byte) (managementObject.Properties["IGMPLevel"]?.Value ?? default(byte)),
		 Index = (uint) (managementObject.Properties["Index"]?.Value ?? default(uint)),
		 InterfaceIndex = (uint) (managementObject.Properties["InterfaceIndex"]?.Value ?? default(uint)),
		 IpAddress = (string[]) (managementObject.Properties["IPAddress"]?.Value ?? new string[0]),
		 IpConnectionMetric = (uint) (managementObject.Properties["IPConnectionMetric"]?.Value ?? default(uint)),
		 IpEnabled = (bool) (managementObject.Properties["IPEnabled"]?.Value ?? default(bool)),
		 IpFilterSecurityEnabled = (bool) (managementObject.Properties["IPFilterSecurityEnabled"]?.Value ?? default(bool)),
		 IpPortSecurityEnabled = (bool) (managementObject.Properties["IPPortSecurityEnabled"]?.Value ?? default(bool)),
		 IpSecPermitIpProtocols = (string[]) (managementObject.Properties["IPSecPermitIPProtocols"]?.Value ?? new string[0]),
		 IpSecPermitTcpPorts = (string[]) (managementObject.Properties["IPSecPermitTCPPorts"]?.Value ?? new string[0]),
		 IpSecPermitUdpPorts = (string[]) (managementObject.Properties["IPSecPermitUDPPorts"]?.Value ?? new string[0]),
		 IpSubnet = (string[]) (managementObject.Properties["IPSubnet"]?.Value ?? new string[0]),
		 IpUseZeroBroadcast = (bool) (managementObject.Properties["IPUseZeroBroadcast"]?.Value ?? default(bool)),
		 IpxAddress = (string) (managementObject.Properties["IPXAddress"]?.Value),
		 IpxEnabled = (bool) (managementObject.Properties["IPXEnabled"]?.Value ?? default(bool)),
		 IpxFrameType = (uint[]) (managementObject.Properties["IPXFrameType"]?.Value ?? new uint[0]),
		 IpxMediaType = (uint) (managementObject.Properties["IPXMediaType"]?.Value ?? default(uint)),
		 IpxNetworkNumber = (string[]) (managementObject.Properties["IPXNetworkNumber"]?.Value ?? new string[0]),
		 IpxVirtualNetNumber = (string) (managementObject.Properties["IPXVirtualNetNumber"]?.Value),
		 KeepAliveInterval = (uint) (managementObject.Properties["KeepAliveInterval"]?.Value ?? default(uint)),
		 KeepAliveTime = (uint) (managementObject.Properties["KeepAliveTime"]?.Value ?? default(uint)),
		 MacAddress = (string) (managementObject.Properties["MACAddress"]?.Value),
		 Mtu = (uint) (managementObject.Properties["MTU"]?.Value ?? default(uint)),
		 NumForwardPackets = (uint) (managementObject.Properties["NumForwardPackets"]?.Value ?? default(uint)),
		 PmtubhDetectEnabled = (bool) (managementObject.Properties["PMTUBHDetectEnabled"]?.Value ?? default(bool)),
		 PmtuDiscoveryEnabled = (bool) (managementObject.Properties["PMTUDiscoveryEnabled"]?.Value ?? default(bool)),
		 ServiceName = (string) (managementObject.Properties["ServiceName"]?.Value),
		 SettingId = (string) (managementObject.Properties["SettingID"]?.Value),
		 TcpipNetbiosOptions = (uint) (managementObject.Properties["TcpipNetbiosOptions"]?.Value ?? default(uint)),
		 TcpMaxConnectRetransmissions = (uint) (managementObject.Properties["TcpMaxConnectRetransmissions"]?.Value ?? default(uint)),
		 TcpMaxDataRetransmissions = (uint) (managementObject.Properties["TcpMaxDataRetransmissions"]?.Value ?? default(uint)),
		 TcpNumConnections = (uint) (managementObject.Properties["TcpNumConnections"]?.Value ?? default(uint)),
		 TcpUseRfc1122UrgentPointer = (bool) (managementObject.Properties["TcpUseRFC1122UrgentPointer"]?.Value ?? default(bool)),
		 TcpWindowSize = (ushort) (managementObject.Properties["TcpWindowSize"]?.Value ?? default(ushort)),
		 WinsEnableLmHostsLookup = (bool) (managementObject.Properties["WINSEnableLMHostsLookup"]?.Value ?? default(bool)),
		 WinsHostLookupFile = (string) (managementObject.Properties["WINSHostLookupFile"]?.Value),
		 WinsPrimaryServer = (string) (managementObject.Properties["WINSPrimaryServer"]?.Value),
		 WinsScopeId = (string) (managementObject.Properties["WINSScopeID"]?.Value),
		 WinsSecondaryServer = (string) (managementObject.Properties["WINSSecondaryServer"]?.Value)
                };
        }
    }
}