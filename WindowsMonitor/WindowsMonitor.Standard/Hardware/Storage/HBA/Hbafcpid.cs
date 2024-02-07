using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.HBA
{
    /// <summary>
    /// </summary>
    public sealed class Hbafcpid
    {
		public uint Fcid { get; private set; }
		public ulong FcpLun { get; private set; }
		public byte[] NodeWwn { get; private set; }
		public byte[] PortWwn { get; private set; }

        public static IEnumerable<Hbafcpid> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<Hbafcpid> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<Hbafcpid> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HBAFCPID");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new Hbafcpid
                {
                     Fcid = (uint) (managementObject.Properties["Fcid"]?.Value ?? default(uint)),
		 FcpLun = (ulong) (managementObject.Properties["FcpLun"]?.Value ?? default(ulong)),
		 NodeWwn = (byte[]) (managementObject.Properties["NodeWWN"]?.Value ?? new byte[0]),
		 PortWwn = (byte[]) (managementObject.Properties["PortWWN"]?.Value ?? new byte[0])
                };
        }
    }
}