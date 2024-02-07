using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Acpi
{
    /// <summary>
    /// </summary>
    public sealed class AcpiGenAddr
    {
		public ulong Address { get; private set; }
		public uint AddressSpaceId { get; private set; }
		public uint BitOffset { get; private set; }
		public uint BitWidth { get; private set; }
		public uint Reserved { get; private set; }

        public static IEnumerable<AcpiGenAddr> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<AcpiGenAddr> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<AcpiGenAddr> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM AcpiGenAddr");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new AcpiGenAddr
                {
                     Address = (ulong) (managementObject.Properties["Address"]?.Value ?? default(ulong)),
		 AddressSpaceId = (uint) (managementObject.Properties["AddressSpaceID"]?.Value ?? default(uint)),
		 BitOffset = (uint) (managementObject.Properties["BitOffset"]?.Value ?? default(uint)),
		 BitWidth = (uint) (managementObject.Properties["BitWidth"]?.Value ?? default(uint)),
		 Reserved = (uint) (managementObject.Properties["Reserved"]?.Value ?? default(uint))
                };
        }
    }
}