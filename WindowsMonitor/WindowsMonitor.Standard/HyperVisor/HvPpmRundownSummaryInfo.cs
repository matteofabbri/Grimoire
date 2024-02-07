using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.HyperVisor
{
    /// <summary>
    /// </summary>
    public sealed class HvPpmRundownSummaryInfo
    {
		public ulong IdleStateCount { get; private set; }
		public ulong PccEnabled { get; private set; }
		public ulong PerfStateCount { get; private set; }
		public ulong ThrottleStateCount { get; private set; }

        public static IEnumerable<HvPpmRundownSummaryInfo> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HvPpmRundownSummaryInfo> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HvPpmRundownSummaryInfo> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HvPpmRundownSummaryInfo");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HvPpmRundownSummaryInfo
                {
                     IdleStateCount = (ulong) (managementObject.Properties["IdleStateCount"]?.Value ?? default(ulong)),
		 PccEnabled = (ulong) (managementObject.Properties["PccEnabled"]?.Value ?? default(ulong)),
		 PerfStateCount = (ulong) (managementObject.Properties["PerfStateCount"]?.Value ?? default(ulong)),
		 ThrottleStateCount = (ulong) (managementObject.Properties["ThrottleStateCount"]?.Value ?? default(ulong))
                };
        }
    }
}