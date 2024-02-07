using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network.Tcp
{
    /// <summary>
    /// </summary>
    public sealed class TcpOffloadParameters
    {
		public uint Flags { get; private set; }
		public dynamic Header { get; private set; }
		public byte Psec { get; private set; }
		public byte Pv4Checksum { get; private set; }
		public byte LsoV1 { get; private set; }
		public byte LsoV2IPv4 { get; private set; }
		public byte LsoV2IPv6 { get; private set; }
		public byte TcpConnectionIPv4 { get; private set; }
		public byte TcpConnectionIPv6 { get; private set; }
		public byte TcpiPv4Checksum { get; private set; }
		public byte TcpiPv6Checksum { get; private set; }
		public byte UdpiPv4Checksum { get; private set; }
		public byte UdpiPv6Checksum { get; private set; }

        public static IEnumerable<TcpOffloadParameters> Retrieve(string remote, string username, string password)
        {
            var options = new ConnectionOptions
            {
                Impersonation = ImpersonationLevel.Impersonate,
                Username = username,
                Password = password
            };

            var managementScope = new ManagementScope(new ManagementPath($"\\\\{remote}\\root\\wmi"), options);
            managementScope.Connect();

            return Retrieve(managementScope);
        }

        public static IEnumerable<TcpOffloadParameters> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<TcpOffloadParameters> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_TcpOffloadParameters");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new TcpOffloadParameters
                {
                     Flags = (uint) (managementObject.Properties["Flags"]?.Value ?? default(uint)),
		 Header = (dynamic) (managementObject.Properties["Header"]?.Value ?? default(dynamic)),
		 Psec = (byte) (managementObject.Properties["IPsec"]?.Value ?? default(byte)),
		 Pv4Checksum = (byte) (managementObject.Properties["IPv4Checksum"]?.Value ?? default(byte)),
		 LsoV1 = (byte) (managementObject.Properties["LsoV1"]?.Value ?? default(byte)),
		 LsoV2IPv4 = (byte) (managementObject.Properties["LsoV2IPv4"]?.Value ?? default(byte)),
		 LsoV2IPv6 = (byte) (managementObject.Properties["LsoV2IPv6"]?.Value ?? default(byte)),
		 TcpConnectionIPv4 = (byte) (managementObject.Properties["TcpConnectionIPv4"]?.Value ?? default(byte)),
		 TcpConnectionIPv6 = (byte) (managementObject.Properties["TcpConnectionIPv6"]?.Value ?? default(byte)),
		 TcpiPv4Checksum = (byte) (managementObject.Properties["TCPIPv4Checksum"]?.Value ?? default(byte)),
		 TcpiPv6Checksum = (byte) (managementObject.Properties["TCPIPv6Checksum"]?.Value ?? default(byte)),
		 UdpiPv4Checksum = (byte) (managementObject.Properties["UDPIPv4Checksum"]?.Value ?? default(byte)),
		 UdpiPv6Checksum = (byte) (managementObject.Properties["UDPIPv6Checksum"]?.Value ?? default(byte))
                };
        }
    }
}