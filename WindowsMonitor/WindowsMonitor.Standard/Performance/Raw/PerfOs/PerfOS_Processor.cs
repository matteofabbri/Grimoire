using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.PerfOs
{
    /// <summary>
    /// </summary>
    public sealed class PerfOsProcessor
    {
		public ulong C1TransitionsPersec { get; private set; }
		public ulong C2TransitionsPersec { get; private set; }
		public ulong C3TransitionsPersec { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public uint DpcRate { get; private set; }
		public uint DpCsQueuedPersec { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public uint InterruptsPersec { get; private set; }
		public string Name { get; private set; }
		public ulong PercentC1Time { get; private set; }
		public ulong PercentC2Time { get; private set; }
		public ulong PercentC3Time { get; private set; }
		public ulong PercentDpcTime { get; private set; }
		public ulong PercentIdleTime { get; private set; }
		public ulong PercentInterruptTime { get; private set; }
		public ulong PercentPrivilegedTime { get; private set; }
		public ulong PercentProcessorTime { get; private set; }
		public ulong PercentUserTime { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<PerfOsProcessor> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<PerfOsProcessor> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<PerfOsProcessor> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_PerfOS_Processor");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new PerfOsProcessor
                {
                     C1TransitionsPersec = (ulong) (managementObject.Properties["C1TransitionsPersec"]?.Value ?? default(ulong)),
		 C2TransitionsPersec = (ulong) (managementObject.Properties["C2TransitionsPersec"]?.Value ?? default(ulong)),
		 C3TransitionsPersec = (ulong) (managementObject.Properties["C3TransitionsPersec"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DpcRate = (uint) (managementObject.Properties["DPCRate"]?.Value ?? default(uint)),
		 DpCsQueuedPersec = (uint) (managementObject.Properties["DPCsQueuedPersec"]?.Value ?? default(uint)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 InterruptsPersec = (uint) (managementObject.Properties["InterruptsPersec"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 PercentC1Time = (ulong) (managementObject.Properties["PercentC1Time"]?.Value ?? default(ulong)),
		 PercentC2Time = (ulong) (managementObject.Properties["PercentC2Time"]?.Value ?? default(ulong)),
		 PercentC3Time = (ulong) (managementObject.Properties["PercentC3Time"]?.Value ?? default(ulong)),
		 PercentDpcTime = (ulong) (managementObject.Properties["PercentDPCTime"]?.Value ?? default(ulong)),
		 PercentIdleTime = (ulong) (managementObject.Properties["PercentIdleTime"]?.Value ?? default(ulong)),
		 PercentInterruptTime = (ulong) (managementObject.Properties["PercentInterruptTime"]?.Value ?? default(ulong)),
		 PercentPrivilegedTime = (ulong) (managementObject.Properties["PercentPrivilegedTime"]?.Value ?? default(ulong)),
		 PercentProcessorTime = (ulong) (managementObject.Properties["PercentProcessorTime"]?.Value ?? default(ulong)),
		 PercentUserTime = (ulong) (managementObject.Properties["PercentUserTime"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}