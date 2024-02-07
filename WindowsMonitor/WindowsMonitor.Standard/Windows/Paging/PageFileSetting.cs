using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Paging
{
    /// <summary>
    /// </summary>
    public sealed class PageFileSetting
    {
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public uint InitialSize { get; private set; }
		public uint MaximumSize { get; private set; }
		public string Name { get; private set; }
		public string SettingId { get; private set; }

        public static IEnumerable<PageFileSetting> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<PageFileSetting> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<PageFileSetting> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PageFileSetting");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new PageFileSetting
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 InitialSize = (uint) (managementObject.Properties["InitialSize"]?.Value ?? default(uint)),
		 MaximumSize = (uint) (managementObject.Properties["MaximumSize"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 SettingId = (string) (managementObject.Properties["SettingID"]?.Value)
                };
        }
    }
}