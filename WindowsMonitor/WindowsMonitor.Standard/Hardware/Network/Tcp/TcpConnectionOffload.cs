using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network.Tcp
{
    /// <summary>
    /// </summary>
    public sealed class TcpConnectionOffload
    {
		public uint Encapsulation { get; private set; }
		public uint Flags { get; private set; }
		public dynamic Header { get; private set; }
		public uint SupportIp4 { get; private set; }
		public uint SupportIp6 { get; private set; }
		public uint SupportIp6ExtensionHeaders { get; private set; }
		public uint SupportSack { get; private set; }
		public uint TcpConnectionOffloadCapacity { get; private set; }

        public static IEnumerable<TcpConnectionOffload> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<TcpConnectionOffload> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<TcpConnectionOffload> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_WmiTcpConnectionOffload");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new TcpConnectionOffload
                {
                     Encapsulation = (uint) (managementObject.Properties["Encapsulation"]?.Value ?? default(uint)),
		 Flags = (uint) (managementObject.Properties["Flags"]?.Value ?? default(uint)),
		 Header = (dynamic) (managementObject.Properties["Header"]?.Value ?? default(dynamic)),
		 SupportIp4 = (uint) (managementObject.Properties["SupportIp4"]?.Value ?? default(uint)),
		 SupportIp6 = (uint) (managementObject.Properties["SupportIp6"]?.Value ?? default(uint)),
		 SupportIp6ExtensionHeaders = (uint) (managementObject.Properties["SupportIp6ExtensionHeaders"]?.Value ?? default(uint)),
		 SupportSack = (uint) (managementObject.Properties["SupportSack"]?.Value ?? default(uint)),
		 TcpConnectionOffloadCapacity = (uint) (managementObject.Properties["TcpConnectionOffloadCapacity"]?.Value ?? default(uint))
                };
        }
    }
}