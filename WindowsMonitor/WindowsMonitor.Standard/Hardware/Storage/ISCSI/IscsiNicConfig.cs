using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.ISCSI
{
    /// <summary>
    /// </summary>
    public sealed class IscsiNicConfig
    {
		public bool Active { get; private set; }
		public string InstanceName { get; private set; }
		public uint LinkSpeed { get; private set; }
		public uint LinkState { get; private set; }
		public byte[] MacAddress { get; private set; }
		public uint MaxFrameSize { get; private set; }
		public uint MaxLinkSpeed { get; private set; }

        public static IEnumerable<IscsiNicConfig> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<IscsiNicConfig> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<IscsiNicConfig> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSiSCSI_NICConfig");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new IscsiNicConfig
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 LinkSpeed = (uint) (managementObject.Properties["LinkSpeed"]?.Value ?? default(uint)),
		 LinkState = (uint) (managementObject.Properties["LinkState"]?.Value ?? default(uint)),
		 MacAddress = (byte[]) (managementObject.Properties["MacAddress"]?.Value ?? new byte[0]),
		 MaxFrameSize = (uint) (managementObject.Properties["MaxFrameSize"]?.Value ?? default(uint)),
		 MaxLinkSpeed = (uint) (managementObject.Properties["MaxLinkSpeed"]?.Value ?? default(uint))
                };
        }
    }
}