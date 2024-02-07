using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted.Network
{
    /// <summary>
    /// </summary>
    public sealed class TcpipUdPv4
    {
		public string Caption { get; private set; }
		public uint DatagramsNoPortPersec { get; private set; }
		public uint DatagramsPersec { get; private set; }
		public uint DatagramsReceivedErrors { get; private set; }
		public uint DatagramsReceivedPersec { get; private set; }
		public uint DatagramsSentPersec { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<TcpipUdPv4> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<TcpipUdPv4> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<TcpipUdPv4> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_Tcpip_UDPv4");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new TcpipUdPv4
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 DatagramsNoPortPersec = (uint) (managementObject.Properties["DatagramsNoPortPersec"]?.Value ?? default(uint)),
		 DatagramsPersec = (uint) (managementObject.Properties["DatagramsPersec"]?.Value ?? default(uint)),
		 DatagramsReceivedErrors = (uint) (managementObject.Properties["DatagramsReceivedErrors"]?.Value ?? default(uint)),
		 DatagramsReceivedPersec = (uint) (managementObject.Properties["DatagramsReceivedPersec"]?.Value ?? default(uint)),
		 DatagramsSentPersec = (uint) (managementObject.Properties["DatagramsSentPersec"]?.Value ?? default(uint)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}