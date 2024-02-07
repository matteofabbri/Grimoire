using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.PointingDevices
{
    /// <summary>
    /// </summary>
    public sealed class MsMousePortInformation
    {
		public bool Active { get; private set; }
		public uint Buttons { get; private set; }
		public uint ConnectorType { get; private set; }
		public uint DataQueueSize { get; private set; }
		public uint ErrorCount { get; private set; }
		public uint HardwareType { get; private set; }
		public string InstanceName { get; private set; }

        public static IEnumerable<MsMousePortInformation> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<MsMousePortInformation> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<MsMousePortInformation> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSMouse_PortInformation");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new MsMousePortInformation
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 Buttons = (uint) (managementObject.Properties["Buttons"]?.Value ?? default(uint)),
		 ConnectorType = (uint) (managementObject.Properties["ConnectorType"]?.Value ?? default(uint)),
		 DataQueueSize = (uint) (managementObject.Properties["DataQueueSize"]?.Value ?? default(uint)),
		 ErrorCount = (uint) (managementObject.Properties["ErrorCount"]?.Value ?? default(uint)),
		 HardwareType = (uint) (managementObject.Properties["HardwareType"]?.Value ?? default(uint)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string))
                };
        }
    }
}