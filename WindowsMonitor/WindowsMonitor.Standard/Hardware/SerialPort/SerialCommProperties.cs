using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.SerialPort
{
    /// <summary>
    /// </summary>
    public sealed class SerialCommProperties
    {
        public bool Active { get; private set; }
        public uint DwCurrentRxQueue { get; private set; }
        public uint DwCurrentTxQueue { get; private set; }
        public uint DwMaxBaud { get; private set; }
        public uint DwMaxRxQueue { get; private set; }
        public uint DwMaxTxQueue { get; private set; }
        public uint DwProvCapabilities { get; private set; }
        public uint DwProvCharSize { get; private set; }
        public uint DwProvSpec1 { get; private set; }
        public uint DwProvSpec2 { get; private set; }
        public uint DwProvSubType { get; private set; }
        public uint DwReserved1 { get; private set; }
        public uint DwServiceMask { get; private set; }
        public uint DwSettableBaud { get; private set; }
        public uint DwSettableParams { get; private set; }
        public string InstanceName { get; private set; }
        public byte[] WcProvChar { get; private set; }
        public ushort WPacketLength { get; private set; }
        public ushort WPacketVersion { get; private set; }
        public ushort WSettableData { get; private set; }
        public ushort WSettableStopParity { get; private set; }

        public static IEnumerable<SerialCommProperties> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SerialCommProperties> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SerialCommProperties> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSSerial_CommProperties");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SerialCommProperties
                {
                    Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
                    DwCurrentRxQueue = (uint) (managementObject.Properties["dwCurrentRxQueue"]?.Value ?? default(uint)),
                    DwCurrentTxQueue = (uint) (managementObject.Properties["dwCurrentTxQueue"]?.Value ?? default(uint)),
                    DwMaxBaud = (uint) (managementObject.Properties["dwMaxBaud"]?.Value ?? default(uint)),
                    DwMaxRxQueue = (uint) (managementObject.Properties["dwMaxRxQueue"]?.Value ?? default(uint)),
                    DwMaxTxQueue = (uint) (managementObject.Properties["dwMaxTxQueue"]?.Value ?? default(uint)),
                    DwProvCapabilities =
                        (uint) (managementObject.Properties["dwProvCapabilities"]?.Value ?? default(uint)),
                    DwProvCharSize = (uint) (managementObject.Properties["dwProvCharSize"]?.Value ?? default(uint)),
                    DwProvSpec1 = (uint) (managementObject.Properties["dwProvSpec1"]?.Value ?? default(uint)),
                    DwProvSpec2 = (uint) (managementObject.Properties["dwProvSpec2"]?.Value ?? default(uint)),
                    DwProvSubType = (uint) (managementObject.Properties["dwProvSubType"]?.Value ?? default(uint)),
                    DwReserved1 = (uint) (managementObject.Properties["dwReserved1"]?.Value ?? default(uint)),
                    DwServiceMask = (uint) (managementObject.Properties["dwServiceMask"]?.Value ?? default(uint)),
                    DwSettableBaud = (uint) (managementObject.Properties["dwSettableBaud"]?.Value ?? default(uint)),
                    DwSettableParams = (uint) (managementObject.Properties["dwSettableParams"]?.Value ?? default(uint)),
                    InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
                    WcProvChar = (byte[]) (managementObject.Properties["wcProvChar"]?.Value ?? new byte[0]),
                    WPacketLength = (ushort) (managementObject.Properties["wPacketLength"]?.Value ?? default(ushort)),
                    WPacketVersion = (ushort) (managementObject.Properties["wPacketVersion"]?.Value ?? default(ushort)),
                    WSettableData = (ushort) (managementObject.Properties["wSettableData"]?.Value ?? default(ushort)),
                    WSettableStopParity =
                        (ushort) (managementObject.Properties["wSettableStopParity"]?.Value ?? default(ushort))
                };
        }
    }
}