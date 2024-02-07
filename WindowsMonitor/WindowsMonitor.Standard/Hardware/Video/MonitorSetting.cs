using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Video
{
    /// <summary>
    /// </summary>
    public sealed class MonitorSetting
    {
		public string Element { get; private set; }
		public string Setting { get; private set; }

        public static IEnumerable<MonitorSetting> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<MonitorSetting> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<MonitorSetting> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_MonitorSetting");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new MonitorSetting
                {
                     Element = (string) (managementObject.Properties["Element"]?.Value ?? default(string)),
		 Setting = (string) (managementObject.Properties["Setting"]?.Value ?? default(string))
                };
        }
    }
}