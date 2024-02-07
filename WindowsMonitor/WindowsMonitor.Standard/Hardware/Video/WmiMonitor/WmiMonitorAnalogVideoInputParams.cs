using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Video.WmiMonitor
{
    /// <summary>
    /// </summary>
    public sealed class WmiMonitorAnalogVideoInputParams
    {
		public bool Active { get; private set; }
		public byte CompositeSyncSupported { get; private set; }
		public string InstanceName { get; private set; }
		public byte SeparateSyncsSupported { get; private set; }
		public byte SerrationOfVsyncRequired { get; private set; }
		public byte SetupExpected { get; private set; }
		public byte SignalLevelStandard { get; private set; }
		public byte SyncOnGreenVideoSupported { get; private set; }

        public static IEnumerable<WmiMonitorAnalogVideoInputParams> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<WmiMonitorAnalogVideoInputParams> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<WmiMonitorAnalogVideoInputParams> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM WmiMonitorAnalogVideoInputParams");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new WmiMonitorAnalogVideoInputParams
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 CompositeSyncSupported = (byte) (managementObject.Properties["CompositeSyncSupported"]?.Value ?? default(byte)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 SeparateSyncsSupported = (byte) (managementObject.Properties["SeparateSyncsSupported"]?.Value ?? default(byte)),
		 SerrationOfVsyncRequired = (byte) (managementObject.Properties["SerrationOfVsyncRequired"]?.Value ?? default(byte)),
		 SetupExpected = (byte) (managementObject.Properties["SetupExpected"]?.Value ?? default(byte)),
		 SignalLevelStandard = (byte) (managementObject.Properties["SignalLevelStandard"]?.Value ?? default(byte)),
		 SyncOnGreenVideoSupported = (byte) (managementObject.Properties["SyncOnGreenVideoSupported"]?.Value ?? default(byte))
                };
        }
    }
}