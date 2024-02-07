using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network.IPSec
{
    /// <summary>
    /// </summary>
    public sealed class IpSecOffloadV1Supported
    {
		public uint AhEspCombined { get; private set; }
		public uint Encapsulation { get; private set; }
		public uint Flags { get; private set; }
		public uint Pv4Options { get; private set; }
		public uint TransportTunnelCombined { get; private set; }

        public static IEnumerable<IpSecOffloadV1Supported> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<IpSecOffloadV1Supported> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<IpSecOffloadV1Supported> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_WmiIPSecOffloadV1_Supported");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new IpSecOffloadV1Supported
                {
                     AhEspCombined = (uint) (managementObject.Properties["AhEspCombined"]?.Value ?? default(uint)),
		 Encapsulation = (uint) (managementObject.Properties["Encapsulation"]?.Value ?? default(uint)),
		 Flags = (uint) (managementObject.Properties["Flags"]?.Value ?? default(uint)),
		 Pv4Options = (uint) (managementObject.Properties["IPv4Options"]?.Value ?? default(uint)),
		 TransportTunnelCombined = (uint) (managementObject.Properties["TransportTunnelCombined"]?.Value ?? default(uint))
                };
        }
    }
}