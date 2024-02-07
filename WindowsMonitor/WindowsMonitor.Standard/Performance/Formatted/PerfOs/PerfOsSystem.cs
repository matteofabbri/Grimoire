using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted.PerfOs
{
    /// <summary>
    /// </summary>
    public sealed class PerfOsSystem
    {
		public uint AlignmentFixupsPersec { get; private set; }
		public string Caption { get; private set; }
		public uint ContextSwitchesPersec { get; private set; }
		public string Description { get; private set; }
		public uint ExceptionDispatchesPersec { get; private set; }
		public ulong FileControlBytesPersec { get; private set; }
		public uint FileControlOperationsPersec { get; private set; }
		public uint FileDataOperationsPersec { get; private set; }
		public ulong FileReadBytesPersec { get; private set; }
		public uint FileReadOperationsPersec { get; private set; }
		public ulong FileWriteBytesPersec { get; private set; }
		public uint FileWriteOperationsPersec { get; private set; }
		public uint FloatingEmulationsPersec { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public uint PercentRegistryQuotaInUse { get; private set; }
		public uint Processes { get; private set; }
		public uint ProcessorQueueLength { get; private set; }
		public uint SystemCallsPersec { get; private set; }
		public ulong SystemUpTime { get; private set; }
		public uint Threads { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<PerfOsSystem> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<PerfOsSystem> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<PerfOsSystem> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_PerfOS_System");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new PerfOsSystem
                {
                     AlignmentFixupsPersec = (uint) (managementObject.Properties["AlignmentFixupsPersec"]?.Value ?? default(uint)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 ContextSwitchesPersec = (uint) (managementObject.Properties["ContextSwitchesPersec"]?.Value ?? default(uint)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 ExceptionDispatchesPersec = (uint) (managementObject.Properties["ExceptionDispatchesPersec"]?.Value ?? default(uint)),
		 FileControlBytesPersec = (ulong) (managementObject.Properties["FileControlBytesPersec"]?.Value ?? default(ulong)),
		 FileControlOperationsPersec = (uint) (managementObject.Properties["FileControlOperationsPersec"]?.Value ?? default(uint)),
		 FileDataOperationsPersec = (uint) (managementObject.Properties["FileDataOperationsPersec"]?.Value ?? default(uint)),
		 FileReadBytesPersec = (ulong) (managementObject.Properties["FileReadBytesPersec"]?.Value ?? default(ulong)),
		 FileReadOperationsPersec = (uint) (managementObject.Properties["FileReadOperationsPersec"]?.Value ?? default(uint)),
		 FileWriteBytesPersec = (ulong) (managementObject.Properties["FileWriteBytesPersec"]?.Value ?? default(ulong)),
		 FileWriteOperationsPersec = (uint) (managementObject.Properties["FileWriteOperationsPersec"]?.Value ?? default(uint)),
		 FloatingEmulationsPersec = (uint) (managementObject.Properties["FloatingEmulationsPersec"]?.Value ?? default(uint)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 PercentRegistryQuotaInUse = (uint) (managementObject.Properties["PercentRegistryQuotaInUse"]?.Value ?? default(uint)),
		 Processes = (uint) (managementObject.Properties["Processes"]?.Value ?? default(uint)),
		 ProcessorQueueLength = (uint) (managementObject.Properties["ProcessorQueueLength"]?.Value ?? default(uint)),
		 SystemCallsPersec = (uint) (managementObject.Properties["SystemCallsPersec"]?.Value ?? default(uint)),
		 SystemUpTime = (ulong) (managementObject.Properties["SystemUpTime"]?.Value ?? default(ulong)),
		 Threads = (uint) (managementObject.Properties["Threads"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}