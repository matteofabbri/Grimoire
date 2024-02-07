using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Software.ODBC
{
    /// <summary>
    /// </summary>
    public sealed class OdbcDriverSoftwareElement
    {
		public string Check { get; private set; }
		public string Element { get; private set; }
		public ushort Phase { get; private set; }

        public static IEnumerable<OdbcDriverSoftwareElement> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<OdbcDriverSoftwareElement> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<OdbcDriverSoftwareElement> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_ODBCDriverSoftwareElement");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new OdbcDriverSoftwareElement
                {
                     Check =  (managementObject.Properties["Check"]?.Value?.ToString()),
		 Element =  (managementObject.Properties["Element"]?.Value?.ToString()),
		 Phase = (ushort) (managementObject.Properties["Phase"]?.Value ?? default(ushort))
                };
        }
    }
}