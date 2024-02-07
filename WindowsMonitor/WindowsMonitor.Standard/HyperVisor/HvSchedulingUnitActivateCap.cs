using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.HyperVisor
{
    /// <summary>
    /// </summary>
    public sealed class HvSchedulingUnitActivateCap
    {
		public ulong Cap { get; private set; }
		public ulong CapEndTime { get; private set; }
		public ulong MaxCappedQuantum { get; private set; }
		public ulong ProcessId { get; private set; }
		public ulong SchedulerId { get; private set; }
		public ulong SchedulingUnitId { get; private set; }

        public static IEnumerable<HvSchedulingUnitActivateCap> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HvSchedulingUnitActivateCap> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HvSchedulingUnitActivateCap> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HvSchedulingUnitActivateCap");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HvSchedulingUnitActivateCap
                {
                     Cap = (ulong) (managementObject.Properties["Cap"]?.Value ?? default(ulong)),
		 CapEndTime = (ulong) (managementObject.Properties["CapEndTime"]?.Value ?? default(ulong)),
		 MaxCappedQuantum = (ulong) (managementObject.Properties["MaxCappedQuantum"]?.Value ?? default(ulong)),
		 ProcessId = (ulong) (managementObject.Properties["ProcessId"]?.Value ?? default(ulong)),
		 SchedulerId = (ulong) (managementObject.Properties["SchedulerId"]?.Value ?? default(ulong)),
		 SchedulingUnitId = (ulong) (managementObject.Properties["SchedulingUnitId"]?.Value ?? default(ulong))
                };
        }
    }
}