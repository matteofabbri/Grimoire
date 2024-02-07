using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network
{
    /// <summary>
    /// </summary>
    public sealed class NetworkDirectAdapterCapabilities
    {
		public uint MaxCqCount { get; private set; }
		public uint MaxInboundReadLimit { get; private set; }
		public uint MaxMrCount { get; private set; }
		public uint MaxMwCount { get; private set; }
		public uint MaxOutboundReadLimit { get; private set; }
		public uint MaxPdCount { get; private set; }
		public uint MaxQpCount { get; private set; }
		public uint MaxSrqCount { get; private set; }
		public ulong MissingCounterMask { get; private set; }
		public dynamic NdAdapterInfo { get; private set; }

        public static IEnumerable<NetworkDirectAdapterCapabilities> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<NetworkDirectAdapterCapabilities> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<NetworkDirectAdapterCapabilities> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_NetworkDirectAdapterCapabilities");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new NetworkDirectAdapterCapabilities
                {
                     MaxCqCount = (uint) (managementObject.Properties["MaxCqCount"]?.Value ?? default(uint)),
		 MaxInboundReadLimit = (uint) (managementObject.Properties["MaxInboundReadLimit"]?.Value ?? default(uint)),
		 MaxMrCount = (uint) (managementObject.Properties["MaxMrCount"]?.Value ?? default(uint)),
		 MaxMwCount = (uint) (managementObject.Properties["MaxMwCount"]?.Value ?? default(uint)),
		 MaxOutboundReadLimit = (uint) (managementObject.Properties["MaxOutboundReadLimit"]?.Value ?? default(uint)),
		 MaxPdCount = (uint) (managementObject.Properties["MaxPdCount"]?.Value ?? default(uint)),
		 MaxQpCount = (uint) (managementObject.Properties["MaxQpCount"]?.Value ?? default(uint)),
		 MaxSrqCount = (uint) (managementObject.Properties["MaxSrqCount"]?.Value ?? default(uint)),
		 MissingCounterMask = (ulong) (managementObject.Properties["MissingCounterMask"]?.Value ?? default(ulong)),
		 NdAdapterInfo = (dynamic) (managementObject.Properties["NdAdapterInfo"]?.Value ?? default(dynamic))
                };
        }
    }
}