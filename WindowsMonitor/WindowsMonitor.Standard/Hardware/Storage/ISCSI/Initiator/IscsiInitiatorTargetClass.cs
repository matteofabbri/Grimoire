using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.ISCSI.Initiator
{
    /// <summary>
    /// </summary>
    public sealed class IscsiInitiatorTargetClass
    {
		public string DiscoveryMechanism { get; private set; }
		public string InitiatorName { get; private set; }
		public dynamic LoginOptions { get; private set; }
		public dynamic Mappings { get; private set; }
		public dynamic[] PortalGroups { get; private set; }
		public uint ProtocolType { get; private set; }
		public string TargetAlias { get; private set; }
		public uint TargetFlags { get; private set; }
		public string TargetName { get; private set; }

        public static IEnumerable<IscsiInitiatorTargetClass> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<IscsiInitiatorTargetClass> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<IscsiInitiatorTargetClass> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSiSCSIInitiator_TargetClass");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new IscsiInitiatorTargetClass
                {
                     DiscoveryMechanism = (string) (managementObject.Properties["DiscoveryMechanism"]?.Value ?? default(string)),
		 InitiatorName = (string) (managementObject.Properties["InitiatorName"]?.Value ?? default(string)),
		 LoginOptions = (dynamic) (managementObject.Properties["LoginOptions"]?.Value ?? default(dynamic)),
		 Mappings = (dynamic) (managementObject.Properties["Mappings"]?.Value ?? default(dynamic)),
		 PortalGroups = (dynamic[]) (managementObject.Properties["PortalGroups"]?.Value ?? new dynamic[0]),
		 ProtocolType = (uint) (managementObject.Properties["ProtocolType"]?.Value ?? default(uint)),
		 TargetAlias = (string) (managementObject.Properties["TargetAlias"]?.Value ?? default(string)),
		 TargetFlags = (uint) (managementObject.Properties["TargetFlags"]?.Value ?? default(uint)),
		 TargetName = (string) (managementObject.Properties["TargetName"]?.Value ?? default(string))
                };
        }
    }
}