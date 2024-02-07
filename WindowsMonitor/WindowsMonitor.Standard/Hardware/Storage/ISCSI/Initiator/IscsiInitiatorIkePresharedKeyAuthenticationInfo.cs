using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.ISCSI.Initiator
{
    /// <summary>
    /// </summary>
    public sealed class IscsiInitiatorIkePresharedKeyAuthenticationInfo
    {
		public uint AuthMethod { get; private set; }
		public byte[] Id { get; private set; }
		public uint IdType { get; private set; }
		public byte[] Key { get; private set; }
		public ulong SecurityFlags { get; private set; }

        public static IEnumerable<IscsiInitiatorIkePresharedKeyAuthenticationInfo> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<IscsiInitiatorIkePresharedKeyAuthenticationInfo> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<IscsiInitiatorIkePresharedKeyAuthenticationInfo> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSiSCSIInitiator_IKEPresharedKeyAuthenticationInfo");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new IscsiInitiatorIkePresharedKeyAuthenticationInfo
                {
                     AuthMethod = (uint) (managementObject.Properties["AuthMethod"]?.Value ?? default(uint)),
		 Id = (byte[]) (managementObject.Properties["Id"]?.Value ?? new byte[0]),
		 IdType = (uint) (managementObject.Properties["IdType"]?.Value ?? default(uint)),
		 Key = (byte[]) (managementObject.Properties["key"]?.Value ?? new byte[0]),
		 SecurityFlags = (ulong) (managementObject.Properties["SecurityFlags"]?.Value ?? default(ulong))
                };
        }
    }
}