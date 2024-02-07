using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw
{
    /// <summary>
    /// </summary>
    public sealed class XhciTransferRing
    {
		public uint BytesPerSec { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public uint FailedTransferCount { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public uint IsochTdFailuresPersec { get; private set; }
		public uint IsochTdPersec { get; private set; }
		public uint MissedServiceErrorCount { get; private set; }
		public string Name { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public uint TransfersPersec { get; private set; }
		public uint UnderrunOverruncount { get; private set; }

        public static IEnumerable<XhciTransferRing> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<XhciTransferRing> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<XhciTransferRing> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_Counters_XHCITransferRing");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new XhciTransferRing
                {
                     BytesPerSec = (uint) (managementObject.Properties["BytesPerSec"]?.Value ?? default(uint)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FailedTransferCount = (uint) (managementObject.Properties["FailedTransferCount"]?.Value ?? default(uint)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 IsochTdFailuresPersec = (uint) (managementObject.Properties["IsochTDFailuresPersec"]?.Value ?? default(uint)),
		 IsochTdPersec = (uint) (managementObject.Properties["IsochTDPersec"]?.Value ?? default(uint)),
		 MissedServiceErrorCount = (uint) (managementObject.Properties["MissedServiceErrorCount"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 TransfersPersec = (uint) (managementObject.Properties["TransfersPersec"]?.Value ?? default(uint)),
		 UnderrunOverruncount = (uint) (managementObject.Properties["UnderrunOverruncount"]?.Value ?? default(uint))
                };
        }
    }
}