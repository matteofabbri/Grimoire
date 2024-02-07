using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.HyperVisor
{
    /// <summary>
    /// </summary>
    public sealed class HvSchedulingUnitSwitch
    {
		public ulong ProcessId { get; private set; }
		public ulong Quantum { get; private set; }
		public ulong SchedulerId { get; private set; }
		public ulong SchedulingUnitId { get; private set; }
		public ulong SwitchReason { get; private set; }
		public ulong WaitTime { get; private set; }

        public static IEnumerable<HvSchedulingUnitSwitch> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HvSchedulingUnitSwitch> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HvSchedulingUnitSwitch> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HvSchedulingUnitSwitch");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HvSchedulingUnitSwitch
                {
                     ProcessId = (ulong) (managementObject.Properties["ProcessId"]?.Value ?? default(ulong)),
		 Quantum = (ulong) (managementObject.Properties["Quantum"]?.Value ?? default(ulong)),
		 SchedulerId = (ulong) (managementObject.Properties["SchedulerId"]?.Value ?? default(ulong)),
		 SchedulingUnitId = (ulong) (managementObject.Properties["SchedulingUnitId"]?.Value ?? default(ulong)),
		 SwitchReason = (ulong) (managementObject.Properties["SwitchReason"]?.Value ?? default(ulong)),
		 WaitTime = (ulong) (managementObject.Properties["WaitTime"]?.Value ?? default(ulong))
                };
        }
    }
}