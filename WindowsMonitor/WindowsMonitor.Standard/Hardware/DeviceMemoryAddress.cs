using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware
{
    /// <summary>
    /// </summary>
    public sealed class DeviceMemoryAddress
    {
		public string Caption { get; private set; }
		public string CreationClassName { get; private set; }
		public string CsCreationClassName { get; private set; }
		public string CsName { get; private set; }
		public string Description { get; private set; }
		public ulong EndingAddress { get; private set; }
		public DateTime InstallDate { get; private set; }
		public string MemoryType { get; private set; }
		public string Name { get; private set; }
		public ulong StartingAddress { get; private set; }
		public string Status { get; private set; }

        public static IEnumerable<DeviceMemoryAddress> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<DeviceMemoryAddress> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<DeviceMemoryAddress> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_DeviceMemoryAddress");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new DeviceMemoryAddress
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CreationClassName = (string) (managementObject.Properties["CreationClassName"]?.Value),
		 CsCreationClassName = (string) (managementObject.Properties["CSCreationClassName"]?.Value),
		 CsName = (string) (managementObject.Properties["CSName"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 EndingAddress = (ulong) (managementObject.Properties["EndingAddress"]?.Value ?? default(ulong)),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 MemoryType = (string) (managementObject.Properties["MemoryType"]?.Value),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 StartingAddress = (ulong) (managementObject.Properties["StartingAddress"]?.Value ?? default(ulong)),
		 Status = (string) (managementObject.Properties["Status"]?.Value)
                };
        }
    }
}