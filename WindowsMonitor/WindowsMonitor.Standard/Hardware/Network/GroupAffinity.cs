using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network
{
    /// <summary>
    /// </summary>
    public sealed class GroupAffinity
    {
		public ushort Group { get; private set; }
		public ulong Mask { get; private set; }
		public ushort[] Reserved { get; private set; }

        public static IEnumerable<GroupAffinity> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<GroupAffinity> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<GroupAffinity> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_GroupAffinity");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new GroupAffinity
                {
                     Group = (ushort) (managementObject.Properties["Group"]?.Value ?? default(ushort)),
		 Mask = (ulong) (managementObject.Properties["Mask"]?.Value ?? default(ulong)),
		 Reserved = (ushort[]) (managementObject.Properties["Reserved"]?.Value ?? new ushort[0])
                };
        }
    }
}