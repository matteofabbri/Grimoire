using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.HBA.Msfc
{
    /// <summary>
    /// </summary>
    public sealed class NpivlunMappingInformation
    {
		public bool Active { get; private set; }
		public string InstanceName { get; private set; }
		public byte OsBus { get; private set; }
		public byte Oslun { get; private set; }
		public byte OsTarget { get; private set; }
		public byte[] WwpnPhysicalPort { get; private set; }
		public byte[] WwpnVirtualPort { get; private set; }

        public static IEnumerable<NpivlunMappingInformation> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<NpivlunMappingInformation> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<NpivlunMappingInformation> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSFC_NPIVLUNMappingInformation");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new NpivlunMappingInformation
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 OsBus = (byte) (managementObject.Properties["OSBus"]?.Value ?? default(byte)),
		 Oslun = (byte) (managementObject.Properties["OSLUN"]?.Value ?? default(byte)),
		 OsTarget = (byte) (managementObject.Properties["OSTarget"]?.Value ?? default(byte)),
		 WwpnPhysicalPort = (byte[]) (managementObject.Properties["WWPNPhysicalPort"]?.Value ?? new byte[0]),
		 WwpnVirtualPort = (byte[]) (managementObject.Properties["WWPNVirtualPort"]?.Value ?? new byte[0])
                };
        }
    }
}