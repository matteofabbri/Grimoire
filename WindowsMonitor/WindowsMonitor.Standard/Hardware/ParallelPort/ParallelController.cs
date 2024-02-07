using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.ParallelPort
{
    /// <summary>
    /// </summary>
    public sealed class ParallelController
    {
        public ushort Availability { get; private set; }
        public ushort[] Capabilities { get; private set; }
        public string[] CapabilityDescriptions { get; private set; }
        public string Caption { get; private set; }
        public uint ConfigManagerErrorCode { get; private set; }
        public bool ConfigManagerUserConfig { get; private set; }
        public string CreationClassName { get; private set; }
        public string Description { get; private set; }
        public string DeviceId { get; private set; }
        public bool DmaSupport { get; private set; }
        public bool ErrorCleared { get; private set; }
        public string ErrorDescription { get; private set; }
        public DateTime InstallDate { get; private set; }
        public uint LastErrorCode { get; private set; }
        public uint MaxNumberControlled { get; private set; }
        public string Name { get; private set; }
        public string PnpDeviceId { get; private set; }
        public ushort[] PowerManagementCapabilities { get; private set; }
        public bool PowerManagementSupported { get; private set; }
        public ushort ProtocolSupported { get; private set; }
        public string Status { get; private set; }
        public ushort StatusInfo { get; private set; }
        public string SystemCreationClassName { get; private set; }
        public string SystemName { get; private set; }
        public DateTime TimeOfLastReset { get; private set; }

        public static IEnumerable<ParallelController> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ParallelController> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ParallelController> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_ParallelController");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ParallelController
                {
                    Availability = (ushort) (managementObject.Properties["Availability"]?.Value ?? default(ushort)),
                    Capabilities = (ushort[]) (managementObject.Properties["Capabilities"]?.Value ?? new ushort[0]),
                    CapabilityDescriptions =
                        (string[]) (managementObject.Properties["CapabilityDescriptions"]?.Value ?? new string[0]),
                    Caption = (string) managementObject.Properties["Caption"]?.Value,
                    ConfigManagerErrorCode =
                        (uint) (managementObject.Properties["ConfigManagerErrorCode"]?.Value ?? default(uint)),
                    ConfigManagerUserConfig =
                        (bool) (managementObject.Properties["ConfigManagerUserConfig"]?.Value ?? default(bool)),
                    CreationClassName = (string) managementObject.Properties["CreationClassName"]?.Value,
                    Description = (string) managementObject.Properties["Description"]?.Value,
                    DeviceId = (string) managementObject.Properties["DeviceID"]?.Value,
                    DmaSupport = (bool) (managementObject.Properties["DMASupport"]?.Value ?? default(bool)),
                    ErrorCleared = (bool) (managementObject.Properties["ErrorCleared"]?.Value ?? default(bool)),
                    ErrorDescription = (string) managementObject.Properties["ErrorDescription"]?.Value,
                    InstallDate =
                        ManagementDateTimeConverter.ToDateTime(
                            managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
                    LastErrorCode = (uint) (managementObject.Properties["LastErrorCode"]?.Value ?? default(uint)),
                    MaxNumberControlled =
                        (uint) (managementObject.Properties["MaxNumberControlled"]?.Value ?? default(uint)),
                    Name = (string) managementObject.Properties["Name"]?.Value,
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
                        managementObject.Properties["TimeOfLastReset"]?.Value as string ?? "00010102000000.000000+060")
                };
        }
    }
}