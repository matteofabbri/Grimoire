using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Users.Roaming
{
    /// <summary>
    /// </summary>
    public sealed class RoamingUserHealthConfiguration
    {
		public byte HealthStatusForTempProfiles { get; private set; }
		public ushort LastProfileDownloadIntervalCautionInHours { get; private set; }
		public ushort LastProfileDownloadIntervalUnhealthyInHours { get; private set; }
		public ushort LastProfileUploadIntervalCautionInHours { get; private set; }
		public ushort LastProfileUploadIntervalUnhealthyInHours { get; private set; }

        public static IEnumerable<RoamingUserHealthConfiguration> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<RoamingUserHealthConfiguration> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<RoamingUserHealthConfiguration> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_RoamingUserHealthConfiguration");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new RoamingUserHealthConfiguration
                {
                     HealthStatusForTempProfiles = (byte) (managementObject.Properties["HealthStatusForTempProfiles"]?.Value ?? default(byte)),
		 LastProfileDownloadIntervalCautionInHours = (ushort) (managementObject.Properties["LastProfileDownloadIntervalCautionInHours"]?.Value ?? default(ushort)),
		 LastProfileDownloadIntervalUnhealthyInHours = (ushort) (managementObject.Properties["LastProfileDownloadIntervalUnhealthyInHours"]?.Value ?? default(ushort)),
		 LastProfileUploadIntervalCautionInHours = (ushort) (managementObject.Properties["LastProfileUploadIntervalCautionInHours"]?.Value ?? default(ushort)),
		 LastProfileUploadIntervalUnhealthyInHours = (ushort) (managementObject.Properties["LastProfileUploadIntervalUnhealthyInHours"]?.Value ?? default(ushort))
                };
        }
    }
}