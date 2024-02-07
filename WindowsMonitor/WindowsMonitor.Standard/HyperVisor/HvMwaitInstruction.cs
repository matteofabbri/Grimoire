using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.HyperVisor
{
    /// <summary>
    /// </summary>
    public sealed class HvMwaitInstruction
    {
		public ulong GuestRip { get; private set; }
		public ulong MwaitExtension { get; private set; }
		public ulong MwaitHint { get; private set; }

        public static IEnumerable<HvMwaitInstruction> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HvMwaitInstruction> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HvMwaitInstruction> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HvMwaitInstruction");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HvMwaitInstruction
                {
                     GuestRip = (ulong) (managementObject.Properties["GuestRip"]?.Value ?? default(ulong)),
		 MwaitExtension = (ulong) (managementObject.Properties["MwaitExtension"]?.Value ?? default(ulong)),
		 MwaitHint = (ulong) (managementObject.Properties["MwaitHint"]?.Value ?? default(ulong))
                };
        }
    }
}