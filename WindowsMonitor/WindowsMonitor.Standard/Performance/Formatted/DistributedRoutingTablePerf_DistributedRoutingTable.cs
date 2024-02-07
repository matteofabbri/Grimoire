using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted
{
    /// <summary>
    /// </summary>
    public sealed class DistributedRoutingTablePerfDistributedRoutingTable
    {
		public uint AckMessagesReceivedPersecond { get; private set; }
		public uint AckMessagesSentPersecond { get; private set; }
		public uint AdvertiseMessagesReceivedPersecond { get; private set; }
		public uint AdvertiseMessagesSentPersecond { get; private set; }
		public uint AuthorityMessagesReceivedPersecond { get; private set; }
		public uint AuthoritySentPersecond { get; private set; }
		public uint AverageBytesPersecondReceived { get; private set; }
		public uint AverageBytesPersecondSent { get; private set; }
		public uint CacheEntries { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public uint Estimatedcloudsize { get; private set; }
		public uint FloodMessagesReceivedPersecond { get; private set; }
		public uint FloodMessagesSentPersecond { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public uint InquireMessagesReceivedPersecond { get; private set; }
		public uint InquireMessagesSentPersecond { get; private set; }
		public uint LookupMessagesReceivedPersecond { get; private set; }
		public uint LookupMessagesSentPersecond { get; private set; }
		public string Name { get; private set; }
		public uint ReceiveFailures { get; private set; }
		public uint Registrations { get; private set; }
		public uint RequestMessagesReceivedPersecond { get; private set; }
		public uint RequestMessagesSentPersecond { get; private set; }
		public uint Searches { get; private set; }
		public uint SendFailures { get; private set; }
		public uint SolicitMessagesReceivedPersecond { get; private set; }
		public uint SolicitMessagesSentPersecond { get; private set; }
		public uint StaleCacheEntries { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public uint UnrecognizedMessagesReceived { get; private set; }

        public static IEnumerable<DistributedRoutingTablePerfDistributedRoutingTable> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<DistributedRoutingTablePerfDistributedRoutingTable> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<DistributedRoutingTablePerfDistributedRoutingTable> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_DistributedRoutingTablePerf_DistributedRoutingTable");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new DistributedRoutingTablePerfDistributedRoutingTable
                {
                     AckMessagesReceivedPersecond = (uint) (managementObject.Properties["AckMessagesReceivedPersecond"]?.Value ?? default(uint)),
		 AckMessagesSentPersecond = (uint) (managementObject.Properties["AckMessagesSentPersecond"]?.Value ?? default(uint)),
		 AdvertiseMessagesReceivedPersecond = (uint) (managementObject.Properties["AdvertiseMessagesReceivedPersecond"]?.Value ?? default(uint)),
		 AdvertiseMessagesSentPersecond = (uint) (managementObject.Properties["AdvertiseMessagesSentPersecond"]?.Value ?? default(uint)),
		 AuthorityMessagesReceivedPersecond = (uint) (managementObject.Properties["AuthorityMessagesReceivedPersecond"]?.Value ?? default(uint)),
		 AuthoritySentPersecond = (uint) (managementObject.Properties["AuthoritySentPersecond"]?.Value ?? default(uint)),
		 AverageBytesPersecondReceived = (uint) (managementObject.Properties["AverageBytesPersecondReceived"]?.Value ?? default(uint)),
		 AverageBytesPersecondSent = (uint) (managementObject.Properties["AverageBytesPersecondSent"]?.Value ?? default(uint)),
		 CacheEntries = (uint) (managementObject.Properties["CacheEntries"]?.Value ?? default(uint)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 Estimatedcloudsize = (uint) (managementObject.Properties["Estimatedcloudsize"]?.Value ?? default(uint)),
		 FloodMessagesReceivedPersecond = (uint) (managementObject.Properties["FloodMessagesReceivedPersecond"]?.Value ?? default(uint)),
		 FloodMessagesSentPersecond = (uint) (managementObject.Properties["FloodMessagesSentPersecond"]?.Value ?? default(uint)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 InquireMessagesReceivedPersecond = (uint) (managementObject.Properties["InquireMessagesReceivedPersecond"]?.Value ?? default(uint)),
		 InquireMessagesSentPersecond = (uint) (managementObject.Properties["InquireMessagesSentPersecond"]?.Value ?? default(uint)),
		 LookupMessagesReceivedPersecond = (uint) (managementObject.Properties["LookupMessagesReceivedPersecond"]?.Value ?? default(uint)),
		 LookupMessagesSentPersecond = (uint) (managementObject.Properties["LookupMessagesSentPersecond"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 ReceiveFailures = (uint) (managementObject.Properties["ReceiveFailures"]?.Value ?? default(uint)),
		 Registrations = (uint) (managementObject.Properties["Registrations"]?.Value ?? default(uint)),
		 RequestMessagesReceivedPersecond = (uint) (managementObject.Properties["RequestMessagesReceivedPersecond"]?.Value ?? default(uint)),
		 RequestMessagesSentPersecond = (uint) (managementObject.Properties["RequestMessagesSentPersecond"]?.Value ?? default(uint)),
		 Searches = (uint) (managementObject.Properties["Searches"]?.Value ?? default(uint)),
		 SendFailures = (uint) (managementObject.Properties["SendFailures"]?.Value ?? default(uint)),
		 SolicitMessagesReceivedPersecond = (uint) (managementObject.Properties["SolicitMessagesReceivedPersecond"]?.Value ?? default(uint)),
		 SolicitMessagesSentPersecond = (uint) (managementObject.Properties["SolicitMessagesSentPersecond"]?.Value ?? default(uint)),
		 StaleCacheEntries = (uint) (managementObject.Properties["StaleCacheEntries"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 UnrecognizedMessagesReceived = (uint) (managementObject.Properties["UnrecognizedMessagesReceived"]?.Value ?? default(uint))
                };
        }
    }
}