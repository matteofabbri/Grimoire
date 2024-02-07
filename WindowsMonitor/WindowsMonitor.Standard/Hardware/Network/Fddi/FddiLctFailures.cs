using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network.Fddi
{
    /// <summary>
    /// </summary>
    public sealed class FddiLctFailures
    {
		public bool Active { get; private set; }
		public string InstanceName { get; private set; }
		public uint NdisFddiLctFailures { get; private set; }

        public static IEnumerable<FddiLctFailures> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<FddiLctFailures> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<FddiLctFailures> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_FddiLctFailures");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new FddiLctFailures
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 NdisFddiLctFailures = (uint) (managementObject.Properties["NdisFddiLctFailures"]?.Value ?? default(uint))
                };
        }
    }
}