using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Heap
{
    /// <summary>
    /// </summary>
    public sealed class HeapCreate
    {
		public dynamic AllocatedSpace { get; private set; }
		public dynamic CommittedSpace { get; private set; }
		public uint HeapFlags { get; private set; }
		public uint HeapHandle { get; private set; }
		public dynamic ReservedSpace { get; private set; }

        public static IEnumerable<HeapCreate> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HeapCreate> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HeapCreate> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HeapCreate");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HeapCreate
                {
                     AllocatedSpace = (dynamic) (managementObject.Properties["AllocatedSpace"]?.Value ?? default(dynamic)),
		 CommittedSpace = (dynamic) (managementObject.Properties["CommittedSpace"]?.Value ?? default(dynamic)),
		 HeapFlags = (uint) (managementObject.Properties["HeapFlags"]?.Value ?? default(uint)),
		 HeapHandle = (uint) (managementObject.Properties["HeapHandle"]?.Value ?? default(uint)),
		 ReservedSpace = (dynamic) (managementObject.Properties["ReservedSpace"]?.Value ?? default(dynamic))
                };
        }
    }
}