using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.SqlServer
{
    /// <summary>
    /// </summary>
    public sealed class SqlServerTransactions
    {
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong FreeSpaceintempdbKb { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public ulong LongestTransactionRunningTime { get; private set; }
		public string Name { get; private set; }
		public ulong NonSnapshotVersionTransactions { get; private set; }
		public ulong SnapshotTransactions { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public ulong Transactions { get; private set; }
		public ulong Updateconflictratio { get; private set; }
		public uint UpdateconflictratioBase { get; private set; }
		public ulong UpdateSnapshotTransactions { get; private set; }
		public ulong VersionCleanuprateKbPers { get; private set; }
		public ulong VersionGenerationrateKbPers { get; private set; }
		public ulong VersionStoreSizeKb { get; private set; }
		public ulong VersionStoreunitcount { get; private set; }
		public ulong VersionStoreunitcreation { get; private set; }
		public ulong VersionStoreunittruncation { get; private set; }

        public static IEnumerable<SqlServerTransactions> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SqlServerTransactions> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SqlServerTransactions> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_MSSQLSERVER_SQLServerTransactions");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SqlServerTransactions
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FreeSpaceintempdbKb = (ulong) (managementObject.Properties["FreeSpaceintempdbKB"]?.Value ?? default(ulong)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 LongestTransactionRunningTime = (ulong) (managementObject.Properties["LongestTransactionRunningTime"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 NonSnapshotVersionTransactions = (ulong) (managementObject.Properties["NonSnapshotVersionTransactions"]?.Value ?? default(ulong)),
		 SnapshotTransactions = (ulong) (managementObject.Properties["SnapshotTransactions"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 Transactions = (ulong) (managementObject.Properties["Transactions"]?.Value ?? default(ulong)),
		 Updateconflictratio = (ulong) (managementObject.Properties["Updateconflictratio"]?.Value ?? default(ulong)),
		 UpdateconflictratioBase = (uint) (managementObject.Properties["Updateconflictratio_Base"]?.Value ?? default(uint)),
		 UpdateSnapshotTransactions = (ulong) (managementObject.Properties["UpdateSnapshotTransactions"]?.Value ?? default(ulong)),
		 VersionCleanuprateKbPers = (ulong) (managementObject.Properties["VersionCleanuprateKBPers"]?.Value ?? default(ulong)),
		 VersionGenerationrateKbPers = (ulong) (managementObject.Properties["VersionGenerationrateKBPers"]?.Value ?? default(ulong)),
		 VersionStoreSizeKb = (ulong) (managementObject.Properties["VersionStoreSizeKB"]?.Value ?? default(ulong)),
		 VersionStoreunitcount = (ulong) (managementObject.Properties["VersionStoreunitcount"]?.Value ?? default(ulong)),
		 VersionStoreunitcreation = (ulong) (managementObject.Properties["VersionStoreunitcreation"]?.Value ?? default(ulong)),
		 VersionStoreunittruncation = (ulong) (managementObject.Properties["VersionStoreunittruncation"]?.Value ?? default(ulong))
                };
        }
    }
}