using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.Logicals
{
    /// <summary>
    /// </summary>
    public sealed class LogicalFileAccess
    {
		public uint AccessMask { get; private set; }
		public string GuidInheritedObjectType { get; private set; }
		public string GuidObjectType { get; private set; }
		public uint Inheritance { get; private set; }
		public string SecuritySetting { get; private set; }
		public string Trustee { get; private set; }
		public uint Type { get; private set; }

        public static IEnumerable<LogicalFileAccess> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<LogicalFileAccess> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<LogicalFileAccess> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_LogicalFileAccess");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new LogicalFileAccess
                {
                     AccessMask = (uint) (managementObject.Properties["AccessMask"]?.Value ?? default(uint)),
		 GuidInheritedObjectType = (string) (managementObject.Properties["GuidInheritedObjectType"]?.Value),
		 GuidObjectType = (string) (managementObject.Properties["GuidObjectType"]?.Value),
		 Inheritance = (uint) (managementObject.Properties["Inheritance"]?.Value ?? default(uint)),
		 SecuritySetting =  (managementObject.Properties["SecuritySetting"]?.Value?.ToString()),
		 Trustee =  (managementObject.Properties["Trustee"]?.Value?.ToString()),
		 Type = (uint) (managementObject.Properties["Type"]?.Value ?? default(uint))
                };
        }
    }
}