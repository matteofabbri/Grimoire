using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Boot.Bcd
{
    /// <summary>
    /// </summary>
    public sealed class BcdDeviceLocateElementChildData
    {
		public string AdditionalOptions { get; private set; }
		public uint DeviceType { get; private set; }
		public uint Element { get; private set; }
		public dynamic Parent { get; private set; }
		public uint Type { get; private set; }

        public static IEnumerable<BcdDeviceLocateElementChildData> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<BcdDeviceLocateElementChildData> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<BcdDeviceLocateElementChildData> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM BcdDeviceLocateElementChildData");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new BcdDeviceLocateElementChildData
                {
                     AdditionalOptions = (string) (managementObject.Properties["AdditionalOptions"]?.Value ?? default(string)),
		 DeviceType = (uint) (managementObject.Properties["DeviceType"]?.Value ?? default(uint)),
		 Element = (uint) (managementObject.Properties["Element"]?.Value ?? default(uint)),
		 Parent = (dynamic) (managementObject.Properties["Parent"]?.Value ?? default(dynamic)),
		 Type = (uint) (managementObject.Properties["Type"]?.Value ?? default(uint))
                };
        }
    }
}