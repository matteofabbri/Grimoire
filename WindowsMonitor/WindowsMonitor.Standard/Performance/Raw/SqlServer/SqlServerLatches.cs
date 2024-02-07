using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.SqlServer
{
    /// <summary>
    /// </summary>
    public sealed class SqlServerLatches
    {
		public ulong AverageLatchWaitTimems { get; private set; }
		public uint AverageLatchWaitTimemsBase { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public ulong LatchWaitsPersec { get; private set; }
		public string Name { get; private set; }
		public ulong NumberofSuperLatches { get; private set; }
		public ulong SuperLatchDemotionsPersec { get; private set; }
		public ulong SuperLatchPromotionsPersec { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public ulong TotalLatchWaitTimems { get; private set; }

        public static IEnumerable<SqlServerLatches> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SqlServerLatches> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SqlServerLatches> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_MSSQLSERVER_SQLServerLatches");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SqlServerLatches
                {
                     AverageLatchWaitTimems = (ulong) (managementObject.Properties["AverageLatchWaitTimems"]?.Value ?? default(ulong)),
		 AverageLatchWaitTimemsBase = (uint) (managementObject.Properties["AverageLatchWaitTimems_Base"]?.Value ?? default(uint)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 LatchWaitsPersec = (ulong) (managementObject.Properties["LatchWaitsPersec"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 NumberofSuperLatches = (ulong) (managementObject.Properties["NumberofSuperLatches"]?.Value ?? default(ulong)),
		 SuperLatchDemotionsPersec = (ulong) (managementObject.Properties["SuperLatchDemotionsPersec"]?.Value ?? default(ulong)),
		 SuperLatchPromotionsPersec = (ulong) (managementObject.Properties["SuperLatchPromotionsPersec"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 TotalLatchWaitTimems = (ulong) (managementObject.Properties["TotalLatchWaitTimems"]?.Value ?? default(ulong))
                };
        }
    }
}