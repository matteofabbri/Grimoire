using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.HBA.Msfc
{
    /// <summary>
    /// </summary>
    public sealed class Fc4Statistics
    {
		public ulong ControlRequests { get; private set; }
		public ulong InputMegabytes { get; private set; }
		public ulong InputRequests { get; private set; }
		public ulong OutputMegabytes { get; private set; }
		public ulong OutputRequests { get; private set; }

        public static IEnumerable<Fc4Statistics> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<Fc4Statistics> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<Fc4Statistics> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSFC_FC4STATISTICS");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new Fc4Statistics
                {
                     ControlRequests = (ulong) (managementObject.Properties["ControlRequests"]?.Value ?? default(ulong)),
		 InputMegabytes = (ulong) (managementObject.Properties["InputMegabytes"]?.Value ?? default(ulong)),
		 InputRequests = (ulong) (managementObject.Properties["InputRequests"]?.Value ?? default(ulong)),
		 OutputMegabytes = (ulong) (managementObject.Properties["OutputMegabytes"]?.Value ?? default(ulong)),
		 OutputRequests = (ulong) (managementObject.Properties["OutputRequests"]?.Value ?? default(ulong))
                };
        }
    }
}