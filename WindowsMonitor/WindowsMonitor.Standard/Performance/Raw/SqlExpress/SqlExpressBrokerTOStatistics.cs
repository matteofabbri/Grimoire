using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.SqlExpress
{
    /// <summary>
    /// </summary>
    public sealed class SqlExpressBrokerToStatistics
    {
		public ulong AvgLengthofBatchedWrites { get; private set; }
		public uint AvgLengthofBatchedWritesBase { get; private set; }
		public ulong AvgTimeBetweenBatchesms { get; private set; }
		public uint AvgTimeBetweenBatchesmsBase { get; private set; }
		public ulong AvgTimetoWriteBatchms { get; private set; }
		public uint AvgTimetoWriteBatchmsBase { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public ulong TransmissionObjGetsPerSec { get; private set; }
		public ulong TransmissionObjSetDirtyPerSec { get; private set; }
		public ulong TransmissionObjWritesPerSec { get; private set; }

        public static IEnumerable<SqlExpressBrokerToStatistics> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SqlExpressBrokerToStatistics> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SqlExpressBrokerToStatistics> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_MSSQLSQLEXPRESS_MSSQLSQLEXPRESSBrokerTOStatistics");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SqlExpressBrokerToStatistics
                {
                     AvgLengthofBatchedWrites = (ulong) (managementObject.Properties["AvgLengthofBatchedWrites"]?.Value ?? default(ulong)),
		 AvgLengthofBatchedWritesBase = (uint) (managementObject.Properties["AvgLengthofBatchedWrites_Base"]?.Value ?? default(uint)),
		 AvgTimeBetweenBatchesms = (ulong) (managementObject.Properties["AvgTimeBetweenBatchesms"]?.Value ?? default(ulong)),
		 AvgTimeBetweenBatchesmsBase = (uint) (managementObject.Properties["AvgTimeBetweenBatchesms_Base"]?.Value ?? default(uint)),
		 AvgTimetoWriteBatchms = (ulong) (managementObject.Properties["AvgTimetoWriteBatchms"]?.Value ?? default(ulong)),
		 AvgTimetoWriteBatchmsBase = (uint) (managementObject.Properties["AvgTimetoWriteBatchms_Base"]?.Value ?? default(uint)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 TransmissionObjGetsPerSec = (ulong) (managementObject.Properties["TransmissionObjGetsPerSec"]?.Value ?? default(ulong)),
		 TransmissionObjSetDirtyPerSec = (ulong) (managementObject.Properties["TransmissionObjSetDirtyPerSec"]?.Value ?? default(ulong)),
		 TransmissionObjWritesPerSec = (ulong) (managementObject.Properties["TransmissionObjWritesPerSec"]?.Value ?? default(ulong))
                };
        }
    }
}