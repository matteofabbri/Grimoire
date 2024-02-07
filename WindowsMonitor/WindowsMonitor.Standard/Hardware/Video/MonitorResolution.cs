using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Video
{
    /// <summary>
    /// </summary>
    public sealed class MonitorResolution
    {
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public uint HorizontalResolution { get; private set; }
		public uint MaxRefreshRate { get; private set; }
		public uint MinRefreshRate { get; private set; }
		public uint RefreshRate { get; private set; }
		public ushort ScanMode { get; private set; }
		public string SettingId { get; private set; }
		public uint VerticalResolution { get; private set; }

        public static IEnumerable<MonitorResolution> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<MonitorResolution> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<MonitorResolution> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_MonitorResolution");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new MonitorResolution
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 HorizontalResolution = (uint) (managementObject.Properties["HorizontalResolution"]?.Value ?? default(uint)),
		 MaxRefreshRate = (uint) (managementObject.Properties["MaxRefreshRate"]?.Value ?? default(uint)),
		 MinRefreshRate = (uint) (managementObject.Properties["MinRefreshRate"]?.Value ?? default(uint)),
		 RefreshRate = (uint) (managementObject.Properties["RefreshRate"]?.Value ?? default(uint)),
		 ScanMode = (ushort) (managementObject.Properties["ScanMode"]?.Value ?? default(ushort)),
		 SettingId = (string) (managementObject.Properties["SettingID"]?.Value),
		 VerticalResolution = (uint) (managementObject.Properties["VerticalResolution"]?.Value ?? default(uint))
                };
        }
    }
}