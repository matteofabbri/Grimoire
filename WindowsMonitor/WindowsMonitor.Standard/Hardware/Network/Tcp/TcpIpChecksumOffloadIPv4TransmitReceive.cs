using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network.Tcp
{
    /// <summary>
    /// </summary>
    public sealed class TcpIpChecksumOffloadIPv4TransmitReceive
    {
		public uint Encapsulation { get; private set; }
		public uint IpChecksum { get; private set; }
		public uint IpOptionsSupported { get; private set; }
		public uint TcpChecksum { get; private set; }
		public uint TcpOptionsSupported { get; private set; }
		public uint UdpChecksum { get; private set; }

        public static IEnumerable<TcpIpChecksumOffloadIPv4TransmitReceive> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<TcpIpChecksumOffloadIPv4TransmitReceive> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<TcpIpChecksumOffloadIPv4TransmitReceive> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_WmiTcpIpChecksumOffload_IPv4TransmitReceive");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new TcpIpChecksumOffloadIPv4TransmitReceive
                {
                     Encapsulation = (uint) (managementObject.Properties["Encapsulation"]?.Value ?? default(uint)),
		 IpChecksum = (uint) (managementObject.Properties["IpChecksum"]?.Value ?? default(uint)),
		 IpOptionsSupported = (uint) (managementObject.Properties["IpOptionsSupported"]?.Value ?? default(uint)),
		 TcpChecksum = (uint) (managementObject.Properties["TcpChecksum"]?.Value ?? default(uint)),
		 TcpOptionsSupported = (uint) (managementObject.Properties["TcpOptionsSupported"]?.Value ?? default(uint)),
		 UdpChecksum = (uint) (managementObject.Properties["UdpChecksum"]?.Value ?? default(uint))
                };
        }
    }
}