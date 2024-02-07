using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Power
{
    /// <summary>
    /// </summary>
    public sealed class UninterruptiblePowerSupply
    {
		public ushort ActiveInputVoltage { get; private set; }
		public ushort Availability { get; private set; }
		public string Caption { get; private set; }
		public uint ConfigManagerErrorCode { get; private set; }
		public bool ConfigManagerUserConfig { get; private set; }
		public string CreationClassName { get; private set; }
		public string Description { get; private set; }
		public string DeviceId { get; private set; }
		public bool ErrorCleared { get; private set; }
		public string ErrorDescription { get; private set; }
		public ushort EstimatedChargeRemaining { get; private set; }
		public uint EstimatedRunTime { get; private set; }
		public DateTime InstallDate { get; private set; }
		public bool IsSwitchingSupply { get; private set; }
		public uint LastErrorCode { get; private set; }
		public string Name { get; private set; }
		public string PnpDeviceId { get; private set; }
		public ushort[] PowerManagementCapabilities { get; private set; }
		public bool PowerManagementSupported { get; private set; }
		public uint Range1InputFrequencyHigh { get; private set; }
		public uint Range1InputFrequencyLow { get; private set; }
		public uint Range1InputVoltageHigh { get; private set; }
		public uint Range1InputVoltageLow { get; private set; }
		public uint Range2InputFrequencyHigh { get; private set; }
		public uint Range2InputFrequencyLow { get; private set; }
		public uint Range2InputVoltageHigh { get; private set; }
		public uint Range2InputVoltageLow { get; private set; }
		public ushort RemainingCapacityStatus { get; private set; }
		public string Status { get; private set; }
		public ushort StatusInfo { get; private set; }
		public string SystemCreationClassName { get; private set; }
		public string SystemName { get; private set; }
		public uint TimeOnBackup { get; private set; }
		public uint TotalOutputPower { get; private set; }
		public ushort TypeOfRangeSwitching { get; private set; }

        public static IEnumerable<UninterruptiblePowerSupply> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<UninterruptiblePowerSupply> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<UninterruptiblePowerSupply> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_UninterruptiblePowerSupply");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new UninterruptiblePowerSupply
                {
                     ActiveInputVoltage = (ushort) (managementObject.Properties["ActiveInputVoltage"]?.Value ?? default(ushort)),
		 Availability = (ushort) (managementObject.Properties["Availability"]?.Value ?? default(ushort)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 ConfigManagerErrorCode = (uint) (managementObject.Properties["ConfigManagerErrorCode"]?.Value ?? default(uint)),
		 ConfigManagerUserConfig = (bool) (managementObject.Properties["ConfigManagerUserConfig"]?.Value ?? default(bool)),
		 CreationClassName = (string) (managementObject.Properties["CreationClassName"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DeviceId = (string) (managementObject.Properties["DeviceID"]?.Value),
		 ErrorCleared = (bool) (managementObject.Properties["ErrorCleared"]?.Value ?? default(bool)),
		 ErrorDescription = (string) (managementObject.Properties["ErrorDescription"]?.Value),
		 EstimatedChargeRemaining = (ushort) (managementObject.Properties["EstimatedChargeRemaining"]?.Value ?? default(ushort)),
		 EstimatedRunTime = (uint) (managementObject.Properties["EstimatedRunTime"]?.Value ?? default(uint)),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 IsSwitchingSupply = (bool) (managementObject.Properties["IsSwitchingSupply"]?.Value ?? default(bool)),
		 LastErrorCode = (uint) (managementObject.Properties["LastErrorCode"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 PnpDeviceId = (string) (managementObject.Properties["PNPDeviceID"]?.Value),
		 PowerManagementCapabilities = (ushort[]) (managementObject.Properties["PowerManagementCapabilities"]?.Value ?? new ushort[0]),
		 PowerManagementSupported = (bool) (managementObject.Properties["PowerManagementSupported"]?.Value ?? default(bool)),
		 Range1InputFrequencyHigh = (uint) (managementObject.Properties["Range1InputFrequencyHigh"]?.Value ?? default(uint)),
		 Range1InputFrequencyLow = (uint) (managementObject.Properties["Range1InputFrequencyLow"]?.Value ?? default(uint)),
		 Range1InputVoltageHigh = (uint) (managementObject.Properties["Range1InputVoltageHigh"]?.Value ?? default(uint)),
		 Range1InputVoltageLow = (uint) (managementObject.Properties["Range1InputVoltageLow"]?.Value ?? default(uint)),
		 Range2InputFrequencyHigh = (uint) (managementObject.Properties["Range2InputFrequencyHigh"]?.Value ?? default(uint)),
		 Range2InputFrequencyLow = (uint) (managementObject.Properties["Range2InputFrequencyLow"]?.Value ?? default(uint)),
		 Range2InputVoltageHigh = (uint) (managementObject.Properties["Range2InputVoltageHigh"]?.Value ?? default(uint)),
		 Range2InputVoltageLow = (uint) (managementObject.Properties["Range2InputVoltageLow"]?.Value ?? default(uint)),
		 RemainingCapacityStatus = (ushort) (managementObject.Properties["RemainingCapacityStatus"]?.Value ?? default(ushort)),
		 Status = (string) (managementObject.Properties["Status"]?.Value),
		 StatusInfo = (ushort) (managementObject.Properties["StatusInfo"]?.Value ?? default(ushort)),
		 SystemCreationClassName = (string) (managementObject.Properties["SystemCreationClassName"]?.Value),
		 SystemName = (string) (managementObject.Properties["SystemName"]?.Value),
		 TimeOnBackup = (uint) (managementObject.Properties["TimeOnBackup"]?.Value ?? default(uint)),
		 TotalOutputPower = (uint) (managementObject.Properties["TotalOutputPower"]?.Value ?? default(uint)),
		 TypeOfRangeSwitching = (ushort) (managementObject.Properties["TypeOfRangeSwitching"]?.Value ?? default(ushort))
                };
        }
    }
}