using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Software
{
    /// <summary>
    /// </summary>
    public sealed class SoftwareFeature
    {
		public ushort Accesses { get; private set; }
		public ushort Attributes { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public string IdentifyingNumber { get; private set; }
		public DateTime InstallDate { get; private set; }
		public string InstallState { get; private set; }
		public DateTime LastUse { get; private set; }
		public string Name { get; private set; }
		public string ProductName { get; private set; }
		public string Status { get; private set; }
		public string Vendor { get; private set; }
		public string Version { get; private set; }

        public static IEnumerable<SoftwareFeature> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SoftwareFeature> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SoftwareFeature> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_SoftwareFeature");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SoftwareFeature
                {
                     Accesses = (ushort) (managementObject.Properties["Accesses"]?.Value ?? default(ushort)),
		 Attributes = (ushort) (managementObject.Properties["Attributes"]?.Value ?? default(ushort)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 IdentifyingNumber = (string) (managementObject.Properties["IdentifyingNumber"]?.Value),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 InstallState =  (managementObject.Properties["InstallState"]?.Value?.ToString()),
		 LastUse = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["LastUse"]?.Value as string ?? "00010102000000.000000+060"),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 ProductName = (string) (managementObject.Properties["ProductName"]?.Value),
		 Status = (string) (managementObject.Properties["Status"]?.Value),
		 Vendor = (string) (managementObject.Properties["Vendor"]?.Value),
		 Version = (string) (managementObject.Properties["Version"]?.Value)
                };
        }
    }
}