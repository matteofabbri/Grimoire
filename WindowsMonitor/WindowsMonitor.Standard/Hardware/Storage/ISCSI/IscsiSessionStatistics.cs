using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.ISCSI
{
    /// <summary>
    /// </summary>
    public sealed class IscsiSessionStatistics
    {
		public bool Active { get; private set; }
		public ulong BytesReceived { get; private set; }
		public ulong BytesSent { get; private set; }
		public string Caption { get; private set; }
		public ulong ConnectionTimeoutErrors { get; private set; }
		public string Description { get; private set; }
		public ulong DigestErrors { get; private set; }
		public ulong FormatErrors { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string InstanceName { get; private set; }
		public string IScsiName { get; private set; }
		public string Name { get; private set; }
		public ulong PduCommandsSent { get; private set; }
		public ulong PduResponsesReceived { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public ulong UniqueAdapterId { get; private set; }
		public ulong Usid { get; private set; }

        public static IEnumerable<IscsiSessionStatistics> Retrieve(string remote, string username, string password)
        {
            var options = new ConnectionOptions
            {
                Impersonation = ImpersonationLevel.Impersonate,
                Username = username,
                Password = password
            };

            var managementScope = new ManagementScope(new ManagementPath($"\\\\{remote}\\root\\wmi"), options);
            managementScope.Connect();

            return Retrieve(managementScope);
        }

        public static IEnumerable<IscsiSessionStatistics> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<IscsiSessionStatistics> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSiSCSI_SessionStatistics");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new IscsiSessionStatistics
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 BytesReceived = (ulong) (managementObject.Properties["BytesReceived"]?.Value ?? default(ulong)),
		 BytesSent = (ulong) (managementObject.Properties["BytesSent"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value ?? default(string)),
		 ConnectionTimeoutErrors = (ulong) (managementObject.Properties["ConnectionTimeoutErrors"]?.Value ?? default(ulong)),
		 Description = (string) (managementObject.Properties["Description"]?.Value ?? default(string)),
		 DigestErrors = (ulong) (managementObject.Properties["DigestErrors"]?.Value ?? default(ulong)),
		 FormatErrors = (ulong) (managementObject.Properties["FormatErrors"]?.Value ?? default(ulong)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 IScsiName = (string) (managementObject.Properties["iSCSIName"]?.Value ?? default(string)),
		 Name = (string) (managementObject.Properties["Name"]?.Value ?? default(string)),
		 PduCommandsSent = (ulong) (managementObject.Properties["PDUCommandsSent"]?.Value ?? default(ulong)),
		 PduResponsesReceived = (ulong) (managementObject.Properties["PDUResponsesReceived"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 UniqueAdapterId = (ulong) (managementObject.Properties["UniqueAdapterId"]?.Value ?? default(ulong)),
		 Usid = (ulong) (managementObject.Properties["USID"]?.Value ?? default(ulong))
                };
        }
    }
}