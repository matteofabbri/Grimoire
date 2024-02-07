using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.ISCSI
{
    /// <summary>
    /// </summary>
    public sealed class IscsiQueryLbPolicy
    {
		public bool Active { get; private set; }
		public string InstanceName { get; private set; }
		public dynamic[] LoadBalancePolicies { get; private set; }
		public uint Reserved { get; private set; }
		public uint SessionCount { get; private set; }
		public ulong UniqueAdapterId { get; private set; }

        public static IEnumerable<IscsiQueryLbPolicy> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<IscsiQueryLbPolicy> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<IscsiQueryLbPolicy> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSiSCSI_QueryLBPolicy");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new IscsiQueryLbPolicy
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 LoadBalancePolicies = (dynamic[]) (managementObject.Properties["LoadBalancePolicies"]?.Value ?? new dynamic[0]),
		 Reserved = (uint) (managementObject.Properties["Reserved"]?.Value ?? default(uint)),
		 SessionCount = (uint) (managementObject.Properties["SessionCount"]?.Value ?? default(uint)),
		 UniqueAdapterId = (ulong) (managementObject.Properties["UniqueAdapterId"]?.Value ?? default(ulong))
                };
        }
    }
}