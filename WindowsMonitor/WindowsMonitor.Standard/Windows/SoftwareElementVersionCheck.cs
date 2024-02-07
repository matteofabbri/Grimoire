using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows
{
    /// <summary>
    /// </summary>
    public sealed class SoftwareElementVersionCheck
    {
		public string Caption { get; private set; }
		public string CheckId { get; private set; }
		public bool CheckMode { get; private set; }
		public string Description { get; private set; }
		public string LowerSoftwareElementVersion { get; private set; }
		public string Name { get; private set; }
		public string SoftwareElementId { get; private set; }
		public string SoftwareElementName { get; private set; }
		public ushort SoftwareElementState { get; private set; }
		public ushort SoftwareElementStateDesired { get; private set; }
		public ushort TargetOperatingSystem { get; private set; }
		public ushort TargetOperatingSystemDesired { get; private set; }
		public string UpperSoftwareElementVersion { get; private set; }
		public string Version { get; private set; }

        public static IEnumerable<SoftwareElementVersionCheck> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SoftwareElementVersionCheck> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SoftwareElementVersionCheck> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_SoftwareElementVersionCheck");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SoftwareElementVersionCheck
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CheckId = (string) (managementObject.Properties["CheckID"]?.Value),
		 CheckMode = (bool) (managementObject.Properties["CheckMode"]?.Value ?? default(bool)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 LowerSoftwareElementVersion = (string) (managementObject.Properties["LowerSoftwareElementVersion"]?.Value),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 SoftwareElementId = (string) (managementObject.Properties["SoftwareElementID"]?.Value),
		 SoftwareElementName = (string) (managementObject.Properties["SoftwareElementName"]?.Value),
		 SoftwareElementState = (ushort) (managementObject.Properties["SoftwareElementState"]?.Value ?? default(ushort)),
		 SoftwareElementStateDesired = (ushort) (managementObject.Properties["SoftwareElementStateDesired"]?.Value ?? default(ushort)),
		 TargetOperatingSystem = (ushort) (managementObject.Properties["TargetOperatingSystem"]?.Value ?? default(ushort)),
		 TargetOperatingSystemDesired = (ushort) (managementObject.Properties["TargetOperatingSystemDesired"]?.Value ?? default(ushort)),
		 UpperSoftwareElementVersion = (string) (managementObject.Properties["UpperSoftwareElementVersion"]?.Value),
		 Version = (string) (managementObject.Properties["Version"]?.Value)
                };
        }
    }
}