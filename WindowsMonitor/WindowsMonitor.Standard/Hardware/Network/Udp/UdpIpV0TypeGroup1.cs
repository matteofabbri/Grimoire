using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network.Udp
{
    /// <summary>
    /// </summary>
    public sealed class UdpIpV0TypeGroup1
    {
		public uint Context { get; private set; }
		public dynamic Daddr { get; private set; }
		public dynamic Dport { get; private set; }
		public ushort Dsize { get; private set; }
		public uint Flags { get; private set; }
		public dynamic Saddr { get; private set; }
		public ushort Size { get; private set; }
		public dynamic Sport { get; private set; }

        public static IEnumerable<UdpIpV0TypeGroup1> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<UdpIpV0TypeGroup1> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<UdpIpV0TypeGroup1> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM UdpIp_V0_TypeGroup1");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new UdpIpV0TypeGroup1
                {
                     Context = (uint) (managementObject.Properties["context"]?.Value ?? default(uint)),
		 Daddr = (dynamic) (managementObject.Properties["daddr"]?.Value ?? default(dynamic)),
		 Dport = (dynamic) (managementObject.Properties["dport"]?.Value ?? default(dynamic)),
		 Dsize = (ushort) (managementObject.Properties["dsize"]?.Value ?? default(ushort)),
		 Flags = (uint) (managementObject.Properties["Flags"]?.Value ?? default(uint)),
		 Saddr = (dynamic) (managementObject.Properties["saddr"]?.Value ?? default(dynamic)),
		 Size = (ushort) (managementObject.Properties["size"]?.Value ?? default(ushort)),
		 Sport = (dynamic) (managementObject.Properties["sport"]?.Value ?? default(dynamic))
                };
        }
    }
}