using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network
{
    /// <summary>
    /// </summary>
    public sealed class LinkStateData
    {
		public uint AutoNegotiationFlags { get; private set; }
		public dynamic Header { get; private set; }
		public uint MediaConnectState { get; private set; }
		public uint MediaDuplexState { get; private set; }
		public uint PauseFunctions { get; private set; }
		public ulong RcvLinkSpeed { get; private set; }
		public ulong XmitLinkSpeed { get; private set; }

        public static IEnumerable<LinkStateData> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<LinkStateData> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<LinkStateData> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_LinkStateData");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new LinkStateData
                {
                     AutoNegotiationFlags = (uint) (managementObject.Properties["AutoNegotiationFlags"]?.Value ?? default(uint)),
		 Header = (dynamic) (managementObject.Properties["Header"]?.Value ?? default(dynamic)),
		 MediaConnectState = (uint) (managementObject.Properties["MediaConnectState"]?.Value ?? default(uint)),
		 MediaDuplexState = (uint) (managementObject.Properties["MediaDuplexState"]?.Value ?? default(uint)),
		 PauseFunctions = (uint) (managementObject.Properties["PauseFunctions"]?.Value ?? default(uint)),
		 RcvLinkSpeed = (ulong) (managementObject.Properties["RcvLinkSpeed"]?.Value ?? default(ulong)),
		 XmitLinkSpeed = (ulong) (managementObject.Properties["XmitLinkSpeed"]?.Value ?? default(ulong))
                };
        }
    }
}