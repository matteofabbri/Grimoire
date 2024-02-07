using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Video.WmiMonitor
{
    /// <summary>
    /// </summary>
    public sealed class WmiMonitorId
    {
		public bool Active { get; private set; }
		public string InstanceName { get; private set; }
		public ushort[] ManufacturerName { get; private set; }
		public ushort[] ProductCodeId { get; private set; }
		public ushort[] SerialNumberId { get; private set; }
		public ushort[] UserFriendlyName { get; private set; }
		public ushort UserFriendlyNameLength { get; private set; }
		public byte WeekOfManufacture { get; private set; }
		public ushort YearOfManufacture { get; private set; }

        public static IEnumerable<WmiMonitorId> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<WmiMonitorId> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<WmiMonitorId> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM WmiMonitorID");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new WmiMonitorId
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 ManufacturerName = (ushort[]) (managementObject.Properties["ManufacturerName"]?.Value ?? new ushort[0]),
		 ProductCodeId = (ushort[]) (managementObject.Properties["ProductCodeID"]?.Value ?? new ushort[0]),
		 SerialNumberId = (ushort[]) (managementObject.Properties["SerialNumberID"]?.Value ?? new ushort[0]),
		 UserFriendlyName = (ushort[]) (managementObject.Properties["UserFriendlyName"]?.Value ?? new ushort[0]),
		 UserFriendlyNameLength = (ushort) (managementObject.Properties["UserFriendlyNameLength"]?.Value ?? default(ushort)),
		 WeekOfManufacture = (byte) (managementObject.Properties["WeekOfManufacture"]?.Value ?? default(byte)),
		 YearOfManufacture = (ushort) (managementObject.Properties["YearOfManufacture"]?.Value ?? default(ushort))
                };
        }
    }
}