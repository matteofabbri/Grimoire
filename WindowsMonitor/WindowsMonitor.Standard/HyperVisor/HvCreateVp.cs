using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.HyperVisor
{
    /// <summary>
    /// </summary>
    public sealed class HvCreateVp
    {
		public ulong HvStatus { get; private set; }
		public ulong PartitionId { get; private set; }
		public ulong ThreadId { get; private set; }

        public static IEnumerable<HvCreateVp> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HvCreateVp> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HvCreateVp> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HvCreateVp");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HvCreateVp
                {
                     HvStatus = (ulong) (managementObject.Properties["HvStatus"]?.Value ?? default(ulong)),
		 PartitionId = (ulong) (managementObject.Properties["PartitionId"]?.Value ?? default(ulong)),
		 ThreadId = (ulong) (managementObject.Properties["ThreadId"]?.Value ?? default(ulong))
                };
        }
    }
}