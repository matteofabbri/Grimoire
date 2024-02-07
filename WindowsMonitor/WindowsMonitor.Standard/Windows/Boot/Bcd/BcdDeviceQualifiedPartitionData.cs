using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Boot.Bcd
{
    /// <summary>
    /// </summary>
    public sealed class BcdDeviceQualifiedPartitionData
    {
		public string AdditionalOptions { get; private set; }
		public uint DeviceType { get; private set; }
		public string DiskSignature { get; private set; }
		public string PartitionIdentifier { get; private set; }
		public uint PartitionStyle { get; private set; }

        public static IEnumerable<BcdDeviceQualifiedPartitionData> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<BcdDeviceQualifiedPartitionData> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<BcdDeviceQualifiedPartitionData> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM BcdDeviceQualifiedPartitionData");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new BcdDeviceQualifiedPartitionData
                {
                     AdditionalOptions = (string) (managementObject.Properties["AdditionalOptions"]?.Value ?? default(string)),
		 DeviceType = (uint) (managementObject.Properties["DeviceType"]?.Value ?? default(uint)),
		 DiskSignature = (string) (managementObject.Properties["DiskSignature"]?.Value ?? default(string)),
		 PartitionIdentifier = (string) (managementObject.Properties["PartitionIdentifier"]?.Value ?? default(string)),
		 PartitionStyle = (uint) (managementObject.Properties["PartitionStyle"]?.Value ?? default(uint))
                };
        }
    }
}