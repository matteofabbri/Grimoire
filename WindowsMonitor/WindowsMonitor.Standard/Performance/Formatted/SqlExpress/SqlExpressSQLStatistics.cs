using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted.SqlExpress
{
    /// <summary>
    /// </summary>
    public sealed class SqlExpressSqlStatistics
    {
		public ulong AutoParamAttemptsPersec { get; private set; }
		public ulong BatchRequestsPersec { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong FailedAutoParamsPersec { get; private set; }
		public ulong ForcedParameterizationsPersec { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public ulong GuidedplanexecutionsPersec { get; private set; }
		public ulong MisguidedplanexecutionsPersec { get; private set; }
		public string Name { get; private set; }
		public ulong SafeAutoParamsPersec { get; private set; }
		public ulong SqlAttentionrate { get; private set; }
		public ulong SqlCompilationsPersec { get; private set; }
		public ulong SqlReCompilationsPersec { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public ulong UnsafeAutoParamsPersec { get; private set; }

        public static IEnumerable<SqlExpressSqlStatistics> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SqlExpressSqlStatistics> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SqlExpressSqlStatistics> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_MSSQLSQLEXPRESS_MSSQLSQLEXPRESSSQLStatistics");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SqlExpressSqlStatistics
                {
                     AutoParamAttemptsPersec = (ulong) (managementObject.Properties["AutoParamAttemptsPersec"]?.Value ?? default(ulong)),
		 BatchRequestsPersec = (ulong) (managementObject.Properties["BatchRequestsPersec"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FailedAutoParamsPersec = (ulong) (managementObject.Properties["FailedAutoParamsPersec"]?.Value ?? default(ulong)),
		 ForcedParameterizationsPersec = (ulong) (managementObject.Properties["ForcedParameterizationsPersec"]?.Value ?? default(ulong)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 GuidedplanexecutionsPersec = (ulong) (managementObject.Properties["GuidedplanexecutionsPersec"]?.Value ?? default(ulong)),
		 MisguidedplanexecutionsPersec = (ulong) (managementObject.Properties["MisguidedplanexecutionsPersec"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 SafeAutoParamsPersec = (ulong) (managementObject.Properties["SafeAutoParamsPersec"]?.Value ?? default(ulong)),
		 SqlAttentionrate = (ulong) (managementObject.Properties["SQLAttentionrate"]?.Value ?? default(ulong)),
		 SqlCompilationsPersec = (ulong) (managementObject.Properties["SQLCompilationsPersec"]?.Value ?? default(ulong)),
		 SqlReCompilationsPersec = (ulong) (managementObject.Properties["SQLReCompilationsPersec"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 UnsafeAutoParamsPersec = (ulong) (managementObject.Properties["UnsafeAutoParamsPersec"]?.Value ?? default(ulong))
                };
        }
    }
}