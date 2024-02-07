using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.SystemConfig.V1
{
    /// <summary>
    /// </summary>
    public sealed class PnP
    {
		public uint DescriptionLength { get; private set; }
		public string DeviceDescription { get; private set; }
		public string DeviceId { get; private set; }
		public uint Flags { get; private set; }
		public string FriendlyName { get; private set; }
		public uint FriendlyNameLength { get; private set; }
		public uint IdLength { get; private set; }

        public static IEnumerable<PnP> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<PnP> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<PnP> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM SystemConfig_V1_PnP");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new PnP
                {
                     DescriptionLength = (uint) (managementObject.Properties["DescriptionLength"]?.Value ?? default(uint)),
		 DeviceDescription = (string) (managementObject.Properties["DeviceDescription"]?.Value ?? default(string)),
		 DeviceId = (string) (managementObject.Properties["DeviceID"]?.Value ?? default(string)),
		 Flags = (uint) (managementObject.Properties["Flags"]?.Value ?? default(uint)),
		 FriendlyName = (string) (managementObject.Properties["FriendlyName"]?.Value ?? default(string)),
		 FriendlyNameLength = (uint) (managementObject.Properties["FriendlyNameLength"]?.Value ?? default(uint)),
		 IdLength = (uint) (managementObject.Properties["IDLength"]?.Value ?? default(uint))
                };
        }
    }
}