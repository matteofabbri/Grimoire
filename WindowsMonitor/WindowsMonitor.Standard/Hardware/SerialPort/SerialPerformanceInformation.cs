using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.SerialPort
{
    /// <summary>
    /// </summary>
    public sealed class SerialPerformanceInformation
    {
        public bool Active { get; private set; }
        public uint BufferOverrunErrorCount { get; private set; }
        public uint FrameErrorCount { get; private set; }
        public string InstanceName { get; private set; }
        public uint ParityErrorCount { get; private set; }
        public uint ReceivedCount { get; private set; }
        public uint SerialOverrunErrorCount { get; private set; }
        public uint TransmittedCount { get; private set; }

        public static IEnumerable<SerialPerformanceInformation> Retrieve(string remote, string username,
            string password)
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

        public static IEnumerable<SerialPerformanceInformation> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SerialPerformanceInformation> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSSerial_PerformanceInformation");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SerialPerformanceInformation
                {
                    Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
                    BufferOverrunErrorCount =
                        (uint) (managementObject.Properties["BufferOverrunErrorCount"]?.Value ?? default(uint)),
                    FrameErrorCount = (uint) (managementObject.Properties["FrameErrorCount"]?.Value ?? default(uint)),
                    InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
                    ParityErrorCount = (uint) (managementObject.Properties["ParityErrorCount"]?.Value ?? default(uint)),
                    ReceivedCount = (uint) (managementObject.Properties["ReceivedCount"]?.Value ?? default(uint)),
                    SerialOverrunErrorCount =
                        (uint) (managementObject.Properties["SerialOverrunErrorCount"]?.Value ?? default(uint)),
                    TransmittedCount = (uint) (managementObject.Properties["TransmittedCount"]?.Value ?? default(uint))
                };
        }
    }
}