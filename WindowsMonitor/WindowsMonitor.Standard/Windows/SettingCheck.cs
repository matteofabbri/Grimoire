using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows
{
    /// <summary>
    /// </summary>
    public sealed class SettingCheck
    {
		public string Caption { get; private set; }
		public string CheckId { get; private set; }
		public bool CheckMode { get; private set; }
		public ushort CheckType { get; private set; }
		public string Description { get; private set; }
		public string EntryName { get; private set; }
		public string EntryValue { get; private set; }
		public string FileName { get; private set; }
		public string Name { get; private set; }
		public string SectionKey { get; private set; }
		public string SoftwareElementId { get; private set; }
		public ushort SoftwareElementState { get; private set; }
		public ushort TargetOperatingSystem { get; private set; }
		public string Version { get; private set; }

        public static IEnumerable<SettingCheck> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SettingCheck> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SettingCheck> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_SettingCheck");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SettingCheck
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CheckId = (string) (managementObject.Properties["CheckID"]?.Value),
		 CheckMode = (bool) (managementObject.Properties["CheckMode"]?.Value ?? default(bool)),
		 CheckType = (ushort) (managementObject.Properties["CheckType"]?.Value ?? default(ushort)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 EntryName = (string) (managementObject.Properties["EntryName"]?.Value),
		 EntryValue = (string) (managementObject.Properties["EntryValue"]?.Value),
		 FileName = (string) (managementObject.Properties["FileName"]?.Value),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 SectionKey = (string) (managementObject.Properties["SectionKey"]?.Value),
		 SoftwareElementId = (string) (managementObject.Properties["SoftwareElementID"]?.Value),
		 SoftwareElementState = (ushort) (managementObject.Properties["SoftwareElementState"]?.Value ?? default(ushort)),
		 TargetOperatingSystem = (ushort) (managementObject.Properties["TargetOperatingSystem"]?.Value ?? default(ushort)),
		 Version = (string) (managementObject.Properties["Version"]?.Value)
                };
        }
    }
}