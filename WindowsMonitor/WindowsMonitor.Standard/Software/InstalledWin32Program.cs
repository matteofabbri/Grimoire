using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Software
{
    /// <summary>
    /// </summary>
    public sealed class InstalledWin32Program
    {
		public string Language { get; private set; }
		public string MsiPackageCode { get; private set; }
		public string MsiProductCode { get; private set; }
		public string Name { get; private set; }
		public string ProgramId { get; private set; }
		public string Vendor { get; private set; }
		public string Version { get; private set; }

        public static IEnumerable<InstalledWin32Program> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<InstalledWin32Program> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<InstalledWin32Program> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_InstalledWin32Program");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new InstalledWin32Program
                {
                     Language = (string) (managementObject.Properties["Language"]?.Value),
		 MsiPackageCode = (string) (managementObject.Properties["MsiPackageCode"]?.Value),
		 MsiProductCode = (string) (managementObject.Properties["MsiProductCode"]?.Value),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 ProgramId = (string) (managementObject.Properties["ProgramId"]?.Value),
		 Vendor = (string) (managementObject.Properties["Vendor"]?.Value),
		 Version = (string) (managementObject.Properties["Version"]?.Value)
                };
        }
    }
}