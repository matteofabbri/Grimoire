using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network.Wifi
{
    /// <summary>
    /// </summary>
    public sealed class NetworkTypesSupported
    {
		public bool Active { get; private set; }
		public string InstanceName { get; private set; }
		public dynamic[] Ndis80211NetworkTypes { get; private set; }
		public uint NumberOfItems { get; private set; }

        public static IEnumerable<NetworkTypesSupported> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<NetworkTypesSupported> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<NetworkTypesSupported> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_80211_NetworkTypesSupported");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new NetworkTypesSupported
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 Ndis80211NetworkTypes = (dynamic[]) (managementObject.Properties["Ndis80211NetworkTypes"]?.Value ?? new dynamic[0]),
		 NumberOfItems = (uint) (managementObject.Properties["NumberOfItems"]?.Value ?? default(uint))
                };
        }
    }
}