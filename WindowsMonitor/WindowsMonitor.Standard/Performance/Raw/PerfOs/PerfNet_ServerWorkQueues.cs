using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.PerfOs
{
    /// <summary>
    /// </summary>
    public sealed class PerfNetServerWorkQueues
    {
		public uint ActiveThreads { get; private set; }
		public uint AvailableThreads { get; private set; }
		public uint AvailableWorkItems { get; private set; }
		public uint BorrowedWorkItems { get; private set; }
		public ulong BytesReceivedPersec { get; private set; }
		public ulong BytesSentPersec { get; private set; }
		public ulong BytesTransferredPersec { get; private set; }
		public string Caption { get; private set; }
		public uint ContextBlocksQueuedPersec { get; private set; }
		public uint CurrentClients { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public uint QueueLength { get; private set; }
		public ulong ReadBytesPersec { get; private set; }
		public ulong ReadOperationsPersec { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public ulong TotalBytesPersec { get; private set; }
		public ulong TotalOperationsPersec { get; private set; }
		public uint WorkItemShortages { get; private set; }
		public ulong WriteBytesPersec { get; private set; }
		public ulong WriteOperationsPersec { get; private set; }

        public static IEnumerable<PerfNetServerWorkQueues> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<PerfNetServerWorkQueues> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<PerfNetServerWorkQueues> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_PerfNet_ServerWorkQueues");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new PerfNetServerWorkQueues
                {
                     ActiveThreads = (uint) (managementObject.Properties["ActiveThreads"]?.Value ?? default(uint)),
		 AvailableThreads = (uint) (managementObject.Properties["AvailableThreads"]?.Value ?? default(uint)),
		 AvailableWorkItems = (uint) (managementObject.Properties["AvailableWorkItems"]?.Value ?? default(uint)),
		 BorrowedWorkItems = (uint) (managementObject.Properties["BorrowedWorkItems"]?.Value ?? default(uint)),
		 BytesReceivedPersec = (ulong) (managementObject.Properties["BytesReceivedPersec"]?.Value ?? default(ulong)),
		 BytesSentPersec = (ulong) (managementObject.Properties["BytesSentPersec"]?.Value ?? default(ulong)),
		 BytesTransferredPersec = (ulong) (managementObject.Properties["BytesTransferredPersec"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 ContextBlocksQueuedPersec = (uint) (managementObject.Properties["ContextBlocksQueuedPersec"]?.Value ?? default(uint)),
		 CurrentClients = (uint) (managementObject.Properties["CurrentClients"]?.Value ?? default(uint)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 QueueLength = (uint) (managementObject.Properties["QueueLength"]?.Value ?? default(uint)),
		 ReadBytesPersec = (ulong) (managementObject.Properties["ReadBytesPersec"]?.Value ?? default(ulong)),
		 ReadOperationsPersec = (ulong) (managementObject.Properties["ReadOperationsPersec"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 TotalBytesPersec = (ulong) (managementObject.Properties["TotalBytesPersec"]?.Value ?? default(ulong)),
		 TotalOperationsPersec = (ulong) (managementObject.Properties["TotalOperationsPersec"]?.Value ?? default(ulong)),
		 WorkItemShortages = (uint) (managementObject.Properties["WorkItemShortages"]?.Value ?? default(uint)),
		 WriteBytesPersec = (ulong) (managementObject.Properties["WriteBytesPersec"]?.Value ?? default(ulong)),
		 WriteOperationsPersec = (ulong) (managementObject.Properties["WriteOperationsPersec"]?.Value ?? default(ulong))
                };
        }
    }
}