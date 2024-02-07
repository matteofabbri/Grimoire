using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network
{
    /// <summary>
    /// </summary>
    public sealed class PciDeviceProperty
    {
		public uint CurrentLinkSpeed { get; private set; }
		public uint CurrentLinkWidth { get; private set; }
		public uint CurrentPayloadSize { get; private set; }
		public uint CurrentSpeedAndMode { get; private set; }
		public uint DeviceType { get; private set; }
		public dynamic Header { get; private set; }
		public uint MaxLinkSpeed { get; private set; }
		public uint MaxLinkWidth { get; private set; }
		public uint MaxPayloadSize { get; private set; }
		public uint MaxReadRequestSize { get; private set; }

        public static IEnumerable<PciDeviceProperty> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<PciDeviceProperty> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<PciDeviceProperty> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_PciDeviceProperty");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new PciDeviceProperty
                {
                     CurrentLinkSpeed = (uint) (managementObject.Properties["CurrentLinkSpeed"]?.Value ?? default(uint)),
		 CurrentLinkWidth = (uint) (managementObject.Properties["CurrentLinkWidth"]?.Value ?? default(uint)),
		 CurrentPayloadSize = (uint) (managementObject.Properties["CurrentPayloadSize"]?.Value ?? default(uint)),
		 CurrentSpeedAndMode = (uint) (managementObject.Properties["CurrentSpeedAndMode"]?.Value ?? default(uint)),
		 DeviceType = (uint) (managementObject.Properties["DeviceType"]?.Value ?? default(uint)),
		 Header = (dynamic) (managementObject.Properties["Header"]?.Value ?? default(dynamic)),
		 MaxLinkSpeed = (uint) (managementObject.Properties["MaxLinkSpeed"]?.Value ?? default(uint)),
		 MaxLinkWidth = (uint) (managementObject.Properties["MaxLinkWidth"]?.Value ?? default(uint)),
		 MaxPayloadSize = (uint) (managementObject.Properties["MaxPayloadSize"]?.Value ?? default(uint)),
		 MaxReadRequestSize = (uint) (managementObject.Properties["MaxReadRequestSize"]?.Value ?? default(uint))
                };
        }
    }
}