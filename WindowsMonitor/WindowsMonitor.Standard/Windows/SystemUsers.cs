using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows
{
    /// <summary>
    /// </summary>
    public sealed class SystemUsers
    {
		public string GroupComponent { get; private set; }
		public string PartComponent { get; private set; }

        public static IEnumerable<SystemUsers> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SystemUsers> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SystemUsers> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_SystemUsers");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SystemUsers
                {
                     GroupComponent = (string) (managementObject.Properties["GroupComponent"]?.Value ?? default(string)),
		 PartComponent = (string) (managementObject.Properties["PartComponent"]?.Value ?? default(string))
                };
        }
    }
}