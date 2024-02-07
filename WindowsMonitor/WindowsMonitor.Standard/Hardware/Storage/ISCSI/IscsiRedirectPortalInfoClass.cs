using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.ISCSI
{
    /// <summary>
    /// </summary>
    public sealed class IscsiRedirectPortalInfoClass
    {
		public bool Active { get; private set; }
		public string InstanceName { get; private set; }
		public dynamic[] RedirectSessionList { get; private set; }
		public uint SessionCount { get; private set; }
		public ulong UniqueAdapterId { get; private set; }

        public static IEnumerable<IscsiRedirectPortalInfoClass> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<IscsiRedirectPortalInfoClass> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<IscsiRedirectPortalInfoClass> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSiSCSI_RedirectPortalInfoClass");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new IscsiRedirectPortalInfoClass
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 RedirectSessionList = (dynamic[]) (managementObject.Properties["RedirectSessionList"]?.Value ?? new dynamic[0]),
		 SessionCount = (uint) (managementObject.Properties["SessionCount"]?.Value ?? default(uint)),
		 UniqueAdapterId = (ulong) (managementObject.Properties["UniqueAdapterId"]?.Value ?? default(ulong))
                };
        }
    }
}