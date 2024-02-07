using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.ISCSI
{
    /// <summary>
    /// </summary>
    public sealed class IscsiHbaSessionConfig
    {
		public bool Active { get; private set; }
		public uint FirstBurstLength { get; private set; }
		public bool ImmediateData { get; private set; }
		public bool InitialR2T { get; private set; }
		public string InstanceName { get; private set; }
		public uint MaxBurstLength { get; private set; }
		public uint MaxOutstandingR2T { get; private set; }
		public uint MaxRecvDataSegmentLength { get; private set; }

        public static IEnumerable<IscsiHbaSessionConfig> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<IscsiHbaSessionConfig> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<IscsiHbaSessionConfig> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSiSCSI_HBASessionConfig");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new IscsiHbaSessionConfig
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 FirstBurstLength = (uint) (managementObject.Properties["FirstBurstLength"]?.Value ?? default(uint)),
		 ImmediateData = (bool) (managementObject.Properties["ImmediateData"]?.Value ?? default(bool)),
		 InitialR2T = (bool) (managementObject.Properties["InitialR2T"]?.Value ?? default(bool)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 MaxBurstLength = (uint) (managementObject.Properties["MaxBurstLength"]?.Value ?? default(uint)),
		 MaxOutstandingR2T = (uint) (managementObject.Properties["MaxOutstandingR2T"]?.Value ?? default(uint)),
		 MaxRecvDataSegmentLength = (uint) (managementObject.Properties["MaxRecvDataSegmentLength"]?.Value ?? default(uint))
                };
        }
    }
}