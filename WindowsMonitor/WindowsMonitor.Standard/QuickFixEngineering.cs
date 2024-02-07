using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor
{
    /// <summary>
    /// </summary>
    public sealed class QuickFixEngineering
    {
		public string Caption { get; private set; }
		public string CsName { get; private set; }
		public string Description { get; private set; }
		public string FixComments { get; private set; }
		public string HotFixId { get; private set; }
		public DateTime InstallDate { get; private set; }
		public string InstalledBy { get; private set; }
		public string InstalledOn { get; private set; }
		public string Name { get; private set; }
		public string ServicePackInEffect { get; private set; }
		public string Status { get; private set; }

        public static IEnumerable<QuickFixEngineering> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<QuickFixEngineering> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<QuickFixEngineering> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_QuickFixEngineering");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new QuickFixEngineering
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CsName = (string) (managementObject.Properties["CSName"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FixComments = (string) (managementObject.Properties["FixComments"]?.Value),
		 HotFixId = (string) (managementObject.Properties["HotFixID"]?.Value),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 InstalledBy = (string) (managementObject.Properties["InstalledBy"]?.Value),
		 InstalledOn = (string) (managementObject.Properties["InstalledOn"]?.Value),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 ServicePackInEffect = (string) (managementObject.Properties["ServicePackInEffect"]?.Value),
		 Status = (string) (managementObject.Properties["Status"]?.Value)
                };
        }
    }
}