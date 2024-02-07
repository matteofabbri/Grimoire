using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.HyperVisor
{
    /// <summary>
    /// </summary>
    public sealed class HvPpmCapEvent
    {
		public ulong LpIndex { get; private set; }
		public ulong PStateCap { get; private set; }
		public ulong ThermalCap { get; private set; }
		public ulong StateCap { get; private set; }

        public static IEnumerable<HvPpmCapEvent> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HvPpmCapEvent> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HvPpmCapEvent> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HvPpmCapEvent");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HvPpmCapEvent
                {
                     LpIndex = (ulong) (managementObject.Properties["LpIndex"]?.Value ?? default(ulong)),
		 PStateCap = (ulong) (managementObject.Properties["PStateCap"]?.Value ?? default(ulong)),
		 ThermalCap = (ulong) (managementObject.Properties["ThermalCap"]?.Value ?? default(ulong)),
		 StateCap = (ulong) (managementObject.Properties["TStateCap"]?.Value ?? default(ulong))
                };
        }
    }
}