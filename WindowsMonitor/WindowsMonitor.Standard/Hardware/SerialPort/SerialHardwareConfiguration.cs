using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.SerialPort
{
    /// <summary>
    /// </summary>
    public sealed class SerialHardwareConfiguration
    {
        public bool Active { get; private set; }
        public ulong BaseIoAddress { get; private set; }
        public string InstanceName { get; private set; }
        public uint InterruptType { get; private set; }
        public ulong IrqAffinityMask { get; private set; }
        public uint IrqLevel { get; private set; }
        public uint IrqNumber { get; private set; }
        public uint IrqVector { get; private set; }

        public static IEnumerable<SerialHardwareConfiguration> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SerialHardwareConfiguration> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SerialHardwareConfiguration> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSSerial_HardwareConfiguration");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SerialHardwareConfiguration
                {
                    Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
                    BaseIoAddress = (ulong) (managementObject.Properties["BaseIOAddress"]?.Value ?? default(ulong)),
                    InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
                    InterruptType = (uint) (managementObject.Properties["InterruptType"]?.Value ?? default(uint)),
                    IrqAffinityMask = (ulong) (managementObject.Properties["IrqAffinityMask"]?.Value ?? default(ulong)),
                    IrqLevel = (uint) (managementObject.Properties["IrqLevel"]?.Value ?? default(uint)),
                    IrqNumber = (uint) (managementObject.Properties["IrqNumber"]?.Value ?? default(uint)),
                    IrqVector = (uint) (managementObject.Properties["IrqVector"]?.Value ?? default(uint))
                };
        }
    }
}