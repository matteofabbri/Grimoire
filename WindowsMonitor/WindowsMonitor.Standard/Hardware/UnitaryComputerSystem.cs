using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware
{
    /// <summary>
    /// </summary>
    public sealed class UnitaryComputerSystem
    {
		public string Caption { get; private set; }
		public string CreationClassName { get; private set; }
		public string Description { get; private set; }
		public string[] InitialLoadInfo { get; private set; }
		public DateTime InstallDate { get; private set; }
		public string LastLoadInfo { get; private set; }
		public string Name { get; private set; }
		public string NameFormat { get; private set; }
		public ushort[] PowerManagementCapabilities { get; private set; }
		public bool PowerManagementSupported { get; private set; }
		public ushort PowerState { get; private set; }
		public string PrimaryOwnerContact { get; private set; }
		public string PrimaryOwnerName { get; private set; }
		public ushort ResetCapability { get; private set; }
		public string[] Roles { get; private set; }
		public string Status { get; private set; }

        public static IEnumerable<UnitaryComputerSystem> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<UnitaryComputerSystem> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<UnitaryComputerSystem> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_UnitaryComputerSystem");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new UnitaryComputerSystem
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CreationClassName = (string) (managementObject.Properties["CreationClassName"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 InitialLoadInfo = (string[]) (managementObject.Properties["InitialLoadInfo"]?.Value ?? new string[0]),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 LastLoadInfo = (string) (managementObject.Properties["LastLoadInfo"]?.Value),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 NameFormat = (string) (managementObject.Properties["NameFormat"]?.Value),
		 PowerManagementCapabilities = (ushort[]) (managementObject.Properties["PowerManagementCapabilities"]?.Value ?? new ushort[0]),
		 PowerManagementSupported = (bool) (managementObject.Properties["PowerManagementSupported"]?.Value ?? default(bool)),
		 PowerState = (ushort) (managementObject.Properties["PowerState"]?.Value ?? default(ushort)),
		 PrimaryOwnerContact = (string) (managementObject.Properties["PrimaryOwnerContact"]?.Value),
		 PrimaryOwnerName = (string) (managementObject.Properties["PrimaryOwnerName"]?.Value),
		 ResetCapability = (ushort) (managementObject.Properties["ResetCapability"]?.Value ?? default(ushort)),
		 Roles = (string[]) (managementObject.Properties["Roles"]?.Value ?? new string[0]),
		 Status = (string) (managementObject.Properties["Status"]?.Value)
                };
        }
    }
}