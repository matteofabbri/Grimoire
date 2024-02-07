using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network.Wifi
{
    /// <summary>
    /// </summary>
    public sealed class WLanBssId
    {
		public dynamic Ndis80211Configuration { get; private set; }
		public dynamic Ndis80211InfrastructureMode { get; private set; }
		public byte[] Ndis80211MacAddress { get; private set; }
		public dynamic Ndis80211NetworkTypeInUse { get; private set; }
		public uint Ndis80211Privacy { get; private set; }
		public uint Ndis80211Rssi { get; private set; }
		public byte[] Ndis80211SsId { get; private set; }
		public uint Ndis80211SsIdLength { get; private set; }
		public byte[] Ndis80211SupportedRate { get; private set; }
		public uint Ndis80211WLanBssIdLength { get; private set; }
		public ushort Reserved { get; private set; }

        public static IEnumerable<WLanBssId> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<WLanBssId> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<WLanBssId> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_80211_WLanBssId");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new WLanBssId
                {
                     Ndis80211Configuration = (dynamic) (managementObject.Properties["Ndis80211Configuration"]?.Value ?? default(dynamic)),
		 Ndis80211InfrastructureMode = (dynamic) (managementObject.Properties["Ndis80211InfrastructureMode"]?.Value ?? default(dynamic)),
		 Ndis80211MacAddress = (byte[]) (managementObject.Properties["Ndis80211MacAddress"]?.Value ?? new byte[0]),
		 Ndis80211NetworkTypeInUse = (dynamic) (managementObject.Properties["Ndis80211NetworkTypeInUse"]?.Value ?? default(dynamic)),
		 Ndis80211Privacy = (uint) (managementObject.Properties["Ndis80211Privacy"]?.Value ?? default(uint)),
		 Ndis80211Rssi = (uint) (managementObject.Properties["Ndis80211Rssi"]?.Value ?? default(uint)),
		 Ndis80211SsId = (byte[]) (managementObject.Properties["Ndis80211SsId"]?.Value ?? new byte[0]),
		 Ndis80211SsIdLength = (uint) (managementObject.Properties["Ndis80211SsIdLength"]?.Value ?? default(uint)),
		 Ndis80211SupportedRate = (byte[]) (managementObject.Properties["Ndis80211SupportedRate"]?.Value ?? new byte[0]),
		 Ndis80211WLanBssIdLength = (uint) (managementObject.Properties["Ndis80211WLanBssIdLength"]?.Value ?? default(uint)),
		 Reserved = (ushort) (managementObject.Properties["Reserved"]?.Value ?? default(ushort))
                };
        }
    }
}