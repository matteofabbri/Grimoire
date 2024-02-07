using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware
{
    /// <summary>
    /// </summary>
    public sealed class DeviceErrorCounts
    {
		public string Caption { get; private set; }
		public ulong CriticalErrorCount { get; private set; }
		public string Description { get; private set; }
		public string DeviceCreationClassName { get; private set; }
		public string DeviceId { get; private set; }
		public ulong IndeterminateErrorCount { get; private set; }
		public ulong MajorErrorCount { get; private set; }
		public ulong MinorErrorCount { get; private set; }
		public string Name { get; private set; }
		public string SystemCreationClassName { get; private set; }
		public string SystemName { get; private set; }
		public ulong WarningCount { get; private set; }

        public static IEnumerable<DeviceErrorCounts> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<DeviceErrorCounts> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<DeviceErrorCounts> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_DeviceErrorCounts");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new DeviceErrorCounts
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CriticalErrorCount = (ulong) (managementObject.Properties["CriticalErrorCount"]?.Value ?? default(ulong)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DeviceCreationClassName = (string) (managementObject.Properties["DeviceCreationClassName"]?.Value),
		 DeviceId = (string) (managementObject.Properties["DeviceID"]?.Value),
		 IndeterminateErrorCount = (ulong) (managementObject.Properties["IndeterminateErrorCount"]?.Value ?? default(ulong)),
		 MajorErrorCount = (ulong) (managementObject.Properties["MajorErrorCount"]?.Value ?? default(ulong)),
		 MinorErrorCount = (ulong) (managementObject.Properties["MinorErrorCount"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 SystemCreationClassName = (string) (managementObject.Properties["SystemCreationClassName"]?.Value),
		 SystemName = (string) (managementObject.Properties["SystemName"]?.Value),
		 WarningCount = (ulong) (managementObject.Properties["WarningCount"]?.Value ?? default(ulong))
                };
        }
    }
}