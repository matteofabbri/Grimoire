using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Drives
{
    /// <summary>
    /// </summary>
    public sealed class DiskDriverGeometry
    {
		public bool Active { get; private set; }
		public uint BytesPerSector { get; private set; }
		public long Cylinders { get; private set; }
		public string InstanceName { get; private set; }
		public uint MediaType { get; private set; }
		public uint SectorsPerTrack { get; private set; }
		public uint TracksPerCylinder { get; private set; }

        public static IEnumerable<DiskDriverGeometry> Retrieve(string remote, string username, string password)
        {
            var options = new ConnectionOptions
            {
                Impersonation = ImpersonationLevel.Impersonate,
                Username = username,
                Password = password
            };

            var managementScope = new ManagementScope(new ManagementPath($"\\\\{remote}\\root\\wmi"), options);
            managementScope.Connect();

            return Retrieve(managementScope);
        }

        public static IEnumerable<DiskDriverGeometry> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<DiskDriverGeometry> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSDiskDriver_Geometry");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new DiskDriverGeometry
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 BytesPerSector = (uint) (managementObject.Properties["BytesPerSector"]?.Value ?? default(uint)),
		 Cylinders = (long) (managementObject.Properties["Cylinders"]?.Value ?? default(long)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 MediaType = (uint) (managementObject.Properties["MediaType"]?.Value ?? default(uint)),
		 SectorsPerTrack = (uint) (managementObject.Properties["SectorsPerTrack"]?.Value ?? default(uint)),
		 TracksPerCylinder = (uint) (managementObject.Properties["TracksPerCylinder"]?.Value ?? default(uint))
                };
        }
    }
}