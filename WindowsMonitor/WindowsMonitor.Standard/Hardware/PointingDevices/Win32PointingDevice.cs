using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.PointingDevices
{
    /// <summary>
    /// </summary>
    public sealed class Win32PointingDevice
    {
		public ushort Availability { get; private set; }
		public string Caption { get; private set; }
		public uint ConfigManagerErrorCode { get; private set; }
		public bool ConfigManagerUserConfig { get; private set; }
		public string CreationClassName { get; private set; }
		public string Description { get; private set; }
		public string DeviceId { get; private set; }
		public ushort DeviceInterface { get; private set; }
		public uint DoubleSpeedThreshold { get; private set; }
		public bool ErrorCleared { get; private set; }
		public string ErrorDescription { get; private set; }
		public ushort Handedness { get; private set; }
		public string HardwareType { get; private set; }
		public string InfFileName { get; private set; }
		public string InfSection { get; private set; }
		public DateTime InstallDate { get; private set; }
		public bool IsLocked { get; private set; }
		public uint LastErrorCode { get; private set; }
		public string Manufacturer { get; private set; }
		public string Name { get; private set; }
		public byte NumberOfButtons { get; private set; }
		public string PnpDeviceId { get; private set; }
		public ushort PointingType { get; private set; }
		public ushort[] PowerManagementCapabilities { get; private set; }
		public bool PowerManagementSupported { get; private set; }
		public uint QuadSpeedThreshold { get; private set; }
		public uint Resolution { get; private set; }
		public uint SampleRate { get; private set; }
		public string Status { get; private set; }
		public ushort StatusInfo { get; private set; }
		public uint Synch { get; private set; }
		public string SystemCreationClassName { get; private set; }
		public string SystemName { get; private set; }

        public static IEnumerable<Win32PointingDevice> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<Win32PointingDevice> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<Win32PointingDevice> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PointingDevice");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new Win32PointingDevice
                {
                     Availability = (ushort) (managementObject.Properties["Availability"]?.Value ?? default(ushort)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 ConfigManagerErrorCode = (uint) (managementObject.Properties["ConfigManagerErrorCode"]?.Value ?? default(uint)),
		 ConfigManagerUserConfig = (bool) (managementObject.Properties["ConfigManagerUserConfig"]?.Value ?? default(bool)),
		 CreationClassName = (string) (managementObject.Properties["CreationClassName"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DeviceId = (string) (managementObject.Properties["DeviceID"]?.Value),
		 DeviceInterface = (ushort) (managementObject.Properties["DeviceInterface"]?.Value ?? default(ushort)),
		 DoubleSpeedThreshold = (uint) (managementObject.Properties["DoubleSpeedThreshold"]?.Value ?? default(uint)),
		 ErrorCleared = (bool) (managementObject.Properties["ErrorCleared"]?.Value ?? default(bool)),
		 ErrorDescription = (string) (managementObject.Properties["ErrorDescription"]?.Value),
		 Handedness = (ushort) (managementObject.Properties["Handedness"]?.Value ?? default(ushort)),
		 HardwareType = (string) (managementObject.Properties["HardwareType"]?.Value),
		 InfFileName = (string) (managementObject.Properties["InfFileName"]?.Value),
		 InfSection = (string) (managementObject.Properties["InfSection"]?.Value),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 IsLocked = (bool) (managementObject.Properties["IsLocked"]?.Value ?? default(bool)),
		 LastErrorCode = (uint) (managementObject.Properties["LastErrorCode"]?.Value ?? default(uint)),
		 Manufacturer = (string) (managementObject.Properties["Manufacturer"]?.Value),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 NumberOfButtons = (byte) (managementObject.Properties["NumberOfButtons"]?.Value ?? default(byte)),
		 PnpDeviceId = (string) (managementObject.Properties["PNPDeviceID"]?.Value),
		 PointingType = (ushort) (managementObject.Properties["PointingType"]?.Value ?? default(ushort)),
		 PowerManagementCapabilities = (ushort[]) (managementObject.Properties["PowerManagementCapabilities"]?.Value ?? new ushort[0]),
		 PowerManagementSupported = (bool) (managementObject.Properties["PowerManagementSupported"]?.Value ?? default(bool)),
		 QuadSpeedThreshold = (uint) (managementObject.Properties["QuadSpeedThreshold"]?.Value ?? default(uint)),
		 Resolution = (uint) (managementObject.Properties["Resolution"]?.Value ?? default(uint)),
		 SampleRate = (uint) (managementObject.Properties["SampleRate"]?.Value ?? default(uint)),
		 Status = (string) (managementObject.Properties["Status"]?.Value),
		 StatusInfo = (ushort) (managementObject.Properties["StatusInfo"]?.Value ?? default(ushort)),
		 Synch = (uint) (managementObject.Properties["Synch"]?.Value ?? default(uint)),
		 SystemCreationClassName = (string) (managementObject.Properties["SystemCreationClassName"]?.Value),
		 SystemName = (string) (managementObject.Properties["SystemName"]?.Value)
                };
        }
    }
}