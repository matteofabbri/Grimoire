using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Software.COM
{
    /// <summary>
    /// </summary>
    public sealed class ClassicComClass
    {
		public string Caption { get; private set; }
		public string ComponentId { get; private set; }
		public string Description { get; private set; }
		public DateTime InstallDate { get; private set; }
		public string Name { get; private set; }
		public string Status { get; private set; }

        public static IEnumerable<ClassicComClass> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ClassicComClass> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ClassicComClass> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_ClassicCOMClass");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ClassicComClass
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 ComponentId = (string) (managementObject.Properties["ComponentId"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 Status = (string) (managementObject.Properties["Status"]?.Value)
                };
        }
    }
}