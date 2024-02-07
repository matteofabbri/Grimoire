using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows
{
    /// <summary>
    /// </summary>
    public sealed class NomadSettings
    {
        public uint AssumedLinkSpeed { get; private set; }
        public uint AuthenticatedUsers { get; private set; }
        public uint BlockSize { get; private set; }
        public string CachePath { get; private set; }
        public string CertIssuer { get; private set; }
        public string CertSubject { get; private set; }
        public uint CompatibilityFlags { get; private set; }
        public uint Debug { get; private set; }
        public uint DebugMask { get; private set; }
        public uint DownloadTimeout { get; private set; }
        public string DpNotAvailableCodes { get; private set; }
        public uint EncryptionLevel { get; private set; }
        public uint EnforceQuotas { get; private set; }
        public string FriMaxWorkRate { get; private set; }
        public uint GenerateWerEvents { get; private set; }
        public uint HaackTimeoutMins { get; private set; }
        public string InstallationDirectory { get; private set; }
        public string Ipv4Subnet { get; private set; }
        public uint JobResetSleepMSecs { get; private set; }
        public string KnownMobileDevices { get; private set; }
        public string LocalCachePath { get; private set; }
        public string LogFileName { get; private set; }
        public uint LogFormat { get; private set; }
        public uint MaxAllocRequest { get; private set; }
        public uint MaxBusyBackoffSecs { get; private set; }
        public uint MaxCacheSizeMb { get; private set; }
        public uint MaxConcurrency { get; private set; }
        public uint MaximumMegaByte { get; private set; }
        public uint MaxLogFileSize { get; private set; }
        public uint MaxPackageSizeRas { get; private set; }
        public uint MaxPackageSizeSlowLan { get; private set; }
        public uint MaxPacketsPerSecond { get; private set; }
        public uint MaxStatusFrequency { get; private set; }
        public string MCastMsipidKey { get; private set; }
        public string MonMaxWorkRate { get; private set; }
        public string MsipidKey { get; private set; }
        public string MultiCastMadcapScope { get; private set; }
        public uint MultiCastResilFactor { get; private set; }
        public uint MultiCastTtl { get; private set; }
        public uint MutiCastSupport { get; private set; }
        public uint NoHardlink { get; private set; }
        public string NomadInhibitedAdSites { get; private set; }
        public string NomadInhibitedSubnets { get; private set; }
        public string NomadNeverUseSubnets { get; private set; }
        public uint P2PPort { get; private set; }
        public uint P2Penabled { get; private set; }
        public uint P2PMulticastMode { get; private set; }
        public string PatchLevel { get; private set; }
        public uint PercentAvailableDisk { get; private set; }
        public string PermittedLsZShares { get; private set; }
        public string PlatformUrl { get; private set; }
        public uint PostCompleteTimeoutHours { get; private set; }
        public uint PreCompleteTimeoutHours { get; private set; }
        public string Product { get; private set; }
        public string ProductVersion { get; private set; }
        public uint RecycleDpDelay { get; private set; }
        public uint RunHidden { get; private set; }
        public string SatMaxWorkRate { get; private set; }
        public string SigsFolder { get; private set; }
        public uint SpecialNetShare { get; private set; }
        public uint SsdEnabled { get; private set; }
        public uint SspbaEnabled { get; private set; }
        public string StatusMsgEvents { get; private set; }
        public string SuccessCodes { get; private set; }
        public string SunMaxWorkRate { get; private set; }
        public string ThuMaxWorkRate { get; private set; }
        public string TueMaxWorkRate { get; private set; }
        public uint Ui { get; private set; }
        public string WedMaxWorkRate { get; private set; }
        public uint WlanBlipSecs { get; private set; }
        public string WlanProfileList { get; private set; }

        public static IEnumerable<NomadSettings> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<NomadSettings> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<NomadSettings> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM NomadSettings");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new NomadSettings
                {
                    AssumedLinkSpeed = (uint) (managementObject.Properties["AssumedLinkSpeed"]?.Value ?? default(uint)),
                    AuthenticatedUsers =
                        (uint) (managementObject.Properties["AuthenticatedUsers"]?.Value ?? default(uint)),
                    BlockSize = (uint) (managementObject.Properties["BlockSize"]?.Value ?? default(uint)),
                    CachePath = (string) managementObject.Properties["CachePath"]?.Value,
                    CertIssuer = (string) managementObject.Properties["CertIssuer"]?.Value,
                    CertSubject = (string) managementObject.Properties["CertSubject"]?.Value,
                    CompatibilityFlags =
                        (uint) (managementObject.Properties["CompatibilityFlags"]?.Value ?? default(uint)),
                    Debug = (uint) (managementObject.Properties["Debug"]?.Value ?? default(uint)),
                    DebugMask = (uint) (managementObject.Properties["DebugMask"]?.Value ?? default(uint)),
                    DownloadTimeout = (uint) (managementObject.Properties["DownloadTimeout"]?.Value ?? default(uint)),
                    DpNotAvailableCodes =
                        (string) managementObject.Properties["DpNotAvailableCodes"]?.Value,
                    EncryptionLevel = (uint) (managementObject.Properties["EncryptionLevel"]?.Value ?? default(uint)),
                    EnforceQuotas = (uint) (managementObject.Properties["EnforceQuotas"]?.Value ?? default(uint)),
                    FriMaxWorkRate = (string) managementObject.Properties["FriMaxWorkRate"]?.Value,
                    GenerateWerEvents =
                        (uint) (managementObject.Properties["GenerateWEREvents"]?.Value ?? default(uint)),
                    HaackTimeoutMins = (uint) (managementObject.Properties["HAACKTimeoutMins"]?.Value ?? default(uint)),
                    InstallationDirectory =
                        (string) managementObject.Properties["InstallationDirectory"]?.Value,
                    Ipv4Subnet = (string) managementObject.Properties["ipv4Subnet"]?.Value,
                    JobResetSleepMSecs =
                        (uint) (managementObject.Properties["JobResetSleepMSecs"]?.Value ?? default(uint)),
                    KnownMobileDevices =
                        (string) managementObject.Properties["KnownMobileDevices"]?.Value,
                    LocalCachePath = (string) managementObject.Properties["LocalCachePath"]?.Value,
                    LogFileName = (string) managementObject.Properties["LogFileName"]?.Value,
                    LogFormat = (uint) (managementObject.Properties["LogFormat"]?.Value ?? default(uint)),
                    MaxAllocRequest = (uint) (managementObject.Properties["MaxAllocRequest"]?.Value ?? default(uint)),
                    MaxBusyBackoffSecs =
                        (uint) (managementObject.Properties["MaxBusyBackoffSecs"]?.Value ?? default(uint)),
                    MaxCacheSizeMb = (uint) (managementObject.Properties["MaxCacheSizeMB"]?.Value ?? default(uint)),
                    MaxConcurrency = (uint) (managementObject.Properties["MaxConcurrency"]?.Value ?? default(uint)),
                    MaximumMegaByte = (uint) (managementObject.Properties["MaximumMegaByte"]?.Value ?? default(uint)),
                    MaxLogFileSize = (uint) (managementObject.Properties["MaxLogFileSize"]?.Value ?? default(uint)),
                    MaxPackageSizeRas =
                        (uint) (managementObject.Properties["MaxPackageSizeRAS"]?.Value ?? default(uint)),
                    MaxPackageSizeSlowLan =
                        (uint) (managementObject.Properties["MaxPackageSizeSlowLAN"]?.Value ?? default(uint)),
                    MaxPacketsPerSecond =
                        (uint) (managementObject.Properties["MaxPacketsPerSecond"]?.Value ?? default(uint)),
                    MaxStatusFrequency =
                        (uint) (managementObject.Properties["MaxStatusFrequency"]?.Value ?? default(uint)),
                    MCastMsipidKey = (string) managementObject.Properties["MCastMSIPIDKey"]?.Value,
                    MonMaxWorkRate = (string) managementObject.Properties["MonMaxWorkRate"]?.Value,
                    MsipidKey = (string) managementObject.Properties["MSIPIDKey"]?.Value,
                    MultiCastMadcapScope =
                        (string) managementObject.Properties["MultiCastMADCAPScope"]?.Value,
                    MultiCastResilFactor =
                        (uint) (managementObject.Properties["MultiCastResilFactor"]?.Value ?? default(uint)),
                    MultiCastTtl = (uint) (managementObject.Properties["MultiCastTTL"]?.Value ?? default(uint)),
                    MutiCastSupport = (uint) (managementObject.Properties["MutiCastSupport"]?.Value ?? default(uint)),
                    NoHardlink = (uint) (managementObject.Properties["NoHardlink"]?.Value ?? default(uint)),
                    NomadInhibitedAdSites =
                        (string) managementObject.Properties["NomadInhibitedADSites"]?.Value,
                    NomadInhibitedSubnets =
                        (string) managementObject.Properties["NomadInhibitedSubnets"]?.Value,
                    NomadNeverUseSubnets =
                        (string) managementObject.Properties["NomadNeverUseSubnets"]?.Value,
                    P2PPort = (uint) (managementObject.Properties["P2P_Port"]?.Value ?? default(uint)),
                    P2Penabled = (uint) (managementObject.Properties["P2Penabled"]?.Value ?? default(uint)),
                    P2PMulticastMode = (uint) (managementObject.Properties["P2PMulticastMode"]?.Value ?? default(uint)),
                    PatchLevel = (string) managementObject.Properties["PatchLevel"]?.Value,
                    PercentAvailableDisk =
                        (uint) (managementObject.Properties["PercentAvailableDisk"]?.Value ?? default(uint)),
                    PermittedLsZShares =
                        (string) managementObject.Properties["PermittedLsZShares"]?.Value,
                    PlatformUrl = (string) managementObject.Properties["PlatformUrl"]?.Value,
                    PostCompleteTimeoutHours =
                        (uint) (managementObject.Properties["PostCompleteTimeoutHours"]?.Value ?? default(uint)),
                    PreCompleteTimeoutHours =
                        (uint) (managementObject.Properties["PreCompleteTimeoutHours"]?.Value ?? default(uint)),
                    Product = (string) managementObject.Properties["Product"]?.Value,
                    ProductVersion = (string) managementObject.Properties["ProductVersion"]?.Value,
                    RecycleDpDelay = (uint) (managementObject.Properties["RecycleDPDelay"]?.Value ?? default(uint)),
                    RunHidden = (uint) (managementObject.Properties["RunHidden"]?.Value ?? default(uint)),
                    SatMaxWorkRate = (string) managementObject.Properties["SatMaxWorkRate"]?.Value,
                    SigsFolder = (string) managementObject.Properties["SigsFolder"]?.Value,
                    SpecialNetShare = (uint) (managementObject.Properties["SpecialNetShare"]?.Value ?? default(uint)),
                    SsdEnabled = (uint) (managementObject.Properties["SSDEnabled"]?.Value ?? default(uint)),
                    SspbaEnabled = (uint) (managementObject.Properties["SSPBAEnabled"]?.Value ?? default(uint)),
                    StatusMsgEvents =
                        (string) managementObject.Properties["StatusMsgEvents"]?.Value,
                    SuccessCodes = (string) managementObject.Properties["SuccessCodes"]?.Value,
                    SunMaxWorkRate = (string) managementObject.Properties["SunMaxWorkRate"]?.Value,
                    ThuMaxWorkRate = (string) managementObject.Properties["ThuMaxWorkRate"]?.Value,
                    TueMaxWorkRate = (string) managementObject.Properties["TueMaxWorkRate"]?.Value,
                    Ui = (uint) (managementObject.Properties["UI"]?.Value ?? default(uint)),
                    WedMaxWorkRate = (string) managementObject.Properties["WedMaxWorkRate"]?.Value,
                    WlanBlipSecs = (uint) (managementObject.Properties["WlanBlipSecs"]?.Value ?? default(uint)),
                    WlanProfileList =
                        (string) managementObject.Properties["WlanProfileList"]?.Value
                };
        }
    }
}