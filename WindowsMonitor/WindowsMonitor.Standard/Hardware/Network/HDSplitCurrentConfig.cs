using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network
{
    /// <summary>
    /// </summary>
    public sealed class HdSplitCurrentConfig
    {
		public bool Active { get; private set; }
		public string InstanceName { get; private set; }

        public static IEnumerable<HdSplitCurrentConfig> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HdSplitCurrentConfig> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HdSplitCurrentConfig> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_HDSplitCurrentConfig");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HdSplitCurrentConfig
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string))
                };
        }
    }
}