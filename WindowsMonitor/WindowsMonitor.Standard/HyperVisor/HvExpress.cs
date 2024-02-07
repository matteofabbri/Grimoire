using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.HyperVisor
{
    /// <summary>
    /// </summary>
    public sealed class HvExpress
    {
		public ulong SignaledProcessorSet { get; private set; }
		public ulong TargetProcessorSet { get; private set; }

        public static IEnumerable<HvExpress> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HvExpress> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HvExpress> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HvExpress");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HvExpress
                {
                     SignaledProcessorSet = (ulong) (managementObject.Properties["SignaledProcessorSet"]?.Value ?? default(ulong)),
		 TargetProcessorSet = (ulong) (managementObject.Properties["TargetProcessorSet"]?.Value ?? default(ulong))
                };
        }
    }
}