using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware
{
    /// <summary>
    /// </summary>
    public sealed class AgpInformation
    {
		public bool Active { get; private set; }
		public uint AgpCommand { get; private set; }
		public uint AgpStatus { get; private set; }
		public ulong ApertureBase { get; private set; }
		public uint ApertureLength { get; private set; }
		public string InstanceName { get; private set; }

        public static IEnumerable<AgpInformation> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<AgpInformation> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<AgpInformation> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSAgp_Information");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new AgpInformation
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 AgpCommand = (uint) (managementObject.Properties["AgpCommand"]?.Value ?? default(uint)),
		 AgpStatus = (uint) (managementObject.Properties["AgpStatus"]?.Value ?? default(uint)),
		 ApertureBase = (ulong) (managementObject.Properties["ApertureBase"]?.Value ?? default(ulong)),
		 ApertureLength = (uint) (managementObject.Properties["ApertureLength"]?.Value ?? default(uint)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string))
                };
        }
    }
}