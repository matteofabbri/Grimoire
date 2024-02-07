using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.SystemConfig.V1
{
    /// <summary>
    /// </summary>
    public sealed class LogDisk
    {
		public uint BytesPerSector { get; private set; }
		public uint DiskNumber { get; private set; }
		public char[] DriveLetterString { get; private set; }
		public uint DriveType { get; private set; }
		public char[] FileSystem { get; private set; }
		public uint Flags { get; private set; }
		public long NumberOfFreeClusters { get; private set; }
		public uint Pad1 { get; private set; }
		public uint Pad2 { get; private set; }
		public uint PartitionNumber { get; private set; }
		public ulong PartitionSize { get; private set; }
		public uint SectorsPerCluster { get; private set; }
		public uint Size { get; private set; }
		public ulong StartOffset { get; private set; }
		public long TotalNumberOfClusters { get; private set; }
		public uint VolumeExt { get; private set; }

        public static IEnumerable<LogDisk> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<LogDisk> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<LogDisk> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM SystemConfig_V1_LogDisk");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new LogDisk
                {
                     BytesPerSector = (uint) (managementObject.Properties["BytesPerSector"]?.Value ?? default(uint)),
		 DiskNumber = (uint) (managementObject.Properties["DiskNumber"]?.Value ?? default(uint)),
		 DriveLetterString = (char[]) (managementObject.Properties["DriveLetterString"]?.Value ?? new char[0]),
		 DriveType = (uint) (managementObject.Properties["DriveType"]?.Value ?? default(uint)),
		 FileSystem = (char[]) (managementObject.Properties["FileSystem"]?.Value ?? new char[0]),
		 Flags = (uint) (managementObject.Properties["Flags"]?.Value ?? default(uint)),
		 NumberOfFreeClusters = (long) (managementObject.Properties["NumberOfFreeClusters"]?.Value ?? default(long)),
		 Pad1 = (uint) (managementObject.Properties["Pad1"]?.Value ?? default(uint)),
		 Pad2 = (uint) (managementObject.Properties["Pad2"]?.Value ?? default(uint)),
		 PartitionNumber = (uint) (managementObject.Properties["PartitionNumber"]?.Value ?? default(uint)),
		 PartitionSize = (ulong) (managementObject.Properties["PartitionSize"]?.Value ?? default(ulong)),
		 SectorsPerCluster = (uint) (managementObject.Properties["SectorsPerCluster"]?.Value ?? default(uint)),
		 Size = (uint) (managementObject.Properties["Size"]?.Value ?? default(uint)),
		 StartOffset = (ulong) (managementObject.Properties["StartOffset"]?.Value ?? default(ulong)),
		 TotalNumberOfClusters = (long) (managementObject.Properties["TotalNumberOfClusters"]?.Value ?? default(long)),
		 VolumeExt = (uint) (managementObject.Properties["VolumeExt"]?.Value ?? default(uint))
                };
        }
    }
}