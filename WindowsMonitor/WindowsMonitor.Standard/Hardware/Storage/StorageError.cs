using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor
{
    /// <summary>
    /// </summary>
    public sealed class StorageError
    {
		public string DeviceCreationClassName { get; private set; }
		public string DeviceId { get; private set; }
		public ulong EndingAddress { get; private set; }
		public ulong StartingAddress { get; private set; }
		public string SystemCreationClassName { get; private set; }
		public string SystemName { get; private set; }

        public static IEnumerable<StorageError> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<StorageError> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<StorageError> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_StorageError");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new StorageError
                {
                     DeviceCreationClassName = (string) (managementObject.Properties["DeviceCreationClassName"]?.Value),
		 DeviceId = (string) (managementObject.Properties["DeviceID"]?.Value),
		 EndingAddress = (ulong) (managementObject.Properties["EndingAddress"]?.Value ?? default(ulong)),
		 StartingAddress = (ulong) (managementObject.Properties["StartingAddress"]?.Value ?? default(ulong)),
		 SystemCreationClassName = (string) (managementObject.Properties["SystemCreationClassName"]?.Value),
		 SystemName = (string) (managementObject.Properties["SystemName"]?.Value)
                };
        }
    }
}