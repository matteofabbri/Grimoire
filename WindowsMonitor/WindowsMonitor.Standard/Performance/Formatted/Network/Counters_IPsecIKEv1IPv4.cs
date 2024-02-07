using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted.Network
{
    /// <summary>
    /// </summary>
    public sealed class CountersIPsecIkEv1IPv4
    {
		public uint ActiveMainModeSAs { get; private set; }
		public uint ActiveQuickModeSAs { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public uint FailedMainModeNegotiations { get; private set; }
		public uint FailedMainModeNegotiationsPersec { get; private set; }
		public uint FailedQuickModeNegotiations { get; private set; }
		public uint FailedQuickModeNegotiationsPersec { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public uint MainModeNegotiationRequestsReceived { get; private set; }
		public uint MainModeNegotiationRequestsReceivedPersec { get; private set; }
		public uint MainModeNegotiations { get; private set; }
		public uint MainModeNegotiationsPersec { get; private set; }
		public string Name { get; private set; }
		public uint PendingMainModeNegotiations { get; private set; }
		public uint PendingQuickModeNegotiations { get; private set; }
		public uint QuickModeNegotiations { get; private set; }
		public uint QuickModeNegotiationsPersec { get; private set; }
		public uint SuccessfulMainModeNegotiations { get; private set; }
		public uint SuccessfulMainModeNegotiationsPersec { get; private set; }
		public uint SuccessfulQuickModeNegotiations { get; private set; }
		public uint SuccessfulQuickModeNegotiationsPersec { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<CountersIPsecIkEv1IPv4> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<CountersIPsecIkEv1IPv4> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<CountersIPsecIkEv1IPv4> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_Counters_IPsecIKEv1IPv4");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new CountersIPsecIkEv1IPv4
                {
                     ActiveMainModeSAs = (uint) (managementObject.Properties["ActiveMainModeSAs"]?.Value ?? default(uint)),
		 ActiveQuickModeSAs = (uint) (managementObject.Properties["ActiveQuickModeSAs"]?.Value ?? default(uint)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FailedMainModeNegotiations = (uint) (managementObject.Properties["FailedMainModeNegotiations"]?.Value ?? default(uint)),
		 FailedMainModeNegotiationsPersec = (uint) (managementObject.Properties["FailedMainModeNegotiationsPersec"]?.Value ?? default(uint)),
		 FailedQuickModeNegotiations = (uint) (managementObject.Properties["FailedQuickModeNegotiations"]?.Value ?? default(uint)),
		 FailedQuickModeNegotiationsPersec = (uint) (managementObject.Properties["FailedQuickModeNegotiationsPersec"]?.Value ?? default(uint)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 MainModeNegotiationRequestsReceived = (uint) (managementObject.Properties["MainModeNegotiationRequestsReceived"]?.Value ?? default(uint)),
		 MainModeNegotiationRequestsReceivedPersec = (uint) (managementObject.Properties["MainModeNegotiationRequestsReceivedPersec"]?.Value ?? default(uint)),
		 MainModeNegotiations = (uint) (managementObject.Properties["MainModeNegotiations"]?.Value ?? default(uint)),
		 MainModeNegotiationsPersec = (uint) (managementObject.Properties["MainModeNegotiationsPersec"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 PendingMainModeNegotiations = (uint) (managementObject.Properties["PendingMainModeNegotiations"]?.Value ?? default(uint)),
		 PendingQuickModeNegotiations = (uint) (managementObject.Properties["PendingQuickModeNegotiations"]?.Value ?? default(uint)),
		 QuickModeNegotiations = (uint) (managementObject.Properties["QuickModeNegotiations"]?.Value ?? default(uint)),
		 QuickModeNegotiationsPersec = (uint) (managementObject.Properties["QuickModeNegotiationsPersec"]?.Value ?? default(uint)),
		 SuccessfulMainModeNegotiations = (uint) (managementObject.Properties["SuccessfulMainModeNegotiations"]?.Value ?? default(uint)),
		 SuccessfulMainModeNegotiationsPersec = (uint) (managementObject.Properties["SuccessfulMainModeNegotiationsPersec"]?.Value ?? default(uint)),
		 SuccessfulQuickModeNegotiations = (uint) (managementObject.Properties["SuccessfulQuickModeNegotiations"]?.Value ?? default(uint)),
		 SuccessfulQuickModeNegotiationsPersec = (uint) (managementObject.Properties["SuccessfulQuickModeNegotiationsPersec"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}