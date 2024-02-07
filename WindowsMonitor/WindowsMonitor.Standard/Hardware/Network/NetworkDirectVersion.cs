using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network
{
    /// <summary>
    /// </summary>
    public sealed class NetworkDirectVersion
    {
		public ushort MajorVersionNumber { get; private set; }
		public ushort MinorVersionNumber { get; private set; }

        public static IEnumerable<NetworkDirectVersion> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<NetworkDirectVersion> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<NetworkDirectVersion> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_NetworkDirectVersion");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new NetworkDirectVersion
                {
                     MajorVersionNumber = (ushort) (managementObject.Properties["MajorVersionNumber"]?.Value ?? default(ushort)),
		 MinorVersionNumber = (ushort) (managementObject.Properties["MinorVersionNumber"]?.Value ?? default(ushort))
                };
        }
    }
}