using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Processors
{
    /// <summary>
    /// </summary>
    public sealed class Processor
    {
		public ushort AddressWidth { get; private set; }
		public ushort Availability { get; private set; }
		public string Caption { get; private set; }
		public uint ConfigManagerErrorCode { get; private set; }
		public bool ConfigManagerUserConfig { get; private set; }
		public string CreationClassName { get; private set; }
		public uint CurrentClockSpeed { get; private set; }
		public ushort DataWidth { get; private set; }
		public string Description { get; private set; }
		public string DeviceId { get; private set; }
		public bool ErrorCleared { get; private set; }
		public string ErrorDescription { get; private set; }
		public ushort Family { get; private set; }
		public DateTime InstallDate { get; private set; }
		public uint LastErrorCode { get; private set; }
		public ushort LoadPercentage { get; private set; }
		public uint MaxClockSpeed { get; private set; }
		public string Name { get; private set; }
		public string OtherFamilyDescription { get; private set; }
		public string PnpDeviceId { get; private set; }
		public ushort[] PowerManagementCapabilities { get; private set; }
		public bool PowerManagementSupported { get; private set; }
		public string Role { get; private set; }
		public string Status { get; private set; }
		public ushort StatusInfo { get; private set; }
		public string Stepping { get; private set; }
		public string SystemCreationClassName { get; private set; }
		public string SystemName { get; private set; }
		public string UniqueId { get; private set; }
		public ushort UpgradeMethod { get; private set; }

        public static IEnumerable<Processor> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<Processor> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<Processor> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_Processor");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new Processor
                {
                     AddressWidth = (ushort) (managementObject.Properties["AddressWidth"]?.Value ?? default(ushort)),
		 Availability = (ushort) (managementObject.Properties["Availability"]?.Value ?? default(ushort)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 ConfigManagerErrorCode = (uint) (managementObject.Properties["ConfigManagerErrorCode"]?.Value ?? default(uint)),
		 ConfigManagerUserConfig = (bool) (managementObject.Properties["ConfigManagerUserConfig"]?.Value ?? default(bool)),
		 CreationClassName = (string) (managementObject.Properties["CreationClassName"]?.Value),
		 CurrentClockSpeed = (uint) (managementObject.Properties["CurrentClockSpeed"]?.Value ?? default(uint)),
		 DataWidth = (ushort) (managementObject.Properties["DataWidth"]?.Value ?? default(ushort)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DeviceId = (string) (managementObject.Properties["DeviceID"]?.Value),
		 ErrorCleared = (bool) (managementObject.Properties["ErrorCleared"]?.Value ?? default(bool)),
		 ErrorDescription = (string) (managementObject.Properties["ErrorDescription"]?.Value),
		 Family = (ushort) (managementObject.Properties["Family"]?.Value ?? default(ushort)),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 LastErrorCode = (uint) (managementObject.Properties["LastErrorCode"]?.Value ?? default(uint)),
		 LoadPercentage = (ushort) (managementObject.Properties["LoadPercentage"]?.Value ?? default(ushort)),
		 MaxClockSpeed = (uint) (managementObject.Properties["MaxClockSpeed"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 OtherFamilyDescription = (string) (managementObject.Properties["OtherFamilyDescription"]?.Value),
		 PnpDeviceId = (string) (managementObject.Properties["PNPDeviceID"]?.Value),
		 PowerManagementCapabilities = (ushort[]) (managementObject.Properties["PowerManagementCapabilities"]?.Value ?? new ushort[0]),
		 PowerManagementSupported = (bool) (managementObject.Properties["PowerManagementSupported"]?.Value ?? default(bool)),
		 Role = (string) (managementObject.Properties["Role"]?.Value),
		 Status = (string) (managementObject.Properties["Status"]?.Value),
		 StatusInfo = (ushort) (managementObject.Properties["StatusInfo"]?.Value ?? default(ushort)),
		 Stepping = (string) (managementObject.Properties["Stepping"]?.Value),
		 SystemCreationClassName = (string) (managementObject.Properties["SystemCreationClassName"]?.Value),
		 SystemName = (string) (managementObject.Properties["SystemName"]?.Value),
		 UniqueId = (string) (managementObject.Properties["UniqueId"]?.Value),
		 UpgradeMethod = (ushort) (managementObject.Properties["UpgradeMethod"]?.Value ?? default(ushort))
                };
        }
    }
}