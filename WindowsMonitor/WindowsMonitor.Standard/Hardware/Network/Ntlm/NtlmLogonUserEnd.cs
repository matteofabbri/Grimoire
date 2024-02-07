using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network.Ntlm
{
    /// <summary>
    /// </summary>
    public sealed class NtlmLogonUserEnd
    {
		public string DomainName { get; private set; }
		public uint LogonType { get; private set; }
		public uint Status { get; private set; }
		public string UserName { get; private set; }

        public static IEnumerable<NtlmLogonUserEnd> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<NtlmLogonUserEnd> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<NtlmLogonUserEnd> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM NtlmLogonUser_End");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new NtlmLogonUserEnd
                {
                     DomainName = (string) (managementObject.Properties["DomainName"]?.Value ?? default(string)),
		 LogonType = (uint) (managementObject.Properties["LogonType"]?.Value ?? default(uint)),
		 Status = (uint) (managementObject.Properties["Status"]?.Value ?? default(uint)),
		 UserName = (string) (managementObject.Properties["UserName"]?.Value ?? default(string))
                };
        }
    }
}