using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.Volumes
{
    /// <summary>
    /// </summary>
    public sealed class VolumeQuota
    {
		public string Element { get; private set; }
		public string Setting { get; private set; }

        public static IEnumerable<VolumeQuota> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<VolumeQuota> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<VolumeQuota> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_VolumeQuota");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new VolumeQuota
                {
                     Element = (string) (managementObject.Properties["Element"]?.Value ?? default(string)),
		 Setting = (string) (managementObject.Properties["Setting"]?.Value ?? default(string))
                };
        }
    }
}