using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.Network.Http
{
    /// <summary>
    /// </summary>
    public sealed class CountersHttpService
    {
		public string Caption { get; private set; }
		public uint CurrentUrisCached { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public uint TotalFlushedUris { get; private set; }
		public uint TotalUrisCached { get; private set; }
		public uint UriCacheFlushes { get; private set; }
		public uint UriCacheHits { get; private set; }
		public uint UriCacheMisses { get; private set; }

        public static IEnumerable<CountersHttpService> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<CountersHttpService> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<CountersHttpService> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_Counters_HTTPService");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new CountersHttpService
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CurrentUrisCached = (uint) (managementObject.Properties["CurrentUrisCached"]?.Value ?? default(uint)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 TotalFlushedUris = (uint) (managementObject.Properties["TotalFlushedUris"]?.Value ?? default(uint)),
		 TotalUrisCached = (uint) (managementObject.Properties["TotalUrisCached"]?.Value ?? default(uint)),
		 UriCacheFlushes = (uint) (managementObject.Properties["UriCacheFlushes"]?.Value ?? default(uint)),
		 UriCacheHits = (uint) (managementObject.Properties["UriCacheHits"]?.Value ?? default(uint)),
		 UriCacheMisses = (uint) (managementObject.Properties["UriCacheMisses"]?.Value ?? default(uint))
                };
        }
    }
}