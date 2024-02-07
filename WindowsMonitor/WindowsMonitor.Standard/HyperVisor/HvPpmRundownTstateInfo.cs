using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.HyperVisor
{
    /// <summary>
    /// </summary>
    public sealed class HvPpmRundownTstateInfo
    {
		public ulong PercentageOfFrequency0 { get; private set; }
		public ulong PercentageOfFrequency1 { get; private set; }
		public ulong PercentageOfFrequency2 { get; private set; }
		public ulong PercentageOfMinFrequency0 { get; private set; }
		public ulong PercentageOfMinFrequency1 { get; private set; }
		public ulong PercentageOfMinFrequency2 { get; private set; }

        public static IEnumerable<HvPpmRundownTstateInfo> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HvPpmRundownTstateInfo> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HvPpmRundownTstateInfo> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HvPpmRundownTstateInfo");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HvPpmRundownTstateInfo
                {
                     PercentageOfFrequency0 = (ulong) (managementObject.Properties["PercentageOfFrequency0"]?.Value ?? default(ulong)),
		 PercentageOfFrequency1 = (ulong) (managementObject.Properties["PercentageOfFrequency1"]?.Value ?? default(ulong)),
		 PercentageOfFrequency2 = (ulong) (managementObject.Properties["PercentageOfFrequency2"]?.Value ?? default(ulong)),
		 PercentageOfMinFrequency0 = (ulong) (managementObject.Properties["PercentageOfMinFrequency0"]?.Value ?? default(ulong)),
		 PercentageOfMinFrequency1 = (ulong) (managementObject.Properties["PercentageOfMinFrequency1"]?.Value ?? default(ulong)),
		 PercentageOfMinFrequency2 = (ulong) (managementObject.Properties["PercentageOfMinFrequency2"]?.Value ?? default(ulong))
                };
        }
    }
}