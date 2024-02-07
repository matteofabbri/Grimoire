using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Software.COM
{
    /// <summary>
    /// </summary>
    public sealed class ComClassEmulator
    {
		public string NewVersion { get; private set; }
		public string OldVersion { get; private set; }

        public static IEnumerable<ComClassEmulator> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ComClassEmulator> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ComClassEmulator> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_ComClassEmulator");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ComClassEmulator
                {
                     NewVersion =  (managementObject.Properties["NewVersion"]?.Value?.ToString()),
		 OldVersion =  (managementObject.Properties["OldVersion"]?.Value?.ToString())
                };
        }
    }
}