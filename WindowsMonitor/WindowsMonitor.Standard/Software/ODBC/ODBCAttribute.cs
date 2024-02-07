using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Software.ODBC
{
    /// <summary>
    /// </summary>
    public sealed class OdbcAttribute
    {
		public string Attribute { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public string Driver { get; private set; }
		public string SettingId { get; private set; }
		public string Value { get; private set; }

        public static IEnumerable<OdbcAttribute> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<OdbcAttribute> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<OdbcAttribute> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_ODBCAttribute");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new OdbcAttribute
                {
                     Attribute = (string) (managementObject.Properties["Attribute"]?.Value),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 Driver = (string) (managementObject.Properties["Driver"]?.Value),
		 SettingId = (string) (managementObject.Properties["SettingID"]?.Value),
		 Value = (string) (managementObject.Properties["Value"]?.Value)
                };
        }
    }
}