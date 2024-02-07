using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Acpi
{
    /// <summary>
    /// </summary>
    public sealed class AcpiPssState
    {
		public uint BmLatency { get; private set; }
		public uint Control { get; private set; }
		public uint Frequency { get; private set; }
		public uint Latency { get; private set; }
		public uint Power { get; private set; }
		public uint Status { get; private set; }

        public static IEnumerable<AcpiPssState> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<AcpiPssState> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<AcpiPssState> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM AcpiPssState");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new AcpiPssState
                {
                     BmLatency = (uint) (managementObject.Properties["BmLatency"]?.Value ?? default(uint)),
		 Control = (uint) (managementObject.Properties["Control"]?.Value ?? default(uint)),
		 Frequency = (uint) (managementObject.Properties["Frequency"]?.Value ?? default(uint)),
		 Latency = (uint) (managementObject.Properties["Latency"]?.Value ?? default(uint)),
		 Power = (uint) (managementObject.Properties["Power"]?.Value ?? default(uint)),
		 Status = (uint) (managementObject.Properties["Status"]?.Value ?? default(uint))
                };
        }
    }
}