using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network.Tcp
{
    /// <summary>
    /// </summary>
    public sealed class TcpIpV1Fail
    {
		public uint Flags { get; private set; }
		public uint Proto { get; private set; }

        public static IEnumerable<TcpIpV1Fail> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<TcpIpV1Fail> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<TcpIpV1Fail> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM TcpIp_V1_Fail");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new TcpIpV1Fail
                {
                     Flags = (uint) (managementObject.Properties["Flags"]?.Value ?? default(uint)),
		 Proto = (uint) (managementObject.Properties["Proto"]?.Value ?? default(uint))
                };
        }
    }
}