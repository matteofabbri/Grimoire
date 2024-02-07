using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.DotNet
{
    /// <summary>
    /// </summary>
    public sealed class NetclrNetworking4000NetclrNetworking4000
    {
		public ulong BytesReceived { get; private set; }
		public ulong BytesSent { get; private set; }
		public string Caption { get; private set; }
		public uint ConnectionsEstablished { get; private set; }
		public uint DatagramsReceived { get; private set; }
		public uint DatagramsSent { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public uint HttpWebRequestsAbortedPerSec { get; private set; }
		public ulong HttpWebRequestsAverageLifetime { get; private set; }
		public uint HttpWebRequestsAverageLifetimeBase { get; private set; }
		public ulong HttpWebRequestsAverageQueueTime { get; private set; }
		public uint HttpWebRequestsAverageQueueTimeBase { get; private set; }
		public uint HttpWebRequestsCreatedPerSec { get; private set; }
		public uint HttpWebRequestsFailedPerSec { get; private set; }
		public uint HttpWebRequestsQueuedPerSec { get; private set; }
		public string Name { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<NetclrNetworking4000NetclrNetworking4000> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<NetclrNetworking4000NetclrNetworking4000> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<NetclrNetworking4000NetclrNetworking4000> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_NETCLRNetworking4000_NETCLRNetworking4000");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new NetclrNetworking4000NetclrNetworking4000
                {
                     BytesReceived = (ulong) (managementObject.Properties["BytesReceived"]?.Value ?? default(ulong)),
		 BytesSent = (ulong) (managementObject.Properties["BytesSent"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 ConnectionsEstablished = (uint) (managementObject.Properties["ConnectionsEstablished"]?.Value ?? default(uint)),
		 DatagramsReceived = (uint) (managementObject.Properties["DatagramsReceived"]?.Value ?? default(uint)),
		 DatagramsSent = (uint) (managementObject.Properties["DatagramsSent"]?.Value ?? default(uint)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 HttpWebRequestsAbortedPerSec = (uint) (managementObject.Properties["HttpWebRequestsAbortedPerSec"]?.Value ?? default(uint)),
		 HttpWebRequestsAverageLifetime = (ulong) (managementObject.Properties["HttpWebRequestsAverageLifetime"]?.Value ?? default(ulong)),
		 HttpWebRequestsAverageLifetimeBase = (uint) (managementObject.Properties["HttpWebRequestsAverageLifetime_Base"]?.Value ?? default(uint)),
		 HttpWebRequestsAverageQueueTime = (ulong) (managementObject.Properties["HttpWebRequestsAverageQueueTime"]?.Value ?? default(ulong)),
		 HttpWebRequestsAverageQueueTimeBase = (uint) (managementObject.Properties["HttpWebRequestsAverageQueueTime_Base"]?.Value ?? default(uint)),
		 HttpWebRequestsCreatedPerSec = (uint) (managementObject.Properties["HttpWebRequestsCreatedPerSec"]?.Value ?? default(uint)),
		 HttpWebRequestsFailedPerSec = (uint) (managementObject.Properties["HttpWebRequestsFailedPerSec"]?.Value ?? default(uint)),
		 HttpWebRequestsQueuedPerSec = (uint) (managementObject.Properties["HttpWebRequestsQueuedPerSec"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}