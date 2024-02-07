using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage
{
    /// <summary>
    /// </summary>
    public sealed class ClusterShare
    {
		public uint AccessMask { get; private set; }
		public bool AllowMaximum { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public DateTime InstallDate { get; private set; }
		public uint MaximumAllowed { get; private set; }
		public string Name { get; private set; }
		public string Path { get; private set; }
		public string ServerName { get; private set; }
		public string Status { get; private set; }
		public uint Type { get; private set; }

        public static IEnumerable<ClusterShare> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ClusterShare> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ClusterShare> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_ClusterShare");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ClusterShare
                {
                     AccessMask = (uint) (managementObject.Properties["AccessMask"]?.Value ?? default(uint)),
		 AllowMaximum = (bool) (managementObject.Properties["AllowMaximum"]?.Value ?? default(bool)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 MaximumAllowed = (uint) (managementObject.Properties["MaximumAllowed"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 Path = (string) (managementObject.Properties["Path"]?.Value),
		 ServerName = (string) (managementObject.Properties["ServerName"]?.Value),
		 Status = (string) (managementObject.Properties["Status"]?.Value),
		 Type = (uint) (managementObject.Properties["Type"]?.Value ?? default(uint))
                };
        }
    }
}