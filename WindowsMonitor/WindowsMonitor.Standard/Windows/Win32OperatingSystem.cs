using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows
{
    /// <summary>
    /// </summary>
    public sealed class Win32OperatingSystem
    {
        public string BootDevice { get; private set; }
        public string BuildNumber { get; private set; }
        public string BuildType { get; private set; }
        public string Caption { get; private set; }
        public string CodeSet { get; private set; }
        public string CountryCode { get; private set; }
        public string CreationClassName { get; private set; }
        public string CsCreationClassName { get; private set; }
        public string CsdVersion { get; private set; }
        public string CsName { get; private set; }
        public string CurrentTimeZone { get; private set; }
        public bool DataExecutionPrevention32BitApplications { get; private set; }
        public bool DataExecutionPreventionAvailable { get; private set; }
        public bool DataExecutionPreventionDrivers { get; private set; }
        public byte DataExecutionPreventionSupportPolicy { get; private set; }
        public bool Debug { get; private set; }
        public string Description { get; private set; }
        public bool Distributed { get; private set; }
        public uint EncryptionLevel { get; private set; }
        public byte ForegroundApplicationBoost { get; private set; }
        public ulong FreePhysicalMemory { get; private set; }
        public ulong FreeSpaceInPagingFiles { get; private set; }
        public ulong FreeVirtualMemory { get; private set; }
        public DateTime InstallDate { get; private set; }
        public uint LargeSystemCache { get; private set; }
        public DateTime LastBootUpTime { get; private set; }
        public DateTime LocalDateTime { get; private set; }
        public string Locale { get; private set; }
        public string Manufacturer { get; private set; }
        public uint MaxNumberOfProcesses { get; private set; }
        public ulong MaxProcessMemorySize { get; private set; }
        public string[] MuiLanguages { get; private set; }
        public string Name { get; private set; }
        public uint NumberOfLicensedUsers { get; private set; }
        public uint NumberOfProcesses { get; private set; }
        public uint NumberOfUsers { get; private set; }
        public uint OperatingSystemSku { get; private set; }
        public string Organization { get; private set; }
        public string OsArchitecture { get; private set; }
        public uint OsLanguage { get; private set; }
        public uint OsProductSuite { get; private set; }
        public ushort OsType { get; private set; }
        public string OtherTypeDescription { get; private set; }
        public bool PaeEnabled { get; private set; }
        public string PlusProductId { get; private set; }
        public string PlusVersionNumber { get; private set; }
        public bool PortableOperatingSystem { get; private set; }
        public bool Primary { get; private set; }
        public uint ProductType { get; private set; }
        public string RegisteredUser { get; private set; }
        public string SerialNumber { get; private set; }
        public ushort ServicePackMajorVersion { get; private set; }
        public ushort ServicePackMinorVersion { get; private set; }
        public ulong SizeStoredInPagingFiles { get; private set; }
        public string Status { get; private set; }
        public uint SuiteMask { get; private set; }
        public string SystemDevice { get; private set; }
        public string SystemDirectory { get; private set; }
        public string SystemDrive { get; private set; }
        public ulong TotalSwapSpaceSize { get; private set; }
        public ulong TotalVirtualMemorySize { get; private set; }
        public ulong TotalVisibleMemorySize { get; private set; }
        public string Version { get; private set; }
        public string WindowsDirectory { get; private set; }

        public static IEnumerable<Win32OperatingSystem> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<Win32OperatingSystem> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<Win32OperatingSystem> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new Win32OperatingSystem
                {
                    BootDevice = (string) (managementObject.Properties["BootDevice"]?.Value),
                    BuildNumber = (string) (managementObject.Properties["BuildNumber"]?.Value),
                    BuildType = (string) (managementObject.Properties["BuildType"]?.Value),
                    Caption = (string) (managementObject.Properties["Caption"]?.Value),
                    CodeSet = (string) (managementObject.Properties["CodeSet"]?.Value),
                    CountryCode = (string) (managementObject.Properties["CountryCode"]?.Value),
                    CreationClassName =
                        (string) (managementObject.Properties["CreationClassName"]?.Value),
                    CsCreationClassName =
                        (string) (managementObject.Properties["CSCreationClassName"]?.Value),
                    CsdVersion = (string) (managementObject.Properties["CSDVersion"]?.Value),
                    CsName = (string) (managementObject.Properties["CSName"]?.Value),
                    CurrentTimeZone =  (managementObject.Properties["CurrentTimeZone"]?.Value?.ToString()),
                    DataExecutionPrevention32BitApplications =
                        (bool) (managementObject.Properties["DataExecutionPrevention_32BitApplications"]?.Value ??
                                default(bool)),
                    DataExecutionPreventionAvailable =
                        (bool) (managementObject.Properties["DataExecutionPrevention_Available"]?.Value ??
                                default(bool)),
                    DataExecutionPreventionDrivers =
                        (bool) (managementObject.Properties["DataExecutionPrevention_Drivers"]?.Value ?? default(bool)),
                    DataExecutionPreventionSupportPolicy =
                        (byte) (managementObject.Properties["DataExecutionPrevention_SupportPolicy"]?.Value ??
                                default(byte)),
                    Debug = (bool) (managementObject.Properties["Debug"]?.Value ?? default(bool)),
                    Description = (string) (managementObject.Properties["Description"]?.Value),
                    Distributed = (bool) (managementObject.Properties["Distributed"]?.Value ?? default(bool)),
                    EncryptionLevel = (uint) (managementObject.Properties["EncryptionLevel"]?.Value ?? default(uint)),
                    ForegroundApplicationBoost =
                        (byte) (managementObject.Properties["ForegroundApplicationBoost"]?.Value ?? default(byte)),
                    FreePhysicalMemory =
                        (ulong) (managementObject.Properties["FreePhysicalMemory"]?.Value ?? default(ulong)),
                    FreeSpaceInPagingFiles =
                        (ulong) (managementObject.Properties["FreeSpaceInPagingFiles"]?.Value ?? default(ulong)),
                    FreeVirtualMemory =
                        (ulong) (managementObject.Properties["FreeVirtualMemory"]?.Value ?? default(ulong)),
                    InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
                    LargeSystemCache = (uint) (managementObject.Properties["LargeSystemCache"]?.Value ?? default(uint)),
                    LastBootUpTime =
                        ManagementDateTimeConverter.ToDateTime (managementObject.Properties["LastBootUpTime"]?.Value as string ?? "00010102000000.000000+060"),
                    LocalDateTime =
                        ManagementDateTimeConverter.ToDateTime (managementObject.Properties["LocalDateTime"]?.Value as string ?? "00010102000000.000000+060"),
                    Locale = (string) (managementObject.Properties["Locale"]?.Value),
                    Manufacturer = (string) (managementObject.Properties["Manufacturer"]?.Value),
                    MaxNumberOfProcesses =
                        (uint) (managementObject.Properties["MaxNumberOfProcesses"]?.Value ?? default(uint)),
                    MaxProcessMemorySize =
                        (ulong) (managementObject.Properties["MaxProcessMemorySize"]?.Value ?? default(ulong)),
                    MuiLanguages = (string[]) (managementObject.Properties["MUILanguages"]?.Value ?? new string[0]),
                    Name = (string) (managementObject.Properties["Name"]?.Value),
                    NumberOfLicensedUsers =
                        (uint) (managementObject.Properties["NumberOfLicensedUsers"]?.Value ?? default(uint)),
                    NumberOfProcesses =
                        (uint) (managementObject.Properties["NumberOfProcesses"]?.Value ?? default(uint)),
                    NumberOfUsers = (uint) (managementObject.Properties["NumberOfUsers"]?.Value ?? default(uint)),
                    OperatingSystemSku =
                        (uint) (managementObject.Properties["OperatingSystemSKU"]?.Value ?? default(uint)),
                    Organization = (string) (managementObject.Properties["Organization"]?.Value),
                    OsArchitecture = (string) (managementObject.Properties["OSArchitecture"]?.Value),
                    OsLanguage = (uint) (managementObject.Properties["OSLanguage"]?.Value ?? default(uint)),
                    OsProductSuite = (uint) (managementObject.Properties["OSProductSuite"]?.Value ?? default(uint)),
                    OsType = (ushort) (managementObject.Properties["OSType"]?.Value ?? default(ushort)),
                    OtherTypeDescription =
                        (string) (managementObject.Properties["OtherTypeDescription"]?.Value),
                    PaeEnabled = (bool) (managementObject.Properties["PAEEnabled"]?.Value ?? default(bool)),
                    PlusProductId = (string) (managementObject.Properties["PlusProductID"]?.Value),
                    PlusVersionNumber =
                        (string) (managementObject.Properties["PlusVersionNumber"]?.Value),
                    PortableOperatingSystem =
                        (bool) (managementObject.Properties["PortableOperatingSystem"]?.Value ?? default(bool)),
                    Primary = (bool) (managementObject.Properties["Primary"]?.Value ?? default(bool)),
                    ProductType = (uint) (managementObject.Properties["ProductType"]?.Value ?? default(uint)),
                    RegisteredUser = (string) (managementObject.Properties["RegisteredUser"]?.Value),
                    SerialNumber = (string) (managementObject.Properties["SerialNumber"]?.Value),
                    ServicePackMajorVersion =
                        (ushort) (managementObject.Properties["ServicePackMajorVersion"]?.Value ?? default(ushort)),
                    ServicePackMinorVersion =
                        (ushort) (managementObject.Properties["ServicePackMinorVersion"]?.Value ?? default(ushort)),
                    SizeStoredInPagingFiles =
                        (ulong) (managementObject.Properties["SizeStoredInPagingFiles"]?.Value ?? default(ulong)),
                    Status = (string) (managementObject.Properties["Status"]?.Value),
                    SuiteMask = (uint) (managementObject.Properties["SuiteMask"]?.Value ?? default(uint)),
                    SystemDevice = (string) (managementObject.Properties["SystemDevice"]?.Value),
                    SystemDirectory =
                        (string) (managementObject.Properties["SystemDirectory"]?.Value),
                    SystemDrive = (string) (managementObject.Properties["SystemDrive"]?.Value),
                    TotalSwapSpaceSize =
                        (ulong) (managementObject.Properties["TotalSwapSpaceSize"]?.Value ?? default(ulong)),
                    TotalVirtualMemorySize =
                        (ulong) (managementObject.Properties["TotalVirtualMemorySize"]?.Value ?? default(ulong)),
                    TotalVisibleMemorySize =
                        (ulong) (managementObject.Properties["TotalVisibleMemorySize"]?.Value ?? default(ulong)),
                    Version = (string) (managementObject.Properties["Version"]?.Value),
                    WindowsDirectory =
                        (string) (managementObject.Properties["WindowsDirectory"]?.Value)
                };
        }
    }
}