using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.HyperVisor
{
    /// <summary>
    /// </summary>
    public sealed class HvDumpIntMapping
    {
		public ulong DeviceId { get; private set; }
		public ulong PartitionId { get; private set; }
		public ulong TargetInfo { get; private set; }
		public ulong TargetLpset0 { get; private set; }
		public ulong TargetLpset1 { get; private set; }
		public ulong TargetVpset { get; private set; }

        public static IEnumerable<HvDumpIntMapping> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HvDumpIntMapping> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HvDumpIntMapping> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HvDumpIntMapping");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HvDumpIntMapping
                {
                     DeviceId = (ulong) (managementObject.Properties["DeviceId"]?.Value ?? default(ulong)),
		 PartitionId = (ulong) (managementObject.Properties["PartitionId"]?.Value ?? default(ulong)),
		 TargetInfo = (ulong) (managementObject.Properties["TargetInfo"]?.Value ?? default(ulong)),
		 TargetLpset0 = (ulong) (managementObject.Properties["TargetLpset0"]?.Value ?? default(ulong)),
		 TargetLpset1 = (ulong) (managementObject.Properties["TargetLpset1"]?.Value ?? default(ulong)),
		 TargetVpset = (ulong) (managementObject.Properties["TargetVpset"]?.Value ?? default(ulong))
                };
        }
    }
}