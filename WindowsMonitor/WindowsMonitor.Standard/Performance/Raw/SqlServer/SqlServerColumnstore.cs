using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.SqlServer
{
    /// <summary>
    /// </summary>
    public sealed class SqlServerColumnstore
    {
		public string Caption { get; private set; }
		public ulong DeltaRowgroupsClosed { get; private set; }
		public ulong DeltaRowgroupsCompressed { get; private set; }
		public ulong DeltaRowgroupsCreated { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public ulong SegmentCacheHitRatio { get; private set; }
		public ulong SegmentCacheHitRatioBase { get; private set; }
		public ulong SegmentReadsPerSec { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public ulong TotalDeleteBuffersMigrated { get; private set; }
		public ulong TotalMergePolicyEvaluations { get; private set; }
		public ulong TotalRowgroupsCompressed { get; private set; }
		public ulong TotalRowgroupsFitForMerge { get; private set; }
		public ulong TotalRowgroupsMergeCompressed { get; private set; }
		public ulong TotalSourceRowgroupsMerged { get; private set; }

        public static IEnumerable<SqlServerColumnstore> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SqlServerColumnstore> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SqlServerColumnstore> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_MSSQLSERVER_SQLServerColumnstore");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SqlServerColumnstore
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 DeltaRowgroupsClosed = (ulong) (managementObject.Properties["DeltaRowgroupsClosed"]?.Value ?? default(ulong)),
		 DeltaRowgroupsCompressed = (ulong) (managementObject.Properties["DeltaRowgroupsCompressed"]?.Value ?? default(ulong)),
		 DeltaRowgroupsCreated = (ulong) (managementObject.Properties["DeltaRowgroupsCreated"]?.Value ?? default(ulong)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 SegmentCacheHitRatio = (ulong) (managementObject.Properties["SegmentCacheHitRatio"]?.Value ?? default(ulong)),
		 SegmentCacheHitRatioBase = (ulong) (managementObject.Properties["SegmentCacheHitRatio_Base"]?.Value ?? default(ulong)),
		 SegmentReadsPerSec = (ulong) (managementObject.Properties["SegmentReadsPerSec"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 TotalDeleteBuffersMigrated = (ulong) (managementObject.Properties["TotalDeleteBuffersMigrated"]?.Value ?? default(ulong)),
		 TotalMergePolicyEvaluations = (ulong) (managementObject.Properties["TotalMergePolicyEvaluations"]?.Value ?? default(ulong)),
		 TotalRowgroupsCompressed = (ulong) (managementObject.Properties["TotalRowgroupsCompressed"]?.Value ?? default(ulong)),
		 TotalRowgroupsFitForMerge = (ulong) (managementObject.Properties["TotalRowgroupsFitForMerge"]?.Value ?? default(ulong)),
		 TotalRowgroupsMergeCompressed = (ulong) (managementObject.Properties["TotalRowgroupsMergeCompressed"]?.Value ?? default(ulong)),
		 TotalSourceRowgroupsMerged = (ulong) (managementObject.Properties["TotalSourceRowgroupsMerged"]?.Value ?? default(ulong))
                };
        }
    }
}