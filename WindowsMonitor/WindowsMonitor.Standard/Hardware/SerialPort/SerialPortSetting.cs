using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.SerialPort
{
    /// <summary>
    /// </summary>
    public sealed class SerialPortSetting
    {
		public string Element { get; private set; }
		public string Setting { get; private set; }

        public static IEnumerable<SerialPortSetting> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SerialPortSetting> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SerialPortSetting> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_SerialPortSetting");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SerialPortSetting
                {
                     Element =  (managementObject.Properties["Element"]?.Value?.ToString()),
		 Setting =  (managementObject.Properties["Setting"]?.Value?.ToString())
                };
        }
    }
}