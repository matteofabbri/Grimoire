using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.SMHBA
{
    /// <summary>
    /// </summary>
    public sealed class SasPort
    {
		public byte[] AttachedSasAddress { get; private set; }
		public byte[] LocalSasAddress { get; private set; }
		public uint NumberofDiscoveredPorts { get; private set; }
		public uint NumberofPhys { get; private set; }
		public uint PortProtocol { get; private set; }

        public static IEnumerable<SasPort> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SasPort> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SasPort> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MS_SMHBA_SAS_Port");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SasPort
                {
                     AttachedSasAddress = (byte[]) (managementObject.Properties["AttachedSASAddress"]?.Value ?? new byte[0]),
		 LocalSasAddress = (byte[]) (managementObject.Properties["LocalSASAddress"]?.Value ?? new byte[0]),
		 NumberofDiscoveredPorts = (uint) (managementObject.Properties["NumberofDiscoveredPorts"]?.Value ?? default(uint)),
		 NumberofPhys = (uint) (managementObject.Properties["NumberofPhys"]?.Value ?? default(uint)),
		 PortProtocol = (uint) (managementObject.Properties["PortProtocol"]?.Value ?? default(uint))
                };
        }
    }
}