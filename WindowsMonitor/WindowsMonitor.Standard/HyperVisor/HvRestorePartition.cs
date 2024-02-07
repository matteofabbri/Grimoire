using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.HyperVisor
{
    /// <summary>
    /// </summary>
    public sealed class HvRestorePartition
    {
		public ulong PartitionId { get; private set; }
		public ulong ReferenceTimeOffset { get; private set; }
		public ulong TscOffset { get; private set; }

        public static IEnumerable<HvRestorePartition> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HvRestorePartition> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HvRestorePartition> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HvRestorePartition");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HvRestorePartition
                {
                     PartitionId = (ulong) (managementObject.Properties["PartitionId"]?.Value ?? default(ulong)),
		 ReferenceTimeOffset = (ulong) (managementObject.Properties["ReferenceTimeOffset"]?.Value ?? default(ulong)),
		 TscOffset = (ulong) (managementObject.Properties["TscOffset"]?.Value ?? default(ulong))
                };
        }
    }
}