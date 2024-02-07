using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw
{
    /// <summary>
    /// </summary>
    public sealed class WindowsWorkflowFoundation4000
    {
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
		public uint WorkflowsAbortedPersec { get; private set; }
		public uint WorkflowsCompleted { get; private set; }
		public uint WorkflowsCompletedPersec { get; private set; }
		public uint WorkflowsCreated { get; private set; }
		public uint WorkflowsCreatedPersec { get; private set; }
		public uint WorkflowsExecuting { get; private set; }
		public uint WorkflowsIdlePersec { get; private set; }
		public uint WorkflowsInMemory { get; private set; }
		public uint WorkflowsLoaded { get; private set; }
		public uint WorkflowsLoadedPersec { get; private set; }
		public uint WorkflowsPending { get; private set; }
		public uint WorkflowsPersisted { get; private set; }
		public uint WorkflowsPersistedPersec { get; private set; }
		public uint WorkflowsRunnable { get; private set; }
		public uint WorkflowsSuspended { get; private set; }
		public uint WorkflowsSuspendedPersec { get; private set; }
		public uint WorkflowsTerminated { get; private set; }
		public uint WorkflowsTerminatedPersec { get; private set; }
		public uint WorkflowsUnloaded { get; private set; }
		public uint WorkflowsUnloadedPersec { get; private set; }

        public static IEnumerable<WindowsWorkflowFoundation4000> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<WindowsWorkflowFoundation4000> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<WindowsWorkflowFoundation4000> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_WindowsWorkflowFoundation4000_WFSystemWorkflow4000");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new WindowsWorkflowFoundation4000
                {
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
		 WorkflowsAbortedPersec = (uint) (managementObject.Properties["WorkflowsAbortedPersec"]?.Value ?? default(uint)),
		 WorkflowsCompleted = (uint) (managementObject.Properties["WorkflowsCompleted"]?.Value ?? default(uint)),
		 WorkflowsCompletedPersec = (uint) (managementObject.Properties["WorkflowsCompletedPersec"]?.Value ?? default(uint)),
		 WorkflowsCreated = (uint) (managementObject.Properties["WorkflowsCreated"]?.Value ?? default(uint)),
		 WorkflowsCreatedPersec = (uint) (managementObject.Properties["WorkflowsCreatedPersec"]?.Value ?? default(uint)),
		 WorkflowsExecuting = (uint) (managementObject.Properties["WorkflowsExecuting"]?.Value ?? default(uint)),
		 WorkflowsIdlePersec = (uint) (managementObject.Properties["WorkflowsIdlePersec"]?.Value ?? default(uint)),
		 WorkflowsInMemory = (uint) (managementObject.Properties["WorkflowsInMemory"]?.Value ?? default(uint)),
		 WorkflowsLoaded = (uint) (managementObject.Properties["WorkflowsLoaded"]?.Value ?? default(uint)),
		 WorkflowsLoadedPersec = (uint) (managementObject.Properties["WorkflowsLoadedPersec"]?.Value ?? default(uint)),
		 WorkflowsPending = (uint) (managementObject.Properties["WorkflowsPending"]?.Value ?? default(uint)),
		 WorkflowsPersisted = (uint) (managementObject.Properties["WorkflowsPersisted"]?.Value ?? default(uint)),
		 WorkflowsPersistedPersec = (uint) (managementObject.Properties["WorkflowsPersistedPersec"]?.Value ?? default(uint)),
		 WorkflowsRunnable = (uint) (managementObject.Properties["WorkflowsRunnable"]?.Value ?? default(uint)),
		 WorkflowsSuspended = (uint) (managementObject.Properties["WorkflowsSuspended"]?.Value ?? default(uint)),
		 WorkflowsSuspendedPersec = (uint) (managementObject.Properties["WorkflowsSuspendedPersec"]?.Value ?? default(uint)),
		 WorkflowsTerminated = (uint) (managementObject.Properties["WorkflowsTerminated"]?.Value ?? default(uint)),
		 WorkflowsTerminatedPersec = (uint) (managementObject.Properties["WorkflowsTerminatedPersec"]?.Value ?? default(uint)),
		 WorkflowsUnloaded = (uint) (managementObject.Properties["WorkflowsUnloaded"]?.Value ?? default(uint)),
		 WorkflowsUnloadedPersec = (uint) (managementObject.Properties["WorkflowsUnloadedPersec"]?.Value ?? default(uint))
                };
        }
    }
}