using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows
{
    /// <summary>
    /// </summary>
    public sealed class NomadPackages
    {
        public string AlreadyCached { get; private set; }
        public string BackOffSeconds { get; private set; }
        public string BytesFromDp { get; private set; }
        public string BytesFromPeer { get; private set; }
        public string CachePriority { get; private set; }
        public string CacheToFolder { get; private set; }
        public string CachingSeconds { get; private set; }
        public string DisconnectedSeconds { get; private set; }
        public string DiskUsageKb { get; private set; }
        public string ElapsedSeconds { get; private set; }
        public string FinishTimeUtc { get; private set; }
        public string LastElectedUtc { get; private set; }
        public string LastElectionUtc { get; private set; }
        public string LstFileTimeUtc { get; private set; }
        public string OptInfo { get; private set; }
        public string PackageId { get; private set; }
        public string Percent { get; private set; }
        public string ReconnectCount { get; private set; }
        public string ReturnCode { get; private set; }
        public string ReturnStatus { get; private set; }
        public string StartTimeUtc { get; private set; }
        public string VerifiedUtc { get; private set; }
        public string Version { get; private set; }
        public string WorkRate { get; private set; }

        public static IEnumerable<NomadPackages> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<NomadPackages> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<NomadPackages> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM NomadPackages");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new NomadPackages
                {
                    AlreadyCached = (string) managementObject.Properties["AlreadyCached"]?.Value,
                    BackOffSeconds = (string) managementObject.Properties["BackOffSeconds"]?.Value,
                    BytesFromDp = (string) managementObject.Properties["BytesFromDP"]?.Value,
                    BytesFromPeer = (string) managementObject.Properties["BytesFromPeer"]?.Value,
                    CachePriority = (string) managementObject.Properties["CachePriority"]?.Value,
                    CacheToFolder = (string) managementObject.Properties["CacheToFolder"]?.Value,
                    CachingSeconds = (string) managementObject.Properties["CachingSeconds"]?.Value,
                    DisconnectedSeconds =
                        (string) managementObject.Properties["DisconnectedSeconds"]?.Value,
                    DiskUsageKb = (string) managementObject.Properties["DiskUsageKB"]?.Value,
                    ElapsedSeconds = (string) managementObject.Properties["ElapsedSeconds"]?.Value,
                    FinishTimeUtc = (string) managementObject.Properties["FinishTimeUTC"]?.Value,
                    LastElectedUtc = (string) managementObject.Properties["LastElectedUTC"]?.Value,
                    LastElectionUtc =
                        (string) managementObject.Properties["LastElectionUTC"]?.Value,
                    LstFileTimeUtc = (string) managementObject.Properties["LstFileTimeUTC"]?.Value,
                    OptInfo = (string) managementObject.Properties["OptInfo"]?.Value,
                    PackageId = (string) managementObject.Properties["PackageID"]?.Value,
                    Percent = (string) managementObject.Properties["Percent"]?.Value,
                    ReconnectCount = (string) managementObject.Properties["ReconnectCount"]?.Value,
                    ReturnCode = (string) managementObject.Properties["ReturnCode"]?.Value,
                    ReturnStatus = (string) managementObject.Properties["ReturnStatus"]?.Value,
                    StartTimeUtc = (string) managementObject.Properties["StartTimeUTC"]?.Value,
                    VerifiedUtc = (string) managementObject.Properties["VerifiedUTC"]?.Value,
                    Version = (string) managementObject.Properties["Version"]?.Value,
                    WorkRate = (string) managementObject.Properties["WorkRate"]?.Value
                };
        }
    }
}