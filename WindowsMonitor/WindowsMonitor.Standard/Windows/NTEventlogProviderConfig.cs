using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows
{
    /// <summary>
    /// </summary>
    public sealed class NtEventlogProviderConfig
    {
        public DateTime LastBootUpTime { get; private set; }

        public static IEnumerable<NtEventlogProviderConfig> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<NtEventlogProviderConfig> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<NtEventlogProviderConfig> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM NTEventlogProviderConfig");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new NtEventlogProviderConfig
                {
                    LastBootUpTime =
                        ManagementDateTimeConverter.ToDateTime(
                            managementObject.Properties["LastBootUpTime"]?.Value as string ??
                            "00010102000000.000000+060")
                };
        }
    }
}