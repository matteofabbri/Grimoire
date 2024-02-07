using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.HyperVisor
{
    /// <summary>
    /// </summary>
    public sealed class HvOverrunParams
    {
		public ulong Param1 { get; private set; }
		public ulong Param2 { get; private set; }
		public ulong Param3 { get; private set; }

        public static IEnumerable<HvOverrunParams> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HvOverrunParams> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HvOverrunParams> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HvOverrunParams");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HvOverrunParams
                {
                     Param1 = (ulong) (managementObject.Properties["Param1"]?.Value ?? default(ulong)),
		 Param2 = (ulong) (managementObject.Properties["Param2"]?.Value ?? default(ulong)),
		 Param3 = (ulong) (managementObject.Properties["Param3"]?.Value ?? default(ulong))
                };
        }
    }
}