using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.HyperVisor
{
    /// <summary>
    /// </summary>
    public sealed class HvSchedulingUnitRunnableDeferred
    {
		public ulong LocalRunListSize { get; private set; }
		public ulong ProcessId { get; private set; }
		public ulong SchedulerId { get; private set; }
		public ulong SchedulerReserves { get; private set; }
		public ulong SchedulingUnitId { get; private set; }

        public static IEnumerable<HvSchedulingUnitRunnableDeferred> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HvSchedulingUnitRunnableDeferred> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HvSchedulingUnitRunnableDeferred> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HvSchedulingUnitRunnableDeferred");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HvSchedulingUnitRunnableDeferred
                {
                     LocalRunListSize = (ulong) (managementObject.Properties["LocalRunListSize"]?.Value ?? default(ulong)),
		 ProcessId = (ulong) (managementObject.Properties["ProcessId"]?.Value ?? default(ulong)),
		 SchedulerId = (ulong) (managementObject.Properties["SchedulerId"]?.Value ?? default(ulong)),
		 SchedulerReserves = (ulong) (managementObject.Properties["SchedulerReserves"]?.Value ?? default(ulong)),
		 SchedulingUnitId = (ulong) (managementObject.Properties["SchedulingUnitId"]?.Value ?? default(ulong))
                };
        }
    }
}