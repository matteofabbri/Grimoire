using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.ISCSI.Initiator
{
    /// <summary>
    /// </summary>
    public sealed class IscsiInitiatorPersistentLoginClass
    {
		public string InitiatorInstance { get; private set; }
		public uint InitiatorPortNumber { get; private set; }
		public bool IsInformationalSession { get; private set; }
		public dynamic LoginOptions { get; private set; }
		public dynamic Mappings { get; private set; }
		public ulong SecurityFlags { get; private set; }
		public string TargetName { get; private set; }
		public dynamic TargetPortal { get; private set; }

        public static IEnumerable<IscsiInitiatorPersistentLoginClass> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<IscsiInitiatorPersistentLoginClass> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<IscsiInitiatorPersistentLoginClass> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSiSCSIInitiator_PersistentLoginClass");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new IscsiInitiatorPersistentLoginClass
                {
                     InitiatorInstance = (string) (managementObject.Properties["InitiatorInstance"]?.Value ?? default(string)),
		 InitiatorPortNumber = (uint) (managementObject.Properties["InitiatorPortNumber"]?.Value ?? default(uint)),
		 IsInformationalSession = (bool) (managementObject.Properties["IsInformationalSession"]?.Value ?? default(bool)),
		 LoginOptions = (dynamic) (managementObject.Properties["LoginOptions"]?.Value ?? default(dynamic)),
		 Mappings = (dynamic) (managementObject.Properties["Mappings"]?.Value ?? default(dynamic)),
		 SecurityFlags = (ulong) (managementObject.Properties["SecurityFlags"]?.Value ?? default(ulong)),
		 TargetName = (string) (managementObject.Properties["TargetName"]?.Value ?? default(string)),
		 TargetPortal = (dynamic) (managementObject.Properties["TargetPortal"]?.Value ?? default(dynamic))
                };
        }
    }
}