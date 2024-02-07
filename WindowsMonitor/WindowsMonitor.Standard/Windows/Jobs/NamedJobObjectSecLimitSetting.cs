using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Jobs
{
    /// <summary>
    /// </summary>
    public sealed class NamedJobObjectSecLimitSetting
    {
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public dynamic PrivilegesToDelete { get; private set; }
		public dynamic RestrictedSiDs { get; private set; }
		public uint SecurityLimitFlags { get; private set; }
		public string SettingId { get; private set; }
		public dynamic SiDsToDisable { get; private set; }

        public static IEnumerable<NamedJobObjectSecLimitSetting> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<NamedJobObjectSecLimitSetting> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<NamedJobObjectSecLimitSetting> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_NamedJobObjectSecLimitSetting");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new NamedJobObjectSecLimitSetting
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 PrivilegesToDelete = (dynamic) (managementObject.Properties["PrivilegesToDelete"]?.Value ?? default(dynamic)),
		 RestrictedSiDs = (dynamic) (managementObject.Properties["RestrictedSIDs"]?.Value ?? default(dynamic)),
		 SecurityLimitFlags = (uint) (managementObject.Properties["SecurityLimitFlags"]?.Value ?? default(uint)),
		 SettingId = (string) (managementObject.Properties["SettingID"]?.Value),
		 SiDsToDisable = (dynamic) (managementObject.Properties["SIDsToDisable"]?.Value ?? default(dynamic))
                };
        }
    }
}