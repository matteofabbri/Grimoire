using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Kerberos
{
    /// <summary>
    /// </summary>
    public sealed class KerbLogonUser
    {
		public string LogonDomain { get; private set; }
		public string LogonType { get; private set; }
		public uint Status { get; private set; }
		public string UserName { get; private set; }

        public static IEnumerable<KerbLogonUser> Retrieve(string remote, string username, string password)
        {
            var options = new ConnectionOptions
            {
                Impersonation = ImpersonationLevel.Impersonate,
                Username = username,
                Password = password
            };

            var managementScope = new ManagementScope(new ManagementPath($"\\\\{remote}\\root\\wmi"), options);
            managementScope.Connect();

            return Retrieve(managementScope);
        }

        public static IEnumerable<KerbLogonUser> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<KerbLogonUser> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM KerbLogonUser_End");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new KerbLogonUser
                {
                     LogonDomain = (string) (managementObject.Properties["LogonDomain"]?.Value ?? default(string)),
		 LogonType = (string) (managementObject.Properties["LogonType"]?.Value ?? default(string)),
		 Status = (uint) (managementObject.Properties["Status"]?.Value ?? default(uint)),
		 UserName = (string) (managementObject.Properties["UserName"]?.Value ?? default(string))
                };
        }
    }
}