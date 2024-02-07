using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Video
{
    /// <summary>
    /// </summary>
    public sealed class PcVideoController
    {
        public ushort[] AcceleratorCapabilities { get; private set; }
        public ushort Availability { get; private set; }
        public string[] CapabilityDescriptions { get; private set; }
        public string Caption { get; private set; }
        public uint ConfigManagerErrorCode { get; private set; }
        public bool ConfigManagerUserConfig { get; private set; }
        public string CreationClassName { get; private set; }
        public uint CurrentBitsPerPixel { get; private set; }
        public uint CurrentHorizontalResolution { get; private set; }
        public ulong CurrentNumberOfColors { get; private set; }
        public uint CurrentNumberOfColumns { get; private set; }
        public uint CurrentNumberOfRows { get; private set; }
        public uint CurrentRefreshRate { get; private set; }
        public ushort CurrentScanMode { get; private set; }
        public uint CurrentVerticalResolution { get; private set; }
        public string Description { get; private set; }
        public string DeviceId { get; private set; }
        public bool ErrorCleared { get; private set; }
        public string ErrorDescription { get; private set; }
        public DateTime InstallDate { get; private set; }
        public uint LastErrorCode { get; private set; }
        public uint MaxMemorySupported { get; private set; }
        public uint MaxNumberControlled { get; private set; }
        public uint MaxRefreshRate { get; private set; }
        public uint MinRefreshRate { get; private set; }
        public string Name { get; private set; }
        public ushort NumberOfColorPlanes { get; private set; }
        public uint NumberOfVideoPages { get; private set; }
        public string PnpDeviceId { get; private set; }
        public ushort[] PowerManagementCapabilities { get; private set; }
        public bool PowerManagementSupported { get; private set; }
        public ushort ProtocolSupported { get; private set; }
        public string Status { get; private set; }
        public ushort StatusInfo { get; private set; }
        public string SystemCreationClassName { get; private set; }
        public string SystemName { get; private set; }
        public DateTime TimeOfLastReset { get; private set; }
        public ushort VideoArchitecture { get; private set; }
        public ushort VideoMemoryType { get; private set; }
        public ushort VideoMode { get; private set; }
        public string VideoProcessor { get; private set; }

        public static IEnumerable<PcVideoController> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<PcVideoController> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<PcVideoController> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_PCVideoController");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new PcVideoController
                {
                    AcceleratorCapabilities =
                        (ushort[]) (managementObject.Properties["AcceleratorCapabilities"]?.Value ?? new ushort[0]),
                    Availability = (ushort) (managementObject.Properties["Availability"]?.Value ?? default(ushort)),
                    CapabilityDescriptions =
                        (string[]) (managementObject.Properties["CapabilityDescriptions"]?.Value ?? new string[0]),
                    Caption = (string) managementObject.Properties["Caption"]?.Value,
                    ConfigManagerErrorCode =
                        (uint) (managementObject.Properties["ConfigManagerErrorCode"]?.Value ?? default(uint)),
                    ConfigManagerUserConfig =
                        (bool) (managementObject.Properties["ConfigManagerUserConfig"]?.Value ?? default(bool)),
                    CreationClassName = (string) managementObject.Properties["CreationClassName"]?.Value,
                    CurrentBitsPerPixel =
                        (uint) (managementObject.Properties["CurrentBitsPerPixel"]?.Value ?? default(uint)),
                    CurrentHorizontalResolution =
                        (uint) (managementObject.Properties["CurrentHorizontalResolution"]?.Value ?? default(uint)),
                    CurrentNumberOfColors =
                        (ulong) (managementObject.Properties["CurrentNumberOfColors"]?.Value ?? default(ulong)),
                    CurrentNumberOfColumns =
                        (uint) (managementObject.Properties["CurrentNumberOfColumns"]?.Value ?? default(uint)),
                    CurrentNumberOfRows =
                        (uint) (managementObject.Properties["CurrentNumberOfRows"]?.Value ?? default(uint)),
                    CurrentRefreshRate =
                        (uint) (managementObject.Properties["CurrentRefreshRate"]?.Value ?? default(uint)),
                    CurrentScanMode =
                        (ushort) (managementObject.Properties["CurrentScanMode"]?.Value ?? default(ushort)),
                    CurrentVerticalResolution =
                        (uint) (managementObject.Properties["CurrentVerticalResolution"]?.Value ?? default(uint)),
                    Description = (string) managementObject.Properties["Description"]?.Value,
                    DeviceId = (string) managementObject.Properties["DeviceID"]?.Value,
                    ErrorCleared = (bool) (managementObject.Properties["ErrorCleared"]?.Value ?? default(bool)),
                    ErrorDescription = (string) managementObject.Properties["ErrorDescription"]?.Value,
                    InstallDate =
                        ManagementDateTimeConverter.ToDateTime(
                            managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
                    LastErrorCode = (uint) (managementObject.Properties["LastErrorCode"]?.Value ?? default(uint)),
                    MaxMemorySupported =
                        (uint) (managementObject.Properties["MaxMemorySupported"]?.Value ?? default(uint)),
                    MaxNumberControlled =
                        (uint) (managementObject.Properties["MaxNumberControlled"]?.Value ?? default(uint)),
                    MaxRefreshRate = (uint) (managementObject.Properties["MaxRefreshRate"]?.Value ?? default(uint)),
                    MinRefreshRate = (uint) (managementObject.Properties["MinRefreshRate"]?.Value ?? default(uint)),
                    Name = (string) managementObject.Properties["Name"]?.Value,
                    NumberOfColorPlanes =
                        (ushort) (managementObject.Properties["NumberOfColorPlanes"]?.Value ?? default(ushort)),
                    NumberOfVideoPages =
                        (uint) (managementObject.Properties["NumberOfVideoPages"]?.Value ?? default(uint)),
                    PnpDeviceId = (string) managementObject.Properties["PNPDeviceID"]?.Value,
                    PowerManagementCapabilities =
                        (ushort[]) (managementObject.Properties["PowerManagementCapabilities"]?.Value ?? new ushort[0]),
                    PowerManagementSupported =
                        (bool) (managementObject.Properties["PowerManagementSupported"]?.Value ?? default(bool)),
                    ProtocolSupported =
                        (ushort) (managementObject.Properties["ProtocolSupported"]?.Value ?? default(ushort)),
                    Status = (string) managementObject.Properties["Status"]?.Value,
                    StatusInfo = (ushort) (managementObject.Properties["StatusInfo"]?.Value ?? default(ushort)),
                    SystemCreationClassName = (string) managementObject.Properties["SystemCreationClassName"]?.Value,
                    SystemName = (string) managementObject.Properties["SystemName"]?.Value,
                    TimeOfLastReset = ManagementDateTimeConverter.ToDateTime(
                        managementObject.Properties["TimeOfLastReset"]?.Value as string ?? "00010102000000.000000+060"),
                    VideoArchitecture =
                        (ushort) (managementObject.Properties["VideoArchitecture"]?.Value ?? default(ushort)),
                    VideoMemoryType =
                        (ushort) (managementObject.Properties["VideoMemoryType"]?.Value ?? default(ushort)),
                    VideoMode = (ushort) (managementObject.Properties["VideoMode"]?.Value ?? default(ushort)),
                    VideoProcessor = (string) managementObject.Properties["VideoProcessor"]?.Value
                };
        }
    }
}