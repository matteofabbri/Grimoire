using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network.Tcp
{
    /// <summary>
    /// </summary>
    public sealed class TcpIpChecksumOffload
    {
		public dynamic Pv4Receive { get; private set; }
		public dynamic Pv4Transmit { get; private set; }
		public dynamic Pv6Receive { get; private set; }
		public dynamic Pv6Transmit { get; private set; }

        public static IEnumerable<TcpIpChecksumOffload> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<TcpIpChecksumOffload> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<TcpIpChecksumOffload> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_WmiTcpIpChecksumOffload");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new TcpIpChecksumOffload
                {
                     Pv4Receive = (dynamic) (managementObject.Properties["IPv4Receive"]?.Value ?? default(dynamic)),
		 Pv4Transmit = (dynamic) (managementObject.Properties["IPv4Transmit"]?.Value ?? default(dynamic)),
		 Pv6Receive = (dynamic) (managementObject.Properties["IPv6Receive"]?.Value ?? default(dynamic)),
		 Pv6Transmit = (dynamic) (managementObject.Properties["IPv6Transmit"]?.Value ?? default(dynamic))
                };
        }
    }
}