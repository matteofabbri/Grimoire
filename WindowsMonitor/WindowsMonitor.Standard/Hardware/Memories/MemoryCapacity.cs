using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Memories
{
    /// <summary>
    /// </summary>
    public sealed class MemoryCapacity
    {
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong MaximumMemoryCapacity { get; private set; }
		public ushort MemoryType { get; private set; }
		public ulong MinimumMemoryCapacity { get; private set; }
		public string Name { get; private set; }

        public static IEnumerable<MemoryCapacity> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<MemoryCapacity> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<MemoryCapacity> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_MemoryCapacity");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new MemoryCapacity
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 MaximumMemoryCapacity = (ulong) (managementObject.Properties["MaximumMemoryCapacity"]?.Value ?? default(ulong)),
		 MemoryType = (ushort) (managementObject.Properties["MemoryType"]?.Value ?? default(ushort)),
		 MinimumMemoryCapacity = (ulong) (managementObject.Properties["MinimumMemoryCapacity"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value)
                };
        }
    }
}