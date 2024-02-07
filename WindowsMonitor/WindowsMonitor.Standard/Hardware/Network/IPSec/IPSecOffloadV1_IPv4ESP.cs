using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network.IPSec
{
    /// <summary>
    /// </summary>
    public sealed class IpSecOffloadV1IPv4Esp
    {
		public uint Des { get; private set; }
		public uint NullEsp { get; private set; }
		public uint Receive { get; private set; }
		public uint Reserved { get; private set; }
		public uint Send { get; private set; }
		public uint Transport { get; private set; }
		public uint TripleDes { get; private set; }
		public uint Tunnel { get; private set; }

        public static IEnumerable<IpSecOffloadV1IPv4Esp> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<IpSecOffloadV1IPv4Esp> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<IpSecOffloadV1IPv4Esp> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_WmiIPSecOffloadV1_IPv4ESP");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new IpSecOffloadV1IPv4Esp
                {
                     Des = (uint) (managementObject.Properties["Des"]?.Value ?? default(uint)),
		 NullEsp = (uint) (managementObject.Properties["NullEsp"]?.Value ?? default(uint)),
		 Receive = (uint) (managementObject.Properties["Receive"]?.Value ?? default(uint)),
		 Reserved = (uint) (managementObject.Properties["Reserved"]?.Value ?? default(uint)),
		 Send = (uint) (managementObject.Properties["Send"]?.Value ?? default(uint)),
		 Transport = (uint) (managementObject.Properties["Transport"]?.Value ?? default(uint)),
		 TripleDes = (uint) (managementObject.Properties["TripleDes"]?.Value ?? default(uint)),
		 Tunnel = (uint) (managementObject.Properties["Tunnel"]?.Value ?? default(uint))
                };
        }
    }
}