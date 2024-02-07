using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Drives
{
    /// <summary>
    /// </summary>
    public sealed class DiskDriverPerformance
    {
		public bool Active { get; private set; }
		public string DeviceName { get; private set; }
		public string InstanceName { get; private set; }
		public dynamic PerfData { get; private set; }

        public static IEnumerable<DiskDriverPerformance> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<DiskDriverPerformance> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<DiskDriverPerformance> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSDiskDriver_Performance");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new DiskDriverPerformance
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 DeviceName = (string) (managementObject.Properties["DeviceName"]?.Value ?? default(string)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 PerfData = (dynamic) (managementObject.Properties["PerfData"]?.Value ?? default(dynamic))
                };
        }
    }
}