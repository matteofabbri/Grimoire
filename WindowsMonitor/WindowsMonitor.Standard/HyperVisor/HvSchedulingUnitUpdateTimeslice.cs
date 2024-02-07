using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.HyperVisor
{
    /// <summary>
    /// </summary>
    public sealed class HvSchedulingUnitUpdateTimeslice
    {
		public ulong LocalRunListSize { get; private set; }
		public ulong ProcessId { get; private set; }
		public ulong SchedulerId { get; private set; }
		public ulong SchedulingInterval { get; private set; }
		public ulong SchedulingUnitId { get; private set; }
		public ulong TimeSlice { get; private set; }

        public static IEnumerable<HvSchedulingUnitUpdateTimeslice> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HvSchedulingUnitUpdateTimeslice> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HvSchedulingUnitUpdateTimeslice> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HvSchedulingUnitUpdateTimeslice");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HvSchedulingUnitUpdateTimeslice
                {
                     LocalRunListSize = (ulong) (managementObject.Properties["LocalRunListSize"]?.Value ?? default(ulong)),
		 ProcessId = (ulong) (managementObject.Properties["ProcessId"]?.Value ?? default(ulong)),
		 SchedulerId = (ulong) (managementObject.Properties["SchedulerId"]?.Value ?? default(ulong)),
		 SchedulingInterval = (ulong) (managementObject.Properties["SchedulingInterval"]?.Value ?? default(ulong)),
		 SchedulingUnitId = (ulong) (managementObject.Properties["SchedulingUnitId"]?.Value ?? default(ulong)),
		 TimeSlice = (ulong) (managementObject.Properties["TimeSlice"]?.Value ?? default(ulong))
                };
        }
    }
}