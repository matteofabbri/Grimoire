using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted
{
    /// <summary>
    /// </summary>
    public sealed class BitLockerDriverCountersProvider
    {
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public uint MaxReadSplitSize { get; private set; }
		public uint MaxWriteSplitSize { get; private set; }
		public uint MinReadSplitSize { get; private set; }
		public uint MinWriteSplitSize { get; private set; }
		public string Name { get; private set; }
		public ulong ReadRequestsPersec { get; private set; }
		public ulong ReadSubrequestsPersec { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public ulong WriteRequestsPersec { get; private set; }
		public ulong WriteSubrequestsPersec { get; private set; }

        public static IEnumerable<BitLockerDriverCountersProvider> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<BitLockerDriverCountersProvider> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<BitLockerDriverCountersProvider> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_MicrosoftWindowsBitLockerDriverCountersProvider_BitLocker");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new BitLockerDriverCountersProvider
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 MaxReadSplitSize = (uint) (managementObject.Properties["MaxReadSplitSize"]?.Value ?? default(uint)),
		 MaxWriteSplitSize = (uint) (managementObject.Properties["MaxWriteSplitSize"]?.Value ?? default(uint)),
		 MinReadSplitSize = (uint) (managementObject.Properties["MinReadSplitSize"]?.Value ?? default(uint)),
		 MinWriteSplitSize = (uint) (managementObject.Properties["MinWriteSplitSize"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 ReadRequestsPersec = (ulong) (managementObject.Properties["ReadRequestsPersec"]?.Value ?? default(ulong)),
		 ReadSubrequestsPersec = (ulong) (managementObject.Properties["ReadSubrequestsPersec"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 WriteRequestsPersec = (ulong) (managementObject.Properties["WriteRequestsPersec"]?.Value ?? default(ulong)),
		 WriteSubrequestsPersec = (ulong) (managementObject.Properties["WriteSubrequestsPersec"]?.Value ?? default(ulong))
                };
        }
    }
}