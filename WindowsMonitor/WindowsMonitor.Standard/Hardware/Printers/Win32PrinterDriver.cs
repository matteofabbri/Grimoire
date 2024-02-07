using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Printers
{
    /// <summary>
    /// </summary>
    public sealed class Win32PrinterDriver
    {
		public string Caption { get; private set; }
		public string ConfigFile { get; private set; }
		public string CreationClassName { get; private set; }
		public string DataFile { get; private set; }
		public string DefaultDataType { get; private set; }
		public string[] DependentFiles { get; private set; }
		public string Description { get; private set; }
		public string DriverPath { get; private set; }
		public string FilePath { get; private set; }
		public string HelpFile { get; private set; }
		public string InfName { get; private set; }
		public DateTime InstallDate { get; private set; }
		public string MonitorName { get; private set; }
		public string Name { get; private set; }
		public string OemUrl { get; private set; }
		public bool Started { get; private set; }
		public string StartMode { get; private set; }
		public string Status { get; private set; }
		public string SupportedPlatform { get; private set; }
		public string SystemCreationClassName { get; private set; }
		public string SystemName { get; private set; }
		public ushort Version { get; private set; }

        public static IEnumerable<Win32PrinterDriver> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<Win32PrinterDriver> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<Win32PrinterDriver> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PrinterDriver");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new Win32PrinterDriver
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 ConfigFile = (string) (managementObject.Properties["ConfigFile"]?.Value),
		 CreationClassName = (string) (managementObject.Properties["CreationClassName"]?.Value),
		 DataFile = (string) (managementObject.Properties["DataFile"]?.Value),
		 DefaultDataType = (string) (managementObject.Properties["DefaultDataType"]?.Value),
		 DependentFiles = (string[]) (managementObject.Properties["DependentFiles"]?.Value ?? new string[0]),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DriverPath = (string) (managementObject.Properties["DriverPath"]?.Value),
		 FilePath = (string) (managementObject.Properties["FilePath"]?.Value),
		 HelpFile = (string) (managementObject.Properties["HelpFile"]?.Value),
		 InfName = (string) (managementObject.Properties["InfName"]?.Value),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 MonitorName = (string) (managementObject.Properties["MonitorName"]?.Value),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 OemUrl = (string) (managementObject.Properties["OEMUrl"]?.Value),
		 Started = (bool) (managementObject.Properties["Started"]?.Value ?? default(bool)),
		 StartMode = (string) (managementObject.Properties["StartMode"]?.Value),
		 Status = (string) (managementObject.Properties["Status"]?.Value),
		 SupportedPlatform = (string) (managementObject.Properties["SupportedPlatform"]?.Value),
		 SystemCreationClassName = (string) (managementObject.Properties["SystemCreationClassName"]?.Value),
		 SystemName = (string) (managementObject.Properties["SystemName"]?.Value),
		 Version = (ushort) (managementObject.Properties["Version"]?.Value ?? default(ushort))
                };
        }
    }
}