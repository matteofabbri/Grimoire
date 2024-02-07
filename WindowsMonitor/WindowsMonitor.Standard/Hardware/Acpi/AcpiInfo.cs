using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware
{
    /// <summary>
    /// </summary>
    public sealed class AcpiInfo
    {
		public bool Active { get; private set; }
		public uint BootArchitecture { get; private set; }
		public uint Capabilities { get; private set; }
		public string InstanceName { get; private set; }
		public uint PreferredProfile { get; private set; }

        public static IEnumerable<AcpiInfo> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<AcpiInfo> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<AcpiInfo> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSAcpiInfo");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new AcpiInfo
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 BootArchitecture = (uint) (managementObject.Properties["BootArchitecture"]?.Value ?? default(uint)),
		 Capabilities = (uint) (managementObject.Properties["Capabilities"]?.Value ?? default(uint)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 PreferredProfile = (uint) (managementObject.Properties["PreferredProfile"]?.Value ?? default(uint))
                };
        }
    }
}