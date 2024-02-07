using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network.StatusDot11
{
    /// <summary>
    /// </summary>
    public sealed class StatusDot11AssociationStart
    {
		public bool Active { get; private set; }
		public string InstanceName { get; private set; }
		public byte[] NdisStatusDot11AssociationStartIndication { get; private set; }
		public uint NumberElements { get; private set; }
		public byte[] SecurityDescriptor { get; private set; }
		public ulong TimeCreated { get; private set; }

        public static IEnumerable<StatusDot11AssociationStart> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<StatusDot11AssociationStart> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<StatusDot11AssociationStart> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_StatusDot11AssociationStart");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new StatusDot11AssociationStart
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 NdisStatusDot11AssociationStartIndication = (byte[]) (managementObject.Properties["NdisStatusDot11AssociationStartIndication"]?.Value ?? new byte[0]),
		 NumberElements = (uint) (managementObject.Properties["NumberElements"]?.Value ?? default(uint)),
		 SecurityDescriptor = (byte[]) (managementObject.Properties["SECURITY_DESCRIPTOR"]?.Value ?? new byte[0]),
		 TimeCreated = (ulong) (managementObject.Properties["TIME_CREATED"]?.Value ?? default(ulong))
                };
        }
    }
}