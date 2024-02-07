using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Sensors
{
    /// <summary>
    /// </summary>
    public sealed class CurrentProbe
    {
		public int Accuracy { get; private set; }
		public ushort Availability { get; private set; }
		public string Caption { get; private set; }
		public uint ConfigManagerErrorCode { get; private set; }
		public bool ConfigManagerUserConfig { get; private set; }
		public string CreationClassName { get; private set; }
		public int CurrentReading { get; private set; }
		public string Description { get; private set; }
		public string DeviceId { get; private set; }
		public bool ErrorCleared { get; private set; }
		public string ErrorDescription { get; private set; }
		public DateTime InstallDate { get; private set; }
		public bool IsLinear { get; private set; }
		public uint LastErrorCode { get; private set; }
		public int LowerThresholdCritical { get; private set; }
		public int LowerThresholdFatal { get; private set; }
		public int LowerThresholdNonCritical { get; private set; }
		public int MaxReadable { get; private set; }
		public int MinReadable { get; private set; }
		public string Name { get; private set; }
		public int NominalReading { get; private set; }
		public int NormalMax { get; private set; }
		public int NormalMin { get; private set; }
		public string PnpDeviceId { get; private set; }
		public ushort[] PowerManagementCapabilities { get; private set; }
		public bool PowerManagementSupported { get; private set; }
		public uint Resolution { get; private set; }
		public string Status { get; private set; }
		public ushort StatusInfo { get; private set; }
		public string SystemCreationClassName { get; private set; }
		public string SystemName { get; private set; }
		public int Tolerance { get; private set; }
		public int UpperThresholdCritical { get; private set; }
		public int UpperThresholdFatal { get; private set; }
		public int UpperThresholdNonCritical { get; private set; }

        public static IEnumerable<CurrentProbe> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<CurrentProbe> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<CurrentProbe> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_CurrentProbe");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new CurrentProbe
                {
                     Accuracy = (int) (managementObject.Properties["Accuracy"]?.Value ?? default(int)),
		 Availability = (ushort) (managementObject.Properties["Availability"]?.Value ?? default(ushort)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 ConfigManagerErrorCode = (uint) (managementObject.Properties["ConfigManagerErrorCode"]?.Value ?? default(uint)),
		 ConfigManagerUserConfig = (bool) (managementObject.Properties["ConfigManagerUserConfig"]?.Value ?? default(bool)),
		 CreationClassName = (string) (managementObject.Properties["CreationClassName"]?.Value),
		 CurrentReading = (int) (managementObject.Properties["CurrentReading"]?.Value ?? default(int)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DeviceId = (string) (managementObject.Properties["DeviceID"]?.Value),
		 ErrorCleared = (bool) (managementObject.Properties["ErrorCleared"]?.Value ?? default(bool)),
		 ErrorDescription = (string) (managementObject.Properties["ErrorDescription"]?.Value),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 IsLinear = (bool) (managementObject.Properties["IsLinear"]?.Value ?? default(bool)),
		 LastErrorCode = (uint) (managementObject.Properties["LastErrorCode"]?.Value ?? default(uint)),
		 LowerThresholdCritical = (int) (managementObject.Properties["LowerThresholdCritical"]?.Value ?? default(int)),
		 LowerThresholdFatal = (int) (managementObject.Properties["LowerThresholdFatal"]?.Value ?? default(int)),
		 LowerThresholdNonCritical = (int) (managementObject.Properties["LowerThresholdNonCritical"]?.Value ?? default(int)),
		 MaxReadable = (int) (managementObject.Properties["MaxReadable"]?.Value ?? default(int)),
		 MinReadable = (int) (managementObject.Properties["MinReadable"]?.Value ?? default(int)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 NominalReading = (int) (managementObject.Properties["NominalReading"]?.Value ?? default(int)),
		 NormalMax = (int) (managementObject.Properties["NormalMax"]?.Value ?? default(int)),
		 NormalMin = (int) (managementObject.Properties["NormalMin"]?.Value ?? default(int)),
		 PnpDeviceId = (string) (managementObject.Properties["PNPDeviceID"]?.Value),
		 PowerManagementCapabilities = (ushort[]) (managementObject.Properties["PowerManagementCapabilities"]?.Value ?? new ushort[0]),
		 PowerManagementSupported = (bool) (managementObject.Properties["PowerManagementSupported"]?.Value ?? default(bool)),
		 Resolution = (uint) (managementObject.Properties["Resolution"]?.Value ?? default(uint)),
		 Status = (string) (managementObject.Properties["Status"]?.Value),
		 StatusInfo = (ushort) (managementObject.Properties["StatusInfo"]?.Value ?? default(ushort)),
		 SystemCreationClassName = (string) (managementObject.Properties["SystemCreationClassName"]?.Value),
		 SystemName = (string) (managementObject.Properties["SystemName"]?.Value),
		 Tolerance = (int) (managementObject.Properties["Tolerance"]?.Value ?? default(int)),
		 UpperThresholdCritical = (int) (managementObject.Properties["UpperThresholdCritical"]?.Value ?? default(int)),
		 UpperThresholdFatal = (int) (managementObject.Properties["UpperThresholdFatal"]?.Value ?? default(int)),
		 UpperThresholdNonCritical = (int) (managementObject.Properties["UpperThresholdNonCritical"]?.Value ?? default(int))
                };
        }
    }
}