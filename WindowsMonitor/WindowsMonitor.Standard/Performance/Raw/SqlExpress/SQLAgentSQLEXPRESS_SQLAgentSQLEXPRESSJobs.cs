using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.SqlExpress
{
    /// <summary>
    /// </summary>
    public sealed class SqlAgentSqlexpressSqlAgentSqlexpressJobs
    {
		public ulong Activejobs { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong Failedjobs { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public ulong JobsactivatedPerminute { get; private set; }
		public ulong Jobsuccessrate { get; private set; }
		public ulong JobsuccessrateBase { get; private set; }
		public string Name { get; private set; }
		public ulong Queuedjobs { get; private set; }
		public ulong Successfuljobs { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<SqlAgentSqlexpressSqlAgentSqlexpressJobs> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SqlAgentSqlexpressSqlAgentSqlexpressJobs> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SqlAgentSqlexpressSqlAgentSqlexpressJobs> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_SQLAgentSQLEXPRESS_SQLAgentSQLEXPRESSJobs");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SqlAgentSqlexpressSqlAgentSqlexpressJobs
                {
                     Activejobs = (ulong) (managementObject.Properties["Activejobs"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 Failedjobs = (ulong) (managementObject.Properties["Failedjobs"]?.Value ?? default(ulong)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 JobsactivatedPerminute = (ulong) (managementObject.Properties["JobsactivatedPerminute"]?.Value ?? default(ulong)),
		 Jobsuccessrate = (ulong) (managementObject.Properties["Jobsuccessrate"]?.Value ?? default(ulong)),
		 JobsuccessrateBase = (ulong) (managementObject.Properties["Jobsuccessrate_Base"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 Queuedjobs = (ulong) (managementObject.Properties["Queuedjobs"]?.Value ?? default(ulong)),
		 Successfuljobs = (ulong) (managementObject.Properties["Successfuljobs"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}