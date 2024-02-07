using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.FRU
{
    /// <summary>
    /// </summary>
    public sealed class ProductFru
    {
		public string Fru { get; private set; }
		public string Product { get; private set; }

        public static IEnumerable<ProductFru> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ProductFru> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ProductFru> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_ProductFRU");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ProductFru
                {
                     Fru =  (managementObject.Properties["FRU"]?.Value?.ToString()),
		 Product =  (managementObject.Properties["Product"]?.Value?.ToString())
                };
        }
    }
}