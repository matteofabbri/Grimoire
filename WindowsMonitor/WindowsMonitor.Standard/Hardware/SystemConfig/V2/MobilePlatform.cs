using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.SystemConfig.V2
{
    /// <summary>
    /// </summary>
    public sealed class MobilePlatform
    {
		public string BootLoaderVersion { get; private set; }
		public string FirmwareRevision { get; private set; }
		public uint Flags { get; private set; }
		public string FriendlyName { get; private set; }
		public string HardwareRevision { get; private set; }
		public string HardwareVariant { get; private set; }
		public string Manufacturer { get; private set; }
		public string ManufacturerDisplayName { get; private set; }
		public string ManufacturerModelName { get; private set; }
		public string MobileOperatorDisplayName { get; private set; }
		public string MobileOperatorName { get; private set; }
		public string ModelName { get; private set; }
		public string RadioHardwareRevision { get; private set; }
		public string RadioSoftwareRevision { get; private set; }
		public string RomVersion { get; private set; }
		public string SocVersion { get; private set; }

        public static IEnumerable<MobilePlatform> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<MobilePlatform> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<MobilePlatform> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM SystemConfig_V2_MobilePlatform");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new MobilePlatform
                {
                     BootLoaderVersion = (string) (managementObject.Properties["BootLoaderVersion"]?.Value ?? default(string)),
		 FirmwareRevision = (string) (managementObject.Properties["FirmwareRevision"]?.Value ?? default(string)),
		 Flags = (uint) (managementObject.Properties["Flags"]?.Value ?? default(uint)),
		 FriendlyName = (string) (managementObject.Properties["FriendlyName"]?.Value ?? default(string)),
		 HardwareRevision = (string) (managementObject.Properties["HardwareRevision"]?.Value ?? default(string)),
		 HardwareVariant = (string) (managementObject.Properties["HardwareVariant"]?.Value ?? default(string)),
		 Manufacturer = (string) (managementObject.Properties["Manufacturer"]?.Value ?? default(string)),
		 ManufacturerDisplayName = (string) (managementObject.Properties["ManufacturerDisplayName"]?.Value ?? default(string)),
		 ManufacturerModelName = (string) (managementObject.Properties["ManufacturerModelName"]?.Value ?? default(string)),
		 MobileOperatorDisplayName = (string) (managementObject.Properties["MobileOperatorDisplayName"]?.Value ?? default(string)),
		 MobileOperatorName = (string) (managementObject.Properties["MobileOperatorName"]?.Value ?? default(string)),
		 ModelName = (string) (managementObject.Properties["ModelName"]?.Value ?? default(string)),
		 RadioHardwareRevision = (string) (managementObject.Properties["RadioHardwareRevision"]?.Value ?? default(string)),
		 RadioSoftwareRevision = (string) (managementObject.Properties["RadioSoftwareRevision"]?.Value ?? default(string)),
		 RomVersion = (string) (managementObject.Properties["ROMVersion"]?.Value ?? default(string)),
		 SocVersion = (string) (managementObject.Properties["SOCVersion"]?.Value ?? default(string))
                };
        }
    }
}