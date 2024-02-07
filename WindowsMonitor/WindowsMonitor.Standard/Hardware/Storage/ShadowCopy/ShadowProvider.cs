using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.ShadowCopy
{
    /// <summary>
    /// </summary>
    public sealed class ShadowProvider
    {
		public string Caption { get; private set; }
		public string Clsid { get; private set; }
		public string Description { get; private set; }
		public string Id { get; private set; }
		public DateTime InstallDate { get; private set; }
		public string Name { get; private set; }
		public string Status { get; private set; }
		public uint Type { get; private set; }
		public string Version { get; private set; }
		public string VersionId { get; private set; }

        public static IEnumerable<ShadowProvider> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ShadowProvider> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ShadowProvider> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_ShadowProvider");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ShadowProvider
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Clsid = (string) (managementObject.Properties["CLSID"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 Id = (string) (managementObject.Properties["ID"]?.Value),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 Status = (string) (managementObject.Properties["Status"]?.Value),
		 Type = (uint) (managementObject.Properties["Type"]?.Value ?? default(uint)),
		 Version = (string) (managementObject.Properties["Version"]?.Value),
		 VersionId = (string) (managementObject.Properties["VersionID"]?.Value)
                };
        }
    }
}