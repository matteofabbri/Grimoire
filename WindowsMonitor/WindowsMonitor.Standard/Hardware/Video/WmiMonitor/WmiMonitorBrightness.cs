using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Video.WmiMonitor
{
    /// <summary>
    /// </summary>
    public sealed class WmiMonitorBrightness
    {
		public bool Active { get; private set; }
		public byte CurrentBrightness { get; private set; }
		public string InstanceName { get; private set; }
		public byte[] Level { get; private set; }
		public uint Levels { get; private set; }

        public static IEnumerable<WmiMonitorBrightness> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<WmiMonitorBrightness> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<WmiMonitorBrightness> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM WmiMonitorBrightness");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new WmiMonitorBrightness
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 CurrentBrightness = (byte) (managementObject.Properties["CurrentBrightness"]?.Value ?? default(byte)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 Level = (byte[]) (managementObject.Properties["Level"]?.Value ?? new byte[0]),
		 Levels = (uint) (managementObject.Properties["Levels"]?.Value ?? default(uint))
                };
        }
    }
}