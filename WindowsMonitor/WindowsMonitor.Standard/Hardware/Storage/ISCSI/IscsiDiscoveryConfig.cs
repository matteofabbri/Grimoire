using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.ISCSI
{
    /// <summary>
    /// </summary>
    public sealed class IscsiDiscoveryConfig
    {
		public bool Active { get; private set; }
		public bool AutomaticiSnsDiscovery { get; private set; }
		public string InitiatorName { get; private set; }
		public string InstanceName { get; private set; }
		public dynamic ISnsServer { get; private set; }
		public bool PerformiSnsDiscovery { get; private set; }
		public bool PerformSlpDiscovery { get; private set; }

        public static IEnumerable<IscsiDiscoveryConfig> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<IscsiDiscoveryConfig> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<IscsiDiscoveryConfig> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSiSCSI_DiscoveryConfig");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new IscsiDiscoveryConfig
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 AutomaticiSnsDiscovery = (bool) (managementObject.Properties["AutomaticiSNSDiscovery"]?.Value ?? default(bool)),
		 InitiatorName = (string) (managementObject.Properties["InitiatorName"]?.Value ?? default(string)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 ISnsServer = (dynamic) (managementObject.Properties["iSNSServer"]?.Value ?? default(dynamic)),
		 PerformiSnsDiscovery = (bool) (managementObject.Properties["PerformiSNSDiscovery"]?.Value ?? default(bool)),
		 PerformSlpDiscovery = (bool) (managementObject.Properties["PerformSLPDiscovery"]?.Value ?? default(bool))
                };
        }
    }
}