using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.HBA.Msfc
{
    /// <summary>
    /// </summary>
    public sealed class FibrePortNpivAttributes
    {
		public bool Active { get; private set; }
		public string InstanceName { get; private set; }
		public uint NumberVirtualPorts { get; private set; }
		public dynamic[] VirtualPorts { get; private set; }
		public byte[] Wwnn { get; private set; }
		public byte[] Wwpn { get; private set; }

        public static IEnumerable<FibrePortNpivAttributes> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<FibrePortNpivAttributes> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<FibrePortNpivAttributes> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSFC_FibrePortNPIVAttributes");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new FibrePortNpivAttributes
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 NumberVirtualPorts = (uint) (managementObject.Properties["NumberVirtualPorts"]?.Value ?? default(uint)),
		 VirtualPorts = (dynamic[]) (managementObject.Properties["VirtualPorts"]?.Value ?? new dynamic[0]),
		 Wwnn = (byte[]) (managementObject.Properties["WWNN"]?.Value ?? new byte[0]),
		 Wwpn = (byte[]) (managementObject.Properties["WWPN"]?.Value ?? new byte[0])
                };
        }
    }
}