using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.SystemConfig
{
    /// <summary>
    /// </summary>
    public sealed class SystemConfigV4PnP
    {
		public dynamic ClassGuid { get; private set; }
		public string DeviceDescription { get; private set; }
		public string DeviceId { get; private set; }
		public uint Flags { get; private set; }
		public string FriendlyName { get; private set; }
		public string[] LowerFilters { get; private set; }
		public uint LowerFiltersCount { get; private set; }
		public string PdoName { get; private set; }
		public string ServiceName { get; private set; }
		public string[] UpperFilters { get; private set; }
		public uint UpperFiltersCount { get; private set; }

        public static IEnumerable<SystemConfigV4PnP> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SystemConfigV4PnP> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SystemConfigV4PnP> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM SystemConfig_V4_PnP");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SystemConfigV4PnP
                {
                     ClassGuid = (dynamic) (managementObject.Properties["ClassGuid"]?.Value ?? default(dynamic)),
		 DeviceDescription = (string) (managementObject.Properties["DeviceDescription"]?.Value ?? default(string)),
		 DeviceId = (string) (managementObject.Properties["DeviceID"]?.Value ?? default(string)),
		 Flags = (uint) (managementObject.Properties["Flags"]?.Value ?? default(uint)),
		 FriendlyName = (string) (managementObject.Properties["FriendlyName"]?.Value ?? default(string)),
		 LowerFilters = (string[]) (managementObject.Properties["LowerFilters"]?.Value ?? new string[0]),
		 LowerFiltersCount = (uint) (managementObject.Properties["LowerFiltersCount"]?.Value ?? default(uint)),
		 PdoName = (string) (managementObject.Properties["PdoName"]?.Value ?? default(string)),
		 ServiceName = (string) (managementObject.Properties["ServiceName"]?.Value ?? default(string)),
		 UpperFilters = (string[]) (managementObject.Properties["UpperFilters"]?.Value ?? new string[0]),
		 UpperFiltersCount = (uint) (managementObject.Properties["UpperFiltersCount"]?.Value ?? default(uint))
                };
        }
    }
}