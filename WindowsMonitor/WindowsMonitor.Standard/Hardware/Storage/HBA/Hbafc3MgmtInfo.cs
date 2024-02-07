using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.HBA
{
    /// <summary>
    /// </summary>
    public sealed class Hbafc3MgmtInfo
    {
		public byte[] IpAddress { get; private set; }
		public ushort IpVersion { get; private set; }
		public uint NumberOfAttachedNodes { get; private set; }
		public uint PortId { get; private set; }
		public ushort Reserved { get; private set; }
		public uint Reserved1 { get; private set; }
		public ushort TopologyDiscoveryFlags { get; private set; }
		public ushort UdpPort { get; private set; }
		public ulong UniqueAdapterId { get; private set; }
		public uint Unittype { get; private set; }
		public byte[] Wwn { get; private set; }

        public static IEnumerable<Hbafc3MgmtInfo> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<Hbafc3MgmtInfo> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<Hbafc3MgmtInfo> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HBAFC3MgmtInfo");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new Hbafc3MgmtInfo
                {
                     IpAddress = (byte[]) (managementObject.Properties["IPAddress"]?.Value ?? new byte[0]),
		 IpVersion = (ushort) (managementObject.Properties["IPVersion"]?.Value ?? default(ushort)),
		 NumberOfAttachedNodes = (uint) (managementObject.Properties["NumberOfAttachedNodes"]?.Value ?? default(uint)),
		 PortId = (uint) (managementObject.Properties["PortId"]?.Value ?? default(uint)),
		 Reserved = (ushort) (managementObject.Properties["reserved"]?.Value ?? default(ushort)),
		 Reserved1 = (uint) (managementObject.Properties["reserved1"]?.Value ?? default(uint)),
		 TopologyDiscoveryFlags = (ushort) (managementObject.Properties["TopologyDiscoveryFlags"]?.Value ?? default(ushort)),
		 UdpPort = (ushort) (managementObject.Properties["UDPPort"]?.Value ?? default(ushort)),
		 UniqueAdapterId = (ulong) (managementObject.Properties["UniqueAdapterId"]?.Value ?? default(ulong)),
		 Unittype = (uint) (managementObject.Properties["unittype"]?.Value ?? default(uint)),
		 Wwn = (byte[]) (managementObject.Properties["wwn"]?.Value ?? new byte[0])
                };
        }
    }
}