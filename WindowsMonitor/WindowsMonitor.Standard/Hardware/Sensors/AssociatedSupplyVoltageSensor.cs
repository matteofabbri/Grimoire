using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Sensors
{
    /// <summary>
    /// </summary>
    public sealed class AssociatedSupplyVoltageSensor
    {
		public string Antecedent { get; private set; }
		public string Dependent { get; private set; }
		public ushort MonitoringRange { get; private set; }

        public static IEnumerable<AssociatedSupplyVoltageSensor> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<AssociatedSupplyVoltageSensor> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<AssociatedSupplyVoltageSensor> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_AssociatedSupplyVoltageSensor");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new AssociatedSupplyVoltageSensor
                {
                     Antecedent = (string) (managementObject.Properties["Antecedent"]?.Value ?? default(string)),
		 Dependent = (string) (managementObject.Properties["Dependent"]?.Value ?? default(string)),
		 MonitoringRange = (ushort) (managementObject.Properties["MonitoringRange"]?.Value ?? default(ushort))
                };
        }
    }
}