using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor
{
    /// <summary>
    /// </summary>
    public sealed class DefragAnalysis
    {
		public ulong AverageFileSize { get; private set; }
		public double AverageFragmentsPerFile { get; private set; }
		public ulong AverageFreeSpacePerExtent { get; private set; }
		public ulong ClusterSize { get; private set; }
		public ulong ExcessFolderFragments { get; private set; }
		public uint FilePercentFragmentation { get; private set; }
		public ulong FragmentedFolders { get; private set; }
		public ulong FreeSpace { get; private set; }
		public uint FreeSpacePercent { get; private set; }
		public uint FreeSpacePercentFragmentation { get; private set; }
		public ulong LargestFreeSpaceExtent { get; private set; }
		public uint MftPercentInUse { get; private set; }
		public ulong MftRecordCount { get; private set; }
		public ulong PageFileSize { get; private set; }
		public ulong TotalExcessFragments { get; private set; }
		public ulong TotalFiles { get; private set; }
		public ulong TotalFolders { get; private set; }
		public ulong TotalFragmentedFiles { get; private set; }
		public ulong TotalFreeSpaceExtents { get; private set; }
		public ulong TotalMftFragments { get; private set; }
		public ulong TotalMftSize { get; private set; }
		public ulong TotalPageFileFragments { get; private set; }
		public uint TotalPercentFragmentation { get; private set; }
		public ulong TotalUnmovableFiles { get; private set; }
		public ulong UsedSpace { get; private set; }
		public string VolumeName { get; private set; }
		public ulong VolumeSize { get; private set; }

        public static IEnumerable<DefragAnalysis> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<DefragAnalysis> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<DefragAnalysis> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_DefragAnalysis");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new DefragAnalysis
                {
                     AverageFileSize = (ulong) (managementObject.Properties["AverageFileSize"]?.Value ?? default(ulong)),
		 AverageFragmentsPerFile = (double) (managementObject.Properties["AverageFragmentsPerFile"]?.Value ?? default(double)),
		 AverageFreeSpacePerExtent = (ulong) (managementObject.Properties["AverageFreeSpacePerExtent"]?.Value ?? default(ulong)),
		 ClusterSize = (ulong) (managementObject.Properties["ClusterSize"]?.Value ?? default(ulong)),
		 ExcessFolderFragments = (ulong) (managementObject.Properties["ExcessFolderFragments"]?.Value ?? default(ulong)),
		 FilePercentFragmentation = (uint) (managementObject.Properties["FilePercentFragmentation"]?.Value ?? default(uint)),
		 FragmentedFolders = (ulong) (managementObject.Properties["FragmentedFolders"]?.Value ?? default(ulong)),
		 FreeSpace = (ulong) (managementObject.Properties["FreeSpace"]?.Value ?? default(ulong)),
		 FreeSpacePercent = (uint) (managementObject.Properties["FreeSpacePercent"]?.Value ?? default(uint)),
		 FreeSpacePercentFragmentation = (uint) (managementObject.Properties["FreeSpacePercentFragmentation"]?.Value ?? default(uint)),
		 LargestFreeSpaceExtent = (ulong) (managementObject.Properties["LargestFreeSpaceExtent"]?.Value ?? default(ulong)),
		 MftPercentInUse = (uint) (managementObject.Properties["MFTPercentInUse"]?.Value ?? default(uint)),
		 MftRecordCount = (ulong) (managementObject.Properties["MFTRecordCount"]?.Value ?? default(ulong)),
		 PageFileSize = (ulong) (managementObject.Properties["PageFileSize"]?.Value ?? default(ulong)),
		 TotalExcessFragments = (ulong) (managementObject.Properties["TotalExcessFragments"]?.Value ?? default(ulong)),
		 TotalFiles = (ulong) (managementObject.Properties["TotalFiles"]?.Value ?? default(ulong)),
		 TotalFolders = (ulong) (managementObject.Properties["TotalFolders"]?.Value ?? default(ulong)),
		 TotalFragmentedFiles = (ulong) (managementObject.Properties["TotalFragmentedFiles"]?.Value ?? default(ulong)),
		 TotalFreeSpaceExtents = (ulong) (managementObject.Properties["TotalFreeSpaceExtents"]?.Value ?? default(ulong)),
		 TotalMftFragments = (ulong) (managementObject.Properties["TotalMFTFragments"]?.Value ?? default(ulong)),
		 TotalMftSize = (ulong) (managementObject.Properties["TotalMFTSize"]?.Value ?? default(ulong)),
		 TotalPageFileFragments = (ulong) (managementObject.Properties["TotalPageFileFragments"]?.Value ?? default(ulong)),
		 TotalPercentFragmentation = (uint) (managementObject.Properties["TotalPercentFragmentation"]?.Value ?? default(uint)),
		 TotalUnmovableFiles = (ulong) (managementObject.Properties["TotalUnmovableFiles"]?.Value ?? default(ulong)),
		 UsedSpace = (ulong) (managementObject.Properties["UsedSpace"]?.Value ?? default(ulong)),
		 VolumeName = (string) (managementObject.Properties["VolumeName"]?.Value),
		 VolumeSize = (ulong) (managementObject.Properties["VolumeSize"]?.Value ?? default(ulong))
                };
        }
    }
}