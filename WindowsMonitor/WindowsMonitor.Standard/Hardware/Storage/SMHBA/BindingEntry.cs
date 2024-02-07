using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.SMHBA
{
    /// <summary>
    /// </summary>
    public sealed class BindingEntry
    {
		public byte[] Luid { get; private set; }
		public dynamic PortLun { get; private set; }
		public dynamic ScsiId { get; private set; }
		public uint Status { get; private set; }
		public uint Type { get; private set; }

        public static IEnumerable<BindingEntry> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<BindingEntry> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<BindingEntry> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MS_SMHBA_BINDINGENTRY");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new BindingEntry
                {
                     Luid = (byte[]) (managementObject.Properties["LUID"]?.Value ?? new byte[0]),
		 PortLun = (dynamic) (managementObject.Properties["PortLun"]?.Value ?? default(dynamic)),
		 ScsiId = (dynamic) (managementObject.Properties["ScsiId"]?.Value ?? default(dynamic)),
		 Status = (uint) (managementObject.Properties["Status"]?.Value ?? default(uint)),
		 Type = (uint) (managementObject.Properties["type"]?.Value ?? default(uint))
                };
        }
    }
}