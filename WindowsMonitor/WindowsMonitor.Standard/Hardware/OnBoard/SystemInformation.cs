using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.OnBoard
{
    /// <summary>
    /// </summary>
    public sealed class SystemInformation
    {
		public bool Active { get; private set; }
		public string BaseBoardManufacturer { get; private set; }
		public string BaseBoardProduct { get; private set; }
		public string BaseBoardVersion { get; private set; }
		public byte BiosMajorRelease { get; private set; }
		public byte BiosMinorRelease { get; private set; }
		public string BiosReleaseDate { get; private set; }
		public string BiosVendor { get; private set; }
		public string BiosVersion { get; private set; }
		public byte EcFirmwareMajorRelease { get; private set; }
		public byte EcFirmwareMinorRelease { get; private set; }
		public string InstanceName { get; private set; }
		public string SystemFamily { get; private set; }
		public string SystemManufacturer { get; private set; }
		public string SystemProductName { get; private set; }
		public string SystemSku { get; private set; }
		public string SystemVersion { get; private set; }

        public static IEnumerable<SystemInformation> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SystemInformation> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SystemInformation> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MS_SystemInformation");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SystemInformation
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 BaseBoardManufacturer = (string) (managementObject.Properties["BaseBoardManufacturer"]?.Value ?? default(string)),
		 BaseBoardProduct = (string) (managementObject.Properties["BaseBoardProduct"]?.Value ?? default(string)),
		 BaseBoardVersion = (string) (managementObject.Properties["BaseBoardVersion"]?.Value ?? default(string)),
		 BiosMajorRelease = (byte) (managementObject.Properties["BiosMajorRelease"]?.Value ?? default(byte)),
		 BiosMinorRelease = (byte) (managementObject.Properties["BiosMinorRelease"]?.Value ?? default(byte)),
		 BiosReleaseDate = (string) (managementObject.Properties["BIOSReleaseDate"]?.Value ?? default(string)),
		 BiosVendor = (string) (managementObject.Properties["BIOSVendor"]?.Value ?? default(string)),
		 BiosVersion = (string) (managementObject.Properties["BIOSVersion"]?.Value ?? default(string)),
		 EcFirmwareMajorRelease = (byte) (managementObject.Properties["ECFirmwareMajorRelease"]?.Value ?? default(byte)),
		 EcFirmwareMinorRelease = (byte) (managementObject.Properties["ECFirmwareMinorRelease"]?.Value ?? default(byte)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 SystemFamily = (string) (managementObject.Properties["SystemFamily"]?.Value ?? default(string)),
		 SystemManufacturer = (string) (managementObject.Properties["SystemManufacturer"]?.Value ?? default(string)),
		 SystemProductName = (string) (managementObject.Properties["SystemProductName"]?.Value ?? default(string)),
		 SystemSku = (string) (managementObject.Properties["SystemSKU"]?.Value ?? default(string)),
		 SystemVersion = (string) (managementObject.Properties["SystemVersion"]?.Value ?? default(string))
                };
        }
    }
}