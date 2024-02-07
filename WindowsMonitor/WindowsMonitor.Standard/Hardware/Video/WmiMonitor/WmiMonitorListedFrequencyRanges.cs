using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Video.WmiMonitor
{
    /// <summary>
    /// </summary>
    public sealed class WmiMonitorListedFrequencyRanges
    {
		public bool Active { get; private set; }
		public string InstanceName { get; private set; }
		public dynamic[] MonitorFreqRanges { get; private set; }
		public ushort NumOfMonitorFreqRanges { get; private set; }

        public static IEnumerable<WmiMonitorListedFrequencyRanges> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<WmiMonitorListedFrequencyRanges> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<WmiMonitorListedFrequencyRanges> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM WmiMonitorListedFrequencyRanges");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new WmiMonitorListedFrequencyRanges
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 MonitorFreqRanges = (dynamic[]) (managementObject.Properties["MonitorFreqRanges"]?.Value ?? new dynamic[0]),
		 NumOfMonitorFreqRanges = (ushort) (managementObject.Properties["NumOfMonitorFreqRanges"]?.Value ?? default(ushort))
                };
        }
    }
}