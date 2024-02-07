using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network.Atm
{
    /// <summary>
    /// </summary>
    public sealed class AtmMaxActiveVcs
    {
		public bool Active { get; private set; }
		public string InstanceName { get; private set; }
		public uint NdisAtmMaxActiveVcs { get; private set; }

        public static IEnumerable<AtmMaxActiveVcs> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<AtmMaxActiveVcs> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<AtmMaxActiveVcs> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_AtmMaxActiveVcs");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new AtmMaxActiveVcs
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 NdisAtmMaxActiveVcs = (uint) (managementObject.Properties["NdisAtmMaxActiveVcs"]?.Value ?? default(uint))
                };
        }
    }
}