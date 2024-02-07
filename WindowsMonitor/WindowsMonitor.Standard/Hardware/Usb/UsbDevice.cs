using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Usb
{
    /// <summary>
    /// </summary>
    public sealed class UsbDevice
    {
		public ushort Availability { get; private set; }
		public string Caption { get; private set; }
		public byte ClassCode { get; private set; }
		public uint ConfigManagerErrorCode { get; private set; }
		public bool ConfigManagerUserConfig { get; private set; }
		public string CreationClassName { get; private set; }
		public byte[] CurrentAlternateSettings { get; private set; }
		public byte CurrentConfigValue { get; private set; }
		public string Description { get; private set; }
		public string DeviceId { get; private set; }
		public bool ErrorCleared { get; private set; }
		public string ErrorDescription { get; private set; }
		public DateTime InstallDate { get; private set; }
		public uint LastErrorCode { get; private set; }
		public string Name { get; private set; }
		public byte NumberOfConfigs { get; private set; }
		public string PnpDeviceId { get; private set; }
		public ushort[] PowerManagementCapabilities { get; private set; }
		public bool PowerManagementSupported { get; private set; }
		public byte ProtocolCode { get; private set; }
		public string Status { get; private set; }
		public ushort StatusInfo { get; private set; }
		public byte SubclassCode { get; private set; }
		public string SystemCreationClassName { get; private set; }
		public string SystemName { get; private set; }
		public ushort UsbVersion { get; private set; }

        public static IEnumerable<UsbDevice> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<UsbDevice> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<UsbDevice> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_USBDevice");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new UsbDevice
                {
                     Availability = (ushort) (managementObject.Properties["Availability"]?.Value ?? default(ushort)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 ClassCode = (byte) (managementObject.Properties["ClassCode"]?.Value ?? default(byte)),
		 ConfigManagerErrorCode = (uint) (managementObject.Properties["ConfigManagerErrorCode"]?.Value ?? default(uint)),
		 ConfigManagerUserConfig = (bool) (managementObject.Properties["ConfigManagerUserConfig"]?.Value ?? default(bool)),
		 CreationClassName = (string) (managementObject.Properties["CreationClassName"]?.Value),
		 CurrentAlternateSettings = (byte[]) (managementObject.Properties["CurrentAlternateSettings"]?.Value ?? new byte[0]),
		 CurrentConfigValue = (byte) (managementObject.Properties["CurrentConfigValue"]?.Value ?? default(byte)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DeviceId = (string) (managementObject.Properties["DeviceID"]?.Value),
		 ErrorCleared = (bool) (managementObject.Properties["ErrorCleared"]?.Value ?? default(bool)),
		 ErrorDescription = (string) (managementObject.Properties["ErrorDescription"]?.Value),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 LastErrorCode = (uint) (managementObject.Properties["LastErrorCode"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 NumberOfConfigs = (byte) (managementObject.Properties["NumberOfConfigs"]?.Value ?? default(byte)),
		 PnpDeviceId = (string) (managementObject.Properties["PNPDeviceID"]?.Value),
		 PowerManagementCapabilities = (ushort[]) (managementObject.Properties["PowerManagementCapabilities"]?.Value ?? new ushort[0]),
		 PowerManagementSupported = (bool) (managementObject.Properties["PowerManagementSupported"]?.Value ?? default(bool)),
		 ProtocolCode = (byte) (managementObject.Properties["ProtocolCode"]?.Value ?? default(byte)),
		 Status = (string) (managementObject.Properties["Status"]?.Value),
		 StatusInfo = (ushort) (managementObject.Properties["StatusInfo"]?.Value ?? default(ushort)),
		 SubclassCode = (byte) (managementObject.Properties["SubclassCode"]?.Value ?? default(byte)),
		 SystemCreationClassName = (string) (managementObject.Properties["SystemCreationClassName"]?.Value),
		 SystemName = (string) (managementObject.Properties["SystemName"]?.Value),
		 UsbVersion = (ushort) (managementObject.Properties["USBVersion"]?.Value ?? default(ushort))
                };
        }
    }
}