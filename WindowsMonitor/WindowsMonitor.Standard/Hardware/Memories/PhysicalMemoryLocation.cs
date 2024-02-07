using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Memories
{
    /// <summary>
    /// </summary>
    public sealed class PhysicalMemoryLocation
    {
		public string GroupComponent { get; private set; }
		public string LocationWithinContainer { get; private set; }
		public string PartComponent { get; private set; }

        public static IEnumerable<PhysicalMemoryLocation> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<PhysicalMemoryLocation> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<PhysicalMemoryLocation> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PhysicalMemoryLocation");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new PhysicalMemoryLocation
                {
                     GroupComponent =  (managementObject.Properties["GroupComponent"]?.Value?.ToString()),
		 LocationWithinContainer = (string) (managementObject.Properties["LocationWithinContainer"]?.Value),
		 PartComponent =  (managementObject.Properties["PartComponent"]?.Value?.ToString())
                };
        }
    }
}