using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.ISCSI
{
    /// <summary>
    /// </summary>
    public sealed class IscsiIpAddress
    {
		public uint IpV4Address { get; private set; }
		public byte[] IpV6Address { get; private set; }
		public uint IpV6FlowInfo { get; private set; }
		public uint IpV6ScopeId { get; private set; }
		public string TextAddress { get; private set; }
		public uint Type { get; private set; }

        public static IEnumerable<IscsiIpAddress> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<IscsiIpAddress> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<IscsiIpAddress> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM ISCSI_IP_Address");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new IscsiIpAddress
                {
                     IpV4Address = (uint) (managementObject.Properties["IpV4Address"]?.Value ?? default(uint)),
		 IpV6Address = (byte[]) (managementObject.Properties["IpV6Address"]?.Value ?? new byte[0]),
		 IpV6FlowInfo = (uint) (managementObject.Properties["IpV6FlowInfo"]?.Value ?? default(uint)),
		 IpV6ScopeId = (uint) (managementObject.Properties["IpV6ScopeId"]?.Value ?? default(uint)),
		 TextAddress = (string) (managementObject.Properties["TextAddress"]?.Value ?? default(string)),
		 Type = (uint) (managementObject.Properties["Type"]?.Value ?? default(uint))
                };
        }
    }
}