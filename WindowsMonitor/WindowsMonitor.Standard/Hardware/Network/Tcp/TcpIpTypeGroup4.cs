using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network.Tcp
{
    /// <summary>
    /// </summary>
    public sealed class TcpIpTypeGroup4
    {
		public uint Connid { get; private set; }
		public dynamic Daddr { get; private set; }
		public dynamic Dport { get; private set; }
		public uint Flags { get; private set; }
		public ushort Mss { get; private set; }
		public uint Pid { get; private set; }
		public uint Rcvwin { get; private set; }
		public short Rcvwinscale { get; private set; }
		public ushort Sackopt { get; private set; }
		public dynamic Saddr { get; private set; }
		public uint Seqnum { get; private set; }
		public uint Size { get; private set; }
		public short Sndwinscale { get; private set; }
		public dynamic Sport { get; private set; }
		public ushort Tsopt { get; private set; }
		public ushort Wsopt { get; private set; }

        public static IEnumerable<TcpIpTypeGroup4> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<TcpIpTypeGroup4> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<TcpIpTypeGroup4> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM TcpIp_TypeGroup4");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new TcpIpTypeGroup4
                {
                     Connid = (uint) (managementObject.Properties["connid"]?.Value ?? default(uint)),
		 Daddr = (dynamic) (managementObject.Properties["daddr"]?.Value ?? default(dynamic)),
		 Dport = (dynamic) (managementObject.Properties["dport"]?.Value ?? default(dynamic)),
		 Flags = (uint) (managementObject.Properties["Flags"]?.Value ?? default(uint)),
		 Mss = (ushort) (managementObject.Properties["mss"]?.Value ?? default(ushort)),
		 Pid = (uint) (managementObject.Properties["PID"]?.Value ?? default(uint)),
		 Rcvwin = (uint) (managementObject.Properties["rcvwin"]?.Value ?? default(uint)),
		 Rcvwinscale = (short) (managementObject.Properties["rcvwinscale"]?.Value ?? default(short)),
		 Sackopt = (ushort) (managementObject.Properties["sackopt"]?.Value ?? default(ushort)),
		 Saddr = (dynamic) (managementObject.Properties["saddr"]?.Value ?? default(dynamic)),
		 Seqnum = (uint) (managementObject.Properties["seqnum"]?.Value ?? default(uint)),
		 Size = (uint) (managementObject.Properties["size"]?.Value ?? default(uint)),
		 Sndwinscale = (short) (managementObject.Properties["sndwinscale"]?.Value ?? default(short)),
		 Sport = (dynamic) (managementObject.Properties["sport"]?.Value ?? default(dynamic)),
		 Tsopt = (ushort) (managementObject.Properties["tsopt"]?.Value ?? default(ushort)),
		 Wsopt = (ushort) (managementObject.Properties["wsopt"]?.Value ?? default(ushort))
                };
        }
    }
}