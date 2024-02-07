using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Video.WmiMonitor
{
    /// <summary>
    /// </summary>
    public sealed class WmiMonitorColorCharacteristics
    {
		public bool Active { get; private set; }
		public dynamic Blue { get; private set; }
		public dynamic DefaultWhite { get; private set; }
		public dynamic Green { get; private set; }
		public string InstanceName { get; private set; }
		public dynamic Red { get; private set; }

        public static IEnumerable<WmiMonitorColorCharacteristics> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<WmiMonitorColorCharacteristics> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<WmiMonitorColorCharacteristics> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM WmiMonitorColorCharacteristics");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new WmiMonitorColorCharacteristics
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 Blue = (dynamic) (managementObject.Properties["Blue"]?.Value ?? default(dynamic)),
		 DefaultWhite = (dynamic) (managementObject.Properties["DefaultWhite"]?.Value ?? default(dynamic)),
		 Green = (dynamic) (managementObject.Properties["Green"]?.Value ?? default(dynamic)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 Red = (dynamic) (managementObject.Properties["Red"]?.Value ?? default(dynamic))
                };
        }
    }
}