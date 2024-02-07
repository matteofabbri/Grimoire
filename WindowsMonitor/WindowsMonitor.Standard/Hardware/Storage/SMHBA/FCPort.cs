using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.SMHBA
{
    /// <summary>
    /// </summary>
    public sealed class FcPort
    {
		public byte[] FabricName { get; private set; }
		public uint FcId { get; private set; }
		public byte[] NodeWwn { get; private set; }
		public uint NumberofDiscoveredPorts { get; private set; }
		public byte NumberofPhys { get; private set; }
		public byte[] PortActiveFc4Types { get; private set; }
		public uint PortSupportedClassofService { get; private set; }
		public byte[] PortSupportedFc4Types { get; private set; }
		public string PortSymbolicName { get; private set; }
		public byte[] PortWwn { get; private set; }

        public static IEnumerable<FcPort> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<FcPort> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<FcPort> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MS_SMHBA_FC_Port");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new FcPort
                {
                     FabricName = (byte[]) (managementObject.Properties["FabricName"]?.Value ?? new byte[0]),
		 FcId = (uint) (managementObject.Properties["FcId"]?.Value ?? default(uint)),
		 NodeWwn = (byte[]) (managementObject.Properties["NodeWWN"]?.Value ?? new byte[0]),
		 NumberofDiscoveredPorts = (uint) (managementObject.Properties["NumberofDiscoveredPorts"]?.Value ?? default(uint)),
		 NumberofPhys = (byte) (managementObject.Properties["NumberofPhys"]?.Value ?? default(byte)),
		 PortActiveFc4Types = (byte[]) (managementObject.Properties["PortActiveFc4Types"]?.Value ?? new byte[0]),
		 PortSupportedClassofService = (uint) (managementObject.Properties["PortSupportedClassofService"]?.Value ?? default(uint)),
		 PortSupportedFc4Types = (byte[]) (managementObject.Properties["PortSupportedFc4Types"]?.Value ?? new byte[0]),
		 PortSymbolicName = (string) (managementObject.Properties["PortSymbolicName"]?.Value ?? default(string)),
		 PortWwn = (byte[]) (managementObject.Properties["PortWWN"]?.Value ?? new byte[0])
                };
        }
    }
}