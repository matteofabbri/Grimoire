using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Processors
{
    /// <summary>
    /// </summary>
    public sealed class ProcessorAcpiCsdDependency
    {
		public uint CoordType { get; private set; }
		public uint Domain { get; private set; }
		public uint Index { get; private set; }
		public byte NumberOfEntries { get; private set; }
		public uint NumProcessors { get; private set; }
		public uint Reserved1 { get; private set; }
		public ulong Reserved2 { get; private set; }
		public byte Revision { get; private set; }

        public static IEnumerable<ProcessorAcpiCsdDependency> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ProcessorAcpiCsdDependency> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ProcessorAcpiCsdDependency> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM ProcessorAcpiCsdDependency");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ProcessorAcpiCsdDependency
                {
                     CoordType = (uint) (managementObject.Properties["CoordType"]?.Value ?? default(uint)),
		 Domain = (uint) (managementObject.Properties["Domain"]?.Value ?? default(uint)),
		 Index = (uint) (managementObject.Properties["Index"]?.Value ?? default(uint)),
		 NumberOfEntries = (byte) (managementObject.Properties["NumberOfEntries"]?.Value ?? default(byte)),
		 NumProcessors = (uint) (managementObject.Properties["NumProcessors"]?.Value ?? default(uint)),
		 Reserved1 = (uint) (managementObject.Properties["Reserved1"]?.Value ?? default(uint)),
		 Reserved2 = (ulong) (managementObject.Properties["Reserved2"]?.Value ?? default(ulong)),
		 Revision = (byte) (managementObject.Properties["Revision"]?.Value ?? default(byte))
                };
        }
    }
}