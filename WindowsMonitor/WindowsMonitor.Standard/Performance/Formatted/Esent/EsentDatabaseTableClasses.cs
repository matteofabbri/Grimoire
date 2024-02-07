using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted.Esent
{
    /// <summary>
    /// </summary>
    public sealed class EsentDatabaseTableClasses
    {
		public string Caption { get; private set; }
		public ulong DatabaseCacheMissAttachedAverageLatency { get; private set; }
		public uint DatabaseCacheMissesPersec { get; private set; }
		public uint DatabaseCachePercentHit { get; private set; }
		public uint DatabaseCachePercentHitUncorrelated { get; private set; }
		public uint DatabaseCacheRequestsPersec { get; private set; }
		public ulong DatabaseCacheSize { get; private set; }
		public ulong DatabaseCacheSizeMb { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<EsentDatabaseTableClasses> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<EsentDatabaseTableClasses> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<EsentDatabaseTableClasses> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_ESENT_DatabaseTableClasses");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new EsentDatabaseTableClasses
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 DatabaseCacheMissAttachedAverageLatency = (ulong) (managementObject.Properties["DatabaseCacheMissAttachedAverageLatency"]?.Value ?? default(ulong)),
		 DatabaseCacheMissesPersec = (uint) (managementObject.Properties["DatabaseCacheMissesPersec"]?.Value ?? default(uint)),
		 DatabaseCachePercentHit = (uint) (managementObject.Properties["DatabaseCachePercentHit"]?.Value ?? default(uint)),
		 DatabaseCachePercentHitUncorrelated = (uint) (managementObject.Properties["DatabaseCachePercentHitUncorrelated"]?.Value ?? default(uint)),
		 DatabaseCacheRequestsPersec = (uint) (managementObject.Properties["DatabaseCacheRequestsPersec"]?.Value ?? default(uint)),
		 DatabaseCacheSize = (ulong) (managementObject.Properties["DatabaseCacheSize"]?.Value ?? default(ulong)),
		 DatabaseCacheSizeMb = (ulong) (managementObject.Properties["DatabaseCacheSizeMB"]?.Value ?? default(ulong)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}