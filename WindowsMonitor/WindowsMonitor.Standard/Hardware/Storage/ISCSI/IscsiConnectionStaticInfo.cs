using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.ISCSI
{
    /// <summary>
    /// </summary>
    public sealed class IscsiConnectionStaticInfo
    {
		public uint AuthType { get; private set; }
		public ushort Cid { get; private set; }
		public byte DataIntegrity { get; private set; }
		public ulong EstimatedThroughput { get; private set; }
		public byte HeaderIntegrity { get; private set; }
		public dynamic LocalAddr { get; private set; }
		public uint LocalPort { get; private set; }
		public uint MaxDatagramSize { get; private set; }
		public uint MaxRecvDataSegmentLength { get; private set; }
		public byte Protocol { get; private set; }
		public dynamic RemoteAddr { get; private set; }
		public uint RemotePort { get; private set; }
		public ushort Reserved { get; private set; }
		public byte State { get; private set; }
		public ulong UniqueConnectionId { get; private set; }

        public static IEnumerable<IscsiConnectionStaticInfo> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<IscsiConnectionStaticInfo> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<IscsiConnectionStaticInfo> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM ISCSI_ConnectionStaticInfo");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new IscsiConnectionStaticInfo
                {
                     AuthType = (uint) (managementObject.Properties["AuthType"]?.Value ?? default(uint)),
		 Cid = (ushort) (managementObject.Properties["CID"]?.Value ?? default(ushort)),
		 DataIntegrity = (byte) (managementObject.Properties["DataIntegrity"]?.Value ?? default(byte)),
		 EstimatedThroughput = (ulong) (managementObject.Properties["EstimatedThroughput"]?.Value ?? default(ulong)),
		 HeaderIntegrity = (byte) (managementObject.Properties["HeaderIntegrity"]?.Value ?? default(byte)),
		 LocalAddr = (dynamic) (managementObject.Properties["LocalAddr"]?.Value ?? default(dynamic)),
		 LocalPort = (uint) (managementObject.Properties["LocalPort"]?.Value ?? default(uint)),
		 MaxDatagramSize = (uint) (managementObject.Properties["MaxDatagramSize"]?.Value ?? default(uint)),
		 MaxRecvDataSegmentLength = (uint) (managementObject.Properties["MaxRecvDataSegmentLength"]?.Value ?? default(uint)),
		 Protocol = (byte) (managementObject.Properties["Protocol"]?.Value ?? default(byte)),
		 RemoteAddr = (dynamic) (managementObject.Properties["RemoteAddr"]?.Value ?? default(dynamic)),
		 RemotePort = (uint) (managementObject.Properties["RemotePort"]?.Value ?? default(uint)),
		 Reserved = (ushort) (managementObject.Properties["Reserved"]?.Value ?? default(ushort)),
		 State = (byte) (managementObject.Properties["State"]?.Value ?? default(byte)),
		 UniqueConnectionId = (ulong) (managementObject.Properties["UniqueConnectionId"]?.Value ?? default(ulong))
                };
        }
    }
}