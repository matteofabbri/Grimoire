using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.HyperVisor
{
    /// <summary>
    /// </summary>
    public sealed class HvInitPartition
    {
		public ulong PartitionId { get; private set; }
		public ulong ReferenceTimeOffset { get; private set; }
		public ulong TscOffset { get; private set; }

        public static IEnumerable<HvInitPartition> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HvInitPartition> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HvInitPartition> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HvInitPartition");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HvInitPartition
                {
                     PartitionId = (ulong) (managementObject.Properties["PartitionId"]?.Value ?? default(ulong)),
		 ReferenceTimeOffset = (ulong) (managementObject.Properties["ReferenceTimeOffset"]?.Value ?? default(ulong)),
		 TscOffset = (ulong) (managementObject.Properties["TscOffset"]?.Value ?? default(ulong))
                };
        }
    }
}