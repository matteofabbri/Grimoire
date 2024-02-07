using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Software
{
    /// <summary>
    /// </summary>
    public sealed class StartupCommand
    {
		public string Caption { get; private set; }
		public string Command { get; private set; }
		public string Description { get; private set; }
		public string Location { get; private set; }
		public string Name { get; private set; }
		public string SettingId { get; private set; }
		public string User { get; private set; }
		public string UserSid { get; private set; }

        public static IEnumerable<StartupCommand> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<StartupCommand> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<StartupCommand> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_StartupCommand");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new StartupCommand
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Command = (string) (managementObject.Properties["Command"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 Location = (string) (managementObject.Properties["Location"]?.Value),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 SettingId = (string) (managementObject.Properties["SettingID"]?.Value),
		 User = (string) (managementObject.Properties["User"]?.Value),
		 UserSid = (string) (managementObject.Properties["UserSID"]?.Value)
                };
        }
    }
}