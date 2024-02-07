using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.MSStorageDriver
{
    /// <summary>
    /// </summary>
    public sealed class FailurePredictStatus
    {
		public bool Active { get; private set; }
		public string InstanceName { get; private set; }
		public bool PredictFailure { get; private set; }
		public uint Reason { get; private set; }

        public static IEnumerable<FailurePredictStatus> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<FailurePredictStatus> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<FailurePredictStatus> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSStorageDriver_FailurePredictStatus");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new FailurePredictStatus
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 PredictFailure = (bool) (managementObject.Properties["PredictFailure"]?.Value ?? default(bool)),
		 Reason = (uint) (managementObject.Properties["Reason"]?.Value ?? default(uint))
                };
        }
    }
}