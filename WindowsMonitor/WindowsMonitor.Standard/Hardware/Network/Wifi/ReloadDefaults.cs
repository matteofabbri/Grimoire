using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network.Wifi
{
    /// <summary>
    /// </summary>
    public sealed class ReloadDefaults
    {
		public bool Active { get; private set; }
		public string InstanceName { get; private set; }
		public uint Ndis80211ReloadDefaults { get; private set; }

        public static IEnumerable<ReloadDefaults> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ReloadDefaults> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ReloadDefaults> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_80211_ReloadDefaults");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ReloadDefaults
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 Ndis80211ReloadDefaults = (uint) (managementObject.Properties["Ndis80211ReloadDefaults"]?.Value ?? default(uint))
                };
        }
    }
}