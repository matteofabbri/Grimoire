using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network
{
    /// <summary>
    /// </summary>
    public sealed class PortArray
    {
		public uint ElementSize { get; private set; }
		public dynamic Header { get; private set; }
		public uint NumberOfPorts { get; private set; }
		public uint OffsetFirstPort { get; private set; }
		public dynamic[] Port { get; private set; }

        public static IEnumerable<PortArray> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<PortArray> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<PortArray> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_PortArray");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new PortArray
                {
                     ElementSize = (uint) (managementObject.Properties["ElementSize"]?.Value ?? default(uint)),
		 Header = (dynamic) (managementObject.Properties["Header"]?.Value ?? default(dynamic)),
		 NumberOfPorts = (uint) (managementObject.Properties["NumberOfPorts"]?.Value ?? default(uint)),
		 OffsetFirstPort = (uint) (managementObject.Properties["OffsetFirstPort"]?.Value ?? default(uint)),
		 Port = (dynamic[]) (managementObject.Properties["Port"]?.Value ?? new dynamic[0])
                };
        }
    }
}