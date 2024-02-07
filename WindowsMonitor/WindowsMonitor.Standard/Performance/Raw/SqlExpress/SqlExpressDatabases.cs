using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.SqlExpress
{
    /// <summary>
    /// </summary>
    public sealed class SqlExpressDatabases
    {
		public ulong ActiveTransactions { get; private set; }
		public ulong BackupPerRestoreThroughputPersec { get; private set; }
		public ulong BulkCopyRowsPersec { get; private set; }
		public ulong BulkCopyThroughputPersec { get; private set; }
		public string Caption { get; private set; }
		public ulong Committableentries { get; private set; }
		public ulong DataFilesSizeKb { get; private set; }
		public ulong DbccLogicalScanBytesPersec { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public ulong GroupCommitTimePersec { get; private set; }
		public ulong LogBytesFlushedPersec { get; private set; }
		public ulong LogCacheHitRatio { get; private set; }
		public ulong LogCacheHitRatioBase { get; private set; }
		public ulong LogCacheReadsPersec { get; private set; }
		public ulong LogFilesSizeKb { get; private set; }
		public ulong LogFilesUsedSizeKb { get; private set; }
		public ulong LogFlushesPersec { get; private set; }
		public ulong LogFlushWaitsPersec { get; private set; }
		public ulong LogFlushWaitTime { get; private set; }
		public ulong LogFlushWriteTimems { get; private set; }
		public ulong LogGrowths { get; private set; }
		public ulong LogPoolCacheMissesPersec { get; private set; }
		public ulong LogPoolDiskReadsPersec { get; private set; }
		public ulong LogPoolRequestsPersec { get; private set; }
		public ulong LogShrinks { get; private set; }
		public ulong LogTruncations { get; private set; }
		public string Name { get; private set; }
		public ulong PercentLogUsed { get; private set; }
		public ulong ReplPendingXacts { get; private set; }
		public ulong ReplTransRate { get; private set; }
		public ulong ShrinkDataMovementBytesPersec { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public ulong TrackedtransactionsPersec { get; private set; }
		public ulong TransactionsPersec { get; private set; }
		public ulong WriteTransactionsPersec { get; private set; }
		public ulong XtpMemoryUsedKb { get; private set; }

        public static IEnumerable<SqlExpressDatabases> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SqlExpressDatabases> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SqlExpressDatabases> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_MSSQLSQLEXPRESS_MSSQLSQLEXPRESSDatabases");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SqlExpressDatabases
                {
                     ActiveTransactions = (ulong) (managementObject.Properties["ActiveTransactions"]?.Value ?? default(ulong)),
		 BackupPerRestoreThroughputPersec = (ulong) (managementObject.Properties["BackupPerRestoreThroughputPersec"]?.Value ?? default(ulong)),
		 BulkCopyRowsPersec = (ulong) (managementObject.Properties["BulkCopyRowsPersec"]?.Value ?? default(ulong)),
		 BulkCopyThroughputPersec = (ulong) (managementObject.Properties["BulkCopyThroughputPersec"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Committableentries = (ulong) (managementObject.Properties["Committableentries"]?.Value ?? default(ulong)),
		 DataFilesSizeKb = (ulong) (managementObject.Properties["DataFilesSizeKB"]?.Value ?? default(ulong)),
		 DbccLogicalScanBytesPersec = (ulong) (managementObject.Properties["DBCCLogicalScanBytesPersec"]?.Value ?? default(ulong)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 GroupCommitTimePersec = (ulong) (managementObject.Properties["GroupCommitTimePersec"]?.Value ?? default(ulong)),
		 LogBytesFlushedPersec = (ulong) (managementObject.Properties["LogBytesFlushedPersec"]?.Value ?? default(ulong)),
		 LogCacheHitRatio = (ulong) (managementObject.Properties["LogCacheHitRatio"]?.Value ?? default(ulong)),
		 LogCacheHitRatioBase = (ulong) (managementObject.Properties["LogCacheHitRatio_Base"]?.Value ?? default(ulong)),
		 LogCacheReadsPersec = (ulong) (managementObject.Properties["LogCacheReadsPersec"]?.Value ?? default(ulong)),
		 LogFilesSizeKb = (ulong) (managementObject.Properties["LogFilesSizeKB"]?.Value ?? default(ulong)),
		 LogFilesUsedSizeKb = (ulong) (managementObject.Properties["LogFilesUsedSizeKB"]?.Value ?? default(ulong)),
		 LogFlushesPersec = (ulong) (managementObject.Properties["LogFlushesPersec"]?.Value ?? default(ulong)),
		 LogFlushWaitsPersec = (ulong) (managementObject.Properties["LogFlushWaitsPersec"]?.Value ?? default(ulong)),
		 LogFlushWaitTime = (ulong) (managementObject.Properties["LogFlushWaitTime"]?.Value ?? default(ulong)),
		 LogFlushWriteTimems = (ulong) (managementObject.Properties["LogFlushWriteTimems"]?.Value ?? default(ulong)),
		 LogGrowths = (ulong) (managementObject.Properties["LogGrowths"]?.Value ?? default(ulong)),
		 LogPoolCacheMissesPersec = (ulong) (managementObject.Properties["LogPoolCacheMissesPersec"]?.Value ?? default(ulong)),
		 LogPoolDiskReadsPersec = (ulong) (managementObject.Properties["LogPoolDiskReadsPersec"]?.Value ?? default(ulong)),
		 LogPoolRequestsPersec = (ulong) (managementObject.Properties["LogPoolRequestsPersec"]?.Value ?? default(ulong)),
		 LogShrinks = (ulong) (managementObject.Properties["LogShrinks"]?.Value ?? default(ulong)),
		 LogTruncations = (ulong) (managementObject.Properties["LogTruncations"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 PercentLogUsed = (ulong) (managementObject.Properties["PercentLogUsed"]?.Value ?? default(ulong)),
		 ReplPendingXacts = (ulong) (managementObject.Properties["ReplPendingXacts"]?.Value ?? default(ulong)),
		 ReplTransRate = (ulong) (managementObject.Properties["ReplTransRate"]?.Value ?? default(ulong)),
		 ShrinkDataMovementBytesPersec = (ulong) (managementObject.Properties["ShrinkDataMovementBytesPersec"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 TrackedtransactionsPersec = (ulong) (managementObject.Properties["TrackedtransactionsPersec"]?.Value ?? default(ulong)),
		 TransactionsPersec = (ulong) (managementObject.Properties["TransactionsPersec"]?.Value ?? default(ulong)),
		 WriteTransactionsPersec = (ulong) (managementObject.Properties["WriteTransactionsPersec"]?.Value ?? default(ulong)),
		 XtpMemoryUsedKb = (ulong) (managementObject.Properties["XTPMemoryUsedKB"]?.Value ?? default(ulong))
                };
        }
    }
}