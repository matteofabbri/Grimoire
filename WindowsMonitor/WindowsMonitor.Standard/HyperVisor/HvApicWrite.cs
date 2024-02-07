using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.HyperVisor
{
    /// <summary>
    /// </summary>
    public sealed class HvApicWrite
    {
		public ulong ByteOffset { get; private set; }
		public ulong Data { get; private set; }
		public ulong GuestRip { get; private set; }

        public static IEnumerable<HvApicWrite> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HvApicWrite> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HvApicWrite> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HvApicWrite");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HvApicWrite
                {
                     ByteOffset = (ulong) (managementObject.Properties["ByteOffset"]?.Value ?? default(ulong)),
		 Data = (ulong) (managementObject.Properties["Data"]?.Value ?? default(ulong)),
		 GuestRip = (ulong) (managementObject.Properties["GuestRip"]?.Value ?? default(ulong))
                };
        }
    }
}