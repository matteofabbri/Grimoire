using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Heap
{
    /// <summary>
    /// </summary>
    public sealed class HeapSnapShot
    {
		public dynamic AllocatedSpace { get; private set; }
		public dynamic CommittedSpace { get; private set; }
		public uint FreeListLength { get; private set; }
		public dynamic FreeSpace { get; private set; }
		public uint HeapFlags { get; private set; }
		public uint HeapHandle { get; private set; }
		public dynamic LargeUcrSpace { get; private set; }
		public uint ProcessId { get; private set; }
		public dynamic ReservedSpace { get; private set; }
		public uint UcrLength { get; private set; }

        public static IEnumerable<HeapSnapShot> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HeapSnapShot> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HeapSnapShot> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HeapSnapShot");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HeapSnapShot
                {
                     AllocatedSpace = (dynamic) (managementObject.Properties["AllocatedSpace"]?.Value ?? default(dynamic)),
		 CommittedSpace = (dynamic) (managementObject.Properties["CommittedSpace"]?.Value ?? default(dynamic)),
		 FreeListLength = (uint) (managementObject.Properties["FreeListLength"]?.Value ?? default(uint)),
		 FreeSpace = (dynamic) (managementObject.Properties["FreeSpace"]?.Value ?? default(dynamic)),
		 HeapFlags = (uint) (managementObject.Properties["HeapFlags"]?.Value ?? default(uint)),
		 HeapHandle = (uint) (managementObject.Properties["HeapHandle"]?.Value ?? default(uint)),
		 LargeUcrSpace = (dynamic) (managementObject.Properties["LargeUCRSpace"]?.Value ?? default(dynamic)),
		 ProcessId = (uint) (managementObject.Properties["ProcessId"]?.Value ?? default(uint)),
		 ReservedSpace = (dynamic) (managementObject.Properties["ReservedSpace"]?.Value ?? default(dynamic)),
		 UcrLength = (uint) (managementObject.Properties["UCRLength"]?.Value ?? default(uint))
                };
        }
    }
}