using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Services
{
    /// <summary>
    /// </summary>
    public sealed class LoadOrderGroupServiceMembers
    {
        public string GroupComponent { get; private set; }
        public string PartComponent { get; private set; }

        public static IEnumerable<LoadOrderGroupServiceMembers> Retrieve(string remote, string username,
            string password)
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

        public static IEnumerable<LoadOrderGroupServiceMembers> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<LoadOrderGroupServiceMembers> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_LoadOrderGroupServiceMembers");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new LoadOrderGroupServiceMembers
                {
                    GroupComponent = (string) managementObject.Properties["GroupComponent"]?.Value,
                    PartComponent = (string) managementObject.Properties["PartComponent"]?.Value
                };
        }
    }
}