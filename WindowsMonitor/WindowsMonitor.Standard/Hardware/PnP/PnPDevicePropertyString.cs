using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.PnP
{
    /// <summary>
    /// </summary>
    public sealed class PnPDevicePropertyString
    {
		public string Data { get; private set; }
		public string DeviceId { get; private set; }
		public string Key { get; private set; }
		public string KeyName { get; private set; }
		public uint Type { get; private set; }

        public static IEnumerable<PnPDevicePropertyString> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<PnPDevicePropertyString> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<PnPDevicePropertyString> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PnPDevicePropertyString");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new PnPDevicePropertyString
                {
                     Data = (string) (managementObject.Properties["Data"]?.Value),
		 DeviceId = (string) (managementObject.Properties["DeviceID"]?.Value),
		 Key = (string) (managementObject.Properties["key"]?.Value),
		 KeyName = (string) (managementObject.Properties["KeyName"]?.Value),
		 Type = (uint) (managementObject.Properties["Type"]?.Value ?? default(uint))
                };
        }
    }
}