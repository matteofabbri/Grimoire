using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network.Wifi
{
    /// <summary>
    /// </summary>
    public sealed class Statistics
    {
		public ulong AckFailureCount { get; private set; }
		public bool Active { get; private set; }
		public ulong FailedCount { get; private set; }
		public ulong FcsErrorCount { get; private set; }
		public ulong FrameDuplicateCount { get; private set; }
		public string InstanceName { get; private set; }
		public ulong MulticastReceivedFrameCount { get; private set; }
		public ulong MulticastTransmittedFrameCount { get; private set; }
		public ulong MultipleRetryCount { get; private set; }
		public ulong ReceivedFragmentCount { get; private set; }
		public ulong RetryCount { get; private set; }
		public ulong RtsFailureCount { get; private set; }
		public ulong RtsSuccessCount { get; private set; }
		public uint StatisticsLength { get; private set; }
		public ulong TransmittedFragmentCount { get; private set; }

        public static IEnumerable<Statistics> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<Statistics> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<Statistics> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_80211_Statistics");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new Statistics
                {
                     AckFailureCount = (ulong) (managementObject.Properties["ACKFailureCount"]?.Value ?? default(ulong)),
		 Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 FailedCount = (ulong) (managementObject.Properties["FailedCount"]?.Value ?? default(ulong)),
		 FcsErrorCount = (ulong) (managementObject.Properties["FCSErrorCount"]?.Value ?? default(ulong)),
		 FrameDuplicateCount = (ulong) (managementObject.Properties["FrameDuplicateCount"]?.Value ?? default(ulong)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 MulticastReceivedFrameCount = (ulong) (managementObject.Properties["MulticastReceivedFrameCount"]?.Value ?? default(ulong)),
		 MulticastTransmittedFrameCount = (ulong) (managementObject.Properties["MulticastTransmittedFrameCount"]?.Value ?? default(ulong)),
		 MultipleRetryCount = (ulong) (managementObject.Properties["MultipleRetryCount"]?.Value ?? default(ulong)),
		 ReceivedFragmentCount = (ulong) (managementObject.Properties["ReceivedFragmentCount"]?.Value ?? default(ulong)),
		 RetryCount = (ulong) (managementObject.Properties["RetryCount"]?.Value ?? default(ulong)),
		 RtsFailureCount = (ulong) (managementObject.Properties["RTSFailureCount"]?.Value ?? default(ulong)),
		 RtsSuccessCount = (ulong) (managementObject.Properties["RTSSuccessCount"]?.Value ?? default(ulong)),
		 StatisticsLength = (uint) (managementObject.Properties["StatisticsLength"]?.Value ?? default(uint)),
		 TransmittedFragmentCount = (ulong) (managementObject.Properties["TransmittedFragmentCount"]?.Value ?? default(ulong))
                };
        }
    }
}