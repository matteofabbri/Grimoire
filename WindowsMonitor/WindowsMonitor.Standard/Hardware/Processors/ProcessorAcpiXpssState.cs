using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Processors
{
    /// <summary>
    /// </summary>
    public sealed class ProcessorAcpiXpssState
    {
		public uint BmLatency { get; private set; }
		public ulong Control { get; private set; }
		public ulong ControlMask { get; private set; }
		public uint Frequency { get; private set; }
		public uint Latency { get; private set; }
		public uint Power { get; private set; }
		public ulong Status { get; private set; }
		public ulong StatusMask { get; private set; }

        public static IEnumerable<ProcessorAcpiXpssState> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ProcessorAcpiXpssState> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ProcessorAcpiXpssState> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM ProcessorAcpiXpssState");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ProcessorAcpiXpssState
                {
                     BmLatency = (uint) (managementObject.Properties["BmLatency"]?.Value ?? default(uint)),
		 Control = (ulong) (managementObject.Properties["Control"]?.Value ?? default(ulong)),
		 ControlMask = (ulong) (managementObject.Properties["ControlMask"]?.Value ?? default(ulong)),
		 Frequency = (uint) (managementObject.Properties["Frequency"]?.Value ?? default(uint)),
		 Latency = (uint) (managementObject.Properties["Latency"]?.Value ?? default(uint)),
		 Power = (uint) (managementObject.Properties["Power"]?.Value ?? default(uint)),
		 Status = (ulong) (managementObject.Properties["Status"]?.Value ?? default(ulong)),
		 StatusMask = (ulong) (managementObject.Properties["StatusMask"]?.Value ?? default(ulong))
                };
        }
    }
}