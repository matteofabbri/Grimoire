using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Printers
{
    /// <summary>
    /// </summary>
    public sealed class Printer
    {
		public ushort Availability { get; private set; }
		public string[] AvailableJobSheets { get; private set; }
		public ushort[] Capabilities { get; private set; }
		public string[] CapabilityDescriptions { get; private set; }
		public string Caption { get; private set; }
		public string[] CharSetsSupported { get; private set; }
		public uint ConfigManagerErrorCode { get; private set; }
		public bool ConfigManagerUserConfig { get; private set; }
		public string CreationClassName { get; private set; }
		public ushort[] CurrentCapabilities { get; private set; }
		public string CurrentCharSet { get; private set; }
		public ushort CurrentLanguage { get; private set; }
		public string CurrentMimeType { get; private set; }
		public string CurrentNaturalLanguage { get; private set; }
		public string CurrentPaperType { get; private set; }
		public ushort[] DefaultCapabilities { get; private set; }
		public uint DefaultCopies { get; private set; }
		public ushort DefaultLanguage { get; private set; }
		public string DefaultMimeType { get; private set; }
		public uint DefaultNumberUp { get; private set; }
		public string DefaultPaperType { get; private set; }
		public string Description { get; private set; }
		public ushort DetectedErrorState { get; private set; }
		public string DeviceId { get; private set; }
		public bool ErrorCleared { get; private set; }
		public string ErrorDescription { get; private set; }
		public string[] ErrorInformation { get; private set; }
		public uint HorizontalResolution { get; private set; }
		public DateTime InstallDate { get; private set; }
		public uint JobCountSinceLastReset { get; private set; }
		public ushort[] LanguagesSupported { get; private set; }
		public uint LastErrorCode { get; private set; }
		public ushort MarkingTechnology { get; private set; }
		public uint MaxCopies { get; private set; }
		public uint MaxNumberUp { get; private set; }
		public uint MaxSizeSupported { get; private set; }
		public string[] MimeTypesSupported { get; private set; }
		public string Name { get; private set; }
		public string[] NaturalLanguagesSupported { get; private set; }
		public ushort[] PaperSizesSupported { get; private set; }
		public string[] PaperTypesAvailable { get; private set; }
		public string PnpDeviceId { get; private set; }
		public ushort[] PowerManagementCapabilities { get; private set; }
		public bool PowerManagementSupported { get; private set; }
		public ushort PrinterStatus { get; private set; }
		public string Status { get; private set; }
		public ushort StatusInfo { get; private set; }
		public string SystemCreationClassName { get; private set; }
		public string SystemName { get; private set; }
		public DateTime TimeOfLastReset { get; private set; }
		public uint VerticalResolution { get; private set; }

        public static IEnumerable<Printer> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<Printer> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<Printer> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_Printer");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new Printer
                {
                     Availability = (ushort) (managementObject.Properties["Availability"]?.Value ?? default(ushort)),
		 AvailableJobSheets = (string[]) (managementObject.Properties["AvailableJobSheets"]?.Value ?? new string[0]),
		 Capabilities = (ushort[]) (managementObject.Properties["Capabilities"]?.Value ?? new ushort[0]),
		 CapabilityDescriptions = (string[]) (managementObject.Properties["CapabilityDescriptions"]?.Value ?? new string[0]),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CharSetsSupported = (string[]) (managementObject.Properties["CharSetsSupported"]?.Value ?? new string[0]),
		 ConfigManagerErrorCode = (uint) (managementObject.Properties["ConfigManagerErrorCode"]?.Value ?? default(uint)),
		 ConfigManagerUserConfig = (bool) (managementObject.Properties["ConfigManagerUserConfig"]?.Value ?? default(bool)),
		 CreationClassName = (string) (managementObject.Properties["CreationClassName"]?.Value),
		 CurrentCapabilities = (ushort[]) (managementObject.Properties["CurrentCapabilities"]?.Value ?? new ushort[0]),
		 CurrentCharSet = (string) (managementObject.Properties["CurrentCharSet"]?.Value),
		 CurrentLanguage = (ushort) (managementObject.Properties["CurrentLanguage"]?.Value ?? default(ushort)),
		 CurrentMimeType = (string) (managementObject.Properties["CurrentMimeType"]?.Value),
		 CurrentNaturalLanguage = (string) (managementObject.Properties["CurrentNaturalLanguage"]?.Value),
		 CurrentPaperType = (string) (managementObject.Properties["CurrentPaperType"]?.Value),
		 DefaultCapabilities = (ushort[]) (managementObject.Properties["DefaultCapabilities"]?.Value ?? new ushort[0]),
		 DefaultCopies = (uint) (managementObject.Properties["DefaultCopies"]?.Value ?? default(uint)),
		 DefaultLanguage = (ushort) (managementObject.Properties["DefaultLanguage"]?.Value ?? default(ushort)),
		 DefaultMimeType = (string) (managementObject.Properties["DefaultMimeType"]?.Value),
		 DefaultNumberUp = (uint) (managementObject.Properties["DefaultNumberUp"]?.Value ?? default(uint)),
		 DefaultPaperType = (string) (managementObject.Properties["DefaultPaperType"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DetectedErrorState = (ushort) (managementObject.Properties["DetectedErrorState"]?.Value ?? default(ushort)),
		 DeviceId = (string) (managementObject.Properties["DeviceID"]?.Value),
		 ErrorCleared = (bool) (managementObject.Properties["ErrorCleared"]?.Value ?? default(bool)),
		 ErrorDescription = (string) (managementObject.Properties["ErrorDescription"]?.Value),
		 ErrorInformation = (string[]) (managementObject.Properties["ErrorInformation"]?.Value ?? new string[0]),
		 HorizontalResolution = (uint) (managementObject.Properties["HorizontalResolution"]?.Value ?? default(uint)),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 JobCountSinceLastReset = (uint) (managementObject.Properties["JobCountSinceLastReset"]?.Value ?? default(uint)),
		 LanguagesSupported = (ushort[]) (managementObject.Properties["LanguagesSupported"]?.Value ?? new ushort[0]),
		 LastErrorCode = (uint) (managementObject.Properties["LastErrorCode"]?.Value ?? default(uint)),
		 MarkingTechnology = (ushort) (managementObject.Properties["MarkingTechnology"]?.Value ?? default(ushort)),
		 MaxCopies = (uint) (managementObject.Properties["MaxCopies"]?.Value ?? default(uint)),
		 MaxNumberUp = (uint) (managementObject.Properties["MaxNumberUp"]?.Value ?? default(uint)),
		 MaxSizeSupported = (uint) (managementObject.Properties["MaxSizeSupported"]?.Value ?? default(uint)),
		 MimeTypesSupported = (string[]) (managementObject.Properties["MimeTypesSupported"]?.Value ?? new string[0]),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 NaturalLanguagesSupported = (string[]) (managementObject.Properties["NaturalLanguagesSupported"]?.Value ?? new string[0]),
		 PaperSizesSupported = (ushort[]) (managementObject.Properties["PaperSizesSupported"]?.Value ?? new ushort[0]),
		 PaperTypesAvailable = (string[]) (managementObject.Properties["PaperTypesAvailable"]?.Value ?? new string[0]),
		 PnpDeviceId = (string) (managementObject.Properties["PNPDeviceID"]?.Value),
		 PowerManagementCapabilities = (ushort[]) (managementObject.Properties["PowerManagementCapabilities"]?.Value ?? new ushort[0]),
		 PowerManagementSupported = (bool) (managementObject.Properties["PowerManagementSupported"]?.Value ?? default(bool)),
		 PrinterStatus = (ushort) (managementObject.Properties["PrinterStatus"]?.Value ?? default(ushort)),
		 Status = (string) (managementObject.Properties["Status"]?.Value),
		 StatusInfo = (ushort) (managementObject.Properties["StatusInfo"]?.Value ?? default(ushort)),
		 SystemCreationClassName = (string) (managementObject.Properties["SystemCreationClassName"]?.Value),
		 SystemName = (string) (managementObject.Properties["SystemName"]?.Value),
		 TimeOfLastReset = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["TimeOfLastReset"]?.Value as string ?? "00010102000000.000000+060"),
		 VerticalResolution = (uint) (managementObject.Properties["VerticalResolution"]?.Value ?? default(uint))
                };
        }
    }
}