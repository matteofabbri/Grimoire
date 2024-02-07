using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.HyperVisor
{
    /// <summary>
    /// </summary>
    public sealed class HvLivedump
    {
		public ulong DepositedPageCount { get; private set; }
		public ulong Duration { get; private set; }
		public ulong PagesCopied { get; private set; }

        public static IEnumerable<HvLivedump> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HvLivedump> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HvLivedump> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HvLivedump");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HvLivedump
                {
                     DepositedPageCount = (ulong) (managementObject.Properties["DepositedPageCount"]?.Value ?? default(ulong)),
		 Duration = (ulong) (managementObject.Properties["Duration"]?.Value ?? default(ulong)),
		 PagesCopied = (ulong) (managementObject.Properties["PagesCopied"]?.Value ?? default(ulong))
                };
        }
    }
}