using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.Security
{
    /// <summary>
    /// </summary>
    public sealed class SecurityDescriptor
    {
		public uint ControlFlags { get; private set; }
		public dynamic[] Dacl { get; private set; }
		public dynamic Group { get; private set; }
		public dynamic Owner { get; private set; }
		public dynamic[] Sacl { get; private set; }
		public ulong TimeCreated { get; private set; }

        public static IEnumerable<SecurityDescriptor> Retrieve(string remote, string username, string password)
        {
            var options = new ConnectionOptions
            {
                Impersonation = ImpersonationLevel.Impersonate,
                Username = username,
                Password = password
            };

            var managementScope = new ManagementScope(new ManagementPath($"\\\\{remote}\\root\\cimv2"), options);
            managementScope.Connect();

            return Retrieve(managementScope);
        }

        public static IEnumerable<SecurityDescriptor> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SecurityDescriptor> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_SecurityDescriptor");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SecurityDescriptor
                {
                     ControlFlags = (uint) (managementObject.Properties["ControlFlags"]?.Value ?? default(uint)),
		 Dacl = (dynamic[]) (managementObject.Properties["DACL"]?.Value ?? new dynamic[0]),
		 Group = (dynamic) (managementObject.Properties["Group"]?.Value ?? default(dynamic)),
		 Owner = (dynamic) (managementObject.Properties["Owner"]?.Value ?? default(dynamic)),
		 Sacl = (dynamic[]) (managementObject.Properties["SACL"]?.Value ?? new dynamic[0]),
		 TimeCreated = (ulong) (managementObject.Properties["TIME_CREATED"]?.Value ?? default(ulong))
                };
        }
    }
}