using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Bios
{
    /// <summary>
    /// </summary>
    public sealed class SmBiosSysid1394
    {
		public byte[] X1394 { get; private set; }

        public static IEnumerable<SmBiosSysid1394> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SmBiosSysid1394> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SmBiosSysid1394> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSSmBios_Sysid1394");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SmBiosSysid1394
                {
                     X1394 = (byte[]) (managementObject.Properties["x1394"]?.Value ?? new byte[0])
                };
        }
    }
}