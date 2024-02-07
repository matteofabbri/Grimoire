using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network.Tcp
{
    /// <summary>
    /// </summary>
    public sealed class TcpIpV1TypeGroup3
    {
		public uint Connid { get; private set; }
		public dynamic Daddr { get; private set; }
		public dynamic Dport { get; private set; }
		public uint Flags { get; private set; }
		public uint Pid { get; private set; }
		public dynamic Saddr { get; private set; }
		public uint Seqnum { get; private set; }
		public uint Size { get; private set; }
		public dynamic Sport { get; private set; }

        public static IEnumerable<TcpIpV1TypeGroup3> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<TcpIpV1TypeGroup3> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<TcpIpV1TypeGroup3> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM TcpIp_V1_TypeGroup3");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new TcpIpV1TypeGroup3
                {
                     Connid = (uint) (managementObject.Properties["connid"]?.Value ?? default(uint)),
		 Daddr = (dynamic) (managementObject.Properties["daddr"]?.Value ?? default(dynamic)),
		 Dport = (dynamic) (managementObject.Properties["dport"]?.Value ?? default(dynamic)),
		 Flags = (uint) (managementObject.Properties["Flags"]?.Value ?? default(uint)),
		 Pid = (uint) (managementObject.Properties["PID"]?.Value ?? default(uint)),
		 Saddr = (dynamic) (managementObject.Properties["saddr"]?.Value ?? default(dynamic)),
		 Seqnum = (uint) (managementObject.Properties["seqnum"]?.Value ?? default(uint)),
		 Size = (uint) (managementObject.Properties["size"]?.Value ?? default(uint)),
		 Sport = (dynamic) (managementObject.Properties["sport"]?.Value ?? default(dynamic))
                };
        }
    }
}