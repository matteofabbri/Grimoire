using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows
{
    /// <summary>
    /// </summary>
    public sealed class Export
    {
		public string Directory { get; private set; }
		public string ExportedDirectoryName { get; private set; }
		public string LocalFs { get; private set; }

        public static IEnumerable<Export> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<Export> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<Export> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_Export");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new Export
                {
                     Directory =  (managementObject.Properties["Directory"]?.Value?.ToString()),
		 ExportedDirectoryName = (string) (managementObject.Properties["ExportedDirectoryName"]?.Value),
		 LocalFs =  (managementObject.Properties["LocalFS"]?.Value?.ToString())
                };
        }
    }
}