using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Video.WmiMonitor
{
    /// <summary>
    /// </summary>
    public sealed class WmiMonitorRawEEdidV1Block
    {
		public bool Active { get; private set; }
		public byte[] Content { get; private set; }
		public byte Id { get; private set; }
		public string InstanceName { get; private set; }
		public byte Type { get; private set; }

        public static IEnumerable<WmiMonitorRawEEdidV1Block> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<WmiMonitorRawEEdidV1Block> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<WmiMonitorRawEEdidV1Block> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM WmiMonitorRawEEdidV1Block");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new WmiMonitorRawEEdidV1Block
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 Content = (byte[]) (managementObject.Properties["Content"]?.Value ?? new byte[0]),
		 Id = (byte) (managementObject.Properties["Id"]?.Value ?? default(byte)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 Type = (byte) (managementObject.Properties["Type"]?.Value ?? default(byte))
                };
        }
    }
}