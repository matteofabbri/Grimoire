using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network.Status
{
    /// <summary>
    /// </summary>
    public sealed class StatusDevicePowerOffEx
    {
		public bool Active { get; private set; }
		public string Device { get; private set; }
		public string InstanceName { get; private set; }
		public byte[] SecurityDescriptor { get; private set; }
		public ulong TimeCreated { get; private set; }

        public static IEnumerable<StatusDevicePowerOffEx> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<StatusDevicePowerOffEx> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<StatusDevicePowerOffEx> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_StatusDevicePowerOffEx");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new StatusDevicePowerOffEx
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 Device = (string) (managementObject.Properties["Device"]?.Value ?? default(string)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 SecurityDescriptor = (byte[]) (managementObject.Properties["SECURITY_DESCRIPTOR"]?.Value ?? new byte[0]),
		 TimeCreated = (ulong) (managementObject.Properties["TIME_CREATED"]?.Value ?? default(ulong))
                };
        }
    }
}