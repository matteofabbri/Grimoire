using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.HBA
{
    /// <summary>
    /// </summary>
    public sealed class HbaApiVersion
    {
		public string Description { get; private set; }
		public uint Version { get; private set; }
		public uint WmiHbaApiVersion { get; private set; }

        public static IEnumerable<HbaApiVersion> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HbaApiVersion> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HbaApiVersion> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MS_SM_HbaApiVersion");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HbaApiVersion
                {
                     Description = (string) (managementObject.Properties["Description"]?.Value ?? default(string)),
		 Version = (uint) (managementObject.Properties["HbaApiVersion"]?.Value ?? default(uint)),
		 WmiHbaApiVersion = (uint) (managementObject.Properties["WmiHbaApiVersion"]?.Value ?? default(uint))
                };
        }
    }
}