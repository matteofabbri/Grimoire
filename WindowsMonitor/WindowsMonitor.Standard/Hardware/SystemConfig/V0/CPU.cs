using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.SystemConfig.V0
{
    /// <summary>
    /// </summary>
    public sealed class Cpu
    {
		public uint AllocationGranularity { get; private set; }
		public char[] ComputerName { get; private set; }
		public char[] DomainName { get; private set; }
		public uint Flags { get; private set; }
		public uint HyperThreadingFlag { get; private set; }
		public uint MemSize { get; private set; }
		public uint MHz { get; private set; }
		public uint NumberOfProcessors { get; private set; }
		public uint PageSize { get; private set; }

        public static IEnumerable<Cpu> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<Cpu> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<Cpu> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM SystemConfig_V0_CPU");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new Cpu
                {
                     AllocationGranularity = (uint) (managementObject.Properties["AllocationGranularity"]?.Value ?? default(uint)),
		 ComputerName = (char[]) (managementObject.Properties["ComputerName"]?.Value ?? new char[0]),
		 DomainName = (char[]) (managementObject.Properties["DomainName"]?.Value ?? new char[0]),
		 Flags = (uint) (managementObject.Properties["Flags"]?.Value ?? default(uint)),
		 HyperThreadingFlag = (uint) (managementObject.Properties["HyperThreadingFlag"]?.Value ?? default(uint)),
		 MemSize = (uint) (managementObject.Properties["MemSize"]?.Value ?? default(uint)),
		 MHz = (uint) (managementObject.Properties["MHz"]?.Value ?? default(uint)),
		 NumberOfProcessors = (uint) (managementObject.Properties["NumberOfProcessors"]?.Value ?? default(uint)),
		 PageSize = (uint) (managementObject.Properties["PageSize"]?.Value ?? default(uint))
                };
        }
    }
}