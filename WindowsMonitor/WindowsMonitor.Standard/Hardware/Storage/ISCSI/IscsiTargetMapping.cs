using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.ISCSI
{
    /// <summary>
    /// </summary>
    public sealed class IscsiTargetMapping
    {
		public bool FromPersistentLogin { get; private set; }
		public uint LunCount { get; private set; }
		public dynamic[] LunList { get; private set; }
		public uint OsBus { get; private set; }
		public uint OsTarget { get; private set; }
		public ulong Reserved { get; private set; }
		public string TargetName { get; private set; }
		public ulong UniqueSessionId { get; private set; }

        public static IEnumerable<IscsiTargetMapping> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<IscsiTargetMapping> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<IscsiTargetMapping> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM ISCSI_TargetMapping");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new IscsiTargetMapping
                {
                     FromPersistentLogin = (bool) (managementObject.Properties["FromPersistentLogin"]?.Value ?? default(bool)),
		 LunCount = (uint) (managementObject.Properties["LUNCount"]?.Value ?? default(uint)),
		 LunList = (dynamic[]) (managementObject.Properties["LUNList"]?.Value ?? new dynamic[0]),
		 OsBus = (uint) (managementObject.Properties["OSBus"]?.Value ?? default(uint)),
		 OsTarget = (uint) (managementObject.Properties["OSTarget"]?.Value ?? default(uint)),
		 Reserved = (ulong) (managementObject.Properties["Reserved"]?.Value ?? default(ulong)),
		 TargetName = (string) (managementObject.Properties["TargetName"]?.Value ?? default(string)),
		 UniqueSessionId = (ulong) (managementObject.Properties["UniqueSessionId"]?.Value ?? default(ulong))
                };
        }
    }
}