using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted.Network.Smb
{
    /// <summary>
    /// </summary>
    public sealed class CountersSmbServer
    {
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public ulong ReadBytesPersec { get; private set; }
		public ulong ReadRequestsPersec { get; private set; }
		public ulong ReceiveBytesPersec { get; private set; }
		public ulong SendBytesPersec { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public ulong WriteBytesPersec { get; private set; }
		public ulong WriteRequestsPersec { get; private set; }

        public static IEnumerable<CountersSmbServer> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<CountersSmbServer> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<CountersSmbServer> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_Counters_SMBServer");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new CountersSmbServer
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 ReadBytesPersec = (ulong) (managementObject.Properties["ReadBytesPersec"]?.Value ?? default(ulong)),
		 ReadRequestsPersec = (ulong) (managementObject.Properties["ReadRequestsPersec"]?.Value ?? default(ulong)),
		 ReceiveBytesPersec = (ulong) (managementObject.Properties["ReceiveBytesPersec"]?.Value ?? default(ulong)),
		 SendBytesPersec = (ulong) (managementObject.Properties["SendBytesPersec"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 WriteBytesPersec = (ulong) (managementObject.Properties["WriteBytesPersec"]?.Value ?? default(ulong)),
		 WriteRequestsPersec = (ulong) (managementObject.Properties["WriteRequestsPersec"]?.Value ?? default(ulong))
                };
        }
    }
}