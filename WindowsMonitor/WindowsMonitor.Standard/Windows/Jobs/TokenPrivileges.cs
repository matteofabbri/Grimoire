using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Jobs
{
    /// <summary>
    /// </summary>
    public sealed class TokenPrivileges
    {
		public uint PrivilegeCount { get; private set; }
		public dynamic[] Privileges { get; private set; }

        public static IEnumerable<TokenPrivileges> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<TokenPrivileges> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<TokenPrivileges> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_TokenPrivileges");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new TokenPrivileges
                {
                     PrivilegeCount = (uint) (managementObject.Properties["PrivilegeCount"]?.Value ?? default(uint)),
		 Privileges = (dynamic[]) (managementObject.Properties["Privileges"]?.Value ?? new dynamic[0])
                };
        }
    }
}