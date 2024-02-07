using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Video.WmiMonitor
{
    /// <summary>
    /// </summary>
    public sealed class WmiMonitorSupportedDisplayFeatures
    {
		public bool ActiveOffSupported { get; private set; }
		public byte DisplayType { get; private set; }
		public bool GtfSupported { get; private set; }
		public bool HasPreferredTimingMode { get; private set; }
		public bool SRgbSupported { get; private set; }
		public bool StandbySupported { get; private set; }
		public bool SuspendSupported { get; private set; }

        public static IEnumerable<WmiMonitorSupportedDisplayFeatures> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<WmiMonitorSupportedDisplayFeatures> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<WmiMonitorSupportedDisplayFeatures> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM WmiMonitorSupportedDisplayFeatures");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new WmiMonitorSupportedDisplayFeatures
                {
                     ActiveOffSupported = (bool) (managementObject.Properties["ActiveOffSupported"]?.Value ?? default(bool)),
		 DisplayType = (byte) (managementObject.Properties["DisplayType"]?.Value ?? default(byte)),
		 GtfSupported = (bool) (managementObject.Properties["GTFSupported"]?.Value ?? default(bool)),
		 HasPreferredTimingMode = (bool) (managementObject.Properties["HasPreferredTimingMode"]?.Value ?? default(bool)),
		 SRgbSupported = (bool) (managementObject.Properties["sRGBSupported"]?.Value ?? default(bool)),
		 StandbySupported = (bool) (managementObject.Properties["StandbySupported"]?.Value ?? default(bool)),
		 SuspendSupported = (bool) (managementObject.Properties["SuspendSupported"]?.Value ?? default(bool))
                };
        }
    }
}