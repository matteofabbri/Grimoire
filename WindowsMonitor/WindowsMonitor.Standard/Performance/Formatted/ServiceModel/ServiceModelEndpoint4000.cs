using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted.ServiceModel
{
    /// <summary>
    /// </summary>
    public sealed class ServiceModelEndpoint4000
    {
		public uint Calls { get; private set; }
		public uint CallsDuration { get; private set; }
		public uint CallsFailed { get; private set; }
		public uint CallsFailedPerSecond { get; private set; }
		public uint CallsFaulted { get; private set; }
		public uint CallsFaultedPerSecond { get; private set; }
		public uint CallsOutstanding { get; private set; }
		public uint CallsPerSecond { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public uint ReliableMessagingMessagesDropped { get; private set; }
		public uint ReliableMessagingMessagesDroppedPerSecond { get; private set; }
		public uint ReliableMessagingSessionsFaulted { get; private set; }
		public uint ReliableMessagingSessionsFaultedPerSecond { get; private set; }
		public uint SecurityCallsNotAuthorized { get; private set; }
		public uint SecurityCallsNotAuthorizedPerSecond { get; private set; }
		public uint SecurityValidationandAuthenticationFailures { get; private set; }
		public uint SecurityValidationandAuthenticationFailuresPerSecond { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public uint TransactionsFlowed { get; private set; }
		public uint TransactionsFlowedPerSecond { get; private set; }

        public static IEnumerable<ServiceModelEndpoint4000> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ServiceModelEndpoint4000> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ServiceModelEndpoint4000> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_ServiceModel4000_ServiceModelEndpoint4000");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ServiceModelEndpoint4000
                {
                     Calls = (uint) (managementObject.Properties["Calls"]?.Value ?? default(uint)),
		 CallsDuration = (uint) (managementObject.Properties["CallsDuration"]?.Value ?? default(uint)),
		 CallsFailed = (uint) (managementObject.Properties["CallsFailed"]?.Value ?? default(uint)),
		 CallsFailedPerSecond = (uint) (managementObject.Properties["CallsFailedPerSecond"]?.Value ?? default(uint)),
		 CallsFaulted = (uint) (managementObject.Properties["CallsFaulted"]?.Value ?? default(uint)),
		 CallsFaultedPerSecond = (uint) (managementObject.Properties["CallsFaultedPerSecond"]?.Value ?? default(uint)),
		 CallsOutstanding = (uint) (managementObject.Properties["CallsOutstanding"]?.Value ?? default(uint)),
		 CallsPerSecond = (uint) (managementObject.Properties["CallsPerSecond"]?.Value ?? default(uint)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 ReliableMessagingMessagesDropped = (uint) (managementObject.Properties["ReliableMessagingMessagesDropped"]?.Value ?? default(uint)),
		 ReliableMessagingMessagesDroppedPerSecond = (uint) (managementObject.Properties["ReliableMessagingMessagesDroppedPerSecond"]?.Value ?? default(uint)),
		 ReliableMessagingSessionsFaulted = (uint) (managementObject.Properties["ReliableMessagingSessionsFaulted"]?.Value ?? default(uint)),
		 ReliableMessagingSessionsFaultedPerSecond = (uint) (managementObject.Properties["ReliableMessagingSessionsFaultedPerSecond"]?.Value ?? default(uint)),
		 SecurityCallsNotAuthorized = (uint) (managementObject.Properties["SecurityCallsNotAuthorized"]?.Value ?? default(uint)),
		 SecurityCallsNotAuthorizedPerSecond = (uint) (managementObject.Properties["SecurityCallsNotAuthorizedPerSecond"]?.Value ?? default(uint)),
		 SecurityValidationandAuthenticationFailures = (uint) (managementObject.Properties["SecurityValidationandAuthenticationFailures"]?.Value ?? default(uint)),
		 SecurityValidationandAuthenticationFailuresPerSecond = (uint) (managementObject.Properties["SecurityValidationandAuthenticationFailuresPerSecond"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 TransactionsFlowed = (uint) (managementObject.Properties["TransactionsFlowed"]?.Value ?? default(uint)),
		 TransactionsFlowedPerSecond = (uint) (managementObject.Properties["TransactionsFlowedPerSecond"]?.Value ?? default(uint))
                };
        }
    }
}