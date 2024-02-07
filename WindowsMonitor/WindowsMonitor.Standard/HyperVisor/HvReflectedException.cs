using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.HyperVisor
{
    /// <summary>
    /// </summary>
    public sealed class HvReflectedException
    {
		public ulong ExceptionNumber { get; private set; }
		public ulong GuestRip { get; private set; }

        public static IEnumerable<HvReflectedException> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HvReflectedException> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HvReflectedException> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HvReflectedException");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HvReflectedException
                {
                     ExceptionNumber = (ulong) (managementObject.Properties["ExceptionNumber"]?.Value ?? default(ulong)),
		 GuestRip = (ulong) (managementObject.Properties["GuestRip"]?.Value ?? default(ulong))
                };
        }
    }
}