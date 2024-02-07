using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network
{
    /// <summary>
    /// </summary>
    public sealed class NicSwitchCapabilities
    {
		public uint Flags { get; private set; }
		public dynamic Header { get; private set; }
		public uint NdisReserved1 { get; private set; }
		public uint NdisReserved2 { get; private set; }
		public uint NdisReserved3 { get; private set; }
		public uint NumMacAddressesPerPort { get; private set; }
		public uint NumTotalMacAddresses { get; private set; }
		public uint NumVlansPerPort { get; private set; }

        public static IEnumerable<NicSwitchCapabilities> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<NicSwitchCapabilities> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<NicSwitchCapabilities> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_NicSwitchCapabilities");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new NicSwitchCapabilities
                {
                     Flags = (uint) (managementObject.Properties["Flags"]?.Value ?? default(uint)),
		 Header = (dynamic) (managementObject.Properties["Header"]?.Value ?? default(dynamic)),
		 NdisReserved1 = (uint) (managementObject.Properties["NdisReserved1"]?.Value ?? default(uint)),
		 NdisReserved2 = (uint) (managementObject.Properties["NdisReserved2"]?.Value ?? default(uint)),
		 NdisReserved3 = (uint) (managementObject.Properties["NdisReserved3"]?.Value ?? default(uint)),
		 NumMacAddressesPerPort = (uint) (managementObject.Properties["NumMacAddressesPerPort"]?.Value ?? default(uint)),
		 NumTotalMacAddresses = (uint) (managementObject.Properties["NumTotalMacAddresses"]?.Value ?? default(uint)),
		 NumVlansPerPort = (uint) (managementObject.Properties["NumVlansPerPort"]?.Value ?? default(uint))
                };
        }
    }
}