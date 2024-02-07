using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Kerberos
{
    /// <summary>
    /// </summary>
    public sealed class KerbSetPassword
    {
		public string AccountName { get; private set; }
		public string AccountRealm { get; private set; }
		public string ClientName { get; private set; }
		public string ClientRealm { get; private set; }
		public string KdcAddress { get; private set; }
		public uint Status { get; private set; }

        public static IEnumerable<KerbSetPassword> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<KerbSetPassword> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<KerbSetPassword> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM KerbSetPassword_End");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new KerbSetPassword
                {
                     AccountName = (string) (managementObject.Properties["AccountName"]?.Value ?? default(string)),
		 AccountRealm = (string) (managementObject.Properties["AccountRealm"]?.Value ?? default(string)),
		 ClientName = (string) (managementObject.Properties["ClientName"]?.Value ?? default(string)),
		 ClientRealm = (string) (managementObject.Properties["ClientRealm"]?.Value ?? default(string)),
		 KdcAddress = (string) (managementObject.Properties["KdcAddress"]?.Value ?? default(string)),
		 Status = (uint) (managementObject.Properties["Status"]?.Value ?? default(uint))
                };
        }
    }
}