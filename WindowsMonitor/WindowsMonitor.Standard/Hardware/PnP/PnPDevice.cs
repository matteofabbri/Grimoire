using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.PnP
{
    /// <summary>
    /// </summary>
    public sealed class PnPDevice
    {
		public string SameElement { get; private set; }
		public string SystemElement { get; private set; }

        public static IEnumerable<PnPDevice> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<PnPDevice> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<PnPDevice> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PnPDevice");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new PnPDevice
                {
                     SameElement =  (managementObject.Properties["SameElement"]?.Value?.ToString()),
		 SystemElement =  (managementObject.Properties["SystemElement"]?.Value?.ToString())
                };
        }
    }
}