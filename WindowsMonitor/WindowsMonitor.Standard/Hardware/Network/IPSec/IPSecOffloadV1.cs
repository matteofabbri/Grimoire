using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network.IPSec
{
    /// <summary>
    /// </summary>
    public sealed class IpSecOffloadV1
    {
		public dynamic WmiIPv4Ah { get; private set; }
		public dynamic WmiIPv4Esp { get; private set; }
		public dynamic WmiSupported { get; private set; }

        public static IEnumerable<IpSecOffloadV1> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<IpSecOffloadV1> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<IpSecOffloadV1> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_WmiIPSecOffloadV1");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new IpSecOffloadV1
                {
                     WmiIPv4Ah = (dynamic) (managementObject.Properties["WmiIPv4AH"]?.Value ?? default(dynamic)),
		 WmiIPv4Esp = (dynamic) (managementObject.Properties["WmiIPv4ESP"]?.Value ?? default(dynamic)),
		 WmiSupported = (dynamic) (managementObject.Properties["WmiSupported"]?.Value ?? default(dynamic))
                };
        }
    }
}