using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Users.Roaming
{
    /// <summary>
    /// </summary>
    public sealed class RoamingProfileUserConfiguration
    {
		public string[] DirectoriesToSyncAtLogonLogoff { get; private set; }
		public string[] ExcludedProfileDirs { get; private set; }
		public bool IsConfiguredByWmi { get; private set; }

        public static IEnumerable<RoamingProfileUserConfiguration> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<RoamingProfileUserConfiguration> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<RoamingProfileUserConfiguration> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_RoamingProfileUserConfiguration");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new RoamingProfileUserConfiguration
                {
                     DirectoriesToSyncAtLogonLogoff = (string[]) (managementObject.Properties["DirectoriesToSyncAtLogonLogoff"]?.Value ?? new string[0]),
		 ExcludedProfileDirs = (string[]) (managementObject.Properties["ExcludedProfileDirs"]?.Value ?? new string[0]),
		 IsConfiguredByWmi = (bool) (managementObject.Properties["IsConfiguredByWMI"]?.Value ?? default(bool))
                };
        }
    }
}