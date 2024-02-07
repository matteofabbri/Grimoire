using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network
{
    /// <summary>
    /// </summary>
    public sealed class StatisticsInfo
    {
		public dynamic Header { get; private set; }
		public ulong IfHcInBroadcastOctets { get; private set; }
		public ulong IfHcInBroadcastPkts { get; private set; }
		public ulong IfHcInMulticastOctets { get; private set; }
		public ulong IfHcInMulticastPkts { get; private set; }
		public ulong IfHcInOctets { get; private set; }
		public ulong IfHcInUcastOctets { get; private set; }
		public ulong IfHcInUcastPkts { get; private set; }
		public ulong IfHcOutBroadcastOctets { get; private set; }
		public ulong IfHcOutBroadcastPkts { get; private set; }
		public ulong IfHcOutMulticastOctets { get; private set; }
		public ulong IfHcOutMulticastPkts { get; private set; }
		public ulong IfHcOutOctets { get; private set; }
		public ulong IfHcOutUcastOctets { get; private set; }
		public ulong IfHcOutUcastPkts { get; private set; }
		public ulong IfInDiscards { get; private set; }
		public ulong IfInErrors { get; private set; }
		public ulong IfOutDiscards { get; private set; }
		public ulong IfOutErrors { get; private set; }
		public uint SupportedStatistics { get; private set; }

        public static IEnumerable<StatisticsInfo> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<StatisticsInfo> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<StatisticsInfo> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_StatisticsInfo");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new StatisticsInfo
                {
                     Header = (dynamic) (managementObject.Properties["Header"]?.Value ?? default(dynamic)),
		 IfHcInBroadcastOctets = (ulong) (managementObject.Properties["ifHCInBroadcastOctets"]?.Value ?? default(ulong)),
		 IfHcInBroadcastPkts = (ulong) (managementObject.Properties["ifHCInBroadcastPkts"]?.Value ?? default(ulong)),
		 IfHcInMulticastOctets = (ulong) (managementObject.Properties["ifHCInMulticastOctets"]?.Value ?? default(ulong)),
		 IfHcInMulticastPkts = (ulong) (managementObject.Properties["ifHCInMulticastPkts"]?.Value ?? default(ulong)),
		 IfHcInOctets = (ulong) (managementObject.Properties["ifHCInOctets"]?.Value ?? default(ulong)),
		 IfHcInUcastOctets = (ulong) (managementObject.Properties["ifHCInUcastOctets"]?.Value ?? default(ulong)),
		 IfHcInUcastPkts = (ulong) (managementObject.Properties["ifHCInUcastPkts"]?.Value ?? default(ulong)),
		 IfHcOutBroadcastOctets = (ulong) (managementObject.Properties["ifHCOutBroadcastOctets"]?.Value ?? default(ulong)),
		 IfHcOutBroadcastPkts = (ulong) (managementObject.Properties["ifHCOutBroadcastPkts"]?.Value ?? default(ulong)),
		 IfHcOutMulticastOctets = (ulong) (managementObject.Properties["ifHCOutMulticastOctets"]?.Value ?? default(ulong)),
		 IfHcOutMulticastPkts = (ulong) (managementObject.Properties["ifHCOutMulticastPkts"]?.Value ?? default(ulong)),
		 IfHcOutOctets = (ulong) (managementObject.Properties["ifHCOutOctets"]?.Value ?? default(ulong)),
		 IfHcOutUcastOctets = (ulong) (managementObject.Properties["ifHCOutUcastOctets"]?.Value ?? default(ulong)),
		 IfHcOutUcastPkts = (ulong) (managementObject.Properties["ifHCOutUcastPkts"]?.Value ?? default(ulong)),
		 IfInDiscards = (ulong) (managementObject.Properties["ifInDiscards"]?.Value ?? default(ulong)),
		 IfInErrors = (ulong) (managementObject.Properties["ifInErrors"]?.Value ?? default(ulong)),
		 IfOutDiscards = (ulong) (managementObject.Properties["ifOutDiscards"]?.Value ?? default(ulong)),
		 IfOutErrors = (ulong) (managementObject.Properties["ifOutErrors"]?.Value ?? default(ulong)),
		 SupportedStatistics = (uint) (managementObject.Properties["SupportedStatistics"]?.Value ?? default(uint))
                };
        }
    }
}