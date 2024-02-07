using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.HyperVisor
{
    /// <summary>
    /// </summary>
    public sealed class HvSample
    {
		public ulong Cr3 { get; private set; }
		public ulong Ip { get; private set; }
		public ulong PartitionId { get; private set; }
		public ulong ProfileSource { get; private set; }
		public ulong VpId { get; private set; }
		public ulong VpTsc { get; private set; }

        public static IEnumerable<HvSample> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HvSample> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HvSample> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HvSample");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HvSample
                {
                     Cr3 = (ulong) (managementObject.Properties["Cr3"]?.Value ?? default(ulong)),
		 Ip = (ulong) (managementObject.Properties["Ip"]?.Value ?? default(ulong)),
		 PartitionId = (ulong) (managementObject.Properties["PartitionId"]?.Value ?? default(ulong)),
		 ProfileSource = (ulong) (managementObject.Properties["ProfileSource"]?.Value ?? default(ulong)),
		 VpId = (ulong) (managementObject.Properties["VpId"]?.Value ?? default(ulong)),
		 VpTsc = (ulong) (managementObject.Properties["VpTsc"]?.Value ?? default(ulong))
                };
        }
    }
}