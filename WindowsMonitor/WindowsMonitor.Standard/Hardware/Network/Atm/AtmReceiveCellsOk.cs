using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network.Atm
{
    /// <summary>
    /// </summary>
    public sealed class AtmReceiveCellsOk
    {
		public bool Active { get; private set; }
		public string InstanceName { get; private set; }
		public ulong NdisAtmReceiveCellsOk { get; private set; }

        public static IEnumerable<AtmReceiveCellsOk> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<AtmReceiveCellsOk> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<AtmReceiveCellsOk> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_AtmReceiveCellsOk");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new AtmReceiveCellsOk
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 NdisAtmReceiveCellsOk = (ulong) (managementObject.Properties["NdisAtmReceiveCellsOk"]?.Value ?? default(ulong))
                };
        }
    }
}