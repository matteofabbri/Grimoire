using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.Volumes
{
    /// <summary>
    /// </summary>
    public sealed class Volume
    {
		public ushort Access { get; private set; }
		public bool Automount { get; private set; }
		public ushort Availability { get; private set; }
		public ulong BlockSize { get; private set; }
		public bool BootVolume { get; private set; }
		public ulong Capacity { get; private set; }
		public string Caption { get; private set; }
		public bool Compressed { get; private set; }
		public uint ConfigManagerErrorCode { get; private set; }
		public bool ConfigManagerUserConfig { get; private set; }
		public string CreationClassName { get; private set; }
		public string Description { get; private set; }
		public string DeviceId { get; private set; }
		public bool DirtyBitSet { get; private set; }
		public string DriveLetter { get; private set; }
		public uint DriveType { get; private set; }
		public bool ErrorCleared { get; private set; }
		public string ErrorDescription { get; private set; }
		public string ErrorMethodology { get; private set; }
		public string FileSystem { get; private set; }
		public ulong FreeSpace { get; private set; }
		public bool IndexingEnabled { get; private set; }
		public DateTime InstallDate { get; private set; }
		public string Label { get; private set; }
		public uint LastErrorCode { get; private set; }
		public uint MaximumFileNameLength { get; private set; }
		public string Name { get; private set; }
		public ulong NumberOfBlocks { get; private set; }
		public bool PageFilePresent { get; private set; }
		public string PnpDeviceId { get; private set; }
		public ushort[] PowerManagementCapabilities { get; private set; }
		public bool PowerManagementSupported { get; private set; }
		public string Purpose { get; private set; }
		public bool QuotasEnabled { get; private set; }
		public bool QuotasIncomplete { get; private set; }
		public bool QuotasRebuilding { get; private set; }
		public uint SerialNumber { get; private set; }
		public string Status { get; private set; }
		public ushort StatusInfo { get; private set; }
		public bool SupportsDiskQuotas { get; private set; }
		public bool SupportsFileBasedCompression { get; private set; }
		public string SystemCreationClassName { get; private set; }
		public string SystemName { get; private set; }
		public bool SystemVolume { get; private set; }

        public static IEnumerable<Volume> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<Volume> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<Volume> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_Volume");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new Volume
                {
                     Access = (ushort) (managementObject.Properties["Access"]?.Value ?? default(ushort)),
		 Automount = (bool) (managementObject.Properties["Automount"]?.Value ?? default(bool)),
		 Availability = (ushort) (managementObject.Properties["Availability"]?.Value ?? default(ushort)),
		 BlockSize = (ulong) (managementObject.Properties["BlockSize"]?.Value ?? default(ulong)),
		 BootVolume = (bool) (managementObject.Properties["BootVolume"]?.Value ?? default(bool)),
		 Capacity = (ulong) (managementObject.Properties["Capacity"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Compressed = (bool) (managementObject.Properties["Compressed"]?.Value ?? default(bool)),
		 ConfigManagerErrorCode = (uint) (managementObject.Properties["ConfigManagerErrorCode"]?.Value ?? default(uint)),
		 ConfigManagerUserConfig = (bool) (managementObject.Properties["ConfigManagerUserConfig"]?.Value ?? default(bool)),
		 CreationClassName = (string) (managementObject.Properties["CreationClassName"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DeviceId = (string) (managementObject.Properties["DeviceID"]?.Value),
		 DirtyBitSet = (bool) (managementObject.Properties["DirtyBitSet"]?.Value ?? default(bool)),
		 DriveLetter = (string) (managementObject.Properties["DriveLetter"]?.Value),
		 DriveType = (uint) (managementObject.Properties["DriveType"]?.Value ?? default(uint)),
		 ErrorCleared = (bool) (managementObject.Properties["ErrorCleared"]?.Value ?? default(bool)),
		 ErrorDescription = (string) (managementObject.Properties["ErrorDescription"]?.Value),
		 ErrorMethodology = (string) (managementObject.Properties["ErrorMethodology"]?.Value),
		 FileSystem = (string) (managementObject.Properties["FileSystem"]?.Value),
		 FreeSpace = (ulong) (managementObject.Properties["FreeSpace"]?.Value ?? default(ulong)),
		 IndexingEnabled = (bool) (managementObject.Properties["IndexingEnabled"]?.Value ?? default(bool)),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 Label = (string) (managementObject.Properties["Label"]?.Value),
		 LastErrorCode = (uint) (managementObject.Properties["LastErrorCode"]?.Value ?? default(uint)),
		 MaximumFileNameLength = (uint) (managementObject.Properties["MaximumFileNameLength"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 NumberOfBlocks = (ulong) (managementObject.Properties["NumberOfBlocks"]?.Value ?? default(ulong)),
		 PageFilePresent = (bool) (managementObject.Properties["PageFilePresent"]?.Value ?? default(bool)),
		 PnpDeviceId = (string) (managementObject.Properties["PNPDeviceID"]?.Value),
		 PowerManagementCapabilities = (ushort[]) (managementObject.Properties["PowerManagementCapabilities"]?.Value ?? new ushort[0]),
		 PowerManagementSupported = (bool) (managementObject.Properties["PowerManagementSupported"]?.Value ?? default(bool)),
		 Purpose = (string) (managementObject.Properties["Purpose"]?.Value),
		 QuotasEnabled = (bool) (managementObject.Properties["QuotasEnabled"]?.Value ?? default(bool)),
		 QuotasIncomplete = (bool) (managementObject.Properties["QuotasIncomplete"]?.Value ?? default(bool)),
		 QuotasRebuilding = (bool) (managementObject.Properties["QuotasRebuilding"]?.Value ?? default(bool)),
		 SerialNumber = (uint) (managementObject.Properties["SerialNumber"]?.Value ?? default(uint)),
		 Status = (string) (managementObject.Properties["Status"]?.Value),
		 StatusInfo = (ushort) (managementObject.Properties["StatusInfo"]?.Value ?? default(ushort)),
		 SupportsDiskQuotas = (bool) (managementObject.Properties["SupportsDiskQuotas"]?.Value ?? default(bool)),
		 SupportsFileBasedCompression = (bool) (managementObject.Properties["SupportsFileBasedCompression"]?.Value ?? default(bool)),
		 SystemCreationClassName = (string) (managementObject.Properties["SystemCreationClassName"]?.Value),
		 SystemName = (string) (managementObject.Properties["SystemName"]?.Value),
		 SystemVolume = (bool) (managementObject.Properties["SystemVolume"]?.Value ?? default(bool))
                };
        }
    }
}