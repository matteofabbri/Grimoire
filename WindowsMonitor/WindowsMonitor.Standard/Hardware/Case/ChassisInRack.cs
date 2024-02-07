using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Case
{
    /// <summary>
    /// </summary>
    public sealed class ChassisInRack
    {
		public ushort BottomU { get; private set; }
		public string GroupComponent { get; private set; }
		public string LocationWithinContainer { get; private set; }
		public string PartComponent { get; private set; }

        public static IEnumerable<ChassisInRack> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ChassisInRack> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ChassisInRack> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_ChassisInRack");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ChassisInRack
                {
                     BottomU = (ushort) (managementObject.Properties["BottomU"]?.Value ?? default(ushort)),
		 GroupComponent = (string) (managementObject.Properties["GroupComponent"]?.Value ?? default(string)),
		 LocationWithinContainer = (string) (managementObject.Properties["LocationWithinContainer"]?.Value),
		 PartComponent = (string) (managementObject.Properties["PartComponent"]?.Value ?? default(string))
                };
        }
    }
}