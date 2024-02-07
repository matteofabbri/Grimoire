using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network
{
    /// <summary>
    /// </summary>
    public sealed class MethodHeader
    {
		public dynamic Header { get; private set; }
		public ulong NetLuid { get; private set; }
		public uint Padding { get; private set; }
		public uint PortNumber { get; private set; }
		public ulong RequestId { get; private set; }
		public uint Timeout { get; private set; }

        public static IEnumerable<MethodHeader> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<MethodHeader> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<MethodHeader> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_WmiMethodHeader");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new MethodHeader
                {
                     Header = (dynamic) (managementObject.Properties["Header"]?.Value ?? default(dynamic)),
		 NetLuid = (ulong) (managementObject.Properties["NetLuid"]?.Value ?? default(ulong)),
		 Padding = (uint) (managementObject.Properties["Padding"]?.Value ?? default(uint)),
		 PortNumber = (uint) (managementObject.Properties["PortNumber"]?.Value ?? default(uint)),
		 RequestId = (ulong) (managementObject.Properties["RequestId"]?.Value ?? default(ulong)),
		 Timeout = (uint) (managementObject.Properties["Timeout"]?.Value ?? default(uint))
                };
        }
    }
}