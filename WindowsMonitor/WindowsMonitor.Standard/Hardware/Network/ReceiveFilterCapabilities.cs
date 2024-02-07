using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network
{
    /// <summary>
    /// </summary>
    public sealed class ReceiveFilterCapabilities
    {
		public uint EnabledFilterTypes { get; private set; }
		public uint EnabledQueueTypes { get; private set; }
		public uint Flags { get; private set; }
		public dynamic Header { get; private set; }
		public uint MaxLookaheadSplitSize { get; private set; }
		public uint MaxMacHeaderFilters { get; private set; }
		public uint MaxQueueGroups { get; private set; }
		public uint MaxQueuesPerQueueGroup { get; private set; }
		public uint MinLookaheadSplitSize { get; private set; }
		public uint NumQueues { get; private set; }
		public uint SupportedFilterTests { get; private set; }
		public uint SupportedHeaders { get; private set; }
		public uint SupportedMacHeaderFields { get; private set; }
		public uint SupportedQueueProperties { get; private set; }

        public static IEnumerable<ReceiveFilterCapabilities> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ReceiveFilterCapabilities> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ReceiveFilterCapabilities> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_ReceiveFilterCapabilities");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ReceiveFilterCapabilities
                {
                     EnabledFilterTypes = (uint) (managementObject.Properties["EnabledFilterTypes"]?.Value ?? default(uint)),
		 EnabledQueueTypes = (uint) (managementObject.Properties["EnabledQueueTypes"]?.Value ?? default(uint)),
		 Flags = (uint) (managementObject.Properties["Flags"]?.Value ?? default(uint)),
		 Header = (dynamic) (managementObject.Properties["Header"]?.Value ?? default(dynamic)),
		 MaxLookaheadSplitSize = (uint) (managementObject.Properties["MaxLookaheadSplitSize"]?.Value ?? default(uint)),
		 MaxMacHeaderFilters = (uint) (managementObject.Properties["MaxMacHeaderFilters"]?.Value ?? default(uint)),
		 MaxQueueGroups = (uint) (managementObject.Properties["MaxQueueGroups"]?.Value ?? default(uint)),
		 MaxQueuesPerQueueGroup = (uint) (managementObject.Properties["MaxQueuesPerQueueGroup"]?.Value ?? default(uint)),
		 MinLookaheadSplitSize = (uint) (managementObject.Properties["MinLookaheadSplitSize"]?.Value ?? default(uint)),
		 NumQueues = (uint) (managementObject.Properties["NumQueues"]?.Value ?? default(uint)),
		 SupportedFilterTests = (uint) (managementObject.Properties["SupportedFilterTests"]?.Value ?? default(uint)),
		 SupportedHeaders = (uint) (managementObject.Properties["SupportedHeaders"]?.Value ?? default(uint)),
		 SupportedMacHeaderFields = (uint) (managementObject.Properties["SupportedMacHeaderFields"]?.Value ?? default(uint)),
		 SupportedQueueProperties = (uint) (managementObject.Properties["SupportedQueueProperties"]?.Value ?? default(uint))
                };
        }
    }
}