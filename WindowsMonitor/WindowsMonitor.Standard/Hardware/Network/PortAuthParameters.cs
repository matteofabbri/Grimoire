using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network
{
    /// <summary>
    /// </summary>
    public sealed class PortAuthParameters
    {
		public dynamic Header { get; private set; }
		public uint RcvAuthorizationState { get; private set; }
		public uint RcvControlState { get; private set; }
		public uint SendAuthorizationState { get; private set; }
		public uint SendControlState { get; private set; }

        public static IEnumerable<PortAuthParameters> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<PortAuthParameters> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<PortAuthParameters> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_PortAuthParameters");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new PortAuthParameters
                {
                     Header = (dynamic) (managementObject.Properties["Header"]?.Value ?? default(dynamic)),
		 RcvAuthorizationState = (uint) (managementObject.Properties["RcvAuthorizationState"]?.Value ?? default(uint)),
		 RcvControlState = (uint) (managementObject.Properties["RcvControlState"]?.Value ?? default(uint)),
		 SendAuthorizationState = (uint) (managementObject.Properties["SendAuthorizationState"]?.Value ?? default(uint)),
		 SendControlState = (uint) (managementObject.Properties["SendControlState"]?.Value ?? default(uint))
                };
        }
    }
}