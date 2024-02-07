using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Registry
{
    /// <summary>
    /// </summary>
    public sealed class AddRemovePrograms
    {
		public string DisplayName { get; private set; }
		public string InstallDate { get; private set; }
		public string ProdId { get; private set; }
		public string Publisher { get; private set; }
		public string Version { get; private set; }

        public static IEnumerable<AddRemovePrograms> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<AddRemovePrograms> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<AddRemovePrograms> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32Reg_AddRemovePrograms");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new AddRemovePrograms
                {
                     DisplayName = (string) (managementObject.Properties["DisplayName"]?.Value),
		 InstallDate = (string) (managementObject.Properties["InstallDate"]?.Value),
		 ProdId = (string) (managementObject.Properties["ProdID"]?.Value),
		 Publisher = (string) (managementObject.Properties["Publisher"]?.Value),
		 Version = (string) (managementObject.Properties["Version"]?.Value)
                };
        }
    }
}