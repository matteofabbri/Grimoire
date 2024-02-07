using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted.HyperV
{
    /// <summary>
    /// </summary>
    public sealed class HyperVHypervisorLogicalProcessor
    {
		public ulong C1TransitionsPersec { get; private set; }
		public ulong C2TransitionsPersec { get; private set; }
		public ulong C3TransitionsPersec { get; private set; }
		public string Caption { get; private set; }
		public ulong ContextSwitchesPersec { get; private set; }
		public string Description { get; private set; }
		public ulong Frequency { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public ulong HardwareInterruptsPersec { get; private set; }
		public ulong InterProcessorInterruptsPersec { get; private set; }
		public ulong InterProcessorInterruptsSentPersec { get; private set; }
		public ulong MonitorTransitionCost { get; private set; }
		public string Name { get; private set; }
		public ulong ParkingStatus { get; private set; }
		public ulong PercentC1Time { get; private set; }
		public ulong PercentC2Time { get; private set; }
		public ulong PercentC3Time { get; private set; }
		public ulong PercentGuestRunTime { get; private set; }
		public ulong PercentHypervisorRunTime { get; private set; }
		public ulong PercentIdleTime { get; private set; }
		public ulong PercentofMaxFrequency { get; private set; }
		public ulong PercentTotalRunTime { get; private set; }
		public ulong ProcessorStateFlags { get; private set; }
		public ulong RootVpIndex { get; private set; }
		public ulong SchedulerInterruptsPersec { get; private set; }
		public ulong TimerInterruptsPersec { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public ulong TotalInterruptsPersec { get; private set; }

        public static IEnumerable<HyperVHypervisorLogicalProcessor> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HyperVHypervisorLogicalProcessor> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HyperVHypervisorLogicalProcessor> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_HvStats_HyperVHypervisorLogicalProcessor");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HyperVHypervisorLogicalProcessor
                {
                     C1TransitionsPersec = (ulong) (managementObject.Properties["C1TransitionsPersec"]?.Value ?? default(ulong)),
		 C2TransitionsPersec = (ulong) (managementObject.Properties["C2TransitionsPersec"]?.Value ?? default(ulong)),
		 C3TransitionsPersec = (ulong) (managementObject.Properties["C3TransitionsPersec"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 ContextSwitchesPersec = (ulong) (managementObject.Properties["ContextSwitchesPersec"]?.Value ?? default(ulong)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 Frequency = (ulong) (managementObject.Properties["Frequency"]?.Value ?? default(ulong)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 HardwareInterruptsPersec = (ulong) (managementObject.Properties["HardwareInterruptsPersec"]?.Value ?? default(ulong)),
		 InterProcessorInterruptsPersec = (ulong) (managementObject.Properties["InterProcessorInterruptsPersec"]?.Value ?? default(ulong)),
		 InterProcessorInterruptsSentPersec = (ulong) (managementObject.Properties["InterProcessorInterruptsSentPersec"]?.Value ?? default(ulong)),
		 MonitorTransitionCost = (ulong) (managementObject.Properties["MonitorTransitionCost"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 ParkingStatus = (ulong) (managementObject.Properties["ParkingStatus"]?.Value ?? default(ulong)),
		 PercentC1Time = (ulong) (managementObject.Properties["PercentC1Time"]?.Value ?? default(ulong)),
		 PercentC2Time = (ulong) (managementObject.Properties["PercentC2Time"]?.Value ?? default(ulong)),
		 PercentC3Time = (ulong) (managementObject.Properties["PercentC3Time"]?.Value ?? default(ulong)),
		 PercentGuestRunTime = (ulong) (managementObject.Properties["PercentGuestRunTime"]?.Value ?? default(ulong)),
		 PercentHypervisorRunTime = (ulong) (managementObject.Properties["PercentHypervisorRunTime"]?.Value ?? default(ulong)),
		 PercentIdleTime = (ulong) (managementObject.Properties["PercentIdleTime"]?.Value ?? default(ulong)),
		 PercentofMaxFrequency = (ulong) (managementObject.Properties["PercentofMaxFrequency"]?.Value ?? default(ulong)),
		 PercentTotalRunTime = (ulong) (managementObject.Properties["PercentTotalRunTime"]?.Value ?? default(ulong)),
		 ProcessorStateFlags = (ulong) (managementObject.Properties["ProcessorStateFlags"]?.Value ?? default(ulong)),
		 RootVpIndex = (ulong) (managementObject.Properties["RootVpIndex"]?.Value ?? default(ulong)),
		 SchedulerInterruptsPersec = (ulong) (managementObject.Properties["SchedulerInterruptsPersec"]?.Value ?? default(ulong)),
		 TimerInterruptsPersec = (ulong) (managementObject.Properties["TimerInterruptsPersec"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 TotalInterruptsPersec = (ulong) (managementObject.Properties["TotalInterruptsPersec"]?.Value ?? default(ulong))
                };
        }
    }
}