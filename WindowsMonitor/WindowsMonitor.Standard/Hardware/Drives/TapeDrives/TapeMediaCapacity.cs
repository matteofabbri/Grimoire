using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Drives.TapeDrives
{
    /// <summary>
    /// </summary>
    public sealed class TapeMediaCapacity
    {
		public bool Active { get; private set; }
		public ulong AvailableCapacity { get; private set; }
		public uint BlockSize { get; private set; }
		public string InstanceName { get; private set; }
		public ulong MaximumCapacity { get; private set; }
		public bool MediaWriteProtected { get; private set; }
		public uint PartitionCount { get; private set; }

        public static IEnumerable<TapeMediaCapacity> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<TapeMediaCapacity> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<TapeMediaCapacity> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSTapeMediaCapacity");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new TapeMediaCapacity
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 AvailableCapacity = (ulong) (managementObject.Properties["AvailableCapacity"]?.Value ?? default(ulong)),
		 BlockSize = (uint) (managementObject.Properties["BlockSize"]?.Value ?? default(uint)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 MaximumCapacity = (ulong) (managementObject.Properties["MaximumCapacity"]?.Value ?? default(ulong)),
		 MediaWriteProtected = (bool) (managementObject.Properties["MediaWriteProtected"]?.Value ?? default(bool)),
		 PartitionCount = (uint) (managementObject.Properties["PartitionCount"]?.Value ?? default(uint))
                };
        }
    }
}