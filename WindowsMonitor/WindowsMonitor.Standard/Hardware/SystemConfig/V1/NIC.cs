using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.SystemConfig.V1
{
    /// <summary>
    /// </summary>
    public sealed class Nic
    {
		public uint Data { get; private set; }
		public int DhcpServer { get; private set; }
		public int DnsServer1 { get; private set; }
		public int DnsServer2 { get; private set; }
		public int DnsServer3 { get; private set; }
		public int DnsServer4 { get; private set; }
		public uint Flags { get; private set; }
		public int Gateway { get; private set; }
		public uint Index { get; private set; }
		public int IpAddress { get; private set; }
		public char[] NicName { get; private set; }
		public char[] PhysicalAddr { get; private set; }
		public uint PhysicalAddrLen { get; private set; }
		public int PrimaryWinsServer { get; private set; }
		public int SecondaryWinsServer { get; private set; }
		public uint Size { get; private set; }
		public int SubnetMask { get; private set; }

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
            var objectQuery = new ObjectQuery("SELECT * FROM SystemConfig_V1_NIC");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new Nic
                {
                     Data = (uint) (managementObject.Properties["Data"]?.Value ?? default(uint)),
		 DhcpServer = (int) (managementObject.Properties["DhcpServer"]?.Value ?? default(int)),
		 DnsServer1 = (int) (managementObject.Properties["DnsServer1"]?.Value ?? default(int)),
		 DnsServer2 = (int) (managementObject.Properties["DnsServer2"]?.Value ?? default(int)),
		 DnsServer3 = (int) (managementObject.Properties["DnsServer3"]?.Value ?? default(int)),
		 DnsServer4 = (int) (managementObject.Properties["DnsServer4"]?.Value ?? default(int)),
		 Flags = (uint) (managementObject.Properties["Flags"]?.Value ?? default(uint)),
		 Gateway = (int) (managementObject.Properties["Gateway"]?.Value ?? default(int)),
		 Index = (uint) (managementObject.Properties["Index"]?.Value ?? default(uint)),
		 IpAddress = (int) (managementObject.Properties["IpAddress"]?.Value ?? default(int)),
		 NicName = (char[]) (managementObject.Properties["NICName"]?.Value ?? new char[0]),
		 PhysicalAddr = (char[]) (managementObject.Properties["PhysicalAddr"]?.Value ?? new char[0]),
		 PhysicalAddrLen = (uint) (managementObject.Properties["PhysicalAddrLen"]?.Value ?? default(uint)),
		 PrimaryWinsServer = (int) (managementObject.Properties["PrimaryWinsServer"]?.Value ?? default(int)),
		 SecondaryWinsServer = (int) (managementObject.Properties["SecondaryWinsServer"]?.Value ?? default(int)),
		 Size = (uint) (managementObject.Properties["Size"]?.Value ?? default(uint)),
		 SubnetMask = (int) (managementObject.Properties["SubnetMask"]?.Value ?? default(int))
                };
        }
    }
}