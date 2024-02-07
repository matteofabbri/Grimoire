using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Kerberos
{
    /// <summary>
    /// </summary>
    public sealed class KerbAcceptSecurityContext
    {
		public string CredSource { get; private set; }
		public string DomainName { get; private set; }
		public uint Status { get; private set; }
		public string Target { get; private set; }
		public string UserName { get; private set; }

        public static IEnumerable<KerbAcceptSecurityContext> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<KerbAcceptSecurityContext> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<KerbAcceptSecurityContext> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM KerbAcceptSecurityContext_End");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new KerbAcceptSecurityContext
                {
                     CredSource = (string) (managementObject.Properties["CredSource"]?.Value ?? default(string)),
		 DomainName = (string) (managementObject.Properties["DomainName"]?.Value ?? default(string)),
		 Status = (uint) (managementObject.Properties["Status"]?.Value ?? default(uint)),
		 Target = (string) (managementObject.Properties["Target"]?.Value ?? default(string)),
		 UserName = (string) (managementObject.Properties["UserName"]?.Value ?? default(string))
                };
        }
    }
}