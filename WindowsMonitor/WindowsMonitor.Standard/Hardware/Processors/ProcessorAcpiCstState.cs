using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Processors
{
    /// <summary>
    /// </summary>
    public sealed class ProcessorAcpiCstState
    {
		public ushort Latency { get; private set; }
		public uint PowerConsumption { get; private set; }
		public dynamic Register { get; private set; }
		public byte StateType { get; private set; }

        public static IEnumerable<ProcessorAcpiCstState> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ProcessorAcpiCstState> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ProcessorAcpiCstState> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM ProcessorAcpiCstState");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ProcessorAcpiCstState
                {
                     Latency = (ushort) (managementObject.Properties["Latency"]?.Value ?? default(ushort)),
		 PowerConsumption = (uint) (managementObject.Properties["PowerConsumption"]?.Value ?? default(uint)),
		 Register = (dynamic) (managementObject.Properties["Register"]?.Value ?? default(dynamic)),
		 StateType = (byte) (managementObject.Properties["StateType"]?.Value ?? default(byte))
                };
        }
    }
}