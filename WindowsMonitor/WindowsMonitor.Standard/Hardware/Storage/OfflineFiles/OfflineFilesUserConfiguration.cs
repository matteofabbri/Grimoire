using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.OfflineFiles
{
    /// <summary>
    /// </summary>
    public sealed class OfflineFilesUserConfiguration
    {
		public string[] AssignedOfflineFiles { get; private set; }
		public bool IsConfiguredByWmi { get; private set; }
		public bool MakeAvailableOfflineButtonRemoved { get; private set; }
		public bool WorkOfflineButtonRemoved { get; private set; }

        public static IEnumerable<OfflineFilesUserConfiguration> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<OfflineFilesUserConfiguration> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<OfflineFilesUserConfiguration> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_OfflineFilesUserConfiguration");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new OfflineFilesUserConfiguration
                {
                     AssignedOfflineFiles = (string[]) (managementObject.Properties["AssignedOfflineFiles"]?.Value ?? new string[0]),
		 IsConfiguredByWmi = (bool) (managementObject.Properties["IsConfiguredByWMI"]?.Value ?? default(bool)),
		 MakeAvailableOfflineButtonRemoved = (bool) (managementObject.Properties["MakeAvailableOfflineButtonRemoved"]?.Value ?? default(bool)),
		 WorkOfflineButtonRemoved = (bool) (managementObject.Properties["WorkOfflineButtonRemoved"]?.Value ?? default(bool))
                };
        }
    }
}