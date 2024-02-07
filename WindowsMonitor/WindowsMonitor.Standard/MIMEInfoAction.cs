using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor
{
    /// <summary>
    /// </summary>
    public sealed class MimeInfoAction
    {
		public string ActionId { get; private set; }
		public string Caption { get; private set; }
		public string Clsid { get; private set; }
		public string ContentType { get; private set; }
		public string Description { get; private set; }
		public ushort Direction { get; private set; }
		public string Extension { get; private set; }
		public string Name { get; private set; }
		public string SoftwareElementId { get; private set; }
		public ushort SoftwareElementState { get; private set; }
		public ushort TargetOperatingSystem { get; private set; }
		public string Version { get; private set; }

        public static IEnumerable<MimeInfoAction> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<MimeInfoAction> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<MimeInfoAction> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_MIMEInfoAction");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new MimeInfoAction
                {
                     ActionId = (string) (managementObject.Properties["ActionID"]?.Value),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Clsid = (string) (managementObject.Properties["CLSID"]?.Value),
		 ContentType = (string) (managementObject.Properties["ContentType"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 Direction = (ushort) (managementObject.Properties["Direction"]?.Value ?? default(ushort)),
		 Extension = (string) (managementObject.Properties["Extension"]?.Value),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 SoftwareElementId = (string) (managementObject.Properties["SoftwareElementID"]?.Value),
		 SoftwareElementState = (ushort) (managementObject.Properties["SoftwareElementState"]?.Value ?? default(ushort)),
		 TargetOperatingSystem = (ushort) (managementObject.Properties["TargetOperatingSystem"]?.Value ?? default(ushort)),
		 Version = (string) (managementObject.Properties["Version"]?.Value)
                };
        }
    }
}