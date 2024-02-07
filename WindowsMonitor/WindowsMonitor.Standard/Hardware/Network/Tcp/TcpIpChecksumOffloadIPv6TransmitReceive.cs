using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network.Tcp
{
    /// <summary>
    /// </summary>
    public sealed class TcpIpChecksumOffloadIPv6TransmitReceive
    {
		public uint Encapsulation { get; private set; }
		public uint IpExtensionHeadersSupported { get; private set; }
		public uint TcpChecksum { get; private set; }
		public uint TcpOptionsSupported { get; private set; }
		public uint UdpChecksum { get; private set; }

        public static IEnumerable<TcpIpChecksumOffloadIPv6TransmitReceive> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<TcpIpChecksumOffloadIPv6TransmitReceive> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<TcpIpChecksumOffloadIPv6TransmitReceive> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_WmiTcpIpChecksumOffload_IPv6TransmitReceive");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new TcpIpChecksumOffloadIPv6TransmitReceive
                {
                     Encapsulation = (uint) (managementObject.Properties["Encapsulation"]?.Value ?? default(uint)),
		 IpExtensionHeadersSupported = (uint) (managementObject.Properties["IpExtensionHeadersSupported"]?.Value ?? default(uint)),
		 TcpChecksum = (uint) (managementObject.Properties["TcpChecksum"]?.Value ?? default(uint)),
		 TcpOptionsSupported = (uint) (managementObject.Properties["TcpOptionsSupported"]?.Value ?? default(uint)),
		 UdpChecksum = (uint) (managementObject.Properties["UdpChecksum"]?.Value ?? default(uint))
                };
        }
    }
}