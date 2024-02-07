using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware
{
    /// <summary>
    /// </summary>
    public sealed class BootConfiguration
    {
		public string BootDirectory { get; private set; }
		public string Caption { get; private set; }
		public string ConfigurationPath { get; private set; }
		public string Description { get; private set; }
		public string LastDrive { get; private set; }
		public string Name { get; private set; }
		public string ScratchDirectory { get; private set; }
		public string SettingId { get; private set; }
		public string TempDirectory { get; private set; }

        public static IEnumerable<BootConfiguration> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<BootConfiguration> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<BootConfiguration> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_BootConfiguration");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new BootConfiguration
                {
                     BootDirectory = (string) (managementObject.Properties["BootDirectory"]?.Value),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 ConfigurationPath = (string) (managementObject.Properties["ConfigurationPath"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 LastDrive = (string) (managementObject.Properties["LastDrive"]?.Value),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 ScratchDirectory = (string) (managementObject.Properties["ScratchDirectory"]?.Value),
		 SettingId = (string) (managementObject.Properties["SettingID"]?.Value),
		 TempDirectory = (string) (managementObject.Properties["TempDirectory"]?.Value)
                };
        }
    }
}