using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Users.Nt
{
    /// <summary>
    /// </summary>
    public sealed class NtLogEventUser
    {
		public string Record { get; private set; }
		public string User { get; private set; }

        public static IEnumerable<NtLogEventUser> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<NtLogEventUser> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<NtLogEventUser> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_NTLogEventUser");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new NtLogEventUser
                {
                     Record =  (managementObject.Properties["Record"]?.Value?.ToString()),
		 User =  (managementObject.Properties["User"]?.Value?.ToString())
                };
        }
    }
}