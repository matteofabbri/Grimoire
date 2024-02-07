using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network
{
    /// <summary>
    /// </summary>
    public sealed class PmCapabilitiesParam
    {
		public dynamic DeviceSleepOnDisconnect { get; private set; }
		public dynamic Header { get; private set; }
		public dynamic PmarpOffload { get; private set; }
		public dynamic PmndOffload { get; private set; }
		public dynamic PmWiFiRekeyOffload { get; private set; }
		public dynamic WakeOnMagicPacket { get; private set; }
		public dynamic WakeOnPattern { get; private set; }

        public static IEnumerable<PmCapabilitiesParam> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<PmCapabilitiesParam> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<PmCapabilitiesParam> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_PMCapabilitiesParam");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new PmCapabilitiesParam
                {
                     DeviceSleepOnDisconnect = (dynamic) (managementObject.Properties["DeviceSleepOnDisconnect"]?.Value ?? default(dynamic)),
		 Header = (dynamic) (managementObject.Properties["Header"]?.Value ?? default(dynamic)),
		 PmarpOffload = (dynamic) (managementObject.Properties["PMARPOffload"]?.Value ?? default(dynamic)),
		 PmndOffload = (dynamic) (managementObject.Properties["PMNDOffload"]?.Value ?? default(dynamic)),
		 PmWiFiRekeyOffload = (dynamic) (managementObject.Properties["PMWiFiRekeyOffload"]?.Value ?? default(dynamic)),
		 WakeOnMagicPacket = (dynamic) (managementObject.Properties["WakeOnMagicPacket"]?.Value ?? default(dynamic)),
		 WakeOnPattern = (dynamic) (managementObject.Properties["WakeOnPattern"]?.Value ?? default(dynamic))
                };
        }
    }
}