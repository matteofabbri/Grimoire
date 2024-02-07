using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Drives.Win32DiskDrives
{
    /// <summary>
    /// </summary>
    public sealed class Win32DiskDrivePhysicalMedia
    {
		public string Antecedent { get; private set; }
		public string Dependent { get; private set; }

        public static IEnumerable<Win32DiskDrivePhysicalMedia> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<Win32DiskDrivePhysicalMedia> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<Win32DiskDrivePhysicalMedia> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_DiskDrivePhysicalMedia");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
            {
                var media = new Win32DiskDrivePhysicalMedia
                {
                    Antecedent = managementObject.Properties["Antecedent"]?.Value as string,
                    Dependent = managementObject.Properties["Dependent"]?.Value as string
                };
                yield return media;
            }
        }
    }
}