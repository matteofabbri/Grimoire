using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Drives.Win32DiskDrives
{
    /// <summary>
    /// </summary>
    public sealed class Win32DiskPartition
    {
		public ushort Access { get; private set; }
		public ushort Availability { get; private set; }
		public ulong BlockSize { get; private set; }
		public bool Bootable { get; private set; }
		public bool BootPartition { get; private set; }
		public string Caption { get; private set; }
		public uint ConfigManagerErrorCode { get; private set; }
		public bool ConfigManagerUserConfig { get; private set; }
		public string CreationClassName { get; private set; }
		public string Description { get; private set; }
		public string DeviceId { get; private set; }
		public uint DiskIndex { get; private set; }
		public bool ErrorCleared { get; private set; }
		public string ErrorDescription { get; private set; }
		public string ErrorMethodology { get; private set; }
		public uint HiddenSectors { get; private set; }
		public uint Index { get; private set; }
		public DateTime InstallDate { get; private set; }
		public uint LastErrorCode { get; private set; }
		public string Name { get; private set; }
		public ulong NumberOfBlocks { get; private set; }
		public string PnpDeviceId { get; private set; }
		public ushort[] PowerManagementCapabilities { get; private set; }
		public bool PowerManagementSupported { get; private set; }
		public bool PrimaryPartition { get; private set; }
		public string Purpose { get; private set; }
		public bool RewritePartition { get; private set; }
		public ulong Size { get; private set; }
		public ulong StartingOffset { get; private set; }
		public string Status { get; private set; }
		public ushort StatusInfo { get; private set; }
		public string SystemCreationClassName { get; private set; }
		public string SystemName { get; private set; }
		public string Type { get; private set; }

        public static IEnumerable<Win32DiskPartition> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<Win32DiskPartition> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<Win32DiskPartition> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_DiskPartition");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new Win32DiskPartition
                {
                     Access = (ushort) (managementObject.Properties["Access"]?.Value ?? default(ushort)),
		 Availability = (ushort) (managementObject.Properties["Availability"]?.Value ?? default(ushort)),
		 BlockSize = (ulong) (managementObject.Properties["BlockSize"]?.Value ?? default(ulong)),
		 Bootable = (bool) (managementObject.Properties["Bootable"]?.Value ?? default(bool)),
		 BootPartition = (bool) (managementObject.Properties["BootPartition"]?.Value ?? default(bool)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 ConfigManagerErrorCode = (uint) (managementObject.Properties["ConfigManagerErrorCode"]?.Value ?? default(uint)),
		 ConfigManagerUserConfig = (bool) (managementObject.Properties["ConfigManagerUserConfig"]?.Value ?? default(bool)),
		 CreationClassName = (string) (managementObject.Properties["CreationClassName"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DeviceId = (string) (managementObject.Properties["DeviceID"]?.Value),
		 DiskIndex = (uint) (managementObject.Properties["DiskIndex"]?.Value ?? default(uint)),
		 ErrorCleared = (bool) (managementObject.Properties["ErrorCleared"]?.Value ?? default(bool)),
		 ErrorDescription = (string) (managementObject.Properties["ErrorDescription"]?.Value),
		 ErrorMethodology = (string) (managementObject.Properties["ErrorMethodology"]?.Value),
		 HiddenSectors = (uint) (managementObject.Properties["HiddenSectors"]?.Value ?? default(uint)),
		 Index = (uint) (managementObject.Properties["Index"]?.Value ?? default(uint)),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 LastErrorCode = (uint) (managementObject.Properties["LastErrorCode"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 NumberOfBlocks = (ulong) (managementObject.Properties["NumberOfBlocks"]?.Value ?? default(ulong)),
		 PnpDeviceId = (string) (managementObject.Properties["PNPDeviceID"]?.Value),
		 PowerManagementCapabilities = (ushort[]) (managementObject.Properties["PowerManagementCapabilities"]?.Value ?? new ushort[0]),
		 PowerManagementSupported = (bool) (managementObject.Properties["PowerManagementSupported"]?.Value ?? default(bool)),
		 PrimaryPartition = (bool) (managementObject.Properties["PrimaryPartition"]?.Value ?? default(bool)),
		 Purpose = (string) (managementObject.Properties["Purpose"]?.Value),
		 RewritePartition = (bool) (managementObject.Properties["RewritePartition"]?.Value ?? default(bool)),
		 Size = (ulong) (managementObject.Properties["Size"]?.Value ?? default(ulong)),
		 StartingOffset = (ulong) (managementObject.Properties["StartingOffset"]?.Value ?? default(ulong)),
		 Status = (string) (managementObject.Properties["Status"]?.Value),
		 StatusInfo = (ushort) (managementObject.Properties["StatusInfo"]?.Value ?? default(ushort)),
		 SystemCreationClassName = (string) (managementObject.Properties["SystemCreationClassName"]?.Value),
		 SystemName = (string) (managementObject.Properties["SystemName"]?.Value),
		 Type = (string) (managementObject.Properties["Type"]?.Value)
                };
        }
    }
}