using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.HyperVisor
{
    /// <summary>
    /// </summary>
    public sealed class HvApicEoi
    {
		public ulong GuestRip { get; private set; }
		public ulong Vector { get; private set; }

        public static IEnumerable<HvApicEoi> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HvApicEoi> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HvApicEoi> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HvApicEoi");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HvApicEoi
                {
                     GuestRip = (ulong) (managementObject.Properties["GuestRip"]?.Value ?? default(ulong)),
		 Vector = (ulong) (managementObject.Properties["Vector"]?.Value ?? default(ulong))
                };
        }
    }
}