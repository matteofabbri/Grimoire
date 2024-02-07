using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Video.WmiMonitor
{
    /// <summary>
    /// </summary>
    public sealed class WmiMonitorBasicDisplayParams
    {
		public bool Active { get; private set; }
		public byte DisplayTransferCharacteristic { get; private set; }
		public string InstanceName { get; private set; }
		public byte MaxHorizontalImageSize { get; private set; }
		public byte MaxVerticalImageSize { get; private set; }
		public dynamic SupportedDisplayFeatures { get; private set; }
		public byte VideoInputType { get; private set; }

        public static IEnumerable<WmiMonitorBasicDisplayParams> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<WmiMonitorBasicDisplayParams> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<WmiMonitorBasicDisplayParams> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM WmiMonitorBasicDisplayParams");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new WmiMonitorBasicDisplayParams
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 DisplayTransferCharacteristic = (byte) (managementObject.Properties["DisplayTransferCharacteristic"]?.Value ?? default(byte)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 MaxHorizontalImageSize = (byte) (managementObject.Properties["MaxHorizontalImageSize"]?.Value ?? default(byte)),
		 MaxVerticalImageSize = (byte) (managementObject.Properties["MaxVerticalImageSize"]?.Value ?? default(byte)),
		 SupportedDisplayFeatures = (dynamic) (managementObject.Properties["SupportedDisplayFeatures"]?.Value ?? default(dynamic)),
		 VideoInputType = (byte) (managementObject.Properties["VideoInputType"]?.Value ?? default(byte))
                };
        }
    }
}