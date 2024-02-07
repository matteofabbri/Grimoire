using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Modems
{
    /// <summary>
    /// </summary>
    public sealed class PotsModem
    {
		public ushort AnswerMode { get; private set; }
		public ushort Availability { get; private set; }
		public string Caption { get; private set; }
		public ushort CompressionInfo { get; private set; }
		public uint ConfigManagerErrorCode { get; private set; }
		public bool ConfigManagerUserConfig { get; private set; }
		public string[] CountriesSupported { get; private set; }
		public string CountrySelected { get; private set; }
		public string CreationClassName { get; private set; }
		public string[] CurrentPasswords { get; private set; }
		public string Description { get; private set; }
		public string DeviceId { get; private set; }
		public ushort DialType { get; private set; }
		public bool ErrorCleared { get; private set; }
		public ushort ErrorControlInfo { get; private set; }
		public string ErrorDescription { get; private set; }
		public uint InactivityTimeout { get; private set; }
		public DateTime InstallDate { get; private set; }
		public uint LastErrorCode { get; private set; }
		public uint MaxBaudRateToPhone { get; private set; }
		public uint MaxBaudRateToSerialPort { get; private set; }
		public ushort MaxNumberOfPasswords { get; private set; }
		public ushort ModulationScheme { get; private set; }
		public string Name { get; private set; }
		public string PnpDeviceId { get; private set; }
		public ushort[] PowerManagementCapabilities { get; private set; }
		public bool PowerManagementSupported { get; private set; }
		public byte RingsBeforeAnswer { get; private set; }
		public ushort SpeakerVolumeInfo { get; private set; }
		public string Status { get; private set; }
		public ushort StatusInfo { get; private set; }
		public bool SupportsCallback { get; private set; }
		public bool SupportsSynchronousConnect { get; private set; }
		public string SystemCreationClassName { get; private set; }
		public string SystemName { get; private set; }
		public DateTime TimeOfLastReset { get; private set; }

        public static IEnumerable<PotsModem> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<PotsModem> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<PotsModem> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_PotsModem");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new PotsModem
                {
                     AnswerMode = (ushort) (managementObject.Properties["AnswerMode"]?.Value ?? default(ushort)),
		 Availability = (ushort) (managementObject.Properties["Availability"]?.Value ?? default(ushort)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CompressionInfo = (ushort) (managementObject.Properties["CompressionInfo"]?.Value ?? default(ushort)),
		 ConfigManagerErrorCode = (uint) (managementObject.Properties["ConfigManagerErrorCode"]?.Value ?? default(uint)),
		 ConfigManagerUserConfig = (bool) (managementObject.Properties["ConfigManagerUserConfig"]?.Value ?? default(bool)),
		 CountriesSupported = (string[]) (managementObject.Properties["CountriesSupported"]?.Value ?? new string[0]),
		 CountrySelected = (string) (managementObject.Properties["CountrySelected"]?.Value),
		 CreationClassName = (string) (managementObject.Properties["CreationClassName"]?.Value),
		 CurrentPasswords = (string[]) (managementObject.Properties["CurrentPasswords"]?.Value ?? new string[0]),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DeviceId = (string) (managementObject.Properties["DeviceID"]?.Value),
		 DialType = (ushort) (managementObject.Properties["DialType"]?.Value ?? default(ushort)),
		 ErrorCleared = (bool) (managementObject.Properties["ErrorCleared"]?.Value ?? default(bool)),
		 ErrorControlInfo = (ushort) (managementObject.Properties["ErrorControlInfo"]?.Value ?? default(ushort)),
		 ErrorDescription = (string) (managementObject.Properties["ErrorDescription"]?.Value),
		 InactivityTimeout = (uint) (managementObject.Properties["InactivityTimeout"]?.Value ?? default(uint)),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 LastErrorCode = (uint) (managementObject.Properties["LastErrorCode"]?.Value ?? default(uint)),
		 MaxBaudRateToPhone = (uint) (managementObject.Properties["MaxBaudRateToPhone"]?.Value ?? default(uint)),
		 MaxBaudRateToSerialPort = (uint) (managementObject.Properties["MaxBaudRateToSerialPort"]?.Value ?? default(uint)),
		 MaxNumberOfPasswords = (ushort) (managementObject.Properties["MaxNumberOfPasswords"]?.Value ?? default(ushort)),
		 ModulationScheme = (ushort) (managementObject.Properties["ModulationScheme"]?.Value ?? default(ushort)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 PnpDeviceId = (string) (managementObject.Properties["PNPDeviceID"]?.Value),
		 PowerManagementCapabilities = (ushort[]) (managementObject.Properties["PowerManagementCapabilities"]?.Value ?? new ushort[0]),
		 PowerManagementSupported = (bool) (managementObject.Properties["PowerManagementSupported"]?.Value ?? default(bool)),
		 RingsBeforeAnswer = (byte) (managementObject.Properties["RingsBeforeAnswer"]?.Value ?? default(byte)),
		 SpeakerVolumeInfo = (ushort) (managementObject.Properties["SpeakerVolumeInfo"]?.Value ?? default(ushort)),
		 Status = (string) (managementObject.Properties["Status"]?.Value),
		 StatusInfo = (ushort) (managementObject.Properties["StatusInfo"]?.Value ?? default(ushort)),
		 SupportsCallback = (bool) (managementObject.Properties["SupportsCallback"]?.Value ?? default(bool)),
		 SupportsSynchronousConnect = (bool) (managementObject.Properties["SupportsSynchronousConnect"]?.Value ?? default(bool)),
		 SystemCreationClassName = (string) (managementObject.Properties["SystemCreationClassName"]?.Value),
		 SystemName = (string) (managementObject.Properties["SystemName"]?.Value),
		 TimeOfLastReset = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["TimeOfLastReset"]?.Value as string ?? "00010102000000.000000+060")
                };
        }
    }
}