using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor
{
    /// <summary>
    /// </summary>
    public sealed class StorageRedundancyGroup
    {
		public string Caption { get; private set; }
		public string CreationClassName { get; private set; }
		public string Description { get; private set; }
		public DateTime InstallDate { get; private set; }
		public string Name { get; private set; }
		public ushort RedundancyStatus { get; private set; }
		public string Status { get; private set; }
		public ushort TypeOfAlgorithm { get; private set; }

        public static IEnumerable<StorageRedundancyGroup> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<StorageRedundancyGroup> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<StorageRedundancyGroup> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_StorageRedundancyGroup");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new StorageRedundancyGroup
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CreationClassName = (string) (managementObject.Properties["CreationClassName"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 RedundancyStatus = (ushort) (managementObject.Properties["RedundancyStatus"]?.Value ?? default(ushort)),
		 Status = (string) (managementObject.Properties["Status"]?.Value),
		 TypeOfAlgorithm = (ushort) (managementObject.Properties["TypeOfAlgorithm"]?.Value ?? default(ushort))
                };
        }
    }
}