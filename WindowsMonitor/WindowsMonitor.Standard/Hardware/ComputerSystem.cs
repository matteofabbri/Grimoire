using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware
{
    /// <summary>
    /// </summary>
    public sealed class ComputerSystem
    {
		public string Caption { get; private set; }
		public string CreationClassName { get; private set; }
		public string Description { get; private set; }
		public DateTime InstallDate { get; private set; }
		public string Name { get; private set; }
		public string NameFormat { get; private set; }
		public string PrimaryOwnerContact { get; private set; }
		public string PrimaryOwnerName { get; private set; }
		public string[] Roles { get; private set; }
		public string Status { get; private set; }

        public static IEnumerable<ComputerSystem> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ComputerSystem> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ComputerSystem> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_ComputerSystem");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ComputerSystem
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CreationClassName = (string) (managementObject.Properties["CreationClassName"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 NameFormat = (string) (managementObject.Properties["NameFormat"]?.Value),
		 PrimaryOwnerContact = (string) (managementObject.Properties["PrimaryOwnerContact"]?.Value),
		 PrimaryOwnerName = (string) (managementObject.Properties["PrimaryOwnerName"]?.Value),
		 Roles = (string[]) (managementObject.Properties["Roles"]?.Value ?? new string[0]),
		 Status = (string) (managementObject.Properties["Status"]?.Value)
                };
        }
    }
}