using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.ISCSI.Initiator
{
    /// <summary>
    /// </summary>
    public sealed class IscsiInitiatorTargetAddress
    {
		public uint OsBusNumber { get; private set; }
		public string OsDeviceName { get; private set; }
		public uint OsLunNumber { get; private set; }
		public uint OsTargetNumber { get; private set; }

        public static IEnumerable<IscsiInitiatorTargetAddress> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<IscsiInitiatorTargetAddress> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<IscsiInitiatorTargetAddress> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSiSCSIInitiator_TargetAddress");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new IscsiInitiatorTargetAddress
                {
                     OsBusNumber = (uint) (managementObject.Properties["OSBusNumber"]?.Value ?? default(uint)),
		 OsDeviceName = (string) (managementObject.Properties["OSDeviceName"]?.Value ?? default(string)),
		 OsLunNumber = (uint) (managementObject.Properties["OSLunNumber"]?.Value ?? default(uint)),
		 OsTargetNumber = (uint) (managementObject.Properties["OSTargetNumber"]?.Value ?? default(uint))
                };
        }
    }
}