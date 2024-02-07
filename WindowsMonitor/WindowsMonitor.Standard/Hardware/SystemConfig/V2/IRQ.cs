using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.SystemConfig.V2
{
    /// <summary>
    /// </summary>
    public sealed class Irq
    {
		public string DeviceDescription { get; private set; }
		public uint DeviceDescriptionLen { get; private set; }
		public uint Flags { get; private set; }
		public ulong IrqAffinity { get; private set; }
		public uint IrqNum { get; private set; }

        public static IEnumerable<Irq> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<Irq> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<Irq> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM SystemConfig_V2_IRQ");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new Irq
                {
                     DeviceDescription = (string) (managementObject.Properties["DeviceDescription"]?.Value ?? default(string)),
		 DeviceDescriptionLen = (uint) (managementObject.Properties["DeviceDescriptionLen"]?.Value ?? default(uint)),
		 Flags = (uint) (managementObject.Properties["Flags"]?.Value ?? default(uint)),
		 IrqAffinity = (ulong) (managementObject.Properties["IRQAffinity"]?.Value ?? default(ulong)),
		 IrqNum = (uint) (managementObject.Properties["IRQNum"]?.Value ?? default(uint))
                };
        }
    }
}