using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Processors
{
    /// <summary>
    /// </summary>
    public sealed class ProcessorAcpiCsd
    {
		public bool Active { get; private set; }
		public uint Count { get; private set; }
		public dynamic[] Dependency { get; private set; }
		public string InstanceName { get; private set; }

        public static IEnumerable<ProcessorAcpiCsd> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ProcessorAcpiCsd> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ProcessorAcpiCsd> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM ProcessorAcpiCsd");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ProcessorAcpiCsd
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 Count = (uint) (managementObject.Properties["Count"]?.Value ?? default(uint)),
		 Dependency = (dynamic[]) (managementObject.Properties["Dependency"]?.Value ?? new dynamic[0]),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string))
                };
        }
    }
}