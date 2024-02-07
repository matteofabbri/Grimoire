using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Software.DCOM
{
    /// <summary>
    /// </summary>
    public sealed class DcomApplicationSetting
    {
		public string AppId { get; private set; }
		public uint AuthenticationLevel { get; private set; }
		public string Caption { get; private set; }
		public string CustomSurrogate { get; private set; }
		public string Description { get; private set; }
		public bool EnableAtStorageActivation { get; private set; }
		public string LocalService { get; private set; }
		public string RemoteServerName { get; private set; }
		public string RunAsUser { get; private set; }
		public string ServiceParameters { get; private set; }
		public string SettingId { get; private set; }
		public bool UseSurrogate { get; private set; }

        public static IEnumerable<DcomApplicationSetting> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<DcomApplicationSetting> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<DcomApplicationSetting> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_DCOMApplicationSetting");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new DcomApplicationSetting
                {
                     AppId = (string) (managementObject.Properties["AppID"]?.Value),
		 AuthenticationLevel = (uint) (managementObject.Properties["AuthenticationLevel"]?.Value ?? default(uint)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CustomSurrogate = (string) (managementObject.Properties["CustomSurrogate"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 EnableAtStorageActivation = (bool) (managementObject.Properties["EnableAtStorageActivation"]?.Value ?? default(bool)),
		 LocalService = (string) (managementObject.Properties["LocalService"]?.Value),
		 RemoteServerName = (string) (managementObject.Properties["RemoteServerName"]?.Value),
		 RunAsUser = (string) (managementObject.Properties["RunAsUser"]?.Value),
		 ServiceParameters = (string) (managementObject.Properties["ServiceParameters"]?.Value),
		 SettingId = (string) (managementObject.Properties["SettingID"]?.Value),
		 UseSurrogate = (bool) (managementObject.Properties["UseSurrogate"]?.Value ?? default(bool))
                };
        }
    }
}