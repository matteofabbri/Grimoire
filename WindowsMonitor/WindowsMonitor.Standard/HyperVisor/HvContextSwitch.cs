using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.HyperVisor
{
    /// <summary>
    /// </summary>
    public sealed class HvContextSwitch
    {
		public ulong ProcessId { get; private set; }
		public ulong Quantum { get; private set; }
		public ulong Reason { get; private set; }
		public ulong ThreadId { get; private set; }
		public ulong TscOffset { get; private set; }
		public ulong WaitTime { get; private set; }

        public static IEnumerable<HvContextSwitch> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HvContextSwitch> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HvContextSwitch> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HvContextSwitch");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HvContextSwitch
                {
                     ProcessId = (ulong) (managementObject.Properties["ProcessId"]?.Value ?? default(ulong)),
		 Quantum = (ulong) (managementObject.Properties["Quantum"]?.Value ?? default(ulong)),
		 Reason = (ulong) (managementObject.Properties["Reason"]?.Value ?? default(ulong)),
		 ThreadId = (ulong) (managementObject.Properties["ThreadId"]?.Value ?? default(ulong)),
		 TscOffset = (ulong) (managementObject.Properties["TscOffset"]?.Value ?? default(ulong)),
		 WaitTime = (ulong) (managementObject.Properties["WaitTime"]?.Value ?? default(ulong))
                };
        }
    }
}