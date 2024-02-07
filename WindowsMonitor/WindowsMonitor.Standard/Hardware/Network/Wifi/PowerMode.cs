using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network.Wifi
{
    /// <summary>
    /// </summary>
    public sealed class PowerMode
    {
		public bool Active { get; private set; }
		public string InstanceName { get; private set; }
		public uint Ndis80211PowerMode { get; private set; }

        public static IEnumerable<PowerMode> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<PowerMode> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<PowerMode> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_80211_PowerMode");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new PowerMode
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 Ndis80211PowerMode = (uint) (managementObject.Properties["Ndis80211PowerMode"]?.Value ?? default(uint))
                };
        }
    }
}