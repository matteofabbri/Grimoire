using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Memories
{
    /// <summary>
    /// </summary>
    public sealed class AssociatedProcessorMemory
    {
		public string Antecedent { get; private set; }
		public uint BusSpeed { get; private set; }
		public string Dependent { get; private set; }

        public static IEnumerable<AssociatedProcessorMemory> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<AssociatedProcessorMemory> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<AssociatedProcessorMemory> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_AssociatedProcessorMemory");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new AssociatedProcessorMemory
                {
                     Antecedent = (string) (managementObject.Properties["Antecedent"]?.Value ?? default(string)),
		 BusSpeed = (uint) (managementObject.Properties["BusSpeed"]?.Value ?? default(uint)),
		 Dependent = (string) (managementObject.Properties["Dependent"]?.Value ?? default(string))
                };
        }
    }
}