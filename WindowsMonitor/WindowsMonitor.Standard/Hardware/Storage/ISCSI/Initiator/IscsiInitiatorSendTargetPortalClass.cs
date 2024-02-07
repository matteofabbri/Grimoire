using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.ISCSI.Initiator
{
    /// <summary>
    /// </summary>
    public sealed class IscsiInitiatorSendTargetPortalClass
    {
		public string InitiatorName { get; private set; }
		public uint InitiatorPortNumber { get; private set; }
		public dynamic LoginOptions { get; private set; }
		public string PortalAddress { get; private set; }
		public string PortalIdentifierString { get; private set; }
		public ushort PortalPort { get; private set; }
		public string PortalSymbolicName { get; private set; }
		public ulong SecurityFlags { get; private set; }

        public static IEnumerable<IscsiInitiatorSendTargetPortalClass> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<IscsiInitiatorSendTargetPortalClass> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<IscsiInitiatorSendTargetPortalClass> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSiSCSIInitiator_SendTargetPortalClass");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new IscsiInitiatorSendTargetPortalClass
                {
                     InitiatorName = (string) (managementObject.Properties["InitiatorName"]?.Value ?? default(string)),
		 InitiatorPortNumber = (uint) (managementObject.Properties["InitiatorPortNumber"]?.Value ?? default(uint)),
		 LoginOptions = (dynamic) (managementObject.Properties["LoginOptions"]?.Value ?? default(dynamic)),
		 PortalAddress = (string) (managementObject.Properties["PortalAddress"]?.Value ?? default(string)),
		 PortalIdentifierString = (string) (managementObject.Properties["PortalIdentifierString"]?.Value ?? default(string)),
		 PortalPort = (ushort) (managementObject.Properties["PortalPort"]?.Value ?? default(ushort)),
		 PortalSymbolicName = (string) (managementObject.Properties["PortalSymbolicName"]?.Value ?? default(string)),
		 SecurityFlags = (ulong) (managementObject.Properties["SecurityFlags"]?.Value ?? default(ulong))
                };
        }
    }
}