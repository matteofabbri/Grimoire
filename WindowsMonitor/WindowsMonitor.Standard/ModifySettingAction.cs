using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor
{
    /// <summary>
    /// </summary>
    public sealed class ModifySettingAction
    {
		public string ActionId { get; private set; }
		public ushort ActionType { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ushort Direction { get; private set; }
		public string EntryName { get; private set; }
		public string EntryValue { get; private set; }
		public string FileName { get; private set; }
		public string Name { get; private set; }
		public string SectionKey { get; private set; }
		public string SoftwareElementId { get; private set; }
		public ushort SoftwareElementState { get; private set; }
		public ushort TargetOperatingSystem { get; private set; }
		public string Version { get; private set; }

        public static IEnumerable<ModifySettingAction> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ModifySettingAction> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ModifySettingAction> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_ModifySettingAction");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ModifySettingAction
                {
                     ActionId = (string) (managementObject.Properties["ActionID"]?.Value),
		 ActionType = (ushort) (managementObject.Properties["ActionType"]?.Value ?? default(ushort)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 Direction = (ushort) (managementObject.Properties["Direction"]?.Value ?? default(ushort)),
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