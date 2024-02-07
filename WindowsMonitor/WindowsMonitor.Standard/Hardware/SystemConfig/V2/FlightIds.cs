using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.SystemConfig.V2
{
    /// <summary>
    /// </summary>
    public sealed class FlightIds
    {
		public uint Flags { get; private set; }
		public string FlightIdList { get; private set; }
		public string UpdateId { get; private set; }

        public static IEnumerable<FlightIds> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<FlightIds> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<FlightIds> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM SystemConfig_V2_FlightIds");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new FlightIds
                {
                     Flags = (uint) (managementObject.Properties["Flags"]?.Value ?? default(uint)),
		 FlightIdList = (string) (managementObject.Properties["FlightIdList"]?.Value ?? default(string)),
		 UpdateId = (string) (managementObject.Properties["UpdateId"]?.Value ?? default(string))
                };
        }
    }
}