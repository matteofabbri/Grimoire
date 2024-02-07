using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.SqlServer
{
    /// <summary>
    /// </summary>
    public sealed class SqlServerMemoryManager
    {
		public string Caption { get; private set; }
		public ulong ConnectionMemoryKb { get; private set; }
		public ulong DatabaseCacheMemoryKb { get; private set; }
		public string Description { get; private set; }
		public ulong Externalbenefitofmemory { get; private set; }
		public ulong FreeMemoryKb { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public ulong GrantedWorkspaceMemoryKb { get; private set; }
		public ulong LockBlocks { get; private set; }
		public ulong LockBlocksAllocated { get; private set; }
		public ulong LockMemoryKb { get; private set; }
		public ulong LockOwnerBlocks { get; private set; }
		public ulong LockOwnerBlocksAllocated { get; private set; }
		public ulong LogPoolMemoryKb { get; private set; }
		public ulong MaximumWorkspaceMemoryKb { get; private set; }
		public ulong MemoryGrantsOutstanding { get; private set; }
		public ulong MemoryGrantsPending { get; private set; }
		public string Name { get; private set; }
		public ulong OptimizerMemoryKb { get; private set; }
		public ulong ReservedServerMemoryKb { get; private set; }
		public ulong SqlCacheMemoryKb { get; private set; }
		public ulong StolenServerMemoryKb { get; private set; }
		public ulong TargetServerMemoryKb { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public ulong TotalServerMemoryKb { get; private set; }

        public static IEnumerable<SqlServerMemoryManager> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SqlServerMemoryManager> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SqlServerMemoryManager> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_MSSQLSERVER_SQLServerMemoryManager");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SqlServerMemoryManager
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 ConnectionMemoryKb = (ulong) (managementObject.Properties["ConnectionMemoryKB"]?.Value ?? default(ulong)),
		 DatabaseCacheMemoryKb = (ulong) (managementObject.Properties["DatabaseCacheMemoryKB"]?.Value ?? default(ulong)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 Externalbenefitofmemory = (ulong) (managementObject.Properties["Externalbenefitofmemory"]?.Value ?? default(ulong)),
		 FreeMemoryKb = (ulong) (managementObject.Properties["FreeMemoryKB"]?.Value ?? default(ulong)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 GrantedWorkspaceMemoryKb = (ulong) (managementObject.Properties["GrantedWorkspaceMemoryKB"]?.Value ?? default(ulong)),
		 LockBlocks = (ulong) (managementObject.Properties["LockBlocks"]?.Value ?? default(ulong)),
		 LockBlocksAllocated = (ulong) (managementObject.Properties["LockBlocksAllocated"]?.Value ?? default(ulong)),
		 LockMemoryKb = (ulong) (managementObject.Properties["LockMemoryKB"]?.Value ?? default(ulong)),
		 LockOwnerBlocks = (ulong) (managementObject.Properties["LockOwnerBlocks"]?.Value ?? default(ulong)),
		 LockOwnerBlocksAllocated = (ulong) (managementObject.Properties["LockOwnerBlocksAllocated"]?.Value ?? default(ulong)),
		 LogPoolMemoryKb = (ulong) (managementObject.Properties["LogPoolMemoryKB"]?.Value ?? default(ulong)),
		 MaximumWorkspaceMemoryKb = (ulong) (managementObject.Properties["MaximumWorkspaceMemoryKB"]?.Value ?? default(ulong)),
		 MemoryGrantsOutstanding = (ulong) (managementObject.Properties["MemoryGrantsOutstanding"]?.Value ?? default(ulong)),
		 MemoryGrantsPending = (ulong) (managementObject.Properties["MemoryGrantsPending"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 OptimizerMemoryKb = (ulong) (managementObject.Properties["OptimizerMemoryKB"]?.Value ?? default(ulong)),
		 ReservedServerMemoryKb = (ulong) (managementObject.Properties["ReservedServerMemoryKB"]?.Value ?? default(ulong)),
		 SqlCacheMemoryKb = (ulong) (managementObject.Properties["SQLCacheMemoryKB"]?.Value ?? default(ulong)),
		 StolenServerMemoryKb = (ulong) (managementObject.Properties["StolenServerMemoryKB"]?.Value ?? default(ulong)),
		 TargetServerMemoryKb = (ulong) (managementObject.Properties["TargetServerMemoryKB"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 TotalServerMemoryKb = (ulong) (managementObject.Properties["TotalServerMemoryKB"]?.Value ?? default(ulong))
                };
        }
    }
}