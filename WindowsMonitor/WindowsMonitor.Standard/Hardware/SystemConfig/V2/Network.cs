using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.SystemConfig.V2
{
    /// <summary>
    /// </summary>
    public sealed class Network
    {
		public uint Flags { get; private set; }
		public uint MaxHashTableSize { get; private set; }
		public uint MaxUserPort { get; private set; }
		public uint TcbTablePartitions { get; private set; }
		public uint TcpTimedWaitDelay { get; private set; }

        public static IEnumerable<Network> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<Network> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<Network> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM SystemConfig_V2_Network");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new Network
                {
                     Flags = (uint) (managementObject.Properties["Flags"]?.Value ?? default(uint)),
		 MaxHashTableSize = (uint) (managementObject.Properties["MaxHashTableSize"]?.Value ?? default(uint)),
		 MaxUserPort = (uint) (managementObject.Properties["MaxUserPort"]?.Value ?? default(uint)),
		 TcbTablePartitions = (uint) (managementObject.Properties["TcbTablePartitions"]?.Value ?? default(uint)),
		 TcpTimedWaitDelay = (uint) (managementObject.Properties["TcpTimedWaitDelay"]?.Value ?? default(uint))
                };
        }
    }
}