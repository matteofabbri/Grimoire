using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network.Ntlm
{
    /// <summary>
    /// </summary>
    public sealed class NtlmValidateUser
    {
		public string LogonDomain { get; private set; }
		public string LogonServer { get; private set; }
		public uint Success { get; private set; }
		public string UserName { get; private set; }
		public string Workstation { get; private set; }

        public static IEnumerable<NtlmValidateUser> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<NtlmValidateUser> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<NtlmValidateUser> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM NtlmValidateUser_End");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new NtlmValidateUser
                {
                     LogonDomain = (string) (managementObject.Properties["LogonDomain"]?.Value ?? default(string)),
		 LogonServer = (string) (managementObject.Properties["LogonServer"]?.Value ?? default(string)),
		 Success = (uint) (managementObject.Properties["Success"]?.Value ?? default(uint)),
		 UserName = (string) (managementObject.Properties["UserName"]?.Value ?? default(string)),
		 Workstation = (string) (managementObject.Properties["Workstation"]?.Value ?? default(string))
                };
        }
    }
}