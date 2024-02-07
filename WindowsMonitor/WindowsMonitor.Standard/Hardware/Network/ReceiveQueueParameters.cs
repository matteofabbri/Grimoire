using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network
{
    /// <summary>
    /// </summary>
    public sealed class ReceiveQueueParameters
    {
		public uint Flags { get; private set; }
		public dynamic Header { get; private set; }
		public uint LookaheadSize { get; private set; }
		public uint MsixTableEntry { get; private set; }
		public uint NumSuggestedReceiveBuffers { get; private set; }
		public dynamic ProcessorAffinity { get; private set; }
		public uint QueueGroupId { get; private set; }
		public uint QueueId { get; private set; }
		public dynamic QueueName { get; private set; }
		public uint QueueType { get; private set; }
		public dynamic VmName { get; private set; }

        public static IEnumerable<ReceiveQueueParameters> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ReceiveQueueParameters> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ReceiveQueueParameters> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_ReceiveQueueParameters");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ReceiveQueueParameters
                {
                     Flags = (uint) (managementObject.Properties["Flags"]?.Value ?? default(uint)),
		 Header = (dynamic) (managementObject.Properties["Header"]?.Value ?? default(dynamic)),
		 LookaheadSize = (uint) (managementObject.Properties["LookaheadSize"]?.Value ?? default(uint)),
		 MsixTableEntry = (uint) (managementObject.Properties["MSIXTableEntry"]?.Value ?? default(uint)),
		 NumSuggestedReceiveBuffers = (uint) (managementObject.Properties["NumSuggestedReceiveBuffers"]?.Value ?? default(uint)),
		 ProcessorAffinity = (dynamic) (managementObject.Properties["ProcessorAffinity"]?.Value ?? default(dynamic)),
		 QueueGroupId = (uint) (managementObject.Properties["QueueGroupId"]?.Value ?? default(uint)),
		 QueueId = (uint) (managementObject.Properties["QueueId"]?.Value ?? default(uint)),
		 QueueName = (dynamic) (managementObject.Properties["QueueName"]?.Value ?? default(dynamic)),
		 QueueType = (uint) (managementObject.Properties["QueueType"]?.Value ?? default(uint)),
		 VmName = (dynamic) (managementObject.Properties["VmName"]?.Value ?? default(dynamic))
                };
        }
    }
}