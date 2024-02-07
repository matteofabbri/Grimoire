using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Drives.TapeDrives
{
    /// <summary>
    /// </summary>
    public sealed class TapeDriveParam
    {
		public bool Active { get; private set; }
		public bool CompressionCapable { get; private set; }
		public bool CompressionEnabled { get; private set; }
		public uint DefaultBlockSize { get; private set; }
		public bool HardwareErrorCorrection { get; private set; }
		public string InstanceName { get; private set; }
		public uint MaximumBlockSize { get; private set; }
		public uint MaximumPartitionCount { get; private set; }
		public uint MinimumBlockSize { get; private set; }
		public bool ReportSetmarks { get; private set; }

        public static IEnumerable<TapeDriveParam> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<TapeDriveParam> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<TapeDriveParam> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSTapeDriveParam");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new TapeDriveParam
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 CompressionCapable = (bool) (managementObject.Properties["CompressionCapable"]?.Value ?? default(bool)),
		 CompressionEnabled = (bool) (managementObject.Properties["CompressionEnabled"]?.Value ?? default(bool)),
		 DefaultBlockSize = (uint) (managementObject.Properties["DefaultBlockSize"]?.Value ?? default(uint)),
		 HardwareErrorCorrection = (bool) (managementObject.Properties["HardwareErrorCorrection"]?.Value ?? default(bool)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 MaximumBlockSize = (uint) (managementObject.Properties["MaximumBlockSize"]?.Value ?? default(uint)),
		 MaximumPartitionCount = (uint) (managementObject.Properties["MaximumPartitionCount"]?.Value ?? default(uint)),
		 MinimumBlockSize = (uint) (managementObject.Properties["MinimumBlockSize"]?.Value ?? default(uint)),
		 ReportSetmarks = (bool) (managementObject.Properties["ReportSetmarks"]?.Value ?? default(bool))
                };
        }
    }
}