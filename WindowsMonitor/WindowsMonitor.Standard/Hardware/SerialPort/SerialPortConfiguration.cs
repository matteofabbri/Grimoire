using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.SerialPort
{
    /// <summary>
    /// </summary>
    public sealed class SerialPortConfiguration
    {
		public bool AbortReadWriteOnError { get; private set; }
		public uint BaudRate { get; private set; }
		public bool BinaryModeEnabled { get; private set; }
		public uint BitsPerByte { get; private set; }
		public string Caption { get; private set; }
		public bool ContinueXMitOnXOff { get; private set; }
		public bool CtsOutflowControl { get; private set; }
		public string Description { get; private set; }
		public bool DiscardNullBytes { get; private set; }
		public bool DsrOutflowControl { get; private set; }
		public bool DsrSensitivity { get; private set; }
		public string DtrFlowControlType { get; private set; }
		public uint EofCharacter { get; private set; }
		public uint ErrorReplaceCharacter { get; private set; }
		public bool ErrorReplacementEnabled { get; private set; }
		public uint EventCharacter { get; private set; }
		public bool IsBusy { get; private set; }
		public string Name { get; private set; }
		public string Parity { get; private set; }
		public bool ParityCheckEnabled { get; private set; }
		public string RtsFlowControlType { get; private set; }
		public string SettingId { get; private set; }
		public string StopBits { get; private set; }
		public uint XOffCharacter { get; private set; }
		public uint XOffXMitThreshold { get; private set; }
		public uint XOnCharacter { get; private set; }
		public uint XonXMitThreshold { get; private set; }
		public uint XonXOffInFlowControl { get; private set; }
		public uint XonXOffOutFlowControl { get; private set; }

        public static IEnumerable<SerialPortConfiguration> Retrieve(string remote, string username, string password)
        {
            var options = new ConnectionOptions
            {
                Impersonation = ImpersonationLevel.Impersonate,
                Username = username,
                Password = password
            };

            var managementScope = new ManagementScope(new ManagementPath($"\\\\{remote}\\root\\cimv2"), options);
            managementScope.Connect();

            return Retrieve(managementScope);
        }

        public static IEnumerable<SerialPortConfiguration> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SerialPortConfiguration> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_SerialPortConfiguration");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SerialPortConfiguration
                {
                     AbortReadWriteOnError = (bool) (managementObject.Properties["AbortReadWriteOnError"]?.Value ?? default(bool)),
		 BaudRate = (uint) (managementObject.Properties["BaudRate"]?.Value ?? default(uint)),
		 BinaryModeEnabled = (bool) (managementObject.Properties["BinaryModeEnabled"]?.Value ?? default(bool)),
		 BitsPerByte = (uint) (managementObject.Properties["BitsPerByte"]?.Value ?? default(uint)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 ContinueXMitOnXOff = (bool) (managementObject.Properties["ContinueXMitOnXOff"]?.Value ?? default(bool)),
		 CtsOutflowControl = (bool) (managementObject.Properties["CTSOutflowControl"]?.Value ?? default(bool)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DiscardNullBytes = (bool) (managementObject.Properties["DiscardNULLBytes"]?.Value ?? default(bool)),
		 DsrOutflowControl = (bool) (managementObject.Properties["DSROutflowControl"]?.Value ?? default(bool)),
		 DsrSensitivity = (bool) (managementObject.Properties["DSRSensitivity"]?.Value ?? default(bool)),
		 DtrFlowControlType = (string) (managementObject.Properties["DTRFlowControlType"]?.Value),
		 EofCharacter = (uint) (managementObject.Properties["EOFCharacter"]?.Value ?? default(uint)),
		 ErrorReplaceCharacter = (uint) (managementObject.Properties["ErrorReplaceCharacter"]?.Value ?? default(uint)),
		 ErrorReplacementEnabled = (bool) (managementObject.Properties["ErrorReplacementEnabled"]?.Value ?? default(bool)),
		 EventCharacter = (uint) (managementObject.Properties["EventCharacter"]?.Value ?? default(uint)),
		 IsBusy = (bool) (managementObject.Properties["IsBusy"]?.Value ?? default(bool)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 Parity = (string) (managementObject.Properties["Parity"]?.Value),
		 ParityCheckEnabled = (bool) (managementObject.Properties["ParityCheckEnabled"]?.Value ?? default(bool)),
		 RtsFlowControlType = (string) (managementObject.Properties["RTSFlowControlType"]?.Value),
		 SettingId = (string) (managementObject.Properties["SettingID"]?.Value),
		 StopBits = (string) (managementObject.Properties["StopBits"]?.Value),
		 XOffCharacter = (uint) (managementObject.Properties["XOffCharacter"]?.Value ?? default(uint)),
		 XOffXMitThreshold = (uint) (managementObject.Properties["XOffXMitThreshold"]?.Value ?? default(uint)),
		 XOnCharacter = (uint) (managementObject.Properties["XOnCharacter"]?.Value ?? default(uint)),
		 XonXMitThreshold = (uint) (managementObject.Properties["XOnXMitThreshold"]?.Value ?? default(uint)),
		 XonXOffInFlowControl = (uint) (managementObject.Properties["XOnXOffInFlowControl"]?.Value ?? default(uint)),
		 XonXOffOutFlowControl = (uint) (managementObject.Properties["XOnXOffOutFlowControl"]?.Value ?? default(uint))
                };
        }
    }
}