using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.HyperVisor
{
    /// <summary>
    /// </summary>
    public sealed class HvApplyCap
    {
		public ulong AdjustedCap { get; private set; }
		public ulong BaseCap { get; private set; }
		public ulong InputTimeSliceRatio { get; private set; }
		public ulong NowTime { get; private set; }
		public ulong PreviousDeadline { get; private set; }
		public ulong Utilization { get; private set; }

        public static IEnumerable<HvApplyCap> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HvApplyCap> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HvApplyCap> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HvApplyCap");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HvApplyCap
                {
                     AdjustedCap = (ulong) (managementObject.Properties["AdjustedCap"]?.Value ?? default(ulong)),
		 BaseCap = (ulong) (managementObject.Properties["BaseCap"]?.Value ?? default(ulong)),
		 InputTimeSliceRatio = (ulong) (managementObject.Properties["InputTimeSliceRatio"]?.Value ?? default(ulong)),
		 NowTime = (ulong) (managementObject.Properties["NowTime"]?.Value ?? default(ulong)),
		 PreviousDeadline = (ulong) (managementObject.Properties["PreviousDeadline"]?.Value ?? default(ulong)),
		 Utilization = (ulong) (managementObject.Properties["Utilization"]?.Value ?? default(ulong))
                };
        }
    }
}