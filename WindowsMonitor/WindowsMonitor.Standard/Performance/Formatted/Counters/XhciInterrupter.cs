using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted.Counters
{
    /// <summary>
    /// </summary>
    public sealed class XhciInterrupter
    {
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public uint DpcRequeueCount { get; private set; }
		public uint DpCsPersec { get; private set; }
		public uint EventRingFullCount { get; private set; }
		public ulong EventsprocessedDpc { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public uint InterruptsPersec { get; private set; }
		public string Name { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<XhciInterrupter> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<XhciInterrupter> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<XhciInterrupter> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_Counters_XHCIInterrupter");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new XhciInterrupter
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DpcRequeueCount = (uint) (managementObject.Properties["DpcRequeueCount"]?.Value ?? default(uint)),
		 DpCsPersec = (uint) (managementObject.Properties["DPCsPersec"]?.Value ?? default(uint)),
		 EventRingFullCount = (uint) (managementObject.Properties["EventRingFullCount"]?.Value ?? default(uint)),
		 EventsprocessedDpc = (ulong) (managementObject.Properties["EventsprocessedDPC"]?.Value ?? default(ulong)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 InterruptsPersec = (uint) (managementObject.Properties["InterruptsPersec"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}