using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network.Wifi
{
    /// <summary>
    /// </summary>
    public sealed class ConfigurationInfo
    {
		public uint AtimWindow { get; private set; }
		public uint BeaconPeriod { get; private set; }
		public uint ConfigLength { get; private set; }
		public uint DsConfig { get; private set; }
		public dynamic FhConfig { get; private set; }

        public static IEnumerable<ConfigurationInfo> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ConfigurationInfo> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ConfigurationInfo> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_80211_ConfigurationInfo");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ConfigurationInfo
                {
                     AtimWindow = (uint) (managementObject.Properties["ATIMWindow"]?.Value ?? default(uint)),
		 BeaconPeriod = (uint) (managementObject.Properties["BeaconPeriod"]?.Value ?? default(uint)),
		 ConfigLength = (uint) (managementObject.Properties["ConfigLength"]?.Value ?? default(uint)),
		 DsConfig = (uint) (managementObject.Properties["DSConfig"]?.Value ?? default(uint)),
		 FhConfig = (dynamic) (managementObject.Properties["FHConfig"]?.Value ?? default(dynamic))
                };
        }
    }
}