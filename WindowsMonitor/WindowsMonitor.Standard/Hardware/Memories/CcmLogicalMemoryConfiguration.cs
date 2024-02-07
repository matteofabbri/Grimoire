using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Memories
{
    /// <summary>
    /// </summary>
    public sealed class CcmLogicalMemoryConfiguration
    {
        public ulong AvailableVirtualMemory { get; private set; }
        public string Name { get; private set; }
        public ulong TotalPageFileSpace { get; private set; }
        public ulong TotalPhysicalMemory { get; private set; }
        public ulong TotalVirtualMemory { get; private set; }

        public static IEnumerable<CcmLogicalMemoryConfiguration> Retrieve(string remote, string username,
            string password)
        {
            var options = new ConnectionOptions
            {
                Impersonation = ImpersonationLevel.Impersonate,
                Username = username,
                Password = password
            };

            var managementScope = new ManagementScope(new ManagementPath($"\\\\{remote}\\root\\cimv2"), options);
            managementScope.Connect();

            return Retrieve(managementScope);
        }

        public static IEnumerable<CcmLogicalMemoryConfiguration> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<CcmLogicalMemoryConfiguration> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CCM_LogicalMemoryConfiguration");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new CcmLogicalMemoryConfiguration
                {
                    AvailableVirtualMemory =
                        (ulong) (managementObject.Properties["AvailableVirtualMemory"]?.Value ?? default(ulong)),
                    Name = (string) managementObject.Properties["Name"]?.Value,
                    TotalPageFileSpace =
                        (ulong) (managementObject.Properties["TotalPageFileSpace"]?.Value ?? default(ulong)),
                    TotalPhysicalMemory =
                        (ulong) (managementObject.Properties["TotalPhysicalMemory"]?.Value ?? default(ulong)),
                    TotalVirtualMemory =
                        (ulong) (managementObject.Properties["TotalVirtualMemory"]?.Value ?? default(ulong))
                };
        }
    }
}