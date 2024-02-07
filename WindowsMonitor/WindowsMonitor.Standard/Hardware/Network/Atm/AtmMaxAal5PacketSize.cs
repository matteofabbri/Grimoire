using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network.Atm
{
    /// <summary>
    /// </summary>
    public sealed class AtmMaxAal5PacketSize
    {
		public bool Active { get; private set; }
		public string InstanceName { get; private set; }
		public uint NdisAtmMaxAal5PacketSize { get; private set; }

        public static IEnumerable<AtmMaxAal5PacketSize> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<AtmMaxAal5PacketSize> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<AtmMaxAal5PacketSize> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_AtmMaxAal5PacketSize");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new AtmMaxAal5PacketSize
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 NdisAtmMaxAal5PacketSize = (uint) (managementObject.Properties["NdisAtmMaxAal5PacketSize"]?.Value ?? default(uint))
                };
        }
    }
}