using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.HyperVisor
{
    /// <summary>
    /// </summary>
    public sealed class HvMsrWrite
    {
		public ulong GuestRip { get; private set; }
		public ulong Index { get; private set; }
		public ulong Value { get; private set; }

        public static IEnumerable<HvMsrWrite> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HvMsrWrite> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HvMsrWrite> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HvMsrWrite");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HvMsrWrite
                {
                     GuestRip = (ulong) (managementObject.Properties["GuestRip"]?.Value ?? default(ulong)),
		 Index = (ulong) (managementObject.Properties["Index"]?.Value ?? default(ulong)),
		 Value = (ulong) (managementObject.Properties["Value"]?.Value ?? default(ulong))
                };
        }
    }
}