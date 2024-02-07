using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.SMHBA
{
    /// <summary>
    /// </summary>
    public sealed class ScsiEntry
    {
		public byte[] Luid { get; private set; }
		public dynamic PortLun { get; private set; }
		public dynamic ScsiId { get; private set; }

        public static IEnumerable<ScsiEntry> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ScsiEntry> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ScsiEntry> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MS_SMHBA_SCSIENTRY");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ScsiEntry
                {
                     Luid = (byte[]) (managementObject.Properties["LUID"]?.Value ?? new byte[0]),
		 PortLun = (dynamic) (managementObject.Properties["PortLun"]?.Value ?? default(dynamic)),
		 ScsiId = (dynamic) (managementObject.Properties["ScsiId"]?.Value ?? default(dynamic))
                };
        }
    }
}