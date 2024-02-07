using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.Counters
{
    /// <summary>
    /// </summary>
    public sealed class PacerPipe
    {
		public uint Averagepacketsinnetcard { get; private set; }
		public uint Averagepacketsinsequencer { get; private set; }
		public uint Averagepacketsinshaper { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public uint Flowmodsrejected { get; private set; }
		public uint Flowsclosed { get; private set; }
		public uint Flowsmodified { get; private set; }
		public uint Flowsopened { get; private set; }
		public uint Flowsrejected { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public uint Maxpacketsinnetcard { get; private set; }
		public uint Maxpacketsinsequencer { get; private set; }
		public uint Maxpacketsinshaper { get; private set; }
		public uint Maxsimultaneousflows { get; private set; }
		public string Name { get; private set; }
		public uint Nonconformingpacketsscheduled { get; private set; }
		public uint NonconformingpacketsscheduledPersec { get; private set; }
		public uint Nonconformingpacketstransmitted { get; private set; }
		public uint NonconformingpacketstransmittedPersec { get; private set; }
		public uint Outofpackets { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<PacerPipe> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<PacerPipe> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<PacerPipe> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_Counters_PacerPipe");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new PacerPipe
                {
                     Averagepacketsinnetcard = (uint) (managementObject.Properties["Averagepacketsinnetcard"]?.Value ?? default(uint)),
		 Averagepacketsinsequencer = (uint) (managementObject.Properties["Averagepacketsinsequencer"]?.Value ?? default(uint)),
		 Averagepacketsinshaper = (uint) (managementObject.Properties["Averagepacketsinshaper"]?.Value ?? default(uint)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 Flowmodsrejected = (uint) (managementObject.Properties["Flowmodsrejected"]?.Value ?? default(uint)),
		 Flowsclosed = (uint) (managementObject.Properties["Flowsclosed"]?.Value ?? default(uint)),
		 Flowsmodified = (uint) (managementObject.Properties["Flowsmodified"]?.Value ?? default(uint)),
		 Flowsopened = (uint) (managementObject.Properties["Flowsopened"]?.Value ?? default(uint)),
		 Flowsrejected = (uint) (managementObject.Properties["Flowsrejected"]?.Value ?? default(uint)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Maxpacketsinnetcard = (uint) (managementObject.Properties["Maxpacketsinnetcard"]?.Value ?? default(uint)),
		 Maxpacketsinsequencer = (uint) (managementObject.Properties["Maxpacketsinsequencer"]?.Value ?? default(uint)),
		 Maxpacketsinshaper = (uint) (managementObject.Properties["Maxpacketsinshaper"]?.Value ?? default(uint)),
		 Maxsimultaneousflows = (uint) (managementObject.Properties["Maxsimultaneousflows"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 Nonconformingpacketsscheduled = (uint) (managementObject.Properties["Nonconformingpacketsscheduled"]?.Value ?? default(uint)),
		 NonconformingpacketsscheduledPersec = (uint) (managementObject.Properties["NonconformingpacketsscheduledPersec"]?.Value ?? default(uint)),
		 Nonconformingpacketstransmitted = (uint) (managementObject.Properties["Nonconformingpacketstransmitted"]?.Value ?? default(uint)),
		 NonconformingpacketstransmittedPersec = (uint) (managementObject.Properties["NonconformingpacketstransmittedPersec"]?.Value ?? default(uint)),
		 Outofpackets = (uint) (managementObject.Properties["Outofpackets"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}