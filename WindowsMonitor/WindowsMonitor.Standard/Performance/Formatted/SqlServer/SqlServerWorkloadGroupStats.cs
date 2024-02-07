using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted.SqlServer
{
    /// <summary>
    /// </summary>
    public sealed class SqlServerWorkloadGroupStats
    {
		public ulong Activeparallelthreads { get; private set; }
		public ulong Activerequests { get; private set; }
		public ulong Blockedtasks { get; private set; }
		public string Caption { get; private set; }
		public ulong CpUdelayedPercent { get; private set; }
		public ulong CpUeffectivePercent { get; private set; }
		public ulong CpUusagePercent { get; private set; }
		public ulong CpUviolatedPercent { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public ulong Maxrequestcputimems { get; private set; }
		public ulong MaxrequestmemorygrantKb { get; private set; }
		public string Name { get; private set; }
		public ulong QueryoptimizationsPersec { get; private set; }
		public ulong Queuedrequests { get; private set; }
		public ulong ReducedmemorygrantsPersec { get; private set; }
		public ulong RequestscompletedPersec { get; private set; }
		public ulong SuboptimalplansPersec { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<SqlServerWorkloadGroupStats> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SqlServerWorkloadGroupStats> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SqlServerWorkloadGroupStats> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_MSSQLSERVER_SQLServerWorkloadGroupStats");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SqlServerWorkloadGroupStats
                {
                     Activeparallelthreads = (ulong) (managementObject.Properties["Activeparallelthreads"]?.Value ?? default(ulong)),
		 Activerequests = (ulong) (managementObject.Properties["Activerequests"]?.Value ?? default(ulong)),
		 Blockedtasks = (ulong) (managementObject.Properties["Blockedtasks"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CpUdelayedPercent = (ulong) (managementObject.Properties["CPUdelayedPercent"]?.Value ?? default(ulong)),
		 CpUeffectivePercent = (ulong) (managementObject.Properties["CPUeffectivePercent"]?.Value ?? default(ulong)),
		 CpUusagePercent = (ulong) (managementObject.Properties["CPUusagePercent"]?.Value ?? default(ulong)),
		 CpUviolatedPercent = (ulong) (managementObject.Properties["CPUviolatedPercent"]?.Value ?? default(ulong)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Maxrequestcputimems = (ulong) (managementObject.Properties["Maxrequestcputimems"]?.Value ?? default(ulong)),
		 MaxrequestmemorygrantKb = (ulong) (managementObject.Properties["MaxrequestmemorygrantKB"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 QueryoptimizationsPersec = (ulong) (managementObject.Properties["QueryoptimizationsPersec"]?.Value ?? default(ulong)),
		 Queuedrequests = (ulong) (managementObject.Properties["Queuedrequests"]?.Value ?? default(ulong)),
		 ReducedmemorygrantsPersec = (ulong) (managementObject.Properties["ReducedmemorygrantsPersec"]?.Value ?? default(ulong)),
		 RequestscompletedPersec = (ulong) (managementObject.Properties["RequestscompletedPersec"]?.Value ?? default(ulong)),
		 SuboptimalplansPersec = (ulong) (managementObject.Properties["SuboptimalplansPersec"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}