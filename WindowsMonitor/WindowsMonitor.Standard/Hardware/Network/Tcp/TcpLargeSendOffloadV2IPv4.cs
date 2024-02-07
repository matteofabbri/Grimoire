using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network.Tcp
{
    /// <summary>
    /// </summary>
    public sealed class TcpLargeSendOffloadV2IPv4
    {
		public uint Encapsulation { get; private set; }
		public uint MaxOffLoadSize { get; private set; }
		public uint MinSegmentCount { get; private set; }

        public static IEnumerable<TcpLargeSendOffloadV2IPv4> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<TcpLargeSendOffloadV2IPv4> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<TcpLargeSendOffloadV2IPv4> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_WmiTcpLargeSendOffloadV2_IPv4");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new TcpLargeSendOffloadV2IPv4
                {
                     Encapsulation = (uint) (managementObject.Properties["Encapsulation"]?.Value ?? default(uint)),
		 MaxOffLoadSize = (uint) (managementObject.Properties["MaxOffLoadSize"]?.Value ?? default(uint)),
		 MinSegmentCount = (uint) (managementObject.Properties["MinSegmentCount"]?.Value ?? default(uint))
                };
        }
    }
}