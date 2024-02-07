using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.Network.Http
{
    /// <summary>
    /// </summary>
    public sealed class CountersIphttpsSession
    {
		public ulong Bytesreceivedonthissession { get; private set; }
		public ulong Bytessentonthissession { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong DurationDurationofthesessionSeconds { get; private set; }
		public ulong ErrorsReceiveerrorsonthissession { get; private set; }
		public ulong ErrorsTransmiterrorsonthissession { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public ulong Packetsreceivedonthissession { get; private set; }
		public ulong Packetssentonthissession { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<CountersIphttpsSession> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<CountersIphttpsSession> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<CountersIphttpsSession> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_Counters_IPHTTPSSession");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new CountersIphttpsSession
                {
                     Bytesreceivedonthissession = (ulong) (managementObject.Properties["Bytesreceivedonthissession"]?.Value ?? default(ulong)),
		 Bytessentonthissession = (ulong) (managementObject.Properties["Bytessentonthissession"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DurationDurationofthesessionSeconds = (ulong) (managementObject.Properties["DurationDurationofthesessionSeconds"]?.Value ?? default(ulong)),
		 ErrorsReceiveerrorsonthissession = (ulong) (managementObject.Properties["ErrorsReceiveerrorsonthissession"]?.Value ?? default(ulong)),
		 ErrorsTransmiterrorsonthissession = (ulong) (managementObject.Properties["ErrorsTransmiterrorsonthissession"]?.Value ?? default(ulong)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 Packetsreceivedonthissession = (ulong) (managementObject.Properties["Packetsreceivedonthissession"]?.Value ?? default(ulong)),
		 Packetssentonthissession = (ulong) (managementObject.Properties["Packetssentonthissession"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}