using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.SystemConfig
{
    /// <summary>
    /// </summary>
    public sealed class SystemConfigPnP
    {
		public dynamic ClassGuid { get; private set; }
		public string DeviceDescription { get; private set; }
		public string DeviceId { get; private set; }
		public uint DevProblem { get; private set; }
		public uint DevStatus { get; private set; }
		public uint Flags { get; private set; }
		public string FriendlyName { get; private set; }
		public string[] LowerFilters { get; private set; }
		public uint LowerFiltersCount { get; private set; }
		public string PdoName { get; private set; }
		public string ServiceName { get; private set; }
		public string[] UpperFilters { get; private set; }
		public uint UpperFiltersCount { get; private set; }

        public static IEnumerable<SystemConfigPnP> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SystemConfigPnP> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SystemConfigPnP> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM SystemConfig_PnP");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SystemConfigPnP
                {
                     ClassGuid = (dynamic) (managementObject.Properties["ClassGuid"]?.Value ?? default(dynamic)),
		 DeviceDescription = (string) (managementObject.Properties["DeviceDescription"]?.Value ?? default(string)),
		 DeviceId = (string) (managementObject.Properties["DeviceID"]?.Value ?? default(string)),
		 DevProblem = (uint) (managementObject.Properties["DevProblem"]?.Value ?? default(uint)),
		 DevStatus = (uint) (managementObject.Properties["DevStatus"]?.Value ?? default(uint)),
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