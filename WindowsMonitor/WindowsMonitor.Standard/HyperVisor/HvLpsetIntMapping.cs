using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.HyperVisor
{
    /// <summary>
    /// </summary>
    public sealed class HvLpsetIntMapping
    {
		public ulong TargetLpset2 { get; private set; }
		public ulong TargetLpset3 { get; private set; }
		public ulong TargetLpset4 { get; private set; }
		public ulong TargetLpset5 { get; private set; }
		public ulong TargetLpset6 { get; private set; }
		public ulong TargetLpset7 { get; private set; }

        public static IEnumerable<HvLpsetIntMapping> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HvLpsetIntMapping> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HvLpsetIntMapping> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HvLpsetIntMapping");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HvLpsetIntMapping
                {
                     TargetLpset2 = (ulong) (managementObject.Properties["TargetLpset2"]?.Value ?? default(ulong)),
		 TargetLpset3 = (ulong) (managementObject.Properties["TargetLpset3"]?.Value ?? default(ulong)),
		 TargetLpset4 = (ulong) (managementObject.Properties["TargetLpset4"]?.Value ?? default(ulong)),
		 TargetLpset5 = (ulong) (managementObject.Properties["TargetLpset5"]?.Value ?? default(ulong)),
		 TargetLpset6 = (ulong) (managementObject.Properties["TargetLpset6"]?.Value ?? default(ulong)),
		 TargetLpset7 = (ulong) (managementObject.Properties["TargetLpset7"]?.Value ?? default(ulong))
                };
        }
    }
}