using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Boot
{
    /// <summary>
    /// </summary>
    public sealed class BootOsFromFs
    {
        public string Antecedent { get; private set; }
        public string Dependent { get; private set; }

        public static IEnumerable<BootOsFromFs> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<BootOsFromFs> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<BootOsFromFs> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_BootOSFromFS");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new BootOsFromFs
                {
                    Antecedent = (string) (managementObject.Properties["Antecedent"]?.Value),
                    Dependent = (string) (managementObject.Properties["Dependent"]?.Value)
                };
        }
    }
}