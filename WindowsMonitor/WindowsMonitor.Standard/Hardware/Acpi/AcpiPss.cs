using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Acpi
{
    /// <summary>
    /// </summary>
    public sealed class AcpiPss
    {
		public uint Count { get; private set; }
		public dynamic[] State { get; private set; }

        public static IEnumerable<AcpiPss> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<AcpiPss> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<AcpiPss> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM AcpiPss");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new AcpiPss
                {
                     Count = (uint) (managementObject.Properties["Count"]?.Value ?? default(uint)),
		 State = (dynamic[]) (managementObject.Properties["State"]?.Value ?? new dynamic[0])
                };
        }
    }
}