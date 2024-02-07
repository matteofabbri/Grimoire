using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.ISCSI
{
    /// <summary>
    /// </summary>
    public sealed class IscsiLoginOptions
    {
		public uint AuthType { get; private set; }
		public uint DataDigest { get; private set; }
		public uint DefaultTime2Retain { get; private set; }
		public uint DefaultTime2Wait { get; private set; }
		public uint HeaderDigest { get; private set; }
		public uint InformationSpecified { get; private set; }
		public uint LoginFlags { get; private set; }
		public uint MaximumConnections { get; private set; }

        public static IEnumerable<IscsiLoginOptions> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<IscsiLoginOptions> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<IscsiLoginOptions> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM ISCSI_LoginOptions");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new IscsiLoginOptions
                {
                     AuthType = (uint) (managementObject.Properties["AuthType"]?.Value ?? default(uint)),
		 DataDigest = (uint) (managementObject.Properties["DataDigest"]?.Value ?? default(uint)),
		 DefaultTime2Retain = (uint) (managementObject.Properties["DefaultTime2Retain"]?.Value ?? default(uint)),
		 DefaultTime2Wait = (uint) (managementObject.Properties["DefaultTime2Wait"]?.Value ?? default(uint)),
		 HeaderDigest = (uint) (managementObject.Properties["HeaderDigest"]?.Value ?? default(uint)),
		 InformationSpecified = (uint) (managementObject.Properties["InformationSpecified"]?.Value ?? default(uint)),
		 LoginFlags = (uint) (managementObject.Properties["LoginFlags"]?.Value ?? default(uint)),
		 MaximumConnections = (uint) (managementObject.Properties["MaximumConnections"]?.Value ?? default(uint))
                };
        }
    }
}