using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Jobs
{
    /// <summary>
    /// </summary>
    public sealed class NamedJobObjectSecLimit
    {
		public string Collection { get; private set; }
		public string Setting { get; private set; }

        public static IEnumerable<NamedJobObjectSecLimit> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<NamedJobObjectSecLimit> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<NamedJobObjectSecLimit> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_NamedJobObjectSecLimit");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new NamedJobObjectSecLimit
                {
                     Collection =  (managementObject.Properties["Collection"]?.Value?.ToString()),
		 Setting =  (managementObject.Properties["Setting"]?.Value?.ToString())
                };
        }
    }
}