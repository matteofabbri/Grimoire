using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.SqlExpress
{
    /// <summary>
    /// </summary>
    public sealed class SqlExpressCursorManagerbyType
    {
		public ulong Activecursors { get; private set; }
		public ulong CachedCursorCounts { get; private set; }
		public ulong CacheHitRatio { get; private set; }
		public ulong CacheHitRatioBase { get; private set; }
		public string Caption { get; private set; }
		public ulong CursorCacheUseCountsPersec { get; private set; }
		public ulong Cursormemoryusage { get; private set; }
		public ulong CursorRequestsPersec { get; private set; }
		public ulong Cursorworktableusage { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public ulong Numberofactivecursorplans { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<SqlExpressCursorManagerbyType> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SqlExpressCursorManagerbyType> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SqlExpressCursorManagerbyType> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_MSSQLSQLEXPRESS_MSSQLSQLEXPRESSCursorManagerbyType");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SqlExpressCursorManagerbyType
                {
                     Activecursors = (ulong) (managementObject.Properties["Activecursors"]?.Value ?? default(ulong)),
		 CachedCursorCounts = (ulong) (managementObject.Properties["CachedCursorCounts"]?.Value ?? default(ulong)),
		 CacheHitRatio = (ulong) (managementObject.Properties["CacheHitRatio"]?.Value ?? default(ulong)),
		 CacheHitRatioBase = (ulong) (managementObject.Properties["CacheHitRatio_Base"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CursorCacheUseCountsPersec = (ulong) (managementObject.Properties["CursorCacheUseCountsPersec"]?.Value ?? default(ulong)),
		 Cursormemoryusage = (ulong) (managementObject.Properties["Cursormemoryusage"]?.Value ?? default(ulong)),
		 CursorRequestsPersec = (ulong) (managementObject.Properties["CursorRequestsPersec"]?.Value ?? default(ulong)),
		 Cursorworktableusage = (ulong) (managementObject.Properties["Cursorworktableusage"]?.Value ?? default(ulong)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 Numberofactivecursorplans = (ulong) (managementObject.Properties["Numberofactivecursorplans"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}