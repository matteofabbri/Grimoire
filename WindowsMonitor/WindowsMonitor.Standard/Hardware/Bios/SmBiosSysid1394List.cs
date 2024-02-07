using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Bios
{
    /// <summary>
    /// </summary>
    public sealed class SmBiosSysid1394List
    {
		public bool Active { get; private set; }
		public uint Count { get; private set; }
		public string InstanceName { get; private set; }
		public dynamic[] List { get; private set; }

        public static IEnumerable<SmBiosSysid1394List> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SmBiosSysid1394List> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SmBiosSysid1394List> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSSmBios_Sysid1394List");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SmBiosSysid1394List
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 Count = (uint) (managementObject.Properties["Count"]?.Value ?? default(uint)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 List = (dynamic[]) (managementObject.Properties["List"]?.Value ?? new dynamic[0])
                };
        }
    }
}