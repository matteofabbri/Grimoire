using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Processors
{
    /// <summary>
    /// </summary>
    public sealed class ProcessorAcpiTssState
    {
		public uint Control { get; private set; }
		public uint FreqPercentage { get; private set; }
		public uint Power { get; private set; }
		public ulong Reserved1 { get; private set; }
		public ulong Reserved2 { get; private set; }
		public uint Status { get; private set; }
		public uint TransitionLatency { get; private set; }

        public static IEnumerable<ProcessorAcpiTssState> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ProcessorAcpiTssState> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ProcessorAcpiTssState> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM ProcessorAcpiTssState");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ProcessorAcpiTssState
                {
                     Control = (uint) (managementObject.Properties["Control"]?.Value ?? default(uint)),
		 FreqPercentage = (uint) (managementObject.Properties["FreqPercentage"]?.Value ?? default(uint)),
		 Power = (uint) (managementObject.Properties["Power"]?.Value ?? default(uint)),
		 Reserved1 = (ulong) (managementObject.Properties["Reserved1"]?.Value ?? default(ulong)),
		 Reserved2 = (ulong) (managementObject.Properties["Reserved2"]?.Value ?? default(ulong)),
		 Status = (uint) (managementObject.Properties["Status"]?.Value ?? default(uint)),
		 TransitionLatency = (uint) (managementObject.Properties["TransitionLatency"]?.Value ?? default(uint))
                };
        }
    }
}