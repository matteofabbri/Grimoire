using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw
{
    /// <summary>
    /// </summary>
    public sealed class MicrosoftWindowsW32TimePerfWindowsTimeService
    {
		public string Caption { get; private set; }
		public uint ClockFrequencyAdjustment { get; private set; }
		public ulong ComputedTimeOffset { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public uint NtpClientTimeSourceCount { get; private set; }
		public uint NtpRoundtripDelay { get; private set; }
		public ulong NtpServerIncomingRequests { get; private set; }
		public ulong NtpServerOutgoingResponses { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<MicrosoftWindowsW32TimePerfWindowsTimeService> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<MicrosoftWindowsW32TimePerfWindowsTimeService> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<MicrosoftWindowsW32TimePerfWindowsTimeService> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_MicrosoftWindowsW32TimePerf_WindowsTimeService");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new MicrosoftWindowsW32TimePerfWindowsTimeService
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 ClockFrequencyAdjustment = (uint) (managementObject.Properties["ClockFrequencyAdjustment"]?.Value ?? default(uint)),
		 ComputedTimeOffset = (ulong) (managementObject.Properties["ComputedTimeOffset"]?.Value ?? default(ulong)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 NtpClientTimeSourceCount = (uint) (managementObject.Properties["NTPClientTimeSourceCount"]?.Value ?? default(uint)),
		 NtpRoundtripDelay = (uint) (managementObject.Properties["NTPRoundtripDelay"]?.Value ?? default(uint)),
		 NtpServerIncomingRequests = (ulong) (managementObject.Properties["NTPServerIncomingRequests"]?.Value ?? default(ulong)),
		 NtpServerOutgoingResponses = (ulong) (managementObject.Properties["NTPServerOutgoingResponses"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}