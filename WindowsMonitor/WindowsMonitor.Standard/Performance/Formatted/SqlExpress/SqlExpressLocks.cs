using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted.SqlExpress
{
    /// <summary>
    /// </summary>
    public sealed class SqlExpressLocks
    {
		public ulong AverageWaitTimems { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public ulong LockRequestsPersec { get; private set; }
		public ulong LockTimeoutsPersec { get; private set; }
		public ulong LockTimeoutstimeout0Persec { get; private set; }
		public ulong LockWaitsPersec { get; private set; }
		public ulong LockWaitTimems { get; private set; }
		public string Name { get; private set; }
		public ulong NumberofDeadlocksPersec { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<SqlExpressLocks> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SqlExpressLocks> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SqlExpressLocks> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_MSSQLSQLEXPRESS_MSSQLSQLEXPRESSLocks");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SqlExpressLocks
                {
                     AverageWaitTimems = (ulong) (managementObject.Properties["AverageWaitTimems"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 LockRequestsPersec = (ulong) (managementObject.Properties["LockRequestsPersec"]?.Value ?? default(ulong)),
		 LockTimeoutsPersec = (ulong) (managementObject.Properties["LockTimeoutsPersec"]?.Value ?? default(ulong)),
		 LockTimeoutstimeout0Persec = (ulong) (managementObject.Properties["LockTimeoutstimeout0Persec"]?.Value ?? default(ulong)),
		 LockWaitsPersec = (ulong) (managementObject.Properties["LockWaitsPersec"]?.Value ?? default(ulong)),
		 LockWaitTimems = (ulong) (managementObject.Properties["LockWaitTimems"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 NumberofDeadlocksPersec = (ulong) (managementObject.Properties["NumberofDeadlocksPersec"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}