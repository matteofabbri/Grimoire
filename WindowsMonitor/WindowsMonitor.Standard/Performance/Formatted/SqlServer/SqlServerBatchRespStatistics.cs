using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted.SqlServer
{
    /// <summary>
    /// </summary>
    public sealed class SqlServerBatchRespStatistics
    {
		public ulong Batches000000MsAnd000001Ms { get; private set; }
		public ulong Batches000001MsAnd000002Ms { get; private set; }
		public ulong Batches000002MsAnd000005Ms { get; private set; }
		public ulong Batches000005MsAnd000010Ms { get; private set; }
		public ulong Batches000010MsAnd000020Ms { get; private set; }
		public ulong Batches000020MsAnd000050Ms { get; private set; }
		public ulong Batches000050MsAnd000100Ms { get; private set; }
		public ulong Batches000100MsAnd000200Ms { get; private set; }
		public ulong Batches000200MsAnd000500Ms { get; private set; }
		public ulong Batches000500MsAnd001000Ms { get; private set; }
		public ulong Batches001000MsAnd002000Ms { get; private set; }
		public ulong Batches002000MsAnd005000Ms { get; private set; }
		public ulong Batches005000MsAnd010000Ms { get; private set; }
		public ulong Batches010000MsAnd020000Ms { get; private set; }
		public ulong Batches020000MsAnd050000Ms { get; private set; }
		public ulong Batches050000MsAnd100000Ms { get; private set; }
		public ulong Batches100000Ms { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<SqlServerBatchRespStatistics> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SqlServerBatchRespStatistics> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SqlServerBatchRespStatistics> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_MSSQLSERVER_SQLServerBatchRespStatistics");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SqlServerBatchRespStatistics
                {
                     Batches000000MsAnd000001Ms = (ulong) (managementObject.Properties["Batches000000msAnd000001ms"]?.Value ?? default(ulong)),
		 Batches000001MsAnd000002Ms = (ulong) (managementObject.Properties["Batches000001msAnd000002ms"]?.Value ?? default(ulong)),
		 Batches000002MsAnd000005Ms = (ulong) (managementObject.Properties["Batches000002msAnd000005ms"]?.Value ?? default(ulong)),
		 Batches000005MsAnd000010Ms = (ulong) (managementObject.Properties["Batches000005msAnd000010ms"]?.Value ?? default(ulong)),
		 Batches000010MsAnd000020Ms = (ulong) (managementObject.Properties["Batches000010msAnd000020ms"]?.Value ?? default(ulong)),
		 Batches000020MsAnd000050Ms = (ulong) (managementObject.Properties["Batches000020msAnd000050ms"]?.Value ?? default(ulong)),
		 Batches000050MsAnd000100Ms = (ulong) (managementObject.Properties["Batches000050msAnd000100ms"]?.Value ?? default(ulong)),
		 Batches000100MsAnd000200Ms = (ulong) (managementObject.Properties["Batches000100msAnd000200ms"]?.Value ?? default(ulong)),
		 Batches000200MsAnd000500Ms = (ulong) (managementObject.Properties["Batches000200msAnd000500ms"]?.Value ?? default(ulong)),
		 Batches000500MsAnd001000Ms = (ulong) (managementObject.Properties["Batches000500msAnd001000ms"]?.Value ?? default(ulong)),
		 Batches001000MsAnd002000Ms = (ulong) (managementObject.Properties["Batches001000msAnd002000ms"]?.Value ?? default(ulong)),
		 Batches002000MsAnd005000Ms = (ulong) (managementObject.Properties["Batches002000msAnd005000ms"]?.Value ?? default(ulong)),
		 Batches005000MsAnd010000Ms = (ulong) (managementObject.Properties["Batches005000msAnd010000ms"]?.Value ?? default(ulong)),
		 Batches010000MsAnd020000Ms = (ulong) (managementObject.Properties["Batches010000msAnd020000ms"]?.Value ?? default(ulong)),
		 Batches020000MsAnd050000Ms = (ulong) (managementObject.Properties["Batches020000msAnd050000ms"]?.Value ?? default(ulong)),
		 Batches050000MsAnd100000Ms = (ulong) (managementObject.Properties["Batches050000msAnd100000ms"]?.Value ?? default(ulong)),
		 Batches100000Ms = (ulong) (managementObject.Properties["Batches100000ms"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}