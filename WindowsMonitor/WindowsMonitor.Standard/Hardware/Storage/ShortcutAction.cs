using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor
{
    /// <summary>
    /// </summary>
    public sealed class ShortcutAction
    {
		public string ActionId { get; private set; }
		public string Arguments { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ushort Direction { get; private set; }
		public ushort HotKey { get; private set; }
		public string IconIndex { get; private set; }
		public string Name { get; private set; }
		public string Shortcut { get; private set; }
		public ushort ShowCmd { get; private set; }
		public string SoftwareElementId { get; private set; }
		public ushort SoftwareElementState { get; private set; }
		public string Target { get; private set; }
		public ushort TargetOperatingSystem { get; private set; }
		public string Version { get; private set; }
		public string WkDir { get; private set; }

        public static IEnumerable<ShortcutAction> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ShortcutAction> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ShortcutAction> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_ShortcutAction");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ShortcutAction
                {
                     ActionId = (string) (managementObject.Properties["ActionID"]?.Value),
		 Arguments = (string) (managementObject.Properties["Arguments"]?.Value),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 Direction = (ushort) (managementObject.Properties["Direction"]?.Value ?? default(ushort)),
		 HotKey = (ushort) (managementObject.Properties["HotKey"]?.Value ?? default(ushort)),
		 IconIndex = (string) (managementObject.Properties["IconIndex"]?.Value),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 Shortcut = (string) (managementObject.Properties["Shortcut"]?.Value),
		 ShowCmd = (ushort) (managementObject.Properties["ShowCmd"]?.Value ?? default(ushort)),
		 SoftwareElementId = (string) (managementObject.Properties["SoftwareElementID"]?.Value),
		 SoftwareElementState = (ushort) (managementObject.Properties["SoftwareElementState"]?.Value ?? default(ushort)),
		 Target = (string) (managementObject.Properties["Target"]?.Value),
		 TargetOperatingSystem = (ushort) (managementObject.Properties["TargetOperatingSystem"]?.Value ?? default(ushort)),
		 Version = (string) (managementObject.Properties["Version"]?.Value),
		 WkDir = (string) (managementObject.Properties["WkDir"]?.Value)
                };
        }
    }
}