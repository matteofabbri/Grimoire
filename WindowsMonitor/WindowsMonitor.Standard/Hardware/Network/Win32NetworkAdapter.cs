using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network
{
    /// <summary>
    /// </summary>
    public sealed class Win32NetworkAdapter
    {
		public string AdapterType { get; private set; }
		public ushort AdapterTypeId { get; private set; }
		public bool AutoSense { get; private set; }
		public ushort Availability { get; private set; }
		public string Caption { get; private set; }
		public uint ConfigManagerErrorCode { get; private set; }
		public bool ConfigManagerUserConfig { get; private set; }
		public string CreationClassName { get; private set; }
		public string Description { get; private set; }
		public string DeviceId { get; private set; }
		public bool ErrorCleared { get; private set; }
		public string ErrorDescription { get; private set; }
		public string Guid { get; private set; }
		public uint Index { get; private set; }
		public DateTime InstallDate { get; private set; }
		public bool Installed { get; private set; }
		public uint InterfaceIndex { get; private set; }
		public uint LastErrorCode { get; private set; }
		public string MacAddress { get; private set; }
		public string Manufacturer { get; private set; }
		public uint MaxNumberControlled { get; private set; }
		public ulong MaxSpeed { get; private set; }
		public string Name { get; private set; }
		public string NetConnectionId { get; private set; }
		public ushort NetConnectionStatus { get; private set; }
		public bool NetEnabled { get; private set; }
		public string[] NetworkAddresses { get; private set; }
		public string PermanentAddress { get; private set; }
		public bool PhysicalAdapter { get; private set; }
		public string PnpDeviceId { get; private set; }
		public ushort[] PowerManagementCapabilities { get; private set; }
		public bool PowerManagementSupported { get; private set; }
		public string ProductName { get; private set; }
		public string ServiceName { get; private set; }
		public ulong Speed { get; private set; }
		public string Status { get; private set; }
		public ushort StatusInfo { get; private set; }
		public string SystemCreationClassName { get; private set; }
		public string SystemName { get; private set; }
		public DateTime TimeOfLastReset { get; private set; }

        public static IEnumerable<Win32NetworkAdapter> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<Win32NetworkAdapter> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<Win32NetworkAdapter> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_NetworkAdapter");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new Win32NetworkAdapter
                {
                     AdapterType = (string) (managementObject.Properties["AdapterType"]?.Value),
		 AdapterTypeId = (ushort) (managementObject.Properties["AdapterTypeId"]?.Value ?? default(ushort)),
		 AutoSense = (bool) (managementObject.Properties["AutoSense"]?.Value ?? default(bool)),
		 Availability = (ushort) (managementObject.Properties["Availability"]?.Value ?? default(ushort)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 ConfigManagerErrorCode = (uint) (managementObject.Properties["ConfigManagerErrorCode"]?.Value ?? default(uint)),
		 ConfigManagerUserConfig = (bool) (managementObject.Properties["ConfigManagerUserConfig"]?.Value ?? default(bool)),
		 CreationClassName = (string) (managementObject.Properties["CreationClassName"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DeviceId = (string) (managementObject.Properties["DeviceID"]?.Value),
		 ErrorCleared = (bool) (managementObject.Properties["ErrorCleared"]?.Value ?? default(bool)),
		 ErrorDescription = (string) (managementObject.Properties["ErrorDescription"]?.Value),
		 Guid = (string) (managementObject.Properties["GUID"]?.Value),
		 Index = (uint) (managementObject.Properties["Index"]?.Value ?? default(uint)),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 Installed = (bool) (managementObject.Properties["Installed"]?.Value ?? default(bool)),
		 InterfaceIndex = (uint) (managementObject.Properties["InterfaceIndex"]?.Value ?? default(uint)),
		 LastErrorCode = (uint) (managementObject.Properties["LastErrorCode"]?.Value ?? default(uint)),
		 MacAddress = (string) (managementObject.Properties["MACAddress"]?.Value),
		 Manufacturer = (string) (managementObject.Properties["Manufacturer"]?.Value),
		 MaxNumberControlled = (uint) (managementObject.Properties["MaxNumberControlled"]?.Value ?? default(uint)),
		 MaxSpeed = (ulong) (managementObject.Properties["MaxSpeed"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 NetConnectionId = (string) (managementObject.Properties["NetConnectionID"]?.Value),
		 NetConnectionStatus = (ushort) (managementObject.Properties["NetConnectionStatus"]?.Value ?? default(ushort)),
		 NetEnabled = (bool) (managementObject.Properties["NetEnabled"]?.Value ?? default(bool)),
		 NetworkAddresses = (string[]) (managementObject.Properties["NetworkAddresses"]?.Value ?? new string[0]),
		 PermanentAddress = (string) (managementObject.Properties["PermanentAddress"]?.Value),
		 PhysicalAdapter = (bool) (managementObject.Properties["PhysicalAdapter"]?.Value ?? default(bool)),
		 PnpDeviceId = (string) (managementObject.Properties["PNPDeviceID"]?.Value),
		 PowerManagementCapabilities = (ushort[]) (managementObject.Properties["PowerManagementCapabilities"]?.Value ?? new ushort[0]),
		 PowerManagementSupported = (bool) (managementObject.Properties["PowerManagementSupported"]?.Value ?? default(bool)),
		 ProductName = (string) (managementObject.Properties["ProductName"]?.Value),
		 ServiceName = (string) (managementObject.Properties["ServiceName"]?.Value),
		 Speed = (ulong) (managementObject.Properties["Speed"]?.Value ?? default(ulong)),
		 Status = (string) (managementObject.Properties["Status"]?.Value),
		 StatusInfo = (ushort) (managementObject.Properties["StatusInfo"]?.Value ?? default(ushort)),
		 SystemCreationClassName = (string) (managementObject.Properties["SystemCreationClassName"]?.Value),
		 SystemName = (string) (managementObject.Properties["SystemName"]?.Value),
		 TimeOfLastReset = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["TimeOfLastReset"]?.Value as string ?? "00010102000000.000000+060")
                };
        }
    }
}