using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.Logicals
{
    /// <summary>
    /// </summary>
    public sealed class LogicalDisk
    {
		public ushort Access { get; private set; }
		public ushort Availability { get; private set; }
		public ulong BlockSize { get; private set; }
		public string Caption { get; private set; }
		public bool Compressed { get; private set; }
		public uint ConfigManagerErrorCode { get; private set; }
		public bool ConfigManagerUserConfig { get; private set; }
		public string CreationClassName { get; private set; }
		public string Description { get; private set; }
		public string DeviceId { get; private set; }
		public uint DriveType { get; private set; }
		public bool ErrorCleared { get; private set; }
		public string ErrorDescription { get; private set; }
		public string ErrorMethodology { get; private set; }
		public string FileSystem { get; private set; }
		public ulong FreeSpace { get; private set; }
		public DateTime InstallDate { get; private set; }
		public uint LastErrorCode { get; private set; }
		public uint MaximumComponentLength { get; private set; }
		public uint MediaType { get; private set; }
		public string Name { get; private set; }
		public ulong NumberOfBlocks { get; private set; }
		public string PnpDeviceId { get; private set; }
		public ushort[] PowerManagementCapabilities { get; private set; }
		public bool PowerManagementSupported { get; private set; }
		public string ProviderName { get; private set; }
		public string Purpose { get; private set; }
		public bool QuotasDisabled { get; private set; }
		public bool QuotasIncomplete { get; private set; }
		public bool QuotasRebuilding { get; private set; }
		public ulong Size { get; private set; }
		public string Status { get; private set; }
		public ushort StatusInfo { get; private set; }
		public bool SupportsDiskQuotas { get; private set; }
		public bool SupportsFileBasedCompression { get; private set; }
		public string SystemCreationClassName { get; private set; }
		public string SystemName { get; private set; }
		public bool VolumeDirty { get; private set; }
		public string VolumeName { get; private set; }
		public string VolumeSerialNumber { get; private set; }

        public static IEnumerable<LogicalDisk> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<LogicalDisk> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<LogicalDisk> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_LogicalDisk");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new LogicalDisk
                {
                     Access = (ushort) (managementObject.Properties["Access"]?.Value ?? default(ushort)),
		 Availability = (ushort) (managementObject.Properties["Availability"]?.Value ?? default(ushort)),
		 BlockSize = (ulong) (managementObject.Properties["BlockSize"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Compressed = (bool) (managementObject.Properties["Compressed"]?.Value ?? default(bool)),
		 ConfigManagerErrorCode = (uint) (managementObject.Properties["ConfigManagerErrorCode"]?.Value ?? default(uint)),
		 ConfigManagerUserConfig = (bool) (managementObject.Properties["ConfigManagerUserConfig"]?.Value ?? default(bool)),
		 CreationClassName = (string) (managementObject.Properties["CreationClassName"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DeviceId = (string) (managementObject.Properties["DeviceID"]?.Value),
		 DriveType = (uint) (managementObject.Properties["DriveType"]?.Value ?? default(uint)),
		 ErrorCleared = (bool) (managementObject.Properties["ErrorCleared"]?.Value ?? default(bool)),
		 ErrorDescription = (string) (managementObject.Properties["ErrorDescription"]?.Value),
		 ErrorMethodology = (string) (managementObject.Properties["ErrorMethodology"]?.Value),
		 FileSystem = (string) (managementObject.Properties["FileSystem"]?.Value),
		 FreeSpace = (ulong) (managementObject.Properties["FreeSpace"]?.Value ?? default(ulong)),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 LastErrorCode = (uint) (managementObject.Properties["LastErrorCode"]?.Value ?? default(uint)),
		 MaximumComponentLength = (uint) (managementObject.Properties["MaximumComponentLength"]?.Value ?? default(uint)),
		 MediaType = (uint) (managementObject.Properties["MediaType"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 NumberOfBlocks = (ulong) (managementObject.Properties["NumberOfBlocks"]?.Value ?? default(ulong)),
		 PnpDeviceId = (string) (managementObject.Properties["PNPDeviceID"]?.Value),
		 PowerManagementCapabilities = (ushort[]) (managementObject.Properties["PowerManagementCapabilities"]?.Value ?? new ushort[0]),
		 PowerManagementSupported = (bool) (managementObject.Properties["PowerManagementSupported"]?.Value ?? default(bool)),
		 ProviderName = (string) (managementObject.Properties["ProviderName"]?.Value),
		 Purpose = (string) (managementObject.Properties["Purpose"]?.Value),
		 QuotasDisabled = (bool) (managementObject.Properties["QuotasDisabled"]?.Value ?? default(bool)),
		 QuotasIncomplete = (bool) (managementObject.Properties["QuotasIncomplete"]?.Value ?? default(bool)),
		 QuotasRebuilding = (bool) (managementObject.Properties["QuotasRebuilding"]?.Value ?? default(bool)),
		 Size = (ulong) (managementObject.Properties["Size"]?.Value ?? default(ulong)),
		 Status = (string) (managementObject.Properties["Status"]?.Value),
		 StatusInfo = (ushort) (managementObject.Properties["StatusInfo"]?.Value ?? default(ushort)),
		 SupportsDiskQuotas = (bool) (managementObject.Properties["SupportsDiskQuotas"]?.Value ?? default(bool)),
		 SupportsFileBasedCompression = (bool) (managementObject.Properties["SupportsFileBasedCompression"]?.Value ?? default(bool)),
		 SystemCreationClassName = (string) (managementObject.Properties["SystemCreationClassName"]?.Value),
		 SystemName = (string) (managementObject.Properties["SystemName"]?.Value),
		 VolumeDirty = (bool) (managementObject.Properties["VolumeDirty"]?.Value ?? default(bool)),
		 VolumeName = (string) (managementObject.Properties["VolumeName"]?.Value),
		 VolumeSerialNumber = (string) (managementObject.Properties["VolumeSerialNumber"]?.Value)
                };
        }
    }
}