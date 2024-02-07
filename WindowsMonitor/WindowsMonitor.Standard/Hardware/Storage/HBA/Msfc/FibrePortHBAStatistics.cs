using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.HBA.Msfc
{
    /// <summary>
    /// </summary>
    public sealed class FibrePortHbaStatistics
    {
		public bool Active { get; private set; }
		public uint HbaStatus { get; private set; }
		public string InstanceName { get; private set; }
		public dynamic Statistics { get; private set; }
		public ulong UniquePortId { get; private set; }

        public static IEnumerable<FibrePortHbaStatistics> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<FibrePortHbaStatistics> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<FibrePortHbaStatistics> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSFC_FibrePortHBAStatistics");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new FibrePortHbaStatistics
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 HbaStatus = (uint) (managementObject.Properties["HBAStatus"]?.Value ?? default(uint)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 Statistics = (dynamic) (managementObject.Properties["Statistics"]?.Value ?? default(dynamic)),
		 UniquePortId = (ulong) (managementObject.Properties["UniquePortId"]?.Value ?? default(ulong))
                };
        }
    }
}