using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.ISCSI
{
    /// <summary>
    /// </summary>
    public sealed class IscsiTargetPortal
    {
		public dynamic Address { get; private set; }
		public uint Reserved { get; private set; }
		public ushort Socket { get; private set; }

        public static IEnumerable<IscsiTargetPortal> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<IscsiTargetPortal> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<IscsiTargetPortal> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM ISCSI_TargetPortal");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new IscsiTargetPortal
                {
                     Address = (dynamic) (managementObject.Properties["Address"]?.Value ?? default(dynamic)),
		 Reserved = (uint) (managementObject.Properties["Reserved"]?.Value ?? default(uint)),
		 Socket = (ushort) (managementObject.Properties["Socket"]?.Value ?? default(ushort))
                };
        }
    }
}