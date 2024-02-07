using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Users
{
    /// <summary>
    /// </summary>
    public sealed class Desktop
    {
		public uint BorderWidth { get; private set; }
		public string Caption { get; private set; }
		public bool CoolSwitch { get; private set; }
		public uint CursorBlinkRate { get; private set; }
		public string Description { get; private set; }
		public bool DragFullWindows { get; private set; }
		public uint GridGranularity { get; private set; }
		public uint IconSpacing { get; private set; }
		public string IconTitleFaceName { get; private set; }
		public uint IconTitleSize { get; private set; }
		public bool IconTitleWrap { get; private set; }
		public string Name { get; private set; }
		public string Pattern { get; private set; }
		public bool ScreenSaverActive { get; private set; }
		public string ScreenSaverExecutable { get; private set; }
		public bool ScreenSaverSecure { get; private set; }
		public uint ScreenSaverTimeout { get; private set; }
		public string SettingId { get; private set; }
		public string Wallpaper { get; private set; }
		public bool WallpaperStretched { get; private set; }
		public bool WallpaperTiled { get; private set; }

        public static IEnumerable<Desktop> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<Desktop> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<Desktop> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_Desktop");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new Desktop
                {
                     BorderWidth = (uint) (managementObject.Properties["BorderWidth"]?.Value ?? default(uint)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CoolSwitch = (bool) (managementObject.Properties["CoolSwitch"]?.Value ?? default(bool)),
		 CursorBlinkRate = (uint) (managementObject.Properties["CursorBlinkRate"]?.Value ?? default(uint)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DragFullWindows = (bool) (managementObject.Properties["DragFullWindows"]?.Value ?? default(bool)),
		 GridGranularity = (uint) (managementObject.Properties["GridGranularity"]?.Value ?? default(uint)),
		 IconSpacing = (uint) (managementObject.Properties["IconSpacing"]?.Value ?? default(uint)),
		 IconTitleFaceName = (string) (managementObject.Properties["IconTitleFaceName"]?.Value),
		 IconTitleSize = (uint) (managementObject.Properties["IconTitleSize"]?.Value ?? default(uint)),
		 IconTitleWrap = (bool) (managementObject.Properties["IconTitleWrap"]?.Value ?? default(bool)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 Pattern = (string) (managementObject.Properties["Pattern"]?.Value),
		 ScreenSaverActive = (bool) (managementObject.Properties["ScreenSaverActive"]?.Value ?? default(bool)),
		 ScreenSaverExecutable = (string) (managementObject.Properties["ScreenSaverExecutable"]?.Value),
		 ScreenSaverSecure = (bool) (managementObject.Properties["ScreenSaverSecure"]?.Value ?? default(bool)),
		 ScreenSaverTimeout = (uint) (managementObject.Properties["ScreenSaverTimeout"]?.Value ?? default(uint)),
		 SettingId = (string) (managementObject.Properties["SettingID"]?.Value),
		 Wallpaper = (string) (managementObject.Properties["Wallpaper"]?.Value),
		 WallpaperStretched = (bool) (managementObject.Properties["WallpaperStretched"]?.Value ?? default(bool)),
		 WallpaperTiled = (bool) (managementObject.Properties["WallpaperTiled"]?.Value ?? default(bool))
                };
        }
    }
}