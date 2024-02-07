using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw
{
    /// <summary>
    /// </summary>
    public sealed class Wasw3WpCounterProviderWasw3Wp
    {
		public uint ActiveListenerChannels { get; private set; }
		public uint ActiveProtocolHandlers { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public ulong HealthPingReplyLatency { get; private set; }
		public string Name { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public uint TotalHealthPings { get; private set; }
		public uint TotalMessagesSenttoWas { get; private set; }
		public uint TotalRequestsServed { get; private set; }
		public uint TotalRuntimeStatusQueries { get; private set; }
		public uint TotalWasMessagesReceived { get; private set; }

        public static IEnumerable<Wasw3WpCounterProviderWasw3Wp> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<Wasw3WpCounterProviderWasw3Wp> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<Wasw3WpCounterProviderWasw3Wp> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_WASW3WPCounterProvider_WASW3WP");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new Wasw3WpCounterProviderWasw3Wp
                {
                     ActiveListenerChannels = (uint) (managementObject.Properties["ActiveListenerChannels"]?.Value ?? default(uint)),
		 ActiveProtocolHandlers = (uint) (managementObject.Properties["ActiveProtocolHandlers"]?.Value ?? default(uint)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 HealthPingReplyLatency = (ulong) (managementObject.Properties["HealthPingReplyLatency"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 TotalHealthPings = (uint) (managementObject.Properties["TotalHealthPings"]?.Value ?? default(uint)),
		 TotalMessagesSenttoWas = (uint) (managementObject.Properties["TotalMessagesSenttoWAS"]?.Value ?? default(uint)),
		 TotalRequestsServed = (uint) (managementObject.Properties["TotalRequestsServed"]?.Value ?? default(uint)),
		 TotalRuntimeStatusQueries = (uint) (managementObject.Properties["TotalRuntimeStatusQueries"]?.Value ?? default(uint)),
		 TotalWasMessagesReceived = (uint) (managementObject.Properties["TotalWASMessagesReceived"]?.Value ?? default(uint))
                };
        }
    }
}