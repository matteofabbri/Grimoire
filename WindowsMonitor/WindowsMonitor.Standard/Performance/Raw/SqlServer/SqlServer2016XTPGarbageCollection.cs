using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.SqlServer
{
    /// <summary>
    /// </summary>
    public sealed class SqlServer2016XtpGarbageCollection
    {
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public uint DustycornerscanretriesPersecGCissued { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public uint MainGCworkitemsPersec { get; private set; }
		public string Name { get; private set; }
		public uint ParallelGCworkitemPersec { get; private set; }
		public uint RowsprocessedPersec { get; private set; }
		public uint RowsprocessedPersecfirstinbucket { get; private set; }
		public uint RowsprocessedPersecfirstinbucketandremoved { get; private set; }
		public uint RowsprocessedPersecmarkedforunlink { get; private set; }
		public uint RowsprocessedPersecnosweepneeded { get; private set; }
		public uint SweepexpiredrowsremovedPersec { get; private set; }
		public uint SweepexpiredrowstouchedPersec { get; private set; }
		public uint SweepexpiringrowstouchedPersec { get; private set; }
		public uint SweeprowstouchedPersec { get; private set; }
		public uint SweepscansstartedPersec { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<SqlServer2016XtpGarbageCollection> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SqlServer2016XtpGarbageCollection> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SqlServer2016XtpGarbageCollection> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_SQLServer2016XTPDatabaseEngine_SQLServer2016XTPGarbageCollection");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SqlServer2016XtpGarbageCollection
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DustycornerscanretriesPersecGCissued = (uint) (managementObject.Properties["DustycornerscanretriesPersecGCissued"]?.Value ?? default(uint)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 MainGCworkitemsPersec = (uint) (managementObject.Properties["MainGCworkitemsPersec"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 ParallelGCworkitemPersec = (uint) (managementObject.Properties["ParallelGCworkitemPersec"]?.Value ?? default(uint)),
		 RowsprocessedPersec = (uint) (managementObject.Properties["RowsprocessedPersec"]?.Value ?? default(uint)),
		 RowsprocessedPersecfirstinbucket = (uint) (managementObject.Properties["RowsprocessedPersecfirstinbucket"]?.Value ?? default(uint)),
		 RowsprocessedPersecfirstinbucketandremoved = (uint) (managementObject.Properties["RowsprocessedPersecfirstinbucketandremoved"]?.Value ?? default(uint)),
		 RowsprocessedPersecmarkedforunlink = (uint) (managementObject.Properties["RowsprocessedPersecmarkedforunlink"]?.Value ?? default(uint)),
		 RowsprocessedPersecnosweepneeded = (uint) (managementObject.Properties["RowsprocessedPersecnosweepneeded"]?.Value ?? default(uint)),
		 SweepexpiredrowsremovedPersec = (uint) (managementObject.Properties["SweepexpiredrowsremovedPersec"]?.Value ?? default(uint)),
		 SweepexpiredrowstouchedPersec = (uint) (managementObject.Properties["SweepexpiredrowstouchedPersec"]?.Value ?? default(uint)),
		 SweepexpiringrowstouchedPersec = (uint) (managementObject.Properties["SweepexpiringrowstouchedPersec"]?.Value ?? default(uint)),
		 SweeprowstouchedPersec = (uint) (managementObject.Properties["SweeprowstouchedPersec"]?.Value ?? default(uint)),
		 SweepscansstartedPersec = (uint) (managementObject.Properties["SweepscansstartedPersec"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}