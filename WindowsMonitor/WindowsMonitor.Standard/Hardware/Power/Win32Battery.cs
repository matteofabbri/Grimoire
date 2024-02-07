using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Power
{
    /// <summary>
    /// </summary>
    public sealed class Win32Battery
    {
		public ushort Availability { get; private set; }
		public uint BatteryRechargeTime { get; private set; }
		public ushort BatteryStatus { get; private set; }
		public string Caption { get; private set; }
		public ushort Chemistry { get; private set; }
		public uint ConfigManagerErrorCode { get; private set; }
		public bool ConfigManagerUserConfig { get; private set; }
		public string CreationClassName { get; private set; }
		public string Description { get; private set; }
		public uint DesignCapacity { get; private set; }
		public ulong DesignVoltage { get; private set; }
		public string DeviceId { get; private set; }
		public bool ErrorCleared { get; private set; }
		public string ErrorDescription { get; private set; }
		public ushort EstimatedChargeRemaining { get; private set; }
		public uint EstimatedRunTime { get; private set; }
		public uint ExpectedBatteryLife { get; private set; }
		public uint ExpectedLife { get; private set; }
		public uint FullChargeCapacity { get; private set; }
		public DateTime InstallDate { get; private set; }
		public uint LastErrorCode { get; private set; }
		public uint MaxRechargeTime { get; private set; }
		public string Name { get; private set; }
		public string PnpDeviceId { get; private set; }
		public ushort[] PowerManagementCapabilities { get; private set; }
		public bool PowerManagementSupported { get; private set; }
		public string SmartBatteryVersion { get; private set; }
		public string Status { get; private set; }
		public ushort StatusInfo { get; private set; }
		public string SystemCreationClassName { get; private set; }
		public string SystemName { get; private set; }
		public uint TimeOnBattery { get; private set; }
		public uint TimeToFullCharge { get; private set; }

        public static IEnumerable<Win32Battery> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<Win32Battery> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<Win32Battery> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_Battery");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new Win32Battery
                {
                     Availability = (ushort) (managementObject.Properties["Availability"]?.Value ?? default(ushort)),
		 BatteryRechargeTime = (uint) (managementObject.Properties["BatteryRechargeTime"]?.Value ?? default(uint)),
		 BatteryStatus = (ushort) (managementObject.Properties["BatteryStatus"]?.Value ?? default(ushort)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Chemistry = (ushort) (managementObject.Properties["Chemistry"]?.Value ?? default(ushort)),
		 ConfigManagerErrorCode = (uint) (managementObject.Properties["ConfigManagerErrorCode"]?.Value ?? default(uint)),
		 ConfigManagerUserConfig = (bool) (managementObject.Properties["ConfigManagerUserConfig"]?.Value ?? default(bool)),
		 CreationClassName = (string) (managementObject.Properties["CreationClassName"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DesignCapacity = (uint) (managementObject.Properties["DesignCapacity"]?.Value ?? default(uint)),
		 DesignVoltage = (ulong) (managementObject.Properties["DesignVoltage"]?.Value ?? default(ulong)),
		 DeviceId = (string) (managementObject.Properties["DeviceID"]?.Value),
		 ErrorCleared = (bool) (managementObject.Properties["ErrorCleared"]?.Value ?? default(bool)),
		 ErrorDescription = (string) (managementObject.Properties["ErrorDescription"]?.Value),
		 EstimatedChargeRemaining = (ushort) (managementObject.Properties["EstimatedChargeRemaining"]?.Value ?? default(ushort)),
		 EstimatedRunTime = (uint) (managementObject.Properties["EstimatedRunTime"]?.Value ?? default(uint)),
		 ExpectedBatteryLife = (uint) (managementObject.Properties["ExpectedBatteryLife"]?.Value ?? default(uint)),
		 ExpectedLife = (uint) (managementObject.Properties["ExpectedLife"]?.Value ?? default(uint)),
		 FullChargeCapacity = (uint) (managementObject.Properties["FullChargeCapacity"]?.Value ?? default(uint)),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 LastErrorCode = (uint) (managementObject.Properties["LastErrorCode"]?.Value ?? default(uint)),
		 MaxRechargeTime = (uint) (managementObject.Properties["MaxRechargeTime"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 PnpDeviceId = (string) (managementObject.Properties["PNPDeviceID"]?.Value),
		 PowerManagementCapabilities = (ushort[]) (managementObject.Properties["PowerManagementCapabilities"]?.Value ?? new ushort[0]),
		 PowerManagementSupported = (bool) (managementObject.Properties["PowerManagementSupported"]?.Value ?? default(bool)),
		 SmartBatteryVersion = (string) (managementObject.Properties["SmartBatteryVersion"]?.Value),
		 Status = (string) (managementObject.Properties["Status"]?.Value),
		 StatusInfo = (ushort) (managementObject.Properties["StatusInfo"]?.Value ?? default(ushort)),
		 SystemCreationClassName = (string) (managementObject.Properties["SystemCreationClassName"]?.Value),
		 SystemName = (string) (managementObject.Properties["SystemName"]?.Value),
		 TimeOnBattery = (uint) (managementObject.Properties["TimeOnBattery"]?.Value ?? default(uint)),
		 TimeToFullCharge = (uint) (managementObject.Properties["TimeToFullCharge"]?.Value ?? default(uint))
                };
        }
    }
}