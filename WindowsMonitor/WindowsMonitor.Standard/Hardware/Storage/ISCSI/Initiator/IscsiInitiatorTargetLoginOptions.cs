using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.ISCSI.Initiator
{
    /// <summary>
    /// </summary>
    public sealed class IscsiInitiatorTargetLoginOptions
    {
		public uint AuthType { get; private set; }
		public uint DataDigest { get; private set; }
		public uint DefaultTime2Retain { get; private set; }
		public uint DefaultTime2Wait { get; private set; }
		public uint HeaderDigest { get; private set; }
		public uint InformationSpecified { get; private set; }
		public uint LoginFlags { get; private set; }
		public uint MaximumConnections { get; private set; }
		public byte[] Password { get; private set; }
		public byte[] Username { get; private set; }
		public uint Version { get; private set; }

        public static IEnumerable<IscsiInitiatorTargetLoginOptions> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<IscsiInitiatorTargetLoginOptions> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<IscsiInitiatorTargetLoginOptions> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSiSCSIInitiator_TargetLoginOptions");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new IscsiInitiatorTargetLoginOptions
                {
                     AuthType = (uint) (managementObject.Properties["AuthType"]?.Value ?? default(uint)),
		 DataDigest = (uint) (managementObject.Properties["DataDigest"]?.Value ?? default(uint)),
		 DefaultTime2Retain = (uint) (managementObject.Properties["DefaultTime2Retain"]?.Value ?? default(uint)),
		 DefaultTime2Wait = (uint) (managementObject.Properties["DefaultTime2Wait"]?.Value ?? default(uint)),
		 HeaderDigest = (uint) (managementObject.Properties["HeaderDigest"]?.Value ?? default(uint)),
		 InformationSpecified = (uint) (managementObject.Properties["InformationSpecified"]?.Value ?? default(uint)),
		 LoginFlags = (uint) (managementObject.Properties["LoginFlags"]?.Value ?? default(uint)),
		 MaximumConnections = (uint) (managementObject.Properties["MaximumConnections"]?.Value ?? default(uint)),
		 Password = (byte[]) (managementObject.Properties["Password"]?.Value ?? new byte[0]),
		 Username = (byte[]) (managementObject.Properties["Username"]?.Value ?? new byte[0]),
		 Version = (uint) (managementObject.Properties["Version"]?.Value ?? default(uint))
                };
        }
    }
}