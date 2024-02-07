using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.FRU
{
    /// <summary>
    /// </summary>
    public sealed class FruIncludesProduct
    {
		public string Component { get; private set; }
		public string Fru { get; private set; }

        public static IEnumerable<FruIncludesProduct> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<FruIncludesProduct> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<FruIncludesProduct> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_FRUIncludesProduct");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new FruIncludesProduct
                {
                     Component =  (managementObject.Properties["Component"]?.Value?.ToString()),
		 Fru =  (managementObject.Properties["FRU"]?.Value?.ToString())
                };
        }
    }
}