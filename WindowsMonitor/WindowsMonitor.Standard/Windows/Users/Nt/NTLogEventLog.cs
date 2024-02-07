using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Users.Nt
{
    /// <summary>
    /// </summary>
    public sealed class NtLogEventLog
    {
		public string Log { get; private set; }
		public string Record { get; private set; }

        public static IEnumerable<NtLogEventLog> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<NtLogEventLog> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<NtLogEventLog> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_NTLogEventLog");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new NtLogEventLog
                {
                     Log =  (managementObject.Properties["Log"]?.Value?.ToString()),
		 Record =  (managementObject.Properties["Record"]?.Value?.ToString())
                };
        }
    }
}