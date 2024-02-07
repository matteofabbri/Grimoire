using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.SqlExpress
{
    /// <summary>
    /// </summary>
    public sealed class SqlExpressResourcePoolStats
    {
		public ulong ActivememorygrantamountKb { get; private set; }
		public ulong Activememorygrantscount { get; private set; }
		public ulong AvgDiskReadIOms { get; private set; }
		public uint AvgDiskReadIOmsBase { get; private set; }
		public ulong AvgDiskWriteIOms { get; private set; }
		public uint AvgDiskWriteIOmsBase { get; private set; }
		public ulong CachememorytargetKb { get; private set; }
		public string Caption { get; private set; }
		public ulong CompilememorytargetKb { get; private set; }
		public ulong CpUcontroleffectPercent { get; private set; }
		public ulong CpUusagePercent { get; private set; }
		public ulong CpUusagePercentBase { get; private set; }
		public ulong CpUusagetargetPercent { get; private set; }
		public string Description { get; private set; }
		public ulong DiskReadBytesPersec { get; private set; }
		public ulong DiskReadIoPersec { get; private set; }
		public ulong DiskReadIoThrottledPersec { get; private set; }
		public ulong DiskWriteBytesPersec { get; private set; }
		public ulong DiskWriteIoPersec { get; private set; }
		public ulong DiskWriteIoThrottledPersec { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public ulong MaxmemoryKb { get; private set; }
		public ulong MemorygrantsPersec { get; private set; }
		public ulong MemorygranttimeoutsPersec { get; private set; }
		public string Name { get; private set; }
		public ulong Pendingmemorygrantscount { get; private set; }
		public ulong QueryexecmemorytargetKb { get; private set; }
		public ulong TargetmemoryKb { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public ulong UsedmemoryKb { get; private set; }

        public static IEnumerable<SqlExpressResourcePoolStats> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SqlExpressResourcePoolStats> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SqlExpressResourcePoolStats> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_MSSQLSQLEXPRESS_MSSQLSQLEXPRESSResourcePoolStats");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SqlExpressResourcePoolStats
                {
                     ActivememorygrantamountKb = (ulong) (managementObject.Properties["ActivememorygrantamountKB"]?.Value ?? default(ulong)),
		 Activememorygrantscount = (ulong) (managementObject.Properties["Activememorygrantscount"]?.Value ?? default(ulong)),
		 AvgDiskReadIOms = (ulong) (managementObject.Properties["AvgDiskReadIOms"]?.Value ?? default(ulong)),
		 AvgDiskReadIOmsBase = (uint) (managementObject.Properties["AvgDiskReadIOms_Base"]?.Value ?? default(uint)),
		 AvgDiskWriteIOms = (ulong) (managementObject.Properties["AvgDiskWriteIOms"]?.Value ?? default(ulong)),
		 AvgDiskWriteIOmsBase = (uint) (managementObject.Properties["AvgDiskWriteIOms_Base"]?.Value ?? default(uint)),
		 CachememorytargetKb = (ulong) (managementObject.Properties["CachememorytargetKB"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CompilememorytargetKb = (ulong) (managementObject.Properties["CompilememorytargetKB"]?.Value ?? default(ulong)),
		 CpUcontroleffectPercent = (ulong) (managementObject.Properties["CPUcontroleffectPercent"]?.Value ?? default(ulong)),
		 CpUusagePercent = (ulong) (managementObject.Properties["CPUusagePercent"]?.Value ?? default(ulong)),
		 CpUusagePercentBase = (ulong) (managementObject.Properties["CPUusagePercent_Base"]?.Value ?? default(ulong)),
		 CpUusagetargetPercent = (ulong) (managementObject.Properties["CPUusagetargetPercent"]?.Value ?? default(ulong)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DiskReadBytesPersec = (ulong) (managementObject.Properties["DiskReadBytesPersec"]?.Value ?? default(ulong)),
		 DiskReadIoPersec = (ulong) (managementObject.Properties["DiskReadIOPersec"]?.Value ?? default(ulong)),
		 DiskReadIoThrottledPersec = (ulong) (managementObject.Properties["DiskReadIOThrottledPersec"]?.Value ?? default(ulong)),
		 DiskWriteBytesPersec = (ulong) (managementObject.Properties["DiskWriteBytesPersec"]?.Value ?? default(ulong)),
		 DiskWriteIoPersec = (ulong) (managementObject.Properties["DiskWriteIOPersec"]?.Value ?? default(ulong)),
		 DiskWriteIoThrottledPersec = (ulong) (managementObject.Properties["DiskWriteIOThrottledPersec"]?.Value ?? default(ulong)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 MaxmemoryKb = (ulong) (managementObject.Properties["MaxmemoryKB"]?.Value ?? default(ulong)),
		 MemorygrantsPersec = (ulong) (managementObject.Properties["MemorygrantsPersec"]?.Value ?? default(ulong)),
		 MemorygranttimeoutsPersec = (ulong) (managementObject.Properties["MemorygranttimeoutsPersec"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 Pendingmemorygrantscount = (ulong) (managementObject.Properties["Pendingmemorygrantscount"]?.Value ?? default(ulong)),
		 QueryexecmemorytargetKb = (ulong) (managementObject.Properties["QueryexecmemorytargetKB"]?.Value ?? default(ulong)),
		 TargetmemoryKb = (ulong) (managementObject.Properties["TargetmemoryKB"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 UsedmemoryKb = (ulong) (managementObject.Properties["UsedmemoryKB"]?.Value ?? default(ulong))
                };
        }
    }
}