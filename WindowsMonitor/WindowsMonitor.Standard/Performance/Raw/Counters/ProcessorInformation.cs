using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.Counters
{
    /// <summary>
    /// </summary>
    public sealed class ProcessorInformation
    {
		public ulong AverageIdleTime { get; private set; }
		public ulong AverageIdleTimeBase { get; private set; }
		public ulong C1TransitionsPersec { get; private set; }
		public ulong C2TransitionsPersec { get; private set; }
		public ulong C3TransitionsPersec { get; private set; }
		public string Caption { get; private set; }
		public uint ClockInterruptsPersec { get; private set; }
		public string Description { get; private set; }
		public uint DpcRate { get; private set; }
		public uint DpCsQueuedPersec { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public ulong IdleBreakEventsPersec { get; private set; }
		public uint InterruptsPersec { get; private set; }
		public string Name { get; private set; }
		public uint ParkingStatus { get; private set; }
		public ulong PercentC1Time { get; private set; }
		public ulong PercentC2Time { get; private set; }
		public ulong PercentC3Time { get; private set; }
		public ulong PercentDpcTime { get; private set; }
		public ulong PercentIdleTime { get; private set; }
		public ulong PercentInterruptTime { get; private set; }
		public uint PercentofMaximumFrequency { get; private set; }
		public uint PercentPerformanceLimit { get; private set; }
		public ulong PercentPriorityTime { get; private set; }
		public ulong PercentPrivilegedTime { get; private set; }
		public ulong PercentPrivilegedUtility { get; private set; }
		public uint PercentPrivilegedUtilityBase { get; private set; }
		public ulong PercentProcessorPerformance { get; private set; }
		public uint PercentProcessorPerformanceBase { get; private set; }
		public ulong PercentProcessorTime { get; private set; }
		public ulong PercentProcessorUtility { get; private set; }
		public uint PercentProcessorUtilityBase { get; private set; }
		public ulong PercentUserTime { get; private set; }
		public uint PerformanceLimitFlags { get; private set; }
		public uint ProcessorFrequency { get; private set; }
		public uint ProcessorStateFlags { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<ProcessorInformation> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ProcessorInformation> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ProcessorInformation> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_Counters_ProcessorInformation");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ProcessorInformation
                {
                     AverageIdleTime = (ulong) (managementObject.Properties["AverageIdleTime"]?.Value ?? default(ulong)),
		 AverageIdleTimeBase = (ulong) (managementObject.Properties["AverageIdleTime_Base"]?.Value ?? default(ulong)),
		 C1TransitionsPersec = (ulong) (managementObject.Properties["C1TransitionsPersec"]?.Value ?? default(ulong)),
		 C2TransitionsPersec = (ulong) (managementObject.Properties["C2TransitionsPersec"]?.Value ?? default(ulong)),
		 C3TransitionsPersec = (ulong) (managementObject.Properties["C3TransitionsPersec"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 ClockInterruptsPersec = (uint) (managementObject.Properties["ClockInterruptsPersec"]?.Value ?? default(uint)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DpcRate = (uint) (managementObject.Properties["DPCRate"]?.Value ?? default(uint)),
		 DpCsQueuedPersec = (uint) (managementObject.Properties["DPCsQueuedPersec"]?.Value ?? default(uint)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 IdleBreakEventsPersec = (ulong) (managementObject.Properties["IdleBreakEventsPersec"]?.Value ?? default(ulong)),
		 InterruptsPersec = (uint) (managementObject.Properties["InterruptsPersec"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 ParkingStatus = (uint) (managementObject.Properties["ParkingStatus"]?.Value ?? default(uint)),
		 PercentC1Time = (ulong) (managementObject.Properties["PercentC1Time"]?.Value ?? default(ulong)),
		 PercentC2Time = (ulong) (managementObject.Properties["PercentC2Time"]?.Value ?? default(ulong)),
		 PercentC3Time = (ulong) (managementObject.Properties["PercentC3Time"]?.Value ?? default(ulong)),
		 PercentDpcTime = (ulong) (managementObject.Properties["PercentDPCTime"]?.Value ?? default(ulong)),
		 PercentIdleTime = (ulong) (managementObject.Properties["PercentIdleTime"]?.Value ?? default(ulong)),
		 PercentInterruptTime = (ulong) (managementObject.Properties["PercentInterruptTime"]?.Value ?? default(ulong)),
		 PercentofMaximumFrequency = (uint) (managementObject.Properties["PercentofMaximumFrequency"]?.Value ?? default(uint)),
		 PercentPerformanceLimit = (uint) (managementObject.Properties["PercentPerformanceLimit"]?.Value ?? default(uint)),
		 PercentPriorityTime = (ulong) (managementObject.Properties["PercentPriorityTime"]?.Value ?? default(ulong)),
		 PercentPrivilegedTime = (ulong) (managementObject.Properties["PercentPrivilegedTime"]?.Value ?? default(ulong)),
		 PercentPrivilegedUtility = (ulong) (managementObject.Properties["PercentPrivilegedUtility"]?.Value ?? default(ulong)),
		 PercentPrivilegedUtilityBase = (uint) (managementObject.Properties["PercentPrivilegedUtility_Base"]?.Value ?? default(uint)),
		 PercentProcessorPerformance = (ulong) (managementObject.Properties["PercentProcessorPerformance"]?.Value ?? default(ulong)),
		 PercentProcessorPerformanceBase = (uint) (managementObject.Properties["PercentProcessorPerformance_Base"]?.Value ?? default(uint)),
		 PercentProcessorTime = (ulong) (managementObject.Properties["PercentProcessorTime"]?.Value ?? default(ulong)),
		 PercentProcessorUtility = (ulong) (managementObject.Properties["PercentProcessorUtility"]?.Value ?? default(ulong)),
		 PercentProcessorUtilityBase = (uint) (managementObject.Properties["PercentProcessorUtility_Base"]?.Value ?? default(uint)),
		 PercentUserTime = (ulong) (managementObject.Properties["PercentUserTime"]?.Value ?? default(ulong)),
		 PerformanceLimitFlags = (uint) (managementObject.Properties["PerformanceLimitFlags"]?.Value ?? default(uint)),
		 ProcessorFrequency = (uint) (managementObject.Properties["ProcessorFrequency"]?.Value ?? default(uint)),
		 ProcessorStateFlags = (uint) (managementObject.Properties["ProcessorStateFlags"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}