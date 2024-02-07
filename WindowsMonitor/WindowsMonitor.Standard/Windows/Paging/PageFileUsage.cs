using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Paging
{
    /// <summary>
    /// </summary>
    public sealed class PageFileUsage
    {
		public uint AllocatedBaseSize { get; private set; }
		public string Caption { get; private set; }
		public uint CurrentUsage { get; private set; }
		public string Description { get; private set; }
		public DateTime InstallDate { get; private set; }
		public string Name { get; private set; }
		public uint PeakUsage { get; private set; }
		public string Status { get; private set; }
		public bool TempPageFile { get; private set; }

        public static IEnumerable<PageFileUsage> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<PageFileUsage> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<PageFileUsage> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PageFileUsage");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new PageFileUsage
                {
                     AllocatedBaseSize = (uint) (managementObject.Properties["AllocatedBaseSize"]?.Value ?? default(uint)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CurrentUsage = (uint) (managementObject.Properties["CurrentUsage"]?.Value ?? default(uint)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 PeakUsage = (uint) (managementObject.Properties["PeakUsage"]?.Value ?? default(uint)),
		 Status = (string) (managementObject.Properties["Status"]?.Value),
		 TempPageFile = (bool) (managementObject.Properties["TempPageFile"]?.Value ?? default(bool))
                };
        }
    }
}