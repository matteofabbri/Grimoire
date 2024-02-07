using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.ISCSI
{
    /// <summary>
    /// </summary>
    public sealed class IscsiSecurityCapabilities
    {
		public bool Active { get; private set; }
		public bool CertificatesSupported { get; private set; }
		public uint[] EncryptionAvailable { get; private set; }
		public uint EncryptionAvailableCount { get; private set; }
		public string InstanceName { get; private set; }
		public bool ProtectiScsiTraffic { get; private set; }
		public bool ProtectiSnsTraffic { get; private set; }

        public static IEnumerable<IscsiSecurityCapabilities> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<IscsiSecurityCapabilities> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<IscsiSecurityCapabilities> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSiSCSI_SecurityCapabilities");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new IscsiSecurityCapabilities
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 CertificatesSupported = (bool) (managementObject.Properties["CertificatesSupported"]?.Value ?? default(bool)),
		 EncryptionAvailable = (uint[]) (managementObject.Properties["EncryptionAvailable"]?.Value ?? new uint[0]),
		 EncryptionAvailableCount = (uint) (managementObject.Properties["EncryptionAvailableCount"]?.Value ?? default(uint)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 ProtectiScsiTraffic = (bool) (managementObject.Properties["ProtectiScsiTraffic"]?.Value ?? default(bool)),
		 ProtectiSnsTraffic = (bool) (managementObject.Properties["ProtectiSNSTraffic"]?.Value ?? default(bool))
                };
        }
    }
}