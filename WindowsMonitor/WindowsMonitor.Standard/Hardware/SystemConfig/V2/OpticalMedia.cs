using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.SystemConfig.V2
{
    /// <summary>
    /// </summary>
    public sealed class OpticalMedia
    {
		public ushort BusType { get; private set; }
		public uint BytesPerSector { get; private set; }
		public string DeviceName { get; private set; }
		public ushort DeviceType { get; private set; }
		public ushort DiscStatus { get; private set; }
		public ushort DiskNumber { get; private set; }
		public string DriveLetter { get; private set; }
		public string FileSystemName { get; private set; }
		public uint Flags { get; private set; }
		public ushort LastSessionStatus { get; private set; }
		public string ManufacturerName { get; private set; }
		public ushort MediaType { get; private set; }
		public ulong NextWritableAddress { get; private set; }
		public ulong NumberOfFreeBlocks { get; private set; }
		public uint NumberOfSessions { get; private set; }
		public uint NumberOfTracks { get; private set; }
		public ulong Size { get; private set; }
		public ulong StartingOffset { get; private set; }
		public ulong TotalNumberOfBlocks { get; private set; }

        public static IEnumerable<OpticalMedia> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<OpticalMedia> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<OpticalMedia> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM SystemConfig_V2_OpticalMedia");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new OpticalMedia
                {
                     BusType = (ushort) (managementObject.Properties["BusType"]?.Value ?? default(ushort)),
		 BytesPerSector = (uint) (managementObject.Properties["BytesPerSector"]?.Value ?? default(uint)),
		 DeviceName = (string) (managementObject.Properties["DeviceName"]?.Value ?? default(string)),
		 DeviceType = (ushort) (managementObject.Properties["DeviceType"]?.Value ?? default(ushort)),
		 DiscStatus = (ushort) (managementObject.Properties["DiscStatus"]?.Value ?? default(ushort)),
		 DiskNumber = (ushort) (managementObject.Properties["DiskNumber"]?.Value ?? default(ushort)),
		 DriveLetter = (string) (managementObject.Properties["DriveLetter"]?.Value ?? default(string)),
		 FileSystemName = (string) (managementObject.Properties["FileSystemName"]?.Value ?? default(string)),
		 Flags = (uint) (managementObject.Properties["Flags"]?.Value ?? default(uint)),
		 LastSessionStatus = (ushort) (managementObject.Properties["LastSessionStatus"]?.Value ?? default(ushort)),
		 ManufacturerName = (string) (managementObject.Properties["ManufacturerName"]?.Value ?? default(string)),
		 MediaType = (ushort) (managementObject.Properties["MediaType"]?.Value ?? default(ushort)),
		 NextWritableAddress = (ulong) (managementObject.Properties["NextWritableAddress"]?.Value ?? default(ulong)),
		 NumberOfFreeBlocks = (ulong) (managementObject.Properties["NumberOfFreeBlocks"]?.Value ?? default(ulong)),
		 NumberOfSessions = (uint) (managementObject.Properties["NumberOfSessions"]?.Value ?? default(uint)),
		 NumberOfTracks = (uint) (managementObject.Properties["NumberOfTracks"]?.Value ?? default(uint)),
		 Size = (ulong) (managementObject.Properties["Size"]?.Value ?? default(ulong)),
		 StartingOffset = (ulong) (managementObject.Properties["StartingOffset"]?.Value ?? default(ulong)),
		 TotalNumberOfBlocks = (ulong) (managementObject.Properties["TotalNumberOfBlocks"]?.Value ?? default(ulong))
                };
        }
    }
}