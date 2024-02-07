using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.PnP
{
    /// <summary>
    /// </summary>
    public sealed class PnPSignedDriver
    {
		public string Caption { get; private set; }
		public string ClassGuid { get; private set; }
		public string CompatId { get; private set; }
		public string CreationClassName { get; private set; }
		public string Description { get; private set; }
		public string DeviceClass { get; private set; }
		public string DeviceId { get; private set; }
		public string DeviceName { get; private set; }
		public string DevLoader { get; private set; }
		public DateTime DriverDate { get; private set; }
		public string DriverName { get; private set; }
		public string DriverProviderName { get; private set; }
		public string DriverVersion { get; private set; }
		public string FriendlyName { get; private set; }
		public string HardWareId { get; private set; }
		public string InfName { get; private set; }
		public DateTime InstallDate { get; private set; }
		public bool IsSigned { get; private set; }
		public string Location { get; private set; }
		public string Manufacturer { get; private set; }
		public string Name { get; private set; }
		public string Pdo { get; private set; }
		public string Signer { get; private set; }
		public bool Started { get; private set; }
		public string StartMode { get; private set; }
		public string Status { get; private set; }
		public string SystemCreationClassName { get; private set; }
		public string SystemName { get; private set; }

        public static IEnumerable<PnPSignedDriver> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<PnPSignedDriver> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<PnPSignedDriver> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PnPSignedDriver");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new PnPSignedDriver
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 ClassGuid = (string) (managementObject.Properties["ClassGuid"]?.Value),
		 CompatId = (string) (managementObject.Properties["CompatID"]?.Value),
		 CreationClassName = (string) (managementObject.Properties["CreationClassName"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DeviceClass = (string) (managementObject.Properties["DeviceClass"]?.Value),
		 DeviceId = (string) (managementObject.Properties["DeviceID"]?.Value),
		 DeviceName = (string) (managementObject.Properties["DeviceName"]?.Value),
		 DevLoader = (string) (managementObject.Properties["DevLoader"]?.Value),
		 DriverDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["DriverDate"]?.Value as string ?? "00010102000000.000000+060"),
		 DriverName = (string) (managementObject.Properties["DriverName"]?.Value),
		 DriverProviderName = (string) (managementObject.Properties["DriverProviderName"]?.Value),
		 DriverVersion = (string) (managementObject.Properties["DriverVersion"]?.Value),
		 FriendlyName = (string) (managementObject.Properties["FriendlyName"]?.Value),
		 HardWareId = (string) (managementObject.Properties["HardWareID"]?.Value),
		 InfName = (string) (managementObject.Properties["InfName"]?.Value),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 IsSigned = (bool) (managementObject.Properties["IsSigned"]?.Value ?? default(bool)),
		 Location = (string) (managementObject.Properties["Location"]?.Value),
		 Manufacturer = (string) (managementObject.Properties["Manufacturer"]?.Value),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 Pdo = (string) (managementObject.Properties["PDO"]?.Value),
		 Signer = (string) (managementObject.Properties["Signer"]?.Value),
		 Started = (bool) (managementObject.Properties["Started"]?.Value ?? default(bool)),
		 StartMode = (string) (managementObject.Properties["StartMode"]?.Value),
		 Status = (string) (managementObject.Properties["Status"]?.Value),
		 SystemCreationClassName = (string) (managementObject.Properties["SystemCreationClassName"]?.Value),
		 SystemName = (string) (managementObject.Properties["SystemName"]?.Value)
                };
        }
    }
}