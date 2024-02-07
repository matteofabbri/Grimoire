using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Software
{
    /// <summary>
    /// </summary>
    public sealed class ProductSoftwareFeatures
    {
		public string Component { get; private set; }
		public string Product { get; private set; }

        public static IEnumerable<ProductSoftwareFeatures> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ProductSoftwareFeatures> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ProductSoftwareFeatures> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_ProductSoftwareFeatures");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ProductSoftwareFeatures
                {
                     Component =  (managementObject.Properties["Component"]?.Value?.ToString()),
		 Product =  (managementObject.Properties["Product"]?.Value?.ToString())
                };
        }
    }
}