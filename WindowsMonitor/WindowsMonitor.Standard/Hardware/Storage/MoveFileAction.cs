using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor
{
    /// <summary>
    /// </summary>
    public sealed class MoveFileAction
    {
		public string ActionId { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public string DestFolder { get; private set; }
		public string DestName { get; private set; }
		public ushort Direction { get; private set; }
		public string FileKey { get; private set; }
		public string Name { get; private set; }
		public ushort Options { get; private set; }
		public string SoftwareElementId { get; private set; }
		public ushort SoftwareElementState { get; private set; }
		public string SourceFolder { get; private set; }
		public string SourceName { get; private set; }
		public ushort TargetOperatingSystem { get; private set; }
		public string Version { get; private set; }

        public static IEnumerable<MoveFileAction> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<MoveFileAction> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<MoveFileAction> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_MoveFileAction");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new MoveFileAction
                {
                     ActionId = (string) (managementObject.Properties["ActionID"]?.Value),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DestFolder = (string) (managementObject.Properties["DestFolder"]?.Value),
		 DestName = (string) (managementObject.Properties["DestName"]?.Value),
		 Direction = (ushort) (managementObject.Properties["Direction"]?.Value ?? default(ushort)),
		 FileKey = (string) (managementObject.Properties["FileKey"]?.Value),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 Options = (ushort) (managementObject.Properties["Options"]?.Value ?? default(ushort)),
		 SoftwareElementId = (string) (managementObject.Properties["SoftwareElementID"]?.Value),
		 SoftwareElementState = (ushort) (managementObject.Properties["SoftwareElementState"]?.Value ?? default(ushort)),
		 SourceFolder = (string) (managementObject.Properties["SourceFolder"]?.Value),
		 SourceName = (string) (managementObject.Properties["SourceName"]?.Value),
		 TargetOperatingSystem = (ushort) (managementObject.Properties["TargetOperatingSystem"]?.Value ?? default(ushort)),
		 Version = (string) (managementObject.Properties["Version"]?.Value)
                };
        }
    }
}