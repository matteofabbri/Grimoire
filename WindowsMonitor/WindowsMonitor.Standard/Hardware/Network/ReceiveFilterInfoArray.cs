using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network
{
    /// <summary>
    /// </summary>
    public sealed class ReceiveFilterInfoArray
    {
		public uint ElementSize { get; private set; }
		public dynamic[] Filter { get; private set; }
		public uint FirstElementOffset { get; private set; }
		public dynamic Header { get; private set; }
		public uint NumElements { get; private set; }
		public uint QueueId { get; private set; }

        public static IEnumerable<ReceiveFilterInfoArray> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ReceiveFilterInfoArray> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ReceiveFilterInfoArray> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_ReceiveFilterInfoArray");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ReceiveFilterInfoArray
                {
                     ElementSize = (uint) (managementObject.Properties["ElementSize"]?.Value ?? default(uint)),
		 Filter = (dynamic[]) (managementObject.Properties["Filter"]?.Value ?? new dynamic[0]),
		 FirstElementOffset = (uint) (managementObject.Properties["FirstElementOffset"]?.Value ?? default(uint)),
		 Header = (dynamic) (managementObject.Properties["Header"]?.Value ?? default(dynamic)),
		 NumElements = (uint) (managementObject.Properties["NumElements"]?.Value ?? default(uint)),
		 QueueId = (uint) (managementObject.Properties["QueueId"]?.Value ?? default(uint))
                };
        }
    }
}