using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Video.WmiMonitor
{
    /// <summary>
    /// </summary>
    public sealed class WmiMonitorListedSupportedSourceModes
    {
		public bool Active { get; private set; }
		public string InstanceName { get; private set; }
		public dynamic[] MonitorSourceModes { get; private set; }
		public ushort NumOfMonitorSourceModes { get; private set; }
		public ushort PreferredMonitorSourceModeIndex { get; private set; }

        public static IEnumerable<WmiMonitorListedSupportedSourceModes> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<WmiMonitorListedSupportedSourceModes> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<WmiMonitorListedSupportedSourceModes> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM WmiMonitorListedSupportedSourceModes");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new WmiMonitorListedSupportedSourceModes
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 MonitorSourceModes = (dynamic[]) (managementObject.Properties["MonitorSourceModes"]?.Value ?? new dynamic[0]),
		 NumOfMonitorSourceModes = (ushort) (managementObject.Properties["NumOfMonitorSourceModes"]?.Value ?? default(ushort)),
		 PreferredMonitorSourceModeIndex = (ushort) (managementObject.Properties["PreferredMonitorSourceModeIndex"]?.Value ?? default(ushort))
                };
        }
    }
}