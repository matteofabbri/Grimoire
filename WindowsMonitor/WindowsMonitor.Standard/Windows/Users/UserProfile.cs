using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Users
{
    /// <summary>
    /// </summary>
    public sealed class UserProfile
    {
		public dynamic AppDataRoaming { get; private set; }
		public dynamic Contacts { get; private set; }
		public dynamic Desktop { get; private set; }
		public dynamic Documents { get; private set; }
		public dynamic Downloads { get; private set; }
		public dynamic Favorites { get; private set; }
		public byte HealthStatus { get; private set; }
		public DateTime LastAttemptedProfileDownloadTime { get; private set; }
		public DateTime LastAttemptedProfileUploadTime { get; private set; }
		public DateTime LastBackgroundRegistryUploadTime { get; private set; }
		public DateTime LastDownloadTime { get; private set; }
		public DateTime LastUploadTime { get; private set; }
		public DateTime LastUseTime { get; private set; }
		public dynamic Links { get; private set; }
		public bool Loaded { get; private set; }
		public string LocalPath { get; private set; }
		public dynamic Music { get; private set; }
		public dynamic Pictures { get; private set; }
		public uint RefCount { get; private set; }
		public bool RoamingConfigured { get; private set; }
		public string RoamingPath { get; private set; }
		public bool RoamingPreference { get; private set; }
		public dynamic SavedGames { get; private set; }
		public dynamic Searches { get; private set; }
		public string Sid { get; private set; }
		public bool Special { get; private set; }
		public dynamic StartMenu { get; private set; }
		public uint Status { get; private set; }
		public dynamic Videos { get; private set; }

        public static IEnumerable<UserProfile> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<UserProfile> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<UserProfile> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_UserProfile");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new UserProfile
                {
                     AppDataRoaming = (dynamic) (managementObject.Properties["AppDataRoaming"]?.Value ?? default(dynamic)),
		 Contacts = (dynamic) (managementObject.Properties["Contacts"]?.Value ?? default(dynamic)),
		 Desktop = (dynamic) (managementObject.Properties["Desktop"]?.Value ?? default(dynamic)),
		 Documents = (dynamic) (managementObject.Properties["Documents"]?.Value ?? default(dynamic)),
		 Downloads = (dynamic) (managementObject.Properties["Downloads"]?.Value ?? default(dynamic)),
		 Favorites = (dynamic) (managementObject.Properties["Favorites"]?.Value ?? default(dynamic)),
		 HealthStatus = (byte) (managementObject.Properties["HealthStatus"]?.Value ?? default(byte)),
		 LastAttemptedProfileDownloadTime = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["LastAttemptedProfileDownloadTime"]?.Value as string ?? "00010102000000.000000+060"),
		 LastAttemptedProfileUploadTime = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["LastAttemptedProfileUploadTime"]?.Value as string ?? "00010102000000.000000+060"),
		 LastBackgroundRegistryUploadTime = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["LastBackgroundRegistryUploadTime"]?.Value as string ?? "00010102000000.000000+060"),
		 LastDownloadTime = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["LastDownloadTime"]?.Value as string ?? "00010102000000.000000+060"),
		 LastUploadTime = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["LastUploadTime"]?.Value as string ?? "00010102000000.000000+060"),
		 LastUseTime = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["LastUseTime"]?.Value as string ?? "00010102000000.000000+060"),
		 Links = (dynamic) (managementObject.Properties["Links"]?.Value ?? default(dynamic)),
		 Loaded = (bool) (managementObject.Properties["Loaded"]?.Value ?? default(bool)),
		 LocalPath = (string) (managementObject.Properties["LocalPath"]?.Value),
		 Music = (dynamic) (managementObject.Properties["Music"]?.Value ?? default(dynamic)),
		 Pictures = (dynamic) (managementObject.Properties["Pictures"]?.Value ?? default(dynamic)),
		 RefCount = (uint) (managementObject.Properties["RefCount"]?.Value ?? default(uint)),
		 RoamingConfigured = (bool) (managementObject.Properties["RoamingConfigured"]?.Value ?? default(bool)),
		 RoamingPath = (string) (managementObject.Properties["RoamingPath"]?.Value),
		 RoamingPreference = (bool) (managementObject.Properties["RoamingPreference"]?.Value ?? default(bool)),
		 SavedGames = (dynamic) (managementObject.Properties["SavedGames"]?.Value ?? default(dynamic)),
		 Searches = (dynamic) (managementObject.Properties["Searches"]?.Value ?? default(dynamic)),
		 Sid = (string) (managementObject.Properties["SID"]?.Value),
		 Special = (bool) (managementObject.Properties["Special"]?.Value ?? default(bool)),
		 StartMenu = (dynamic) (managementObject.Properties["StartMenu"]?.Value ?? default(dynamic)),
		 Status = (uint) (managementObject.Properties["Status"]?.Value ?? default(uint)),
		 Videos = (dynamic) (managementObject.Properties["Videos"]?.Value ?? default(dynamic))
                };
        }
    }
}