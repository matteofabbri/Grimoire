using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor
{
    /// <summary>
    /// </summary>
    public sealed class ReserveCost
    {
		public string Caption { get; private set; }
		public string CheckId { get; private set; }
		public bool CheckMode { get; private set; }
		public string Description { get; private set; }
		public string Name { get; private set; }
		public string ReserveFolder { get; private set; }
		public string ReserveKey { get; private set; }
		public uint ReserveLocal { get; private set; }
		public uint ReserveSource { get; private set; }
		public string SoftwareElementId { get; private set; }
		public ushort SoftwareElementState { get; private set; }
		public ushort TargetOperatingSystem { get; private set; }
		public string Version { get; private set; }

        public static IEnumerable<ReserveCost> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ReserveCost> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ReserveCost> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_ReserveCost");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ReserveCost
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CheckId = (string) (managementObject.Properties["CheckID"]?.Value),
		 CheckMode = (bool) (managementObject.Properties["CheckMode"]?.Value ?? default(bool)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 ReserveFolder = (string) (managementObject.Properties["ReserveFolder"]?.Value),
		 ReserveKey = (string) (managementObject.Properties["ReserveKey"]?.Value),
		 ReserveLocal = (uint) (managementObject.Properties["ReserveLocal"]?.Value ?? default(uint)),
		 ReserveSource = (uint) (managementObject.Properties["ReserveSource"]?.Value ?? default(uint)),
		 SoftwareElementId = (string) (managementObject.Properties["SoftwareElementID"]?.Value),
		 SoftwareElementState = (ushort) (managementObject.Properties["SoftwareElementState"]?.Value ?? default(ushort)),
		 TargetOperatingSystem = (ushort) (managementObject.Properties["TargetOperatingSystem"]?.Value ?? default(ushort)),
		 Version = (string) (managementObject.Properties["Version"]?.Value)
                };
        }
    }
}