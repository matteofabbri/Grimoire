using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.HBA.Msfc
{
    /// <summary>
    /// </summary>
    public sealed class Tm
    {
		public uint TmHour { get; private set; }
		public uint TmIsdst { get; private set; }
		public uint TmMday { get; private set; }
		public uint TmMin { get; private set; }
		public uint TmMon { get; private set; }
		public uint TmSec { get; private set; }
		public uint TmWday { get; private set; }
		public uint TmYday { get; private set; }
		public uint TmYear { get; private set; }

        public static IEnumerable<Tm> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<Tm> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<Tm> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSFC_TM");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new Tm
                {
                     TmHour = (uint) (managementObject.Properties["tm_hour"]?.Value ?? default(uint)),
		 TmIsdst = (uint) (managementObject.Properties["tm_isdst"]?.Value ?? default(uint)),
		 TmMday = (uint) (managementObject.Properties["tm_mday"]?.Value ?? default(uint)),
		 TmMin = (uint) (managementObject.Properties["tm_min"]?.Value ?? default(uint)),
		 TmMon = (uint) (managementObject.Properties["tm_mon"]?.Value ?? default(uint)),
		 TmSec = (uint) (managementObject.Properties["tm_sec"]?.Value ?? default(uint)),
		 TmWday = (uint) (managementObject.Properties["tm_wday"]?.Value ?? default(uint)),
		 TmYday = (uint) (managementObject.Properties["tm_yday"]?.Value ?? default(uint)),
		 TmYear = (uint) (managementObject.Properties["tm_year"]?.Value ?? default(uint))
                };
        }
    }
}