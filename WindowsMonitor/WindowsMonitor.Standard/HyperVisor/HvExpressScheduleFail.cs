using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.HyperVisor
{
    /// <summary>
    /// </summary>
    public sealed class HvExpressScheduleFail
    {
		public ulong ProcessId { get; private set; }
		public ulong RequestCounter { get; private set; }
		public ulong SchedulerId { get; private set; }
		public ulong SchedulingUnitId { get; private set; }

        public static IEnumerable<HvExpressScheduleFail> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HvExpressScheduleFail> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HvExpressScheduleFail> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HvExpressScheduleFail");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HvExpressScheduleFail
                {
                     ProcessId = (ulong) (managementObject.Properties["ProcessId"]?.Value ?? default(ulong)),
		 RequestCounter = (ulong) (managementObject.Properties["RequestCounter"]?.Value ?? default(ulong)),
		 SchedulerId = (ulong) (managementObject.Properties["SchedulerId"]?.Value ?? default(ulong)),
		 SchedulingUnitId = (ulong) (managementObject.Properties["SchedulingUnitId"]?.Value ?? default(ulong))
                };
        }
    }
}