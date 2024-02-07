using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.HyperVisor
{
    /// <summary>
    /// </summary>
    public sealed class HvPpmSummaryInfo
    {
		public ulong DomainId { get; private set; }
		public ulong IdleStateCount { get; private set; }
		public ulong LpIndex { get; private set; }
		public ulong PccEnabled { get; private set; }
		public ulong PerfStateCount { get; private set; }
		public ulong ThrottleStateCount { get; private set; }

        public static IEnumerable<HvPpmSummaryInfo> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HvPpmSummaryInfo> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HvPpmSummaryInfo> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HvPpmSummaryInfo");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HvPpmSummaryInfo
                {
                     DomainId = (ulong) (managementObject.Properties["DomainId"]?.Value ?? default(ulong)),
		 IdleStateCount = (ulong) (managementObject.Properties["IdleStateCount"]?.Value ?? default(ulong)),
		 LpIndex = (ulong) (managementObject.Properties["LpIndex"]?.Value ?? default(ulong)),
		 PccEnabled = (ulong) (managementObject.Properties["PccEnabled"]?.Value ?? default(ulong)),
		 PerfStateCount = (ulong) (managementObject.Properties["PerfStateCount"]?.Value ?? default(ulong)),
		 ThrottleStateCount = (ulong) (managementObject.Properties["ThrottleStateCount"]?.Value ?? default(ulong))
                };
        }
    }
}