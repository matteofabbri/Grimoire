using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Processors
{
    /// <summary>
    /// </summary>
    public sealed class ProcessorAcpiXpss
    {
		public bool Active { get; private set; }
		public uint Count { get; private set; }
		public string InstanceName { get; private set; }
		public dynamic[] State { get; private set; }

        public static IEnumerable<ProcessorAcpiXpss> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ProcessorAcpiXpss> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ProcessorAcpiXpss> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM ProcessorAcpiXpss");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ProcessorAcpiXpss
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 Count = (uint) (managementObject.Properties["Count"]?.Value ?? default(uint)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 State = (dynamic[]) (managementObject.Properties["State"]?.Value ?? new dynamic[0])
                };
        }
    }
}