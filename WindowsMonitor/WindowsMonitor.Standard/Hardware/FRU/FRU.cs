using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.FRU
{
    /// <summary>
    /// </summary>
    public sealed class Fru
    {
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public string FruNumber { get; private set; }
		public string IdentifyingNumber { get; private set; }
		public string Name { get; private set; }
		public string RevisionLevel { get; private set; }
		public string Vendor { get; private set; }

        public static IEnumerable<Fru> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<Fru> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<Fru> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_FRU");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new Fru
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FruNumber = (string) (managementObject.Properties["FRUNumber"]?.Value),
		 IdentifyingNumber = (string) (managementObject.Properties["IdentifyingNumber"]?.Value),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 RevisionLevel = (string) (managementObject.Properties["RevisionLevel"]?.Value),
		 Vendor = (string) (managementObject.Properties["Vendor"]?.Value)
                };
        }
    }
}