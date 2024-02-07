using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network.Fddi
{
    /// <summary>
    /// </summary>
    public sealed class FddiAttachmentType
    {
		public bool Active { get; private set; }
		public string InstanceName { get; private set; }
		public uint NdisFddiAttachmentType { get; private set; }

        public static IEnumerable<FddiAttachmentType> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<FddiAttachmentType> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<FddiAttachmentType> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_FddiAttachmentType");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new FddiAttachmentType
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 NdisFddiAttachmentType = (uint) (managementObject.Properties["NdisFddiAttachmentType"]?.Value ?? default(uint))
                };
        }
    }
}