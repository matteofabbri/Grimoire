using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.SystemConfig.V2
{
    /// <summary>
    /// </summary>
    public sealed class ProcGroup
    {
		public uint[] Affinity { get; private set; }
		public uint Flags { get; private set; }
		public uint GroupCount { get; private set; }

        public static IEnumerable<ProcGroup> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ProcGroup> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ProcGroup> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM SystemConfig_V2_ProcGroup");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ProcGroup
                {
                     Affinity = (uint[]) (managementObject.Properties["Affinity"]?.Value ?? new uint[0]),
		 Flags = (uint) (managementObject.Properties["Flags"]?.Value ?? default(uint)),
		 GroupCount = (uint) (managementObject.Properties["GroupCount"]?.Value ?? default(uint))
                };
        }
    }
}