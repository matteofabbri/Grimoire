using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows
{
    /// <summary>
    /// </summary>
    public sealed class SoftwareElementChecks
    {
		public string Check { get; private set; }
		public string Element { get; private set; }
		public ushort Phase { get; private set; }

        public static IEnumerable<SoftwareElementChecks> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SoftwareElementChecks> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SoftwareElementChecks> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_SoftwareElementChecks");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SoftwareElementChecks
                {
                     Check =  (managementObject.Properties["Check"]?.Value?.ToString()),
		 Element =  (managementObject.Properties["Element"]?.Value?.ToString()),
		 Phase = (ushort) (managementObject.Properties["Phase"]?.Value ?? default(ushort))
                };
        }
    }
}