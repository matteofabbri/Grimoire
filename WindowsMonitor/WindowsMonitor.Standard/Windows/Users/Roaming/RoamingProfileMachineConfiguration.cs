using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Users.Roaming
{
    /// <summary>
    /// </summary>
    public sealed class RoamingProfileMachineConfiguration
    {
		public bool AddAdminGroupToRupEnabled { get; private set; }
		public bool AllowCrossForestUserPolicy { get; private set; }
		public dynamic BackgroundUploadParams { get; private set; }
		public ushort DeleteProfilesOlderDays { get; private set; }
		public bool DeleteRoamingCacheEnabled { get; private set; }
		public bool DetectSlowLinkDisabled { get; private set; }
		public bool ForceUnloadDisabled { get; private set; }
		public bool IsConfiguredByWmi { get; private set; }
		public string MachineProfilePath { get; private set; }
		public bool OnlyAllowLocalProfiles { get; private set; }
		public bool OwnerCheckDisabled { get; private set; }
		public bool PrimaryComputerEnabled { get; private set; }
		public bool ProfileUploadDisabled { get; private set; }
		public dynamic SlowLinkTimeOutParams { get; private set; }
		public bool SlowLinkUiEnabled { get; private set; }
		public bool TempProfileLogonBlocked { get; private set; }
		public ushort WaitForNetworkInSec { get; private set; }
		public bool WaitForRemoteProfile { get; private set; }

        public static IEnumerable<RoamingProfileMachineConfiguration> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<RoamingProfileMachineConfiguration> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<RoamingProfileMachineConfiguration> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_RoamingProfileMachineConfiguration");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new RoamingProfileMachineConfiguration
                {
                     AddAdminGroupToRupEnabled = (bool) (managementObject.Properties["AddAdminGroupToRUPEnabled"]?.Value ?? default(bool)),
		 AllowCrossForestUserPolicy = (bool) (managementObject.Properties["AllowCrossForestUserPolicy"]?.Value ?? default(bool)),
		 BackgroundUploadParams = (dynamic) (managementObject.Properties["BackgroundUploadParams"]?.Value ?? default(dynamic)),
		 DeleteProfilesOlderDays = (ushort) (managementObject.Properties["DeleteProfilesOlderDays"]?.Value ?? default(ushort)),
		 DeleteRoamingCacheEnabled = (bool) (managementObject.Properties["DeleteRoamingCacheEnabled"]?.Value ?? default(bool)),
		 DetectSlowLinkDisabled = (bool) (managementObject.Properties["DetectSlowLinkDisabled"]?.Value ?? default(bool)),
		 ForceUnloadDisabled = (bool) (managementObject.Properties["ForceUnloadDisabled"]?.Value ?? default(bool)),
		 IsConfiguredByWmi = (bool) (managementObject.Properties["IsConfiguredByWMI"]?.Value ?? default(bool)),
		 MachineProfilePath = (string) (managementObject.Properties["MachineProfilePath"]?.Value),
		 OnlyAllowLocalProfiles = (bool) (managementObject.Properties["OnlyAllowLocalProfiles"]?.Value ?? default(bool)),
		 OwnerCheckDisabled = (bool) (managementObject.Properties["OwnerCheckDisabled"]?.Value ?? default(bool)),
		 PrimaryComputerEnabled = (bool) (managementObject.Properties["PrimaryComputerEnabled"]?.Value ?? default(bool)),
		 ProfileUploadDisabled = (bool) (managementObject.Properties["ProfileUploadDisabled"]?.Value ?? default(bool)),
		 SlowLinkTimeOutParams = (dynamic) (managementObject.Properties["SlowLinkTimeOutParams"]?.Value ?? default(dynamic)),
		 SlowLinkUiEnabled = (bool) (managementObject.Properties["SlowLinkUIEnabled"]?.Value ?? default(bool)),
		 TempProfileLogonBlocked = (bool) (managementObject.Properties["TempProfileLogonBlocked"]?.Value ?? default(bool)),
		 WaitForNetworkInSec = (ushort) (managementObject.Properties["WaitForNetworkInSec"]?.Value ?? default(ushort)),
		 WaitForRemoteProfile = (bool) (managementObject.Properties["WaitForRemoteProfile"]?.Value ?? default(bool))
                };
        }
    }
}