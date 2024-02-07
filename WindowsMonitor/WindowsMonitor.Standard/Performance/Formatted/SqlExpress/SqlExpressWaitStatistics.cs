using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted.SqlExpress
{
    /// <summary>
    /// </summary>
    public sealed class SqlExpressWaitStatistics
    {
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public ulong Lockwaits { get; private set; }
		public ulong Logbufferwaits { get; private set; }
		public ulong Logwritewaits { get; private set; }
		public ulong Memorygrantqueuewaits { get; private set; }
		public string Name { get; private set; }
		public ulong NetworkIOwaits { get; private set; }
		public ulong NonPagelatchwaits { get; private set; }
		public ulong PageIOlatchwaits { get; private set; }
		public ulong Pagelatchwaits { get; private set; }
		public ulong Threadsafememoryobjectswaits { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public ulong Transactionownershipwaits { get; private set; }
		public ulong Waitfortheworker { get; private set; }
		public ulong Workspacesynchronizationwaits { get; private set; }

        public static IEnumerable<SqlExpressWaitStatistics> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SqlExpressWaitStatistics> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SqlExpressWaitStatistics> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_MSSQLSQLEXPRESS_MSSQLSQLEXPRESSWaitStatistics");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SqlExpressWaitStatistics
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Lockwaits = (ulong) (managementObject.Properties["Lockwaits"]?.Value ?? default(ulong)),
		 Logbufferwaits = (ulong) (managementObject.Properties["Logbufferwaits"]?.Value ?? default(ulong)),
		 Logwritewaits = (ulong) (managementObject.Properties["Logwritewaits"]?.Value ?? default(ulong)),
		 Memorygrantqueuewaits = (ulong) (managementObject.Properties["Memorygrantqueuewaits"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 NetworkIOwaits = (ulong) (managementObject.Properties["NetworkIOwaits"]?.Value ?? default(ulong)),
		 NonPagelatchwaits = (ulong) (managementObject.Properties["NonPagelatchwaits"]?.Value ?? default(ulong)),
		 PageIOlatchwaits = (ulong) (managementObject.Properties["PageIOlatchwaits"]?.Value ?? default(ulong)),
		 Pagelatchwaits = (ulong) (managementObject.Properties["Pagelatchwaits"]?.Value ?? default(ulong)),
		 Threadsafememoryobjectswaits = (ulong) (managementObject.Properties["Threadsafememoryobjectswaits"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 Transactionownershipwaits = (ulong) (managementObject.Properties["Transactionownershipwaits"]?.Value ?? default(ulong)),
		 Waitfortheworker = (ulong) (managementObject.Properties["Waitfortheworker"]?.Value ?? default(ulong)),
		 Workspacesynchronizationwaits = (ulong) (managementObject.Properties["Workspacesynchronizationwaits"]?.Value ?? default(ulong))
                };
        }
    }
}