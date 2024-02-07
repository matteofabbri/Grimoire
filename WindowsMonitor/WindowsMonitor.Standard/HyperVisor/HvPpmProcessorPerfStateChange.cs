using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.HyperVisor
{
    /// <summary>
    /// </summary>
    public sealed class HvPpmProcessorPerfStateChange
    {
		public ulong CurrentPercentageOfMaxFrequency { get; private set; }
		public ulong Currentstate { get; private set; }
		public ulong DomainId { get; private set; }
		public ulong LpIndex { get; private set; }
		public ulong PerfCheckTime { get; private set; }
		public ulong TargetPercentageOfMaxFrequency { get; private set; }

        public static IEnumerable<HvPpmProcessorPerfStateChange> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HvPpmProcessorPerfStateChange> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HvPpmProcessorPerfStateChange> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HvPpmProcessorPerfStateChange");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HvPpmProcessorPerfStateChange
                {
                     CurrentPercentageOfMaxFrequency = (ulong) (managementObject.Properties["CurrentPercentageOfMaxFrequency"]?.Value ?? default(ulong)),
		 Currentstate = (ulong) (managementObject.Properties["Currentstate"]?.Value ?? default(ulong)),
		 DomainId = (ulong) (managementObject.Properties["DomainId"]?.Value ?? default(ulong)),
		 LpIndex = (ulong) (managementObject.Properties["LpIndex"]?.Value ?? default(ulong)),
		 PerfCheckTime = (ulong) (managementObject.Properties["PerfCheckTime"]?.Value ?? default(ulong)),
		 TargetPercentageOfMaxFrequency = (ulong) (managementObject.Properties["TargetPercentageOfMaxFrequency"]?.Value ?? default(ulong))
                };
        }
    }
}