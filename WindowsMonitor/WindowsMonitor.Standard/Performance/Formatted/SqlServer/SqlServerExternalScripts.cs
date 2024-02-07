using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted.SqlServer
{
    /// <summary>
    /// </summary>
    public sealed class SqlServerExternalScripts
    {
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong ExecutionErrors { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public ulong ImpliedAuthLogins { get; private set; }
		public string Name { get; private set; }
		public ulong ParallelExecutions { get; private set; }
		public ulong SqlccExecutions { get; private set; }
		public ulong StreamingExecutions { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public ulong TotalExecutions { get; private set; }
		public ulong TotalExecutionTimems { get; private set; }

        public static IEnumerable<SqlServerExternalScripts> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SqlServerExternalScripts> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SqlServerExternalScripts> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_MSSQLSERVER_SQLServerExternalScripts");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SqlServerExternalScripts
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 ExecutionErrors = (ulong) (managementObject.Properties["ExecutionErrors"]?.Value ?? default(ulong)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 ImpliedAuthLogins = (ulong) (managementObject.Properties["ImpliedAuthLogins"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 ParallelExecutions = (ulong) (managementObject.Properties["ParallelExecutions"]?.Value ?? default(ulong)),
		 SqlccExecutions = (ulong) (managementObject.Properties["SQLCCExecutions"]?.Value ?? default(ulong)),
		 StreamingExecutions = (ulong) (managementObject.Properties["StreamingExecutions"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 TotalExecutions = (ulong) (managementObject.Properties["TotalExecutions"]?.Value ?? default(ulong)),
		 TotalExecutionTimems = (ulong) (managementObject.Properties["TotalExecutionTimems"]?.Value ?? default(ulong))
                };
        }
    }
}