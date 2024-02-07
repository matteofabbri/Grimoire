using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.SqlServer
{
    /// <summary>
    /// </summary>
    public sealed class SqlServerMemoryNode
    {
		public string Caption { get; private set; }
		public ulong DatabaseNodeMemoryKb { get; private set; }
		public string Description { get; private set; }
		public ulong ForeignNodeMemoryKb { get; private set; }
		public ulong FreeNodeMemoryKb { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public ulong StolenNodeMemoryKb { get; private set; }
		public ulong TargetNodeMemoryKb { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public ulong TotalNodeMemoryKb { get; private set; }

        public static IEnumerable<SqlServerMemoryNode> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SqlServerMemoryNode> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SqlServerMemoryNode> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_MSSQLSERVER_SQLServerMemoryNode");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SqlServerMemoryNode
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 DatabaseNodeMemoryKb = (ulong) (managementObject.Properties["DatabaseNodeMemoryKB"]?.Value ?? default(ulong)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 ForeignNodeMemoryKb = (ulong) (managementObject.Properties["ForeignNodeMemoryKB"]?.Value ?? default(ulong)),
		 FreeNodeMemoryKb = (ulong) (managementObject.Properties["FreeNodeMemoryKB"]?.Value ?? default(ulong)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 StolenNodeMemoryKb = (ulong) (managementObject.Properties["StolenNodeMemoryKB"]?.Value ?? default(ulong)),
		 TargetNodeMemoryKb = (ulong) (managementObject.Properties["TargetNodeMemoryKB"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 TotalNodeMemoryKb = (ulong) (managementObject.Properties["TotalNodeMemoryKB"]?.Value ?? default(ulong))
                };
        }
    }
}