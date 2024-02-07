using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Boot.Bcd
{
    /// <summary>
    /// </summary>
    public sealed class BcdDeviceData
    {
		public string AdditionalOptions { get; private set; }
		public uint DeviceType { get; private set; }

        public static IEnumerable<BcdDeviceData> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<BcdDeviceData> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<BcdDeviceData> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM BcdDeviceData");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new BcdDeviceData
                {
                     AdditionalOptions = (string) (managementObject.Properties["AdditionalOptions"]?.Value ?? default(string)),
		 DeviceType = (uint) (managementObject.Properties["DeviceType"]?.Value ?? default(uint))
                };
        }
    }
}