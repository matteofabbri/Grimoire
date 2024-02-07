using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted
{
    /// <summary>
    /// </summary>
    public sealed class WorkflowServiceHost4000
    {
		public uint AverageWorkflowLoadTime { get; private set; }
		public uint AverageWorkflowPersistTime { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public uint WorkflowsAborted { get; private set; }
		public uint WorkflowsAbortedPerSecond { get; private set; }
		public uint WorkflowsCompleted { get; private set; }
		public uint WorkflowsCompletedPerSecond { get; private set; }
		public uint WorkflowsCreated { get; private set; }
		public uint WorkflowsCreatedPerSecond { get; private set; }
		public uint WorkflowsExecuting { get; private set; }
		public uint WorkflowsIdlePerSecond { get; private set; }
		public uint WorkflowsInMemory { get; private set; }
		public uint WorkflowsLoaded { get; private set; }
		public uint WorkflowsLoadedPerSecond { get; private set; }
		public uint WorkflowsPersisted { get; private set; }
		public uint WorkflowsPersistedPerSecond { get; private set; }
		public uint WorkflowsSuspended { get; private set; }
		public uint WorkflowsSuspendedPerSecond { get; private set; }
		public uint WorkflowsTerminated { get; private set; }
		public uint WorkflowsTerminatedPerSecond { get; private set; }
		public uint WorkflowsUnloaded { get; private set; }
		public uint WorkflowsUnloadedPerSecond { get; private set; }

        public static IEnumerable<WorkflowServiceHost4000> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<WorkflowServiceHost4000> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<WorkflowServiceHost4000> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_WorkflowServiceHost4000_WorkflowServiceHost4000");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new WorkflowServiceHost4000
                {
                     AverageWorkflowLoadTime = (uint) (managementObject.Properties["AverageWorkflowLoadTime"]?.Value ?? default(uint)),
		 AverageWorkflowPersistTime = (uint) (managementObject.Properties["AverageWorkflowPersistTime"]?.Value ?? default(uint)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 WorkflowsAborted = (uint) (managementObject.Properties["WorkflowsAborted"]?.Value ?? default(uint)),
		 WorkflowsAbortedPerSecond = (uint) (managementObject.Properties["WorkflowsAbortedPerSecond"]?.Value ?? default(uint)),
		 WorkflowsCompleted = (uint) (managementObject.Properties["WorkflowsCompleted"]?.Value ?? default(uint)),
		 WorkflowsCompletedPerSecond = (uint) (managementObject.Properties["WorkflowsCompletedPerSecond"]?.Value ?? default(uint)),
		 WorkflowsCreated = (uint) (managementObject.Properties["WorkflowsCreated"]?.Value ?? default(uint)),
		 WorkflowsCreatedPerSecond = (uint) (managementObject.Properties["WorkflowsCreatedPerSecond"]?.Value ?? default(uint)),
		 WorkflowsExecuting = (uint) (managementObject.Properties["WorkflowsExecuting"]?.Value ?? default(uint)),
		 WorkflowsIdlePerSecond = (uint) (managementObject.Properties["WorkflowsIdlePerSecond"]?.Value ?? default(uint)),
		 WorkflowsInMemory = (uint) (managementObject.Properties["WorkflowsInMemory"]?.Value ?? default(uint)),
		 WorkflowsLoaded = (uint) (managementObject.Properties["WorkflowsLoaded"]?.Value ?? default(uint)),
		 WorkflowsLoadedPerSecond = (uint) (managementObject.Properties["WorkflowsLoadedPerSecond"]?.Value ?? default(uint)),
		 WorkflowsPersisted = (uint) (managementObject.Properties["WorkflowsPersisted"]?.Value ?? default(uint)),
		 WorkflowsPersistedPerSecond = (uint) (managementObject.Properties["WorkflowsPersistedPerSecond"]?.Value ?? default(uint)),
		 WorkflowsSuspended = (uint) (managementObject.Properties["WorkflowsSuspended"]?.Value ?? default(uint)),
		 WorkflowsSuspendedPerSecond = (uint) (managementObject.Properties["WorkflowsSuspendedPerSecond"]?.Value ?? default(uint)),
		 WorkflowsTerminated = (uint) (managementObject.Properties["WorkflowsTerminated"]?.Value ?? default(uint)),
		 WorkflowsTerminatedPerSecond = (uint) (managementObject.Properties["WorkflowsTerminatedPerSecond"]?.Value ?? default(uint)),
		 WorkflowsUnloaded = (uint) (managementObject.Properties["WorkflowsUnloaded"]?.Value ?? default(uint)),
		 WorkflowsUnloadedPerSecond = (uint) (managementObject.Properties["WorkflowsUnloadedPerSecond"]?.Value ?? default(uint))
                };
        }
    }
}