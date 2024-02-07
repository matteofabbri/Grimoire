using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.HyperVisor
{
    /// <summary>
    /// </summary>
    public sealed class HvPpmIdle
    {
		public ulong IdleDuration { get; private set; }
		public ulong IdleState { get; private set; }
		public ulong InterruptVector { get; private set; }

        public static IEnumerable<HvPpmIdle> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HvPpmIdle> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HvPpmIdle> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HvPpmIdle");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HvPpmIdle
                {
                     IdleDuration = (ulong) (managementObject.Properties["IdleDuration"]?.Value ?? default(ulong)),
		 IdleState = (ulong) (managementObject.Properties["IdleState"]?.Value ?? default(ulong)),
		 InterruptVector = (ulong) (managementObject.Properties["InterruptVector"]?.Value ?? default(ulong))
                };
        }
    }
}