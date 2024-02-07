using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted.PerfOs
{
    /// <summary>
    /// </summary>
    public sealed class PerfProcProcess
    {
		public string Caption { get; private set; }
		public uint CreatingProcessId { get; private set; }
		public string Description { get; private set; }
		public ulong ElapsedTime { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public uint HandleCount { get; private set; }
		public uint IdProcess { get; private set; }
		public ulong IoDataBytesPersec { get; private set; }
		public ulong IoDataOperationsPersec { get; private set; }
		public ulong IoOtherBytesPersec { get; private set; }
		public ulong IoOtherOperationsPersec { get; private set; }
		public ulong IoReadBytesPersec { get; private set; }
		public ulong IoReadOperationsPersec { get; private set; }
		public ulong IoWriteBytesPersec { get; private set; }
		public ulong IoWriteOperationsPersec { get; private set; }
		public string Name { get; private set; }
		public uint PageFaultsPersec { get; private set; }
		public ulong PageFileBytes { get; private set; }
		public ulong PageFileBytesPeak { get; private set; }
		public ulong PercentPrivilegedTime { get; private set; }
		public ulong PercentProcessorTime { get; private set; }
		public ulong PercentUserTime { get; private set; }
		public uint PoolNonpagedBytes { get; private set; }
		public uint PoolPagedBytes { get; private set; }
		public uint PriorityBase { get; private set; }
		public ulong PrivateBytes { get; private set; }
		public uint ThreadCount { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public ulong VirtualBytes { get; private set; }
		public ulong VirtualBytesPeak { get; private set; }
		public ulong WorkingSet { get; private set; }
		public ulong WorkingSetPeak { get; private set; }
		public ulong WorkingSetPrivate { get; private set; }

        public static IEnumerable<PerfProcProcess> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<PerfProcProcess> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<PerfProcProcess> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_PerfProc_Process");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new PerfProcProcess
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CreatingProcessId = (uint) (managementObject.Properties["CreatingProcessID"]?.Value ?? default(uint)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 ElapsedTime = (ulong) (managementObject.Properties["ElapsedTime"]?.Value ?? default(ulong)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 HandleCount = (uint) (managementObject.Properties["HandleCount"]?.Value ?? default(uint)),
		 IdProcess = (uint) (managementObject.Properties["IDProcess"]?.Value ?? default(uint)),
		 IoDataBytesPersec = (ulong) (managementObject.Properties["IODataBytesPersec"]?.Value ?? default(ulong)),
		 IoDataOperationsPersec = (ulong) (managementObject.Properties["IODataOperationsPersec"]?.Value ?? default(ulong)),
		 IoOtherBytesPersec = (ulong) (managementObject.Properties["IOOtherBytesPersec"]?.Value ?? default(ulong)),
		 IoOtherOperationsPersec = (ulong) (managementObject.Properties["IOOtherOperationsPersec"]?.Value ?? default(ulong)),
		 IoReadBytesPersec = (ulong) (managementObject.Properties["IOReadBytesPersec"]?.Value ?? default(ulong)),
		 IoReadOperationsPersec = (ulong) (managementObject.Properties["IOReadOperationsPersec"]?.Value ?? default(ulong)),
		 IoWriteBytesPersec = (ulong) (managementObject.Properties["IOWriteBytesPersec"]?.Value ?? default(ulong)),
		 IoWriteOperationsPersec = (ulong) (managementObject.Properties["IOWriteOperationsPersec"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 PageFaultsPersec = (uint) (managementObject.Properties["PageFaultsPersec"]?.Value ?? default(uint)),
		 PageFileBytes = (ulong) (managementObject.Properties["PageFileBytes"]?.Value ?? default(ulong)),
		 PageFileBytesPeak = (ulong) (managementObject.Properties["PageFileBytesPeak"]?.Value ?? default(ulong)),
		 PercentPrivilegedTime = (ulong) (managementObject.Properties["PercentPrivilegedTime"]?.Value ?? default(ulong)),
		 PercentProcessorTime = (ulong) (managementObject.Properties["PercentProcessorTime"]?.Value ?? default(ulong)),
		 PercentUserTime = (ulong) (managementObject.Properties["PercentUserTime"]?.Value ?? default(ulong)),
		 PoolNonpagedBytes = (uint) (managementObject.Properties["PoolNonpagedBytes"]?.Value ?? default(uint)),
		 PoolPagedBytes = (uint) (managementObject.Properties["PoolPagedBytes"]?.Value ?? default(uint)),
		 PriorityBase = (uint) (managementObject.Properties["PriorityBase"]?.Value ?? default(uint)),
		 PrivateBytes = (ulong) (managementObject.Properties["PrivateBytes"]?.Value ?? default(ulong)),
		 ThreadCount = (uint) (managementObject.Properties["ThreadCount"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 VirtualBytes = (ulong) (managementObject.Properties["VirtualBytes"]?.Value ?? default(ulong)),
		 VirtualBytesPeak = (ulong) (managementObject.Properties["VirtualBytesPeak"]?.Value ?? default(ulong)),
		 WorkingSet = (ulong) (managementObject.Properties["WorkingSet"]?.Value ?? default(ulong)),
		 WorkingSetPeak = (ulong) (managementObject.Properties["WorkingSetPeak"]?.Value ?? default(ulong)),
		 WorkingSetPrivate = (ulong) (managementObject.Properties["WorkingSetPrivate"]?.Value ?? default(ulong))
                };
        }
    }
}