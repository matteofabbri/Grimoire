using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Power
{
    /// <summary>
    /// </summary>
    public sealed class PowerDeviceWakeEnable
    {
		public bool Active { get; private set; }
		public bool Enable { get; private set; }
		public string InstanceName { get; private set; }

        public static IEnumerable<PowerDeviceWakeEnable> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<PowerDeviceWakeEnable> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<PowerDeviceWakeEnable> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSPower_DeviceWakeEnable");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new PowerDeviceWakeEnable
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 Enable = (bool) (managementObject.Properties["Enable"]?.Value ?? default(bool)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string))
                };
        }
    }
}