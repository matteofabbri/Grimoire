using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Video
{
    /// <summary>
    /// </summary>
    public sealed class DisplayControllerConfiguration
    {
		public uint BitsPerPixel { get; private set; }
		public string Caption { get; private set; }
		public uint ColorPlanes { get; private set; }
		public string Description { get; private set; }
		public uint DeviceEntriesInAColorTable { get; private set; }
		public uint DeviceSpecificPens { get; private set; }
		public uint HorizontalResolution { get; private set; }
		public string Name { get; private set; }
		public int RefreshRate { get; private set; }
		public uint ReservedSystemPaletteEntries { get; private set; }
		public string SettingId { get; private set; }
		public uint SystemPaletteEntries { get; private set; }
		public uint VerticalResolution { get; private set; }
		public string VideoMode { get; private set; }

        public static IEnumerable<DisplayControllerConfiguration> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<DisplayControllerConfiguration> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<DisplayControllerConfiguration> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_DisplayControllerConfiguration");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new DisplayControllerConfiguration
                {
                     BitsPerPixel = (uint) (managementObject.Properties["BitsPerPixel"]?.Value ?? default(uint)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 ColorPlanes = (uint) (managementObject.Properties["ColorPlanes"]?.Value ?? default(uint)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DeviceEntriesInAColorTable = (uint) (managementObject.Properties["DeviceEntriesInAColorTable"]?.Value ?? default(uint)),
		 DeviceSpecificPens = (uint) (managementObject.Properties["DeviceSpecificPens"]?.Value ?? default(uint)),
		 HorizontalResolution = (uint) (managementObject.Properties["HorizontalResolution"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 RefreshRate = (int) (managementObject.Properties["RefreshRate"]?.Value ?? default(int)),
		 ReservedSystemPaletteEntries = (uint) (managementObject.Properties["ReservedSystemPaletteEntries"]?.Value ?? default(uint)),
		 SettingId = (string) (managementObject.Properties["SettingID"]?.Value),
		 SystemPaletteEntries = (uint) (managementObject.Properties["SystemPaletteEntries"]?.Value ?? default(uint)),
		 VerticalResolution = (uint) (managementObject.Properties["VerticalResolution"]?.Value ?? default(uint)),
		 VideoMode = (string) (managementObject.Properties["VideoMode"]?.Value)
                };
        }
    }
}