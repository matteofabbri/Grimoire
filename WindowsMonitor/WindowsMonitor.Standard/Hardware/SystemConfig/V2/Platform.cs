using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.SystemConfig.V2
{
    /// <summary>
    /// </summary>
    public sealed class Platform
    {
		public string BiosDate { get; private set; }
		public string BiosVersion { get; private set; }
		public uint Flags { get; private set; }
		public string SystemManufacturer { get; private set; }
		public string SystemProductName { get; private set; }

        public static IEnumerable<Platform> Retrieve(string remote, string username, string password)
        {
            var options = new ConnectionOptions
            {
                Impersonation = ImpersonationLevel.Impersonate,
                Username = username,
                Password = password
            };

            var managementScope = new ManagementScope(new ManagementPath($"\\\\{remote}\\root\\wmi"), options);
            managementScope.Connect();

            return Retrieve(managementScope);
        }

        public static IEnumerable<Platform> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<Platform> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM SystemConfig_V2_Platform");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new Platform
                {
                     BiosDate = (string) (managementObject.Properties["BiosDate"]?.Value ?? default(string)),
		 BiosVersion = (string) (managementObject.Properties["BiosVersion"]?.Value ?? default(string)),
		 Flags = (uint) (managementObject.Properties["Flags"]?.Value ?? default(uint)),
		 SystemManufacturer = (string) (managementObject.Properties["SystemManufacturer"]?.Value ?? default(string)),
		 SystemProductName = (string) (managementObject.Properties["SystemProductName"]?.Value ?? default(string))
                };
        }
    }
}