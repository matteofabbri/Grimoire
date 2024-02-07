using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network.Wifi
{
    /// <summary>
    /// </summary>
    public sealed class ConfigurationFh
    {
		public uint DwellTime { get; private set; }
		public uint FhLength { get; private set; }
		public uint HopPattern { get; private set; }
		public uint HopSet { get; private set; }

        public static IEnumerable<ConfigurationFh> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ConfigurationFh> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ConfigurationFh> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_80211_ConfigurationFH");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ConfigurationFh
                {
                     DwellTime = (uint) (managementObject.Properties["DwellTime"]?.Value ?? default(uint)),
		 FhLength = (uint) (managementObject.Properties["FHLength"]?.Value ?? default(uint)),
		 HopPattern = (uint) (managementObject.Properties["HopPattern"]?.Value ?? default(uint)),
		 HopSet = (uint) (managementObject.Properties["HopSet"]?.Value ?? default(uint))
                };
        }
    }
}