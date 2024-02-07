using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.ISCSI
{
    /// <summary>
    /// </summary>
    public sealed class IscsiLunList
    {
		public uint Oslun { get; private set; }
		public uint Reserved { get; private set; }
		public ulong TargetLun { get; private set; }

        public static IEnumerable<IscsiLunList> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<IscsiLunList> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<IscsiLunList> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM ISCSI_LUNList");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new IscsiLunList
                {
                     Oslun = (uint) (managementObject.Properties["OSLUN"]?.Value ?? default(uint)),
		 Reserved = (uint) (managementObject.Properties["Reserved"]?.Value ?? default(uint)),
		 TargetLun = (ulong) (managementObject.Properties["TargetLUN"]?.Value ?? default(ulong))
                };
        }
    }
}