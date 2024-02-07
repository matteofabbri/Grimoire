using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.Network
{
    /// <summary>
    /// </summary>
    public sealed class TcpIpV6
    {
		public string Caption { get; private set; }
		public uint ConnectionFailures { get; private set; }
		public uint ConnectionsActive { get; private set; }
		public uint ConnectionsEstablished { get; private set; }
		public uint ConnectionsPassive { get; private set; }
		public uint ConnectionsReset { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public uint SegmentsPersec { get; private set; }
		public uint SegmentsReceivedPersec { get; private set; }
		public uint SegmentsRetransmittedPersec { get; private set; }
		public uint SegmentsSentPersec { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<TcpIpV6> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<TcpIpV6> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<TcpIpV6> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_Tcpip_TCPv6");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new TcpIpV6
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 ConnectionFailures = (uint) (managementObject.Properties["ConnectionFailures"]?.Value ?? default(uint)),
		 ConnectionsActive = (uint) (managementObject.Properties["ConnectionsActive"]?.Value ?? default(uint)),
		 ConnectionsEstablished = (uint) (managementObject.Properties["ConnectionsEstablished"]?.Value ?? default(uint)),
		 ConnectionsPassive = (uint) (managementObject.Properties["ConnectionsPassive"]?.Value ?? default(uint)),
		 ConnectionsReset = (uint) (managementObject.Properties["ConnectionsReset"]?.Value ?? default(uint)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 SegmentsPersec = (uint) (managementObject.Properties["SegmentsPersec"]?.Value ?? default(uint)),
		 SegmentsReceivedPersec = (uint) (managementObject.Properties["SegmentsReceivedPersec"]?.Value ?? default(uint)),
		 SegmentsRetransmittedPersec = (uint) (managementObject.Properties["SegmentsRetransmittedPersec"]?.Value ?? default(uint)),
		 SegmentsSentPersec = (uint) (managementObject.Properties["SegmentsSentPersec"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}