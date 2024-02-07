using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.ISCSI
{
    /// <summary>
    /// </summary>
    public sealed class IscsiTcpipConfig
    {
		public bool Active { get; private set; }
		public dynamic AlternateDnsServer { get; private set; }
		public dynamic DefaultGateway { get; private set; }
		public bool EnableDhcp { get; private set; }
		public string InstanceName { get; private set; }
		public dynamic IpAddress { get; private set; }
		public uint IpVersions { get; private set; }
		public dynamic PreferredDnsServer { get; private set; }
		public dynamic SubnetMask { get; private set; }
		public bool UseDhcpForDns { get; private set; }
		public bool UseLinkLocalAddress { get; private set; }

        public static IEnumerable<IscsiTcpipConfig> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<IscsiTcpipConfig> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<IscsiTcpipConfig> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSiSCSI_TCPIPConfig");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new IscsiTcpipConfig
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 AlternateDnsServer = (dynamic) (managementObject.Properties["AlternateDNSServer"]?.Value ?? default(dynamic)),
		 DefaultGateway = (dynamic) (managementObject.Properties["DefaultGateway"]?.Value ?? default(dynamic)),
		 EnableDhcp = (bool) (managementObject.Properties["EnableDHCP"]?.Value ?? default(bool)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 IpAddress = (dynamic) (managementObject.Properties["IpAddress"]?.Value ?? default(dynamic)),
		 IpVersions = (uint) (managementObject.Properties["IPVersions"]?.Value ?? default(uint)),
		 PreferredDnsServer = (dynamic) (managementObject.Properties["PreferredDNSServer"]?.Value ?? default(dynamic)),
		 SubnetMask = (dynamic) (managementObject.Properties["SubnetMask"]?.Value ?? default(dynamic)),
		 UseDhcpForDns = (bool) (managementObject.Properties["UseDHCPForDNS"]?.Value ?? default(bool)),
		 UseLinkLocalAddress = (bool) (managementObject.Properties["UseLinkLocalAddress"]?.Value ?? default(bool))
                };
        }
    }
}