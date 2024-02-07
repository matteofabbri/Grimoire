using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.SystemConfig.V2
{
    /// <summary>
    /// </summary>
    public sealed class IdeChannel
    {
		public uint DeviceTimingMode { get; private set; }
		public uint DeviceType { get; private set; }
		public uint Flags { get; private set; }
		public string LocationInformation { get; private set; }
		public uint LocationInformationLen { get; private set; }
		public uint TargetId { get; private set; }

        public static IEnumerable<IdeChannel> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<IdeChannel> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<IdeChannel> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM SystemConfig_V2_IDEChannel");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new IdeChannel
                {
                     DeviceTimingMode = (uint) (managementObject.Properties["DeviceTimingMode"]?.Value ?? default(uint)),
		 DeviceType = (uint) (managementObject.Properties["DeviceType"]?.Value ?? default(uint)),
		 Flags = (uint) (managementObject.Properties["Flags"]?.Value ?? default(uint)),
		 LocationInformation = (string) (managementObject.Properties["LocationInformation"]?.Value ?? default(string)),
		 LocationInformationLen = (uint) (managementObject.Properties["LocationInformationLen"]?.Value ?? default(uint)),
		 TargetId = (uint) (managementObject.Properties["TargetId"]?.Value ?? default(uint))
                };
        }
    }
}