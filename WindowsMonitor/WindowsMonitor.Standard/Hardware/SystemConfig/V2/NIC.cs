using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.SystemConfig.V2
{
    /// <summary>
    /// </summary>
    public sealed class Nic
    {
		public string DnsServerAddresses { get; private set; }
		public uint Flags { get; private set; }
		public string IpAddresses { get; private set; }
		public uint Ipv4Index { get; private set; }
		public uint Ipv6Index { get; private set; }
		public string NicDescription { get; private set; }
		public ulong PhysicalAddr { get; private set; }
		public uint PhysicalAddrLen { get; private set; }

        public static IEnumerable<Nic> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<Nic> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<Nic> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM SystemConfig_V2_NIC");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new Nic
                {
                     DnsServerAddresses = (string) (managementObject.Properties["DnsServerAddresses"]?.Value ?? default(string)),
		 Flags = (uint) (managementObject.Properties["Flags"]?.Value ?? default(uint)),
		 IpAddresses = (string) (managementObject.Properties["IpAddresses"]?.Value ?? default(string)),
		 Ipv4Index = (uint) (managementObject.Properties["Ipv4Index"]?.Value ?? default(uint)),
		 Ipv6Index = (uint) (managementObject.Properties["Ipv6Index"]?.Value ?? default(uint)),
		 NicDescription = (string) (managementObject.Properties["NICDescription"]?.Value ?? default(string)),
		 PhysicalAddr = (ulong) (managementObject.Properties["PhysicalAddr"]?.Value ?? default(ulong)),
		 PhysicalAddrLen = (uint) (managementObject.Properties["PhysicalAddrLen"]?.Value ?? default(uint))
                };
        }
    }
}