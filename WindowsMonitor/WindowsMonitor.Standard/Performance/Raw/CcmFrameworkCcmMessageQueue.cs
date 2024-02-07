using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw
{
    /// <summary>
    /// </summary>
    public sealed class CcmFrameworkCcmMessageQueue
    {
		public ulong BytesQueued { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public ulong MessagesCompleted { get; private set; }
		public uint MessagesCompletedPersecond { get; private set; }
		public ulong MessagesQueued { get; private set; }
		public ulong MessagesReceived { get; private set; }
		public uint MessagesReceivedPersecond { get; private set; }
		public string Name { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<CcmFrameworkCcmMessageQueue> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<CcmFrameworkCcmMessageQueue> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<CcmFrameworkCcmMessageQueue> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_CcmFramework_CCMMessageQueue");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new CcmFrameworkCcmMessageQueue
                {
                     BytesQueued = (ulong) (managementObject.Properties["BytesQueued"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 MessagesCompleted = (ulong) (managementObject.Properties["MessagesCompleted"]?.Value ?? default(ulong)),
		 MessagesCompletedPersecond = (uint) (managementObject.Properties["MessagesCompletedPersecond"]?.Value ?? default(uint)),
		 MessagesQueued = (ulong) (managementObject.Properties["MessagesQueued"]?.Value ?? default(ulong)),
		 MessagesReceived = (ulong) (managementObject.Properties["MessagesReceived"]?.Value ?? default(ulong)),
		 MessagesReceivedPersecond = (uint) (managementObject.Properties["MessagesReceivedPersecond"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}