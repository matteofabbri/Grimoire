using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Registry
{
    /// <summary>
    /// </summary>
    public sealed class RegistryValueChangeEvent
    {
        public string Hive { get; private set; }
        public string KeyPath { get; private set; }
        public byte[] SecurityDescriptor { get; private set; }
        public ulong TimeCreated { get; private set; }
        public string ValueName { get; private set; }

        public static IEnumerable<RegistryValueChangeEvent> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<RegistryValueChangeEvent> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<RegistryValueChangeEvent> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM RegistryValueChangeEvent");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new RegistryValueChangeEvent
                {
                    Hive = (string) managementObject.Properties["Hive"]?.Value,
                    KeyPath = (string) managementObject.Properties["KeyPath"]?.Value,
                    SecurityDescriptor =
                        (byte[]) (managementObject.Properties["SECURITY_DESCRIPTOR"]?.Value ?? new byte[0]),
                    TimeCreated = (ulong) (managementObject.Properties["TIME_CREATED"]?.Value ?? default(ulong)),
                    ValueName = (string) managementObject.Properties["ValueName"]?.Value
                };
        }
    }
}