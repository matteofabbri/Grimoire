using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.Counters
{
    /// <summary>
    /// </summary>
    public sealed class NetworkQoSPolicy
    {
		public ulong Bytestransmitted { get; private set; }
		public ulong BytestransmittedPersec { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public uint Packetsdropped { get; private set; }
		public uint PacketsdroppedPersec { get; private set; }
		public uint Packetstransmitted { get; private set; }
		public uint PacketstransmittedPersec { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<NetworkQoSPolicy> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<NetworkQoSPolicy> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<NetworkQoSPolicy> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_Counters_NetworkQoSPolicy");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new NetworkQoSPolicy
                {
                     Bytestransmitted = (ulong) (managementObject.Properties["Bytestransmitted"]?.Value ?? default(ulong)),
		 BytestransmittedPersec = (ulong) (managementObject.Properties["BytestransmittedPersec"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 Packetsdropped = (uint) (managementObject.Properties["Packetsdropped"]?.Value ?? default(uint)),
		 PacketsdroppedPersec = (uint) (managementObject.Properties["PacketsdroppedPersec"]?.Value ?? default(uint)),
		 Packetstransmitted = (uint) (managementObject.Properties["Packetstransmitted"]?.Value ?? default(uint)),
		 PacketstransmittedPersec = (uint) (managementObject.Properties["PacketstransmittedPersec"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}