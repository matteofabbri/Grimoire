using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.ISCSI
{
    /// <summary>
    /// </summary>
    public sealed class IscsiPath
    {
		public uint ConnectionStatus { get; private set; }
		public ulong EstimatedLinkSpeed { get; private set; }
		public uint PathWeight { get; private set; }
		public uint PrimaryPath { get; private set; }
		public uint TcpOffLoadAvailable { get; private set; }
		public ulong UniqueConnectionId { get; private set; }

        public static IEnumerable<IscsiPath> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<IscsiPath> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<IscsiPath> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM ISCSI_Path");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new IscsiPath
                {
                     ConnectionStatus = (uint) (managementObject.Properties["ConnectionStatus"]?.Value ?? default(uint)),
		 EstimatedLinkSpeed = (ulong) (managementObject.Properties["EstimatedLinkSpeed"]?.Value ?? default(ulong)),
		 PathWeight = (uint) (managementObject.Properties["PathWeight"]?.Value ?? default(uint)),
		 PrimaryPath = (uint) (managementObject.Properties["PrimaryPath"]?.Value ?? default(uint)),
		 TcpOffLoadAvailable = (uint) (managementObject.Properties["TCPOffLoadAvailable"]?.Value ?? default(uint)),
		 UniqueConnectionId = (ulong) (managementObject.Properties["UniqueConnectionId"]?.Value ?? default(ulong))
                };
        }
    }
}