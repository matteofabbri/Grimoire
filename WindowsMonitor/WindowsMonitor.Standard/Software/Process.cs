using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Software
{
    /// <summary>
    /// </summary>
    public sealed class Process
    {
		public string Caption { get; private set; }
		public string CommandLine { get; private set; }
		public string CreationClassName { get; private set; }
		public DateTime CreationDate { get; private set; }
		public string CsCreationClassName { get; private set; }
		public string CsName { get; private set; }
		public string Description { get; private set; }
		public string ExecutablePath { get; private set; }
		public ushort ExecutionState { get; private set; }
		public string Handle { get; private set; }
		public uint HandleCount { get; private set; }
		public DateTime InstallDate { get; private set; }
		public ulong KernelModeTime { get; private set; }
		public uint MaximumWorkingSetSize { get; private set; }
		public uint MinimumWorkingSetSize { get; private set; }
		public string Name { get; private set; }
		public string OsCreationClassName { get; private set; }
		public string OsName { get; private set; }
		public ulong OtherOperationCount { get; private set; }
		public ulong OtherTransferCount { get; private set; }
		public uint PageFaults { get; private set; }
		public uint PageFileUsage { get; private set; }
		public uint ParentProcessId { get; private set; }
		public uint PeakPageFileUsage { get; private set; }
		public ulong PeakVirtualSize { get; private set; }
		public uint PeakWorkingSetSize { get; private set; }
		public uint Priority { get; private set; }
		public ulong PrivatePageCount { get; private set; }
		public uint ProcessId { get; private set; }
		public uint QuotaNonPagedPoolUsage { get; private set; }
		public uint QuotaPagedPoolUsage { get; private set; }
		public uint QuotaPeakNonPagedPoolUsage { get; private set; }
		public uint QuotaPeakPagedPoolUsage { get; private set; }
		public ulong ReadOperationCount { get; private set; }
		public ulong ReadTransferCount { get; private set; }
		public uint SessionId { get; private set; }
		public string Status { get; private set; }
		public DateTime TerminationDate { get; private set; }
		public uint ThreadCount { get; private set; }
		public ulong UserModeTime { get; private set; }
		public ulong VirtualSize { get; private set; }
		public string WindowsVersion { get; private set; }
		public ulong WorkingSetSize { get; private set; }
		public ulong WriteOperationCount { get; private set; }
		public ulong WriteTransferCount { get; private set; }

        public static IEnumerable<Process> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<Process> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<Process> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_Process");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new Process
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CommandLine = (string) (managementObject.Properties["CommandLine"]?.Value),
		 CreationClassName = (string) (managementObject.Properties["CreationClassName"]?.Value),
		 CreationDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["CreationDate"]?.Value as string ?? "00010102000000.000000+060"),
		 CsCreationClassName = (string) (managementObject.Properties["CSCreationClassName"]?.Value),
		 CsName = (string) (managementObject.Properties["CSName"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 ExecutablePath = (string) (managementObject.Properties["ExecutablePath"]?.Value),
		 ExecutionState = (ushort) (managementObject.Properties["ExecutionState"]?.Value ?? default(ushort)),
		 Handle = (string) (managementObject.Properties["Handle"]?.Value),
		 HandleCount = (uint) (managementObject.Properties["HandleCount"]?.Value ?? default(uint)),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 KernelModeTime = (ulong) (managementObject.Properties["KernelModeTime"]?.Value ?? default(ulong)),
		 MaximumWorkingSetSize = (uint) (managementObject.Properties["MaximumWorkingSetSize"]?.Value ?? default(uint)),
		 MinimumWorkingSetSize = (uint) (managementObject.Properties["MinimumWorkingSetSize"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 OsCreationClassName = (string) (managementObject.Properties["OSCreationClassName"]?.Value),
		 OsName = (string) (managementObject.Properties["OSName"]?.Value),
		 OtherOperationCount = (ulong) (managementObject.Properties["OtherOperationCount"]?.Value ?? default(ulong)),
		 OtherTransferCount = (ulong) (managementObject.Properties["OtherTransferCount"]?.Value ?? default(ulong)),
		 PageFaults = (uint) (managementObject.Properties["PageFaults"]?.Value ?? default(uint)),
		 PageFileUsage = (uint) (managementObject.Properties["PageFileUsage"]?.Value ?? default(uint)),
		 ParentProcessId = (uint) (managementObject.Properties["ParentProcessId"]?.Value ?? default(uint)),
		 PeakPageFileUsage = (uint) (managementObject.Properties["PeakPageFileUsage"]?.Value ?? default(uint)),
		 PeakVirtualSize = (ulong) (managementObject.Properties["PeakVirtualSize"]?.Value ?? default(ulong)),
		 PeakWorkingSetSize = (uint) (managementObject.Properties["PeakWorkingSetSize"]?.Value ?? default(uint)),
		 Priority = (uint) (managementObject.Properties["Priority"]?.Value ?? default(uint)),
		 PrivatePageCount = (ulong) (managementObject.Properties["PrivatePageCount"]?.Value ?? default(ulong)),
		 ProcessId = (uint) (managementObject.Properties["ProcessId"]?.Value ?? default(uint)),
		 QuotaNonPagedPoolUsage = (uint) (managementObject.Properties["QuotaNonPagedPoolUsage"]?.Value ?? default(uint)),
		 QuotaPagedPoolUsage = (uint) (managementObject.Properties["QuotaPagedPoolUsage"]?.Value ?? default(uint)),
		 QuotaPeakNonPagedPoolUsage = (uint) (managementObject.Properties["QuotaPeakNonPagedPoolUsage"]?.Value ?? default(uint)),
		 QuotaPeakPagedPoolUsage = (uint) (managementObject.Properties["QuotaPeakPagedPoolUsage"]?.Value ?? default(uint)),
		 ReadOperationCount = (ulong) (managementObject.Properties["ReadOperationCount"]?.Value ?? default(ulong)),
		 ReadTransferCount = (ulong) (managementObject.Properties["ReadTransferCount"]?.Value ?? default(ulong)),
		 SessionId = (uint) (managementObject.Properties["SessionId"]?.Value ?? default(uint)),
		 Status = (string) (managementObject.Properties["Status"]?.Value),
		 TerminationDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["TerminationDate"]?.Value as string ?? "00010102000000.000000+060"),
		 ThreadCount = (uint) (managementObject.Properties["ThreadCount"]?.Value ?? default(uint)),
		 UserModeTime = (ulong) (managementObject.Properties["UserModeTime"]?.Value ?? default(ulong)),
		 VirtualSize = (ulong) (managementObject.Properties["VirtualSize"]?.Value ?? default(ulong)),
		 WindowsVersion = (string) (managementObject.Properties["WindowsVersion"]?.Value),
		 WorkingSetSize = (ulong) (managementObject.Properties["WorkingSetSize"]?.Value ?? default(ulong)),
		 WriteOperationCount = (ulong) (managementObject.Properties["WriteOperationCount"]?.Value ?? default(ulong)),
		 WriteTransferCount = (ulong) (managementObject.Properties["WriteTransferCount"]?.Value ?? default(ulong))
                };
        }
    }
}