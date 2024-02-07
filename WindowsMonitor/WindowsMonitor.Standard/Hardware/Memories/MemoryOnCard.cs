using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Memories
{
    /// <summary>
    /// </summary>
    public sealed class MemoryOnCard
    {
		public string GroupComponent { get; private set; }
		public string LocationWithinContainer { get; private set; }
		public string PartComponent { get; private set; }

        public static IEnumerable<MemoryOnCard> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<MemoryOnCard> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<MemoryOnCard> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_MemoryOnCard");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new MemoryOnCard
                {
                     GroupComponent = (string) (managementObject.Properties["GroupComponent"]?.Value ?? default(string)),
		 LocationWithinContainer = (string) (managementObject.Properties["LocationWithinContainer"]?.Value),
		 PartComponent = (string) (managementObject.Properties["PartComponent"]?.Value ?? default(string))
                };
        }
    }
}