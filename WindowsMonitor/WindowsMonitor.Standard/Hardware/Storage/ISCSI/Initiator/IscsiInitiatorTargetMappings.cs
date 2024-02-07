using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.ISCSI.Initiator
{
    /// <summary>
    /// </summary>
    public sealed class IscsiInitiatorTargetMappings
    {
		public string InitiatorName { get; private set; }
		public dynamic[] LunList { get; private set; }
		public uint OsBusNumber { get; private set; }
		public string OsDeviceName { get; private set; }
		public uint OsTargetNumber { get; private set; }
		public string TargetName { get; private set; }

        public static IEnumerable<IscsiInitiatorTargetMappings> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<IscsiInitiatorTargetMappings> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<IscsiInitiatorTargetMappings> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSiSCSIInitiator_TargetMappings");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new IscsiInitiatorTargetMappings
                {
                     InitiatorName = (string) (managementObject.Properties["InitiatorName"]?.Value ?? default(string)),
		 LunList = (dynamic[]) (managementObject.Properties["LUNList"]?.Value ?? new dynamic[0]),
		 OsBusNumber = (uint) (managementObject.Properties["OSBusNumber"]?.Value ?? default(uint)),
		 OsDeviceName = (string) (managementObject.Properties["OSDeviceName"]?.Value ?? default(string)),
		 OsTargetNumber = (uint) (managementObject.Properties["OSTargetNumber"]?.Value ?? default(uint)),
		 TargetName = (string) (managementObject.Properties["TargetName"]?.Value ?? default(string))
                };
        }
    }
}