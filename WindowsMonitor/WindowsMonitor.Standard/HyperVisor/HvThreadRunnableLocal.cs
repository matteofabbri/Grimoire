using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.HyperVisor
{
    /// <summary>
    /// </summary>
    public sealed class HvThreadRunnableLocal
    {
		public ulong CpuReserves { get; private set; }
		public ulong ProcessId { get; private set; }
		public ulong ThreadId { get; private set; }

        public static IEnumerable<HvThreadRunnableLocal> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HvThreadRunnableLocal> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HvThreadRunnableLocal> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HvThreadRunnableLocal");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HvThreadRunnableLocal
                {
                     CpuReserves = (ulong) (managementObject.Properties["CpuReserves"]?.Value ?? default(ulong)),
		 ProcessId = (ulong) (managementObject.Properties["ProcessId"]?.Value ?? default(ulong)),
		 ThreadId = (ulong) (managementObject.Properties["ThreadId"]?.Value ?? default(ulong))
                };
        }
    }
}