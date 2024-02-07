using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.MSStorageDriver
{
    /// <summary>
    /// </summary>
    public sealed class FailurePredictThresholds
    {
		public bool Active { get; private set; }
		public string InstanceName { get; private set; }
		public byte[] VendorSpecific { get; private set; }

        public static IEnumerable<FailurePredictThresholds> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<FailurePredictThresholds> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<FailurePredictThresholds> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSStorageDriver_FailurePredictThresholds");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new FailurePredictThresholds
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 VendorSpecific = (byte[]) (managementObject.Properties["VendorSpecific"]?.Value ?? new byte[0])
                };
        }
    }
}