using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network
{
    /// <summary>
    /// </summary>
    public sealed class WmiHdSplitCurrentConfig
    {
		public uint BackfillSize { get; private set; }
		public uint CurrentCapabilities { get; private set; }
		public uint HardwareCapabilities { get; private set; }
		public uint HdSplitCombineFlags { get; private set; }
		public uint HdSplitFlags { get; private set; }
		public dynamic Header { get; private set; }
		public uint MaxHeaderSize { get; private set; }

        public static IEnumerable<WmiHdSplitCurrentConfig> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<WmiHdSplitCurrentConfig> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<WmiHdSplitCurrentConfig> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_WmiHDSplitCurrentConfig");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new WmiHdSplitCurrentConfig
                {
                     BackfillSize = (uint) (managementObject.Properties["BackfillSize"]?.Value ?? default(uint)),
		 CurrentCapabilities = (uint) (managementObject.Properties["CurrentCapabilities"]?.Value ?? default(uint)),
		 HardwareCapabilities = (uint) (managementObject.Properties["HardwareCapabilities"]?.Value ?? default(uint)),
		 HdSplitCombineFlags = (uint) (managementObject.Properties["HDSplitCombineFlags"]?.Value ?? default(uint)),
		 HdSplitFlags = (uint) (managementObject.Properties["HDSplitFlags"]?.Value ?? default(uint)),
		 Header = (dynamic) (managementObject.Properties["Header"]?.Value ?? default(dynamic)),
		 MaxHeaderSize = (uint) (managementObject.Properties["MaxHeaderSize"]?.Value ?? default(uint))
                };
        }
    }
}