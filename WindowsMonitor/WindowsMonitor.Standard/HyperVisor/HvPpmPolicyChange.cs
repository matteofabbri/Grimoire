using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.HyperVisor
{
    /// <summary>
    /// </summary>
    public sealed class HvPpmPolicyChange
    {
		public ulong SettingId { get; private set; }
		public ulong ValueApplied { get; private set; }
		public ulong ValueCurrent { get; private set; }
		public ulong ValueRequested { get; private set; }

        public static IEnumerable<HvPpmPolicyChange> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HvPpmPolicyChange> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HvPpmPolicyChange> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HvPpmPolicyChange");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HvPpmPolicyChange
                {
                     SettingId = (ulong) (managementObject.Properties["SettingId"]?.Value ?? default(ulong)),
		 ValueApplied = (ulong) (managementObject.Properties["ValueApplied"]?.Value ?? default(ulong)),
		 ValueCurrent = (ulong) (managementObject.Properties["ValueCurrent"]?.Value ?? default(ulong)),
		 ValueRequested = (ulong) (managementObject.Properties["ValueRequested"]?.Value ?? default(ulong))
                };
        }
    }
}