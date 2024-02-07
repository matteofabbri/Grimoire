using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Sensors
{
    /// <summary>
    /// </summary>
    public sealed class PackageTempSensor
    {
        public string Antecedent { get; private set; }
        public string Dependent { get; private set; }

        public static IEnumerable<PackageTempSensor> Retrieve(string remote, string username, string password)
        {
            var options = new ConnectionOptions
            {
                Impersonation = ImpersonationLevel.Impersonate,
                Username = username,
                Password = password
            };

            var managementScope = new ManagementScope(new ManagementPath($"\\\\{remote}\\root\\cimv2"), options);
            managementScope.Connect();

            return Retrieve(managementScope);
        }

        public static IEnumerable<PackageTempSensor> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<PackageTempSensor> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_PackageTempSensor");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new PackageTempSensor
                {
                    Antecedent = managementObject.Properties["Antecedent"]?.Value?.ToString(),
                    Dependent = managementObject.Properties["Dependent"]?.Value?.ToString()
                };
        }
    }
}