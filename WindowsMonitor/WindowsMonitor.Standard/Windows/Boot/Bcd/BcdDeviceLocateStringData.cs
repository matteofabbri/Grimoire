using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Boot.Bcd
{
    /// <summary>
    /// </summary>
    public sealed class BcdDeviceLocateStringData
    {
		public string AdditionalOptions { get; private set; }
		public uint DeviceType { get; private set; }
		public string Path { get; private set; }
		public uint Type { get; private set; }

        public static IEnumerable<BcdDeviceLocateStringData> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<BcdDeviceLocateStringData> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<BcdDeviceLocateStringData> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM BcdDeviceLocateStringData");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new BcdDeviceLocateStringData
                {
                     AdditionalOptions = (string) (managementObject.Properties["AdditionalOptions"]?.Value ?? default(string)),
		 DeviceType = (uint) (managementObject.Properties["DeviceType"]?.Value ?? default(uint)),
		 Path = (string) (managementObject.Properties["Path"]?.Value ?? default(string)),
		 Type = (uint) (managementObject.Properties["Type"]?.Value ?? default(uint))
                };
        }
    }
}