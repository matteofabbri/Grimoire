using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.HyperVisor
{
    /// <summary>
    /// </summary>
    public sealed class HvHvModule
    {
		public ulong HypervisorBaseAddress { get; private set; }

        public static IEnumerable<HvHvModule> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HvHvModule> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HvHvModule> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HvHvModule");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HvHvModule
                {
                     HypervisorBaseAddress = (ulong) (managementObject.Properties["HypervisorBaseAddress"]?.Value ?? default(ulong))
                };
        }
    }
}