using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Ide
{
    /// <summary>
    /// </summary>
    public sealed class IdePortDeviceInfo
    {
		public bool Active { get; private set; }
		public byte Bus { get; private set; }
		public string InstanceName { get; private set; }
		public byte Lun { get; private set; }
		public byte Target { get; private set; }

        public static IEnumerable<IdePortDeviceInfo> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<IdePortDeviceInfo> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<IdePortDeviceInfo> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSIde_PortDeviceInfo");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new IdePortDeviceInfo
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 Bus = (byte) (managementObject.Properties["Bus"]?.Value ?? default(byte)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 Lun = (byte) (managementObject.Properties["Lun"]?.Value ?? default(byte)),
		 Target = (byte) (managementObject.Properties["Target"]?.Value ?? default(byte))
                };
        }
    }
}