using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.ISCSI
{
    /// <summary>
    /// </summary>
    public sealed class IscsiSupportedLbPolicies
    {
		public uint IScsiPathCount { get; private set; }
		public dynamic[] IScsiPaths { get; private set; }
		public uint LoadBalancePolicy { get; private set; }
		public ulong UniqueSessionId { get; private set; }

        public static IEnumerable<IscsiSupportedLbPolicies> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<IscsiSupportedLbPolicies> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<IscsiSupportedLbPolicies> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM ISCSI_Supported_LB_Policies");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new IscsiSupportedLbPolicies
                {
                     IScsiPathCount = (uint) (managementObject.Properties["iSCSI_PathCount"]?.Value ?? default(uint)),
		 IScsiPaths = (dynamic[]) (managementObject.Properties["iSCSI_Paths"]?.Value ?? new dynamic[0]),
		 LoadBalancePolicy = (uint) (managementObject.Properties["LoadBalancePolicy"]?.Value ?? default(uint)),
		 UniqueSessionId = (ulong) (managementObject.Properties["UniqueSessionId"]?.Value ?? default(ulong))
                };
        }
    }
}