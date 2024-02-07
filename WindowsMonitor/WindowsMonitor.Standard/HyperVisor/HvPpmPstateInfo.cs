using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.HyperVisor
{
    /// <summary>
    /// </summary>
    public sealed class HvPpmPstateInfo
    {
		public ulong Frequency0 { get; private set; }
		public ulong Frequency1 { get; private set; }
		public ulong Frequency2 { get; private set; }
		public ulong PercentageOfMaxFrequency0 { get; private set; }
		public ulong PercentageOfMaxFrequency1 { get; private set; }
		public ulong PercentageOfMaxFrequency2 { get; private set; }

        public static IEnumerable<HvPpmPstateInfo> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HvPpmPstateInfo> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HvPpmPstateInfo> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HvPpmPstateInfo");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HvPpmPstateInfo
                {
                     Frequency0 = (ulong) (managementObject.Properties["Frequency0"]?.Value ?? default(ulong)),
		 Frequency1 = (ulong) (managementObject.Properties["Frequency1"]?.Value ?? default(ulong)),
		 Frequency2 = (ulong) (managementObject.Properties["Frequency2"]?.Value ?? default(ulong)),
		 PercentageOfMaxFrequency0 = (ulong) (managementObject.Properties["PercentageOfMaxFrequency0"]?.Value ?? default(ulong)),
		 PercentageOfMaxFrequency1 = (ulong) (managementObject.Properties["PercentageOfMaxFrequency1"]?.Value ?? default(ulong)),
		 PercentageOfMaxFrequency2 = (ulong) (managementObject.Properties["PercentageOfMaxFrequency2"]?.Value ?? default(ulong))
                };
        }
    }
}