using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.HyperVisor
{
    /// <summary>
    /// </summary>
    public sealed class HvOverrun
    {
		public ulong CallCode { get; private set; }
		public ulong InterceptState { get; private set; }
		public ulong Param1 { get; private set; }
		public ulong Param2 { get; private set; }
		public ulong RunTime { get; private set; }

        public static IEnumerable<HvOverrun> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HvOverrun> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HvOverrun> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HvOverrun");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HvOverrun
                {
                     CallCode = (ulong) (managementObject.Properties["CallCode"]?.Value ?? default(ulong)),
		 InterceptState = (ulong) (managementObject.Properties["InterceptState"]?.Value ?? default(ulong)),
		 Param1 = (ulong) (managementObject.Properties["Param1"]?.Value ?? default(ulong)),
		 Param2 = (ulong) (managementObject.Properties["Param2"]?.Value ?? default(ulong)),
		 RunTime = (ulong) (managementObject.Properties["RunTime"]?.Value ?? default(ulong))
                };
        }
    }
}