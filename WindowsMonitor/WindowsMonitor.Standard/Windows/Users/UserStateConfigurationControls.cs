using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Users
{
    /// <summary>
    /// </summary>
    public sealed class UserStateConfigurationControls
    {
		public byte FolderRedirection { get; private set; }
		public byte OfflineFiles { get; private set; }
		public byte RoamingUserProfile { get; private set; }

        public static IEnumerable<UserStateConfigurationControls> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<UserStateConfigurationControls> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<UserStateConfigurationControls> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_UserStateConfigurationControls");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new UserStateConfigurationControls
                {
                     FolderRedirection = (byte) (managementObject.Properties["FolderRedirection"]?.Value ?? default(byte)),
		 OfflineFiles = (byte) (managementObject.Properties["OfflineFiles"]?.Value ?? default(byte)),
		 RoamingUserProfile = (byte) (managementObject.Properties["RoamingUserProfile"]?.Value ?? default(byte))
                };
        }
    }
}