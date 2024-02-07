using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.HBA
{
    /// <summary>
    /// </summary>
    public sealed class HbafcpBindingEntry
    {
		public dynamic FcpId { get; private set; }
		public dynamic ScsiId { get; private set; }
		public uint Type { get; private set; }

        public static IEnumerable<HbafcpBindingEntry> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HbafcpBindingEntry> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HbafcpBindingEntry> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HBAFCPBindingEntry");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HbafcpBindingEntry
                {
                     FcpId = (dynamic) (managementObject.Properties["FCPId"]?.Value ?? default(dynamic)),
		 ScsiId = (dynamic) (managementObject.Properties["ScsiId"]?.Value ?? default(dynamic)),
		 Type = (uint) (managementObject.Properties["Type"]?.Value ?? default(uint))
                };
        }
    }
}