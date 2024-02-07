using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware
{
    /// <summary>
    /// </summary>
    public sealed class Win32ComputerSystemProduct
    {
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public string IdentifyingNumber { get; private set; }
		public string Name { get; private set; }
		public string SkuNumber { get; private set; }
		public string Uuid { get; private set; }
		public string Vendor { get; private set; }
		public string Version { get; private set; }

        public static IEnumerable<Win32ComputerSystemProduct> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<Win32ComputerSystemProduct> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<Win32ComputerSystemProduct> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_ComputerSystemProduct");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new Win32ComputerSystemProduct
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 IdentifyingNumber = (string) (managementObject.Properties["IdentifyingNumber"]?.Value),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 SkuNumber = (string) (managementObject.Properties["SKUNumber"]?.Value),
		 Uuid = (string) (managementObject.Properties["UUID"]?.Value),
		 Vendor = (string) (managementObject.Properties["Vendor"]?.Value),
		 Version = (string) (managementObject.Properties["Version"]?.Value)
                };
        }
    }
}