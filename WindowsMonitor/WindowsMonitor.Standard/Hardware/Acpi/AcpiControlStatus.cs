using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Acpi
{
    /// <summary>
    /// </summary>
    public sealed class AcpiControlStatus
    {
		public dynamic Control { get; private set; }
		public dynamic Status { get; private set; }

        public static IEnumerable<AcpiControlStatus> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<AcpiControlStatus> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<AcpiControlStatus> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM AcpiControlStatus");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new AcpiControlStatus
                {
                     Control = (dynamic) (managementObject.Properties["Control"]?.Value ?? default(dynamic)),
		 Status = (dynamic) (managementObject.Properties["Status"]?.Value ?? default(dynamic))
                };
        }
    }
}