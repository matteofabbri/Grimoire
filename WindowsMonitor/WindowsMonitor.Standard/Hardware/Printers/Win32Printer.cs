using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Printers
{
    /// <summary>
    /// </summary>
    public sealed class Win32Printer
    {
		public uint Attributes { get; private set; }
		public ushort Availability { get; private set; }
		public string[] AvailableJobSheets { get; private set; }
		public uint AveragePagesPerMinute { get; private set; }
		public ushort[] Capabilities { get; private set; }
		public string[] CapabilityDescriptions { get; private set; }
		public string Caption { get; private set; }
		public string[] CharSetsSupported { get; private set; }
		public string Comment { get; private set; }
		public uint ConfigManagerErrorCode { get; private set; }
		public bool ConfigManagerUserConfig { get; private set; }
		public string CreationClassName { get; private set; }
		public ushort[] CurrentCapabilities { get; private set; }
		public string CurrentCharSet { get; private set; }
		public ushort CurrentLanguage { get; private set; }
		public string CurrentMimeType { get; private set; }
		public string CurrentNaturalLanguage { get; private set; }
		public string CurrentPaperType { get; private set; }
		public bool Default { get; private set; }
		public ushort[] DefaultCapabilities { get; private set; }
		public uint DefaultCopies { get; private set; }
		public ushort DefaultLanguage { get; private set; }
		public string DefaultMimeType { get; private set; }
		public uint DefaultNumberUp { get; private set; }
		public string DefaultPaperType { get; private set; }
		public uint DefaultPriority { get; private set; }
		public string Description { get; private set; }
		public ushort DetectedErrorState { get; private set; }
		public string DeviceId { get; private set; }
		public bool Direct { get; private set; }
		public bool DoCompleteFirst { get; private set; }
		public string DriverName { get; private set; }
		public bool EnableBidi { get; private set; }
		public bool EnableDevQueryPrint { get; private set; }
		public bool ErrorCleared { get; private set; }
		public string ErrorDescription { get; private set; }
		public string[] ErrorInformation { get; private set; }
		public ushort ExtendedDetectedErrorState { get; private set; }
		public ushort ExtendedPrinterStatus { get; private set; }
		public bool Hidden { get; private set; }
		public uint HorizontalResolution { get; private set; }
		public DateTime InstallDate { get; private set; }
		public uint JobCountSinceLastReset { get; private set; }
		public bool KeepPrintedJobs { get; private set; }
		public ushort[] LanguagesSupported { get; private set; }
		public uint LastErrorCode { get; private set; }
		public bool Local { get; private set; }
		public string Location { get; private set; }
		public ushort MarkingTechnology { get; private set; }
		public uint MaxCopies { get; private set; }
		public uint MaxNumberUp { get; private set; }
		public uint MaxSizeSupported { get; private set; }
		public string[] MimeTypesSupported { get; private set; }
		public string Name { get; private set; }
		public string[] NaturalLanguagesSupported { get; private set; }
		public bool Network { get; private set; }
		public ushort[] PaperSizesSupported { get; private set; }
		public string[] PaperTypesAvailable { get; private set; }
		public string Parameters { get; private set; }
		public string PnpDeviceId { get; private set; }
		public string PortName { get; private set; }
		public ushort[] PowerManagementCapabilities { get; private set; }
		public bool PowerManagementSupported { get; private set; }
		public string[] PrinterPaperNames { get; private set; }
		public uint PrinterState { get; private set; }
		public ushort PrinterStatus { get; private set; }
		public string PrintJobDataType { get; private set; }
		public string PrintProcessor { get; private set; }
		public uint Priority { get; private set; }
		public bool Published { get; private set; }
		public bool Queued { get; private set; }
		public bool RawOnly { get; private set; }
		public string SeparatorFile { get; private set; }
		public string ServerName { get; private set; }
		public bool Shared { get; private set; }
		public string ShareName { get; private set; }
		public bool SpoolEnabled { get; private set; }
		public DateTime StartTime { get; private set; }
		public string Status { get; private set; }
		public ushort StatusInfo { get; private set; }
		public string SystemCreationClassName { get; private set; }
		public string SystemName { get; private set; }
		public DateTime TimeOfLastReset { get; private set; }
		public DateTime UntilTime { get; private set; }
		public uint VerticalResolution { get; private set; }
		public bool WorkOffline { get; private set; }

        public static IEnumerable<Win32Printer> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<Win32Printer> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<Win32Printer> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_Printer");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new Win32Printer
                {
                     Attributes = (uint) (managementObject.Properties["Attributes"]?.Value ?? default(uint)),
		 Availability = (ushort) (managementObject.Properties["Availability"]?.Value ?? default(ushort)),
		 AvailableJobSheets = (string[]) (managementObject.Properties["AvailableJobSheets"]?.Value ?? new string[0]),
		 AveragePagesPerMinute = (uint) (managementObject.Properties["AveragePagesPerMinute"]?.Value ?? default(uint)),
		 Capabilities = (ushort[]) (managementObject.Properties["Capabilities"]?.Value ?? new ushort[0]),
		 CapabilityDescriptions = (string[]) (managementObject.Properties["CapabilityDescriptions"]?.Value ?? new string[0]),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CharSetsSupported = (string[]) (managementObject.Properties["CharSetsSupported"]?.Value ?? new string[0]),
		 Comment = (string) (managementObject.Properties["Comment"]?.Value),
		 ConfigManagerErrorCode = (uint) (managementObject.Properties["ConfigManagerErrorCode"]?.Value ?? default(uint)),
		 ConfigManagerUserConfig = (bool) (managementObject.Properties["ConfigManagerUserConfig"]?.Value ?? default(bool)),
		 CreationClassName = (string) (managementObject.Properties["CreationClassName"]?.Value),
		 CurrentCapabilities = (ushort[]) (managementObject.Properties["CurrentCapabilities"]?.Value ?? new ushort[0]),
		 CurrentCharSet = (string) (managementObject.Properties["CurrentCharSet"]?.Value),
		 CurrentLanguage = (ushort) (managementObject.Properties["CurrentLanguage"]?.Value ?? default(ushort)),
		 CurrentMimeType = (string) (managementObject.Properties["CurrentMimeType"]?.Value),
		 CurrentNaturalLanguage = (string) (managementObject.Properties["CurrentNaturalLanguage"]?.Value),
		 CurrentPaperType = (string) (managementObject.Properties["CurrentPaperType"]?.Value),
		 Default = (bool) (managementObject.Properties["Default"]?.Value ?? default(bool)),
		 DefaultCapabilities = (ushort[]) (managementObject.Properties["DefaultCapabilities"]?.Value ?? new ushort[0]),
		 DefaultCopies = (uint) (managementObject.Properties["DefaultCopies"]?.Value ?? default(uint)),
		 DefaultLanguage = (ushort) (managementObject.Properties["DefaultLanguage"]?.Value ?? default(ushort)),
		 DefaultMimeType = (string) (managementObject.Properties["DefaultMimeType"]?.Value),
		 DefaultNumberUp = (uint) (managementObject.Properties["DefaultNumberUp"]?.Value ?? default(uint)),
		 DefaultPaperType = (string) (managementObject.Properties["DefaultPaperType"]?.Value),
		 DefaultPriority = (uint) (managementObject.Properties["DefaultPriority"]?.Value ?? default(uint)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DetectedErrorState = (ushort) (managementObject.Properties["DetectedErrorState"]?.Value ?? default(ushort)),
		 DeviceId = (string) (managementObject.Properties["DeviceID"]?.Value),
		 Direct = (bool) (managementObject.Properties["Direct"]?.Value ?? default(bool)),
		 DoCompleteFirst = (bool) (managementObject.Properties["DoCompleteFirst"]?.Value ?? default(bool)),
		 DriverName = (string) (managementObject.Properties["DriverName"]?.Value),
		 EnableBidi = (bool) (managementObject.Properties["EnableBIDI"]?.Value ?? default(bool)),
		 EnableDevQueryPrint = (bool) (managementObject.Properties["EnableDevQueryPrint"]?.Value ?? default(bool)),
		 ErrorCleared = (bool) (managementObject.Properties["ErrorCleared"]?.Value ?? default(bool)),
		 ErrorDescription = (string) (managementObject.Properties["ErrorDescription"]?.Value),
		 ErrorInformation = (string[]) (managementObject.Properties["ErrorInformation"]?.Value ?? new string[0]),
		 ExtendedDetectedErrorState = (ushort) (managementObject.Properties["ExtendedDetectedErrorState"]?.Value ?? default(ushort)),
		 ExtendedPrinterStatus = (ushort) (managementObject.Properties["ExtendedPrinterStatus"]?.Value ?? default(ushort)),
		 Hidden = (bool) (managementObject.Properties["Hidden"]?.Value ?? default(bool)),
		 HorizontalResolution = (uint) (managementObject.Properties["HorizontalResolution"]?.Value ?? default(uint)),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 JobCountSinceLastReset = (uint) (managementObject.Properties["JobCountSinceLastReset"]?.Value ?? default(uint)),
		 KeepPrintedJobs = (bool) (managementObject.Properties["KeepPrintedJobs"]?.Value ?? default(bool)),
		 LanguagesSupported = (ushort[]) (managementObject.Properties["LanguagesSupported"]?.Value ?? new ushort[0]),
		 LastErrorCode = (uint) (managementObject.Properties["LastErrorCode"]?.Value ?? default(uint)),
		 Local = (bool) (managementObject.Properties["Local"]?.Value ?? default(bool)),
		 Location = (string) (managementObject.Properties["Location"]?.Value),
		 MarkingTechnology = (ushort) (managementObject.Properties["MarkingTechnology"]?.Value ?? default(ushort)),
		 MaxCopies = (uint) (managementObject.Properties["MaxCopies"]?.Value ?? default(uint)),
		 MaxNumberUp = (uint) (managementObject.Properties["MaxNumberUp"]?.Value ?? default(uint)),
		 MaxSizeSupported = (uint) (managementObject.Properties["MaxSizeSupported"]?.Value ?? default(uint)),
		 MimeTypesSupported = (string[]) (managementObject.Properties["MimeTypesSupported"]?.Value ?? new string[0]),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 NaturalLanguagesSupported = (string[]) (managementObject.Properties["NaturalLanguagesSupported"]?.Value ?? new string[0]),
		 Network = (bool) (managementObject.Properties["Network"]?.Value ?? default(bool)),
		 PaperSizesSupported = (ushort[]) (managementObject.Properties["PaperSizesSupported"]?.Value ?? new ushort[0]),
		 PaperTypesAvailable = (string[]) (managementObject.Properties["PaperTypesAvailable"]?.Value ?? new string[0]),
		 Parameters = (string) (managementObject.Properties["Parameters"]?.Value),
		 PnpDeviceId = (string) (managementObject.Properties["PNPDeviceID"]?.Value),
		 PortName = (string) (managementObject.Properties["PortName"]?.Value),
		 PowerManagementCapabilities = (ushort[]) (managementObject.Properties["PowerManagementCapabilities"]?.Value ?? new ushort[0]),
		 PowerManagementSupported = (bool) (managementObject.Properties["PowerManagementSupported"]?.Value ?? default(bool)),
		 PrinterPaperNames = (string[]) (managementObject.Properties["PrinterPaperNames"]?.Value ?? new string[0]),
		 PrinterState = (uint) (managementObject.Properties["PrinterState"]?.Value ?? default(uint)),
		 PrinterStatus = (ushort) (managementObject.Properties["PrinterStatus"]?.Value ?? default(ushort)),
		 PrintJobDataType = (string) (managementObject.Properties["PrintJobDataType"]?.Value),
		 PrintProcessor = (string) (managementObject.Properties["PrintProcessor"]?.Value),
		 Priority = (uint) (managementObject.Properties["Priority"]?.Value ?? default(uint)),
		 Published = (bool) (managementObject.Properties["Published"]?.Value ?? default(bool)),
		 Queued = (bool) (managementObject.Properties["Queued"]?.Value ?? default(bool)),
		 RawOnly = (bool) (managementObject.Properties["RawOnly"]?.Value ?? default(bool)),
		 SeparatorFile = (string) (managementObject.Properties["SeparatorFile"]?.Value),
		 ServerName = (string) (managementObject.Properties["ServerName"]?.Value),
		 Shared = (bool) (managementObject.Properties["Shared"]?.Value ?? default(bool)),
		 ShareName = (string) (managementObject.Properties["ShareName"]?.Value),
		 SpoolEnabled = (bool) (managementObject.Properties["SpoolEnabled"]?.Value ?? default(bool)),
		 StartTime = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["StartTime"]?.Value as string ?? "00010102000000.000000+060"),
		 Status = (string) (managementObject.Properties["Status"]?.Value),
		 StatusInfo = (ushort) (managementObject.Properties["StatusInfo"]?.Value ?? default(ushort)),
		 SystemCreationClassName = (string) (managementObject.Properties["SystemCreationClassName"]?.Value),
		 SystemName = (string) (managementObject.Properties["SystemName"]?.Value),
		 TimeOfLastReset = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["TimeOfLastReset"]?.Value as string ?? "00010102000000.000000+060"),
		 UntilTime = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["UntilTime"]?.Value as string ?? "00010102000000.000000+060"),
		 VerticalResolution = (uint) (managementObject.Properties["VerticalResolution"]?.Value ?? default(uint)),
		 WorkOffline = (bool) (managementObject.Properties["WorkOffline"]?.Value ?? default(bool))
                };
        }
    }
}