using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Memories
{
    /// <summary>
    /// </summary>
    public sealed class MemoryArray
    {
		public ushort Access { get; private set; }
		public byte[] AdditionalErrorData { get; private set; }
		public ushort Availability { get; private set; }
		public ulong BlockSize { get; private set; }
		public string Caption { get; private set; }
		public uint ConfigManagerErrorCode { get; private set; }
		public bool ConfigManagerUserConfig { get; private set; }
		public bool CorrectableError { get; private set; }
		public string CreationClassName { get; private set; }
		public string Description { get; private set; }
		public string DeviceId { get; private set; }
		public ulong EndingAddress { get; private set; }
		public ushort ErrorAccess { get; private set; }
		public ulong ErrorAddress { get; private set; }
		public bool ErrorCleared { get; private set; }
		public byte[] ErrorData { get; private set; }
		public ushort ErrorDataOrder { get; private set; }
		public string ErrorDescription { get; private set; }
		public ushort ErrorGranularity { get; private set; }
		public ushort ErrorInfo { get; private set; }
		public string ErrorMethodology { get; private set; }
		public ulong ErrorResolution { get; private set; }
		public DateTime ErrorTime { get; private set; }
		public uint ErrorTransferSize { get; private set; }
		public DateTime InstallDate { get; private set; }
		public uint LastErrorCode { get; private set; }
		public string Name { get; private set; }
		public ulong NumberOfBlocks { get; private set; }
		public string OtherErrorDescription { get; private set; }
		public string PnpDeviceId { get; private set; }
		public ushort[] PowerManagementCapabilities { get; private set; }
		public bool PowerManagementSupported { get; private set; }
		public string Purpose { get; private set; }
		public ulong StartingAddress { get; private set; }
		public string Status { get; private set; }
		public ushort StatusInfo { get; private set; }
		public string SystemCreationClassName { get; private set; }
		public bool SystemLevelAddress { get; private set; }
		public string SystemName { get; private set; }

        public static IEnumerable<MemoryArray> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<MemoryArray> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<MemoryArray> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_MemoryArray");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new MemoryArray
                {
                     Access = (ushort) (managementObject.Properties["Access"]?.Value ?? default(ushort)),
		 AdditionalErrorData = (byte[]) (managementObject.Properties["AdditionalErrorData"]?.Value ?? new byte[0]),
		 Availability = (ushort) (managementObject.Properties["Availability"]?.Value ?? default(ushort)),
		 BlockSize = (ulong) (managementObject.Properties["BlockSize"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 ConfigManagerErrorCode = (uint) (managementObject.Properties["ConfigManagerErrorCode"]?.Value ?? default(uint)),
		 ConfigManagerUserConfig = (bool) (managementObject.Properties["ConfigManagerUserConfig"]?.Value ?? default(bool)),
		 CorrectableError = (bool) (managementObject.Properties["CorrectableError"]?.Value ?? default(bool)),
		 CreationClassName = (string) (managementObject.Properties["CreationClassName"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DeviceId = (string) (managementObject.Properties["DeviceID"]?.Value),
		 EndingAddress = (ulong) (managementObject.Properties["EndingAddress"]?.Value ?? default(ulong)),
		 ErrorAccess = (ushort) (managementObject.Properties["ErrorAccess"]?.Value ?? default(ushort)),
		 ErrorAddress = (ulong) (managementObject.Properties["ErrorAddress"]?.Value ?? default(ulong)),
		 ErrorCleared = (bool) (managementObject.Properties["ErrorCleared"]?.Value ?? default(bool)),
		 ErrorData = (byte[]) (managementObject.Properties["ErrorData"]?.Value ?? new byte[0]),
		 ErrorDataOrder = (ushort) (managementObject.Properties["ErrorDataOrder"]?.Value ?? default(ushort)),
		 ErrorDescription = (string) (managementObject.Properties["ErrorDescription"]?.Value),
		 ErrorGranularity = (ushort) (managementObject.Properties["ErrorGranularity"]?.Value ?? default(ushort)),
		 ErrorInfo = (ushort) (managementObject.Properties["ErrorInfo"]?.Value ?? default(ushort)),
		 ErrorMethodology = (string) (managementObject.Properties["ErrorMethodology"]?.Value),
		 ErrorResolution = (ulong) (managementObject.Properties["ErrorResolution"]?.Value ?? default(ulong)),
		 ErrorTime = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["ErrorTime"]?.Value as string ?? "00010102000000.000000+060"),
		 ErrorTransferSize = (uint) (managementObject.Properties["ErrorTransferSize"]?.Value ?? default(uint)),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 LastErrorCode = (uint) (managementObject.Properties["LastErrorCode"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 NumberOfBlocks = (ulong) (managementObject.Properties["NumberOfBlocks"]?.Value ?? default(ulong)),
		 OtherErrorDescription = (string) (managementObject.Properties["OtherErrorDescription"]?.Value),
		 PnpDeviceId = (string) (managementObject.Properties["PNPDeviceID"]?.Value),
		 PowerManagementCapabilities = (ushort[]) (managementObject.Properties["PowerManagementCapabilities"]?.Value ?? new ushort[0]),
		 PowerManagementSupported = (bool) (managementObject.Properties["PowerManagementSupported"]?.Value ?? default(bool)),
		 Purpose = (string) (managementObject.Properties["Purpose"]?.Value),
		 StartingAddress = (ulong) (managementObject.Properties["StartingAddress"]?.Value ?? default(ulong)),
		 Status = (string) (managementObject.Properties["Status"]?.Value),
		 StatusInfo = (ushort) (managementObject.Properties["StatusInfo"]?.Value ?? default(ushort)),
		 SystemCreationClassName = (string) (managementObject.Properties["SystemCreationClassName"]?.Value),
		 SystemLevelAddress = (bool) (managementObject.Properties["SystemLevelAddress"]?.Value ?? default(bool)),
		 SystemName = (string) (managementObject.Properties["SystemName"]?.Value)
                };
        }
    }
}