using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows
{
    /// <summary>
    /// </summary>
    public sealed class OperatingSystem
    {
		public string Caption { get; private set; }
		public string CreationClassName { get; private set; }
		public string CsCreationClassName { get; private set; }
		public string CsName { get; private set; }
		public string CurrentTimeZone { get; private set; }
		public string Description { get; private set; }
		public bool Distributed { get; private set; }
		public ulong FreePhysicalMemory { get; private set; }
		public ulong FreeSpaceInPagingFiles { get; private set; }
		public ulong FreeVirtualMemory { get; private set; }
		public DateTime InstallDate { get; private set; }
		public DateTime LastBootUpTime { get; private set; }
		public DateTime LocalDateTime { get; private set; }
		public uint MaxNumberOfProcesses { get; private set; }
		public ulong MaxProcessMemorySize { get; private set; }
		public string Name { get; private set; }
		public uint NumberOfLicensedUsers { get; private set; }
		public uint NumberOfProcesses { get; private set; }
		public uint NumberOfUsers { get; private set; }
		public ushort OsType { get; private set; }
		public string OtherTypeDescription { get; private set; }
		public ulong SizeStoredInPagingFiles { get; private set; }
		public string Status { get; private set; }
		public ulong TotalSwapSpaceSize { get; private set; }
		public ulong TotalVirtualMemorySize { get; private set; }
		public ulong TotalVisibleMemorySize { get; private set; }
		public string Version { get; private set; }

        public static IEnumerable<OperatingSystem> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<OperatingSystem> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<OperatingSystem> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_OperatingSystem");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new OperatingSystem
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CreationClassName = (string) (managementObject.Properties["CreationClassName"]?.Value),
		 CsCreationClassName = (string) (managementObject.Properties["CSCreationClassName"]?.Value),
		 CsName = (string) (managementObject.Properties["CSName"]?.Value),
		 CurrentTimeZone =  (managementObject.Properties["CurrentTimeZone"]?.Value?.ToString()),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 Distributed = (bool) (managementObject.Properties["Distributed"]?.Value ?? default(bool)),
		 FreePhysicalMemory = (ulong) (managementObject.Properties["FreePhysicalMemory"]?.Value ?? default(ulong)),
		 FreeSpaceInPagingFiles = (ulong) (managementObject.Properties["FreeSpaceInPagingFiles"]?.Value ?? default(ulong)),
		 FreeVirtualMemory = (ulong) (managementObject.Properties["FreeVirtualMemory"]?.Value ?? default(ulong)),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 LastBootUpTime = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["LastBootUpTime"]?.Value as string ?? "00010102000000.000000+060"),
		 LocalDateTime = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["LocalDateTime"]?.Value as string ?? "00010102000000.000000+060"),
		 MaxNumberOfProcesses = (uint) (managementObject.Properties["MaxNumberOfProcesses"]?.Value ?? default(uint)),
		 MaxProcessMemorySize = (ulong) (managementObject.Properties["MaxProcessMemorySize"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 NumberOfLicensedUsers = (uint) (managementObject.Properties["NumberOfLicensedUsers"]?.Value ?? default(uint)),
		 NumberOfProcesses = (uint) (managementObject.Properties["NumberOfProcesses"]?.Value ?? default(uint)),
		 NumberOfUsers = (uint) (managementObject.Properties["NumberOfUsers"]?.Value ?? default(uint)),
		 OsType = (ushort) (managementObject.Properties["OSType"]?.Value ?? default(ushort)),
		 OtherTypeDescription = (string) (managementObject.Properties["OtherTypeDescription"]?.Value),
		 SizeStoredInPagingFiles = (ulong) (managementObject.Properties["SizeStoredInPagingFiles"]?.Value ?? default(ulong)),
		 Status = (string) (managementObject.Properties["Status"]?.Value),
		 TotalSwapSpaceSize = (ulong) (managementObject.Properties["TotalSwapSpaceSize"]?.Value ?? default(ulong)),
		 TotalVirtualMemorySize = (ulong) (managementObject.Properties["TotalVirtualMemorySize"]?.Value ?? default(ulong)),
		 TotalVisibleMemorySize = (ulong) (managementObject.Properties["TotalVisibleMemorySize"]?.Value ?? default(ulong)),
		 Version = (string) (managementObject.Properties["Version"]?.Value)
                };
        }
    }
}