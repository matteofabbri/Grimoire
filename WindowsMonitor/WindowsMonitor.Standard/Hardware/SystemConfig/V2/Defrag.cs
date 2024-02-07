using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.SystemConfig.V2
{
    /// <summary>
    /// </summary>
    public sealed class Defrag
    {
		public ulong AlignmentClusters { get; private set; }
		public uint AvgFragmentsPerFile { get; private set; }
		public ulong AvgFreeSpaceSize { get; private set; }
		public uint BytesPerCluster { get; private set; }
		public ulong ClustersPerSlab { get; private set; }
		public uint DirectoryCount { get; private set; }
		public uint Flags { get; private set; }
		public uint FragmentedDirectories { get; private set; }
		public ulong FragmentedDirectoryExtents { get; private set; }
		public ulong FragmentedExtents { get; private set; }
		public uint FragmentedFiles { get; private set; }
		public uint FragmentedSpace { get; private set; }
		public ulong FreeSpaceCount { get; private set; }
		public uint HardwareIssue { get; private set; }
		public uint InUseMftRecords { get; private set; }
		public uint InUseSlabs { get; private set; }
		public ulong LargestFreeSpaceSize { get; private set; }
		public ulong LastRunActualPurgeClusters { get; private set; }
		public uint LastRunActualPurgeSlabs { get; private set; }
		public ulong LastRunClustersTrimmed { get; private set; }
		public ulong LastRunFullDefragTime { get; private set; }
		public uint LastRunInitialBackedSlabs { get; private set; }
		public uint LastRunPercentFragmentation { get; private set; }
		public uint LastRunPinnedSlabs { get; private set; }
		public uint LastRunPotentialPurgeSlabs { get; private set; }
		public uint LastRunSpaceInefficientSlabs { get; private set; }
		public ulong LastRunTime { get; private set; }
		public uint LastRunTrimmedSlabs { get; private set; }
		public uint LastRunUnknownEvictFailSlabs { get; private set; }
		public uint LastRunVolsnapPinnedSlabs { get; private set; }
		public uint MftFragmentCount { get; private set; }
		public ulong MftSize { get; private set; }
		public uint MovableFiles { get; private set; }
		public ulong TotalClusters { get; private set; }
		public uint TotalMftRecords { get; private set; }
		public uint TotalSlabs { get; private set; }
		public ulong TotalUsedClusters { get; private set; }
		public uint UnmovableFiles { get; private set; }
		public dynamic VolumeId { get; private set; }
		public string VolumePathNames { get; private set; }

        public static IEnumerable<Defrag> Retrieve(string remote, string username, string password)
        {
            var options = new ConnectionOptions
            {
                Impersonation = ImpersonationLevel.Impersonate,
                Username = username,
                Password = password
            };

            var managementScope = new ManagementScope(new ManagementPath($"\\\\{remote}\\root\\wmi"), options);
            managementScope.Connect();

            return Retrieve(managementScope);
        }

        public static IEnumerable<Defrag> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<Defrag> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM SystemConfig_V2_Defrag");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new Defrag
                {
                     AlignmentClusters = (ulong) (managementObject.Properties["AlignmentClusters"]?.Value ?? default(ulong)),
		 AvgFragmentsPerFile = (uint) (managementObject.Properties["AvgFragmentsPerFile"]?.Value ?? default(uint)),
		 AvgFreeSpaceSize = (ulong) (managementObject.Properties["AvgFreeSpaceSize"]?.Value ?? default(ulong)),
		 BytesPerCluster = (uint) (managementObject.Properties["BytesPerCluster"]?.Value ?? default(uint)),
		 ClustersPerSlab = (ulong) (managementObject.Properties["ClustersPerSlab"]?.Value ?? default(ulong)),
		 DirectoryCount = (uint) (managementObject.Properties["DirectoryCount"]?.Value ?? default(uint)),
		 Flags = (uint) (managementObject.Properties["Flags"]?.Value ?? default(uint)),
		 FragmentedDirectories = (uint) (managementObject.Properties["FragmentedDirectories"]?.Value ?? default(uint)),
		 FragmentedDirectoryExtents = (ulong) (managementObject.Properties["FragmentedDirectoryExtents"]?.Value ?? default(ulong)),
		 FragmentedExtents = (ulong) (managementObject.Properties["FragmentedExtents"]?.Value ?? default(ulong)),
		 FragmentedFiles = (uint) (managementObject.Properties["FragmentedFiles"]?.Value ?? default(uint)),
		 FragmentedSpace = (uint) (managementObject.Properties["FragmentedSpace"]?.Value ?? default(uint)),
		 FreeSpaceCount = (ulong) (managementObject.Properties["FreeSpaceCount"]?.Value ?? default(ulong)),
		 HardwareIssue = (uint) (managementObject.Properties["HardwareIssue"]?.Value ?? default(uint)),
		 InUseMftRecords = (uint) (managementObject.Properties["InUseMFTRecords"]?.Value ?? default(uint)),
		 InUseSlabs = (uint) (managementObject.Properties["InUseSlabs"]?.Value ?? default(uint)),
		 LargestFreeSpaceSize = (ulong) (managementObject.Properties["LargestFreeSpaceSize"]?.Value ?? default(ulong)),
		 LastRunActualPurgeClusters = (ulong) (managementObject.Properties["LastRunActualPurgeClusters"]?.Value ?? default(ulong)),
		 LastRunActualPurgeSlabs = (uint) (managementObject.Properties["LastRunActualPurgeSlabs"]?.Value ?? default(uint)),
		 LastRunClustersTrimmed = (ulong) (managementObject.Properties["LastRunClustersTrimmed"]?.Value ?? default(ulong)),
		 LastRunFullDefragTime = (ulong) (managementObject.Properties["LastRunFullDefragTime"]?.Value ?? default(ulong)),
		 LastRunInitialBackedSlabs = (uint) (managementObject.Properties["LastRunInitialBackedSlabs"]?.Value ?? default(uint)),
		 LastRunPercentFragmentation = (uint) (managementObject.Properties["LastRunPercentFragmentation"]?.Value ?? default(uint)),
		 LastRunPinnedSlabs = (uint) (managementObject.Properties["LastRunPinnedSlabs"]?.Value ?? default(uint)),
		 LastRunPotentialPurgeSlabs = (uint) (managementObject.Properties["LastRunPotentialPurgeSlabs"]?.Value ?? default(uint)),
		 LastRunSpaceInefficientSlabs = (uint) (managementObject.Properties["LastRunSpaceInefficientSlabs"]?.Value ?? default(uint)),
		 LastRunTime = (ulong) (managementObject.Properties["LastRunTime"]?.Value ?? default(ulong)),
		 LastRunTrimmedSlabs = (uint) (managementObject.Properties["LastRunTrimmedSlabs"]?.Value ?? default(uint)),
		 LastRunUnknownEvictFailSlabs = (uint) (managementObject.Properties["LastRunUnknownEvictFailSlabs"]?.Value ?? default(uint)),
		 LastRunVolsnapPinnedSlabs = (uint) (managementObject.Properties["LastRunVolsnapPinnedSlabs"]?.Value ?? default(uint)),
		 MftFragmentCount = (uint) (managementObject.Properties["MFTFragmentCount"]?.Value ?? default(uint)),
		 MftSize = (ulong) (managementObject.Properties["MFTSize"]?.Value ?? default(ulong)),
		 MovableFiles = (uint) (managementObject.Properties["MovableFiles"]?.Value ?? default(uint)),
		 TotalClusters = (ulong) (managementObject.Properties["TotalClusters"]?.Value ?? default(ulong)),
		 TotalMftRecords = (uint) (managementObject.Properties["TotalMFTRecords"]?.Value ?? default(uint)),
		 TotalSlabs = (uint) (managementObject.Properties["TotalSlabs"]?.Value ?? default(uint)),
		 TotalUsedClusters = (ulong) (managementObject.Properties["TotalUsedClusters"]?.Value ?? default(ulong)),
		 UnmovableFiles = (uint) (managementObject.Properties["UnmovableFiles"]?.Value ?? default(uint)),
		 VolumeId = (dynamic) (managementObject.Properties["VolumeId"]?.Value ?? default(dynamic)),
		 VolumePathNames = (string) (managementObject.Properties["VolumePathNames"]?.Value ?? default(string))
                };
        }
    }
}