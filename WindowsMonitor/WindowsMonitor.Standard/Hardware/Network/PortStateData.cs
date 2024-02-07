using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network
{
    /// <summary>
    /// </summary>
    public sealed class PortStateData
    {
		public uint Direction { get; private set; }
		public uint Flags { get; private set; }
		public dynamic Header { get; private set; }
		public uint MediaConnectState { get; private set; }
		public uint RcvAuthorizationState { get; private set; }
		public uint RcvControlState { get; private set; }
		public ulong RcvLinkSpeed { get; private set; }
		public uint SendAuthorizationState { get; private set; }
		public uint SendControlState { get; private set; }
		public ulong XmitLinkSpeed { get; private set; }

        public static IEnumerable<PortStateData> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<PortStateData> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<PortStateData> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_PortStateData");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new PortStateData
                {
                     Direction = (uint) (managementObject.Properties["Direction"]?.Value ?? default(uint)),
		 Flags = (uint) (managementObject.Properties["Flags"]?.Value ?? default(uint)),
		 Header = (dynamic) (managementObject.Properties["Header"]?.Value ?? default(dynamic)),
		 MediaConnectState = (uint) (managementObject.Properties["MediaConnectState"]?.Value ?? default(uint)),
		 RcvAuthorizationState = (uint) (managementObject.Properties["RcvAuthorizationState"]?.Value ?? default(uint)),
		 RcvControlState = (uint) (managementObject.Properties["RcvControlState"]?.Value ?? default(uint)),
		 RcvLinkSpeed = (ulong) (managementObject.Properties["RcvLinkSpeed"]?.Value ?? default(ulong)),
		 SendAuthorizationState = (uint) (managementObject.Properties["SendAuthorizationState"]?.Value ?? default(uint)),
		 SendControlState = (uint) (managementObject.Properties["SendControlState"]?.Value ?? default(uint)),
		 XmitLinkSpeed = (ulong) (managementObject.Properties["XmitLinkSpeed"]?.Value ?? default(ulong))
                };
        }
    }
}