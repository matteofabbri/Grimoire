using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Heap
{
    /// <summary>
    /// </summary>
    public sealed class HeapRealloc
    {
		public uint HeapHandle { get; private set; }
		public uint NewAllocAddress { get; private set; }
		public dynamic NewAllocSize { get; private set; }
		public uint OldAllocAddress { get; private set; }
		public dynamic OldAllocSize { get; private set; }
		public uint SourceId { get; private set; }

        public static IEnumerable<HeapRealloc> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HeapRealloc> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HeapRealloc> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HeapRealloc");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HeapRealloc
                {
                     HeapHandle = (uint) (managementObject.Properties["HeapHandle"]?.Value ?? default(uint)),
		 NewAllocAddress = (uint) (managementObject.Properties["NewAllocAddress"]?.Value ?? default(uint)),
		 NewAllocSize = (dynamic) (managementObject.Properties["NewAllocSize"]?.Value ?? default(dynamic)),
		 OldAllocAddress = (uint) (managementObject.Properties["OldAllocAddress"]?.Value ?? default(uint)),
		 OldAllocSize = (dynamic) (managementObject.Properties["OldAllocSize"]?.Value ?? default(dynamic)),
		 SourceId = (uint) (managementObject.Properties["SourceId"]?.Value ?? default(uint))
                };
        }
    }
}