using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.SerialPort
{
    /// <summary>
    /// </summary>
    public sealed class SerialCommInfo
    {
        public bool Active { get; private set; }
        public uint BaudRate { get; private set; }
        public uint BitsPerByte { get; private set; }
        public string InstanceName { get; private set; }
        public bool IsBusy { get; private set; }
        public uint MaximumBaudRate { get; private set; }
        public uint MaximumInputBufferSize { get; private set; }
        public uint MaximumOutputBufferSize { get; private set; }
        public uint Parity { get; private set; }
        public bool ParityCheckEnable { get; private set; }
        public bool SettableBaudRate { get; private set; }
        public bool SettableDataBits { get; private set; }
        public bool SettableFlowControl { get; private set; }
        public bool SettableParity { get; private set; }
        public bool SettableParityCheck { get; private set; }
        public bool SettableStopBits { get; private set; }
        public uint StopBits { get; private set; }
        public bool Support16BitMode { get; private set; }
        public bool SupportDtrdsr { get; private set; }
        public bool SupportIntervalTimeouts { get; private set; }
        public bool SupportParityCheck { get; private set; }
        public bool SupportRtscts { get; private set; }
        public bool SupportXonXoff { get; private set; }
        public uint XoffCharacter { get; private set; }
        public uint XoffXmitThreshold { get; private set; }
        public uint XonCharacter { get; private set; }
        public uint XonXmitThreshold { get; private set; }

        public static IEnumerable<SerialCommInfo> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SerialCommInfo> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SerialCommInfo> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSSerial_CommInfo");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SerialCommInfo
                {
                    Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
                    BaudRate = (uint) (managementObject.Properties["BaudRate"]?.Value ?? default(uint)),
                    BitsPerByte = (uint) (managementObject.Properties["BitsPerByte"]?.Value ?? default(uint)),
                    InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
                    IsBusy = (bool) (managementObject.Properties["IsBusy"]?.Value ?? default(bool)),
                    MaximumBaudRate = (uint) (managementObject.Properties["MaximumBaudRate"]?.Value ?? default(uint)),
                    MaximumInputBufferSize =
                        (uint) (managementObject.Properties["MaximumInputBufferSize"]?.Value ?? default(uint)),
                    MaximumOutputBufferSize =
                        (uint) (managementObject.Properties["MaximumOutputBufferSize"]?.Value ?? default(uint)),
                    Parity = (uint) (managementObject.Properties["Parity"]?.Value ?? default(uint)),
                    ParityCheckEnable =
                        (bool) (managementObject.Properties["ParityCheckEnable"]?.Value ?? default(bool)),
                    SettableBaudRate = (bool) (managementObject.Properties["SettableBaudRate"]?.Value ?? default(bool)),
                    SettableDataBits = (bool) (managementObject.Properties["SettableDataBits"]?.Value ?? default(bool)),
                    SettableFlowControl =
                        (bool) (managementObject.Properties["SettableFlowControl"]?.Value ?? default(bool)),
                    SettableParity = (bool) (managementObject.Properties["SettableParity"]?.Value ?? default(bool)),
                    SettableParityCheck =
                        (bool) (managementObject.Properties["SettableParityCheck"]?.Value ?? default(bool)),
                    SettableStopBits = (bool) (managementObject.Properties["SettableStopBits"]?.Value ?? default(bool)),
                    StopBits = (uint) (managementObject.Properties["StopBits"]?.Value ?? default(uint)),
                    Support16BitMode = (bool) (managementObject.Properties["Support16BitMode"]?.Value ?? default(bool)),
                    SupportDtrdsr = (bool) (managementObject.Properties["SupportDTRDSR"]?.Value ?? default(bool)),
                    SupportIntervalTimeouts =
                        (bool) (managementObject.Properties["SupportIntervalTimeouts"]?.Value ?? default(bool)),
                    SupportParityCheck =
                        (bool) (managementObject.Properties["SupportParityCheck"]?.Value ?? default(bool)),
                    SupportRtscts = (bool) (managementObject.Properties["SupportRTSCTS"]?.Value ?? default(bool)),
                    SupportXonXoff = (bool) (managementObject.Properties["SupportXonXoff"]?.Value ?? default(bool)),
                    XoffCharacter = (uint) (managementObject.Properties["XoffCharacter"]?.Value ?? default(uint)),
                    XoffXmitThreshold =
                        (uint) (managementObject.Properties["XoffXmitThreshold"]?.Value ?? default(uint)),
                    XonCharacter = (uint) (managementObject.Properties["XonCharacter"]?.Value ?? default(uint)),
                    XonXmitThreshold = (uint) (managementObject.Properties["XonXmitThreshold"]?.Value ?? default(uint))
                };
        }
    }
}