using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network.Atm
{
    /// <summary>
    /// </summary>
    public sealed class AtmSupportedAalTypes
    {
		public bool Active { get; private set; }
		public string InstanceName { get; private set; }
		public uint NdisAtmSupportedAalTypes { get; private set; }

        public static IEnumerable<AtmSupportedAalTypes> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<AtmSupportedAalTypes> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<AtmSupportedAalTypes> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_AtmSupportedAalTypes");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new AtmSupportedAalTypes
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 NdisAtmSupportedAalTypes = (uint) (managementObject.Properties["NdisAtmSupportedAalTypes"]?.Value ?? default(uint))
                };
        }
    }
}