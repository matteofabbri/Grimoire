using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.ISCSI.Initiator
{
    /// <summary>
    /// </summary>
    public sealed class MsiScsiInitiatorDeviceOnSession
    {
        public string DeviceInterfaceGuid { get; private set; }
        public string DeviceInterfaceName { get; private set; }
        public uint DeviceNumber { get; private set; }
        public uint DeviceType { get; private set; }
        public string InitiatorName { get; private set; }
        public string LegacyName { get; private set; }
        public uint PartitionNumber { get; private set; }
        public byte ScsiLun { get; private set; }
        public byte ScsiPathId { get; private set; }
        public byte ScsiPortNumber { get; private set; }
        public byte ScsiTargetId { get; private set; }
        public string TargetName { get; private set; }

        public static IEnumerable<MsiScsiInitiatorDeviceOnSession> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<MsiScsiInitiatorDeviceOnSession> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<MsiScsiInitiatorDeviceOnSession> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSiSCSIInitiator_DeviceOnSession");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new MsiScsiInitiatorDeviceOnSession
                {
                    DeviceInterfaceGuid = (string) (managementObject.Properties["DeviceInterfaceGuid"]?.Value ?? default(string)),
                    DeviceInterfaceName = (string) (managementObject.Properties["DeviceInterfaceName"]?.Value ?? default(string)),
                    DeviceNumber = (uint) (managementObject.Properties["DeviceNumber"]?.Value ?? default(uint)),
                    DeviceType = (uint) (managementObject.Properties["DeviceType"]?.Value ?? default(uint)),
                    InitiatorName = (string) (managementObject.Properties["InitiatorName"]?.Value ?? default(string)),
                    LegacyName = (string) (managementObject.Properties["LegacyName"]?.Value ?? default(string)),
                    PartitionNumber = (uint) (managementObject.Properties["PartitionNumber"]?.Value ?? default(uint)),
                    ScsiLun = (byte) (managementObject.Properties["ScsiLun"]?.Value ?? default(byte)),
                    ScsiPathId = (byte) (managementObject.Properties["ScsiPathId"]?.Value ?? default(byte)),
                    ScsiPortNumber = (byte) (managementObject.Properties["ScsiPortNumber"]?.Value ?? default(byte)),
                    ScsiTargetId = (byte) (managementObject.Properties["ScsiTargetId"]?.Value ?? default(byte)),
                    TargetName = (string) (managementObject.Properties["TargetName"]?.Value ?? default(string))
                };
        }
    }
}