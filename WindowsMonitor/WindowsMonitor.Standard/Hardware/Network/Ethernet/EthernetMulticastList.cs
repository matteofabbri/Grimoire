using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network.Ethernet
{
    /// <summary>
    /// </summary>
    public sealed class EthernetMulticastList
    {
		public bool Active { get; private set; }
		public string InstanceName { get; private set; }
		public dynamic[] NdisMulticastList { get; private set; }
		public uint NumberElements { get; private set; }

        public static IEnumerable<EthernetMulticastList> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<EthernetMulticastList> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<EthernetMulticastList> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_EthernetMulticastList");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new EthernetMulticastList
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 NdisMulticastList = (dynamic[]) (managementObject.Properties["NdisMulticastList"]?.Value ?? new dynamic[0]),
		 NumberElements = (uint) (managementObject.Properties["NumberElements"]?.Value ?? default(uint))
                };
        }
    }
}