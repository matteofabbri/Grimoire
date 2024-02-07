using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.HyperVisor
{
    /// <summary>
    /// </summary>
    public sealed class HvExpressSchedule
    {
		public ulong SchedulerId { get; private set; }
		public ulong SignaledProcessorSet { get; private set; }

        public static IEnumerable<HvExpressSchedule> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HvExpressSchedule> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HvExpressSchedule> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HvExpressSchedule");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HvExpressSchedule
                {
                     SchedulerId = (ulong) (managementObject.Properties["SchedulerId"]?.Value ?? default(ulong)),
		 SignaledProcessorSet = (ulong) (managementObject.Properties["SignaledProcessorSet"]?.Value ?? default(ulong))
                };
        }
    }
}