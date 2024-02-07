using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Software.COM
{
    /// <summary>
    /// </summary>
    public sealed class CompatibleProduct
    {
		public string CompatibilityDescription { get; private set; }
		public string Name { get; private set; }
		public string Product { get; private set; }

        public static IEnumerable<CompatibleProduct> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<CompatibleProduct> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<CompatibleProduct> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_CompatibleProduct");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new CompatibleProduct
                {
                     CompatibilityDescription = (string) (managementObject.Properties["CompatibilityDescription"]?.Value),
		 Name = (string) (managementObject.Properties["CompatibleProduct"]?.Value ?? default(string)),
		 Product = (string) (managementObject.Properties["Product"]?.Value ?? default(string))
                };
        }
    }
}