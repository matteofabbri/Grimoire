using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network.Atm
{
    /// <summary>
    /// </summary>
    public sealed class AtmTransmitCellsOk
    {
		public bool Active { get; private set; }
		public string InstanceName { get; private set; }
		public ulong NdisAtmTransmitCellsOk { get; private set; }

        public static IEnumerable<AtmTransmitCellsOk> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<AtmTransmitCellsOk> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<AtmTransmitCellsOk> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_AtmTransmitCellsOk");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new AtmTransmitCellsOk
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 NdisAtmTransmitCellsOk = (ulong) (managementObject.Properties["NdisAtmTransmitCellsOk"]?.Value ?? default(ulong))
                };
        }
    }
}