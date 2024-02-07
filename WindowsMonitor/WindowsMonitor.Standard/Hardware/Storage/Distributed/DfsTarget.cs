using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.Distributed
{
    /// <summary>
    /// </summary>
    public sealed class DfsTarget
    {
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public DateTime InstallDate { get; private set; }
		public string LinkName { get; private set; }
		public string Name { get; private set; }
		public string ServerName { get; private set; }
		public string ShareName { get; private set; }
		public uint State { get; private set; }
		public string Status { get; private set; }

        public static IEnumerable<DfsTarget> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<DfsTarget> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<DfsTarget> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_DfsTarget");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new DfsTarget
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 LinkName = (string) (managementObject.Properties["LinkName"]?.Value),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 ServerName = (string) (managementObject.Properties["ServerName"]?.Value),
		 ShareName = (string) (managementObject.Properties["ShareName"]?.Value),
		 State = (uint) (managementObject.Properties["State"]?.Value ?? default(uint)),
		 Status = (string) (managementObject.Properties["Status"]?.Value)
                };
        }
    }
}