using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.Asp
{
    /// <summary>
    /// </summary>
    public sealed class ApppoolCountersProviderApppoolwas
    {
		public string Caption { get; private set; }
		public uint CurrentApplicationPoolState { get; private set; }
		public ulong CurrentApplicationPoolUptime { get; private set; }
		public uint CurrentWorkerProcesses { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public uint MaximumWorkerProcesses { get; private set; }
		public string Name { get; private set; }
		public uint RecentWorkerProcessFailures { get; private set; }
		public ulong TimeSinceLastWorkerProcessFailure { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public uint TotalApplicationPoolRecycles { get; private set; }
		public ulong TotalApplicationPoolUptime { get; private set; }
		public uint TotalWorkerProcessesCreated { get; private set; }
		public uint TotalWorkerProcessFailures { get; private set; }
		public uint TotalWorkerProcessPingFailures { get; private set; }
		public uint TotalWorkerProcessShutdownFailures { get; private set; }
		public uint TotalWorkerProcessStartupFailures { get; private set; }

        public static IEnumerable<ApppoolCountersProviderApppoolwas> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ApppoolCountersProviderApppoolwas> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ApppoolCountersProviderApppoolwas> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_APPPOOLCountersProvider_APPPOOLWAS");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ApppoolCountersProviderApppoolwas
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CurrentApplicationPoolState = (uint) (managementObject.Properties["CurrentApplicationPoolState"]?.Value ?? default(uint)),
		 CurrentApplicationPoolUptime = (ulong) (managementObject.Properties["CurrentApplicationPoolUptime"]?.Value ?? default(ulong)),
		 CurrentWorkerProcesses = (uint) (managementObject.Properties["CurrentWorkerProcesses"]?.Value ?? default(uint)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 MaximumWorkerProcesses = (uint) (managementObject.Properties["MaximumWorkerProcesses"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 RecentWorkerProcessFailures = (uint) (managementObject.Properties["RecentWorkerProcessFailures"]?.Value ?? default(uint)),
		 TimeSinceLastWorkerProcessFailure = (ulong) (managementObject.Properties["TimeSinceLastWorkerProcessFailure"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 TotalApplicationPoolRecycles = (uint) (managementObject.Properties["TotalApplicationPoolRecycles"]?.Value ?? default(uint)),
		 TotalApplicationPoolUptime = (ulong) (managementObject.Properties["TotalApplicationPoolUptime"]?.Value ?? default(ulong)),
		 TotalWorkerProcessesCreated = (uint) (managementObject.Properties["TotalWorkerProcessesCreated"]?.Value ?? default(uint)),
		 TotalWorkerProcessFailures = (uint) (managementObject.Properties["TotalWorkerProcessFailures"]?.Value ?? default(uint)),
		 TotalWorkerProcessPingFailures = (uint) (managementObject.Properties["TotalWorkerProcessPingFailures"]?.Value ?? default(uint)),
		 TotalWorkerProcessShutdownFailures = (uint) (managementObject.Properties["TotalWorkerProcessShutdownFailures"]?.Value ?? default(uint)),
		 TotalWorkerProcessStartupFailures = (uint) (managementObject.Properties["TotalWorkerProcessStartupFailures"]?.Value ?? default(uint))
                };
        }
    }
}