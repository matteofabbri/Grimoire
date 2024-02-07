using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.Xtp
{
    /// <summary>
    /// </summary>
    public sealed class XtpDatabaseEngineXtpStorage
    {
		public string Caption { get; private set; }
		public ulong CheckpointsClosed { get; private set; }
		public ulong CheckpointsCompleted { get; private set; }
		public ulong CoreMergesCompleted { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public ulong MergePolicyEvaluations { get; private set; }
		public ulong MergeRequestsOutstanding { get; private set; }
		public ulong MergesAbandoned { get; private set; }
		public ulong MergesInstalled { get; private set; }
		public string Name { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public ulong TotalFilesMerged { get; private set; }

        public static IEnumerable<XtpDatabaseEngineXtpStorage> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<XtpDatabaseEngineXtpStorage> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<XtpDatabaseEngineXtpStorage> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_XTPDatabaseEngine_XTPStorage");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new XtpDatabaseEngineXtpStorage
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CheckpointsClosed = (ulong) (managementObject.Properties["CheckpointsClosed"]?.Value ?? default(ulong)),
		 CheckpointsCompleted = (ulong) (managementObject.Properties["CheckpointsCompleted"]?.Value ?? default(ulong)),
		 CoreMergesCompleted = (ulong) (managementObject.Properties["CoreMergesCompleted"]?.Value ?? default(ulong)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 MergePolicyEvaluations = (ulong) (managementObject.Properties["MergePolicyEvaluations"]?.Value ?? default(ulong)),
		 MergeRequestsOutstanding = (ulong) (managementObject.Properties["MergeRequestsOutstanding"]?.Value ?? default(ulong)),
		 MergesAbandoned = (ulong) (managementObject.Properties["MergesAbandoned"]?.Value ?? default(ulong)),
		 MergesInstalled = (ulong) (managementObject.Properties["MergesInstalled"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 TotalFilesMerged = (ulong) (managementObject.Properties["TotalFilesMerged"]?.Value ?? default(ulong))
                };
        }
    }
}