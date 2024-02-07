using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.HBA
{
    /// <summary>
    /// </summary>
    public sealed class HbaScsiId
    {
		public ushort[] OsDeviceName { get; private set; }
		public uint ScsiBusNumber { get; private set; }
		public uint ScsiOsLun { get; private set; }
		public uint ScsiTargetNumber { get; private set; }

        public static IEnumerable<HbaScsiId> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HbaScsiId> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HbaScsiId> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HBAScsiID");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HbaScsiId
                {
                     OsDeviceName = (ushort[]) (managementObject.Properties["OSDeviceName"]?.Value ?? new ushort[0]),
		 ScsiBusNumber = (uint) (managementObject.Properties["ScsiBusNumber"]?.Value ?? default(uint)),
		 ScsiOsLun = (uint) (managementObject.Properties["ScsiOSLun"]?.Value ?? default(uint)),
		 ScsiTargetNumber = (uint) (managementObject.Properties["ScsiTargetNumber"]?.Value ?? default(uint))
                };
        }
    }
}