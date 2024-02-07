using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network
{
    /// <summary>
    /// </summary>
    public sealed class ReceiveFilterGlobalParameters
    {
		public uint EnabledFilterTypes { get; private set; }
		public uint EnabledQueueTypes { get; private set; }
		public uint Flags { get; private set; }
		public dynamic Header { get; private set; }

        public static IEnumerable<ReceiveFilterGlobalParameters> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ReceiveFilterGlobalParameters> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ReceiveFilterGlobalParameters> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_ReceiveFilterGlobalParameters");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ReceiveFilterGlobalParameters
                {
                     EnabledFilterTypes = (uint) (managementObject.Properties["EnabledFilterTypes"]?.Value ?? default(uint)),
		 EnabledQueueTypes = (uint) (managementObject.Properties["EnabledQueueTypes"]?.Value ?? default(uint)),
		 Flags = (uint) (managementObject.Properties["Flags"]?.Value ?? default(uint)),
		 Header = (dynamic) (managementObject.Properties["Header"]?.Value ?? default(dynamic))
                };
        }
    }
}