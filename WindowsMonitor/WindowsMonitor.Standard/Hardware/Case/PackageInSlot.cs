using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Case
{
    /// <summary>
    /// </summary>
    public sealed class PackageInSlot
    {
		public string Antecedent { get; private set; }
		public string Dependent { get; private set; }

        public static IEnumerable<PackageInSlot> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<PackageInSlot> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<PackageInSlot> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_PackageInSlot");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new PackageInSlot
                {
                     Antecedent =  (managementObject.Properties["Antecedent"]?.Value?.ToString()),
		 Dependent =  (managementObject.Properties["Dependent"]?.Value?.ToString())
                };
        }
    }
}