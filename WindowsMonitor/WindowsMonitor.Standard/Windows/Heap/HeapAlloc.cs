using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Heap
{
    /// <summary>
    /// </summary>
    public sealed class HeapAlloc
    {
		public uint AllocAddress { get; private set; }
		public dynamic AllocSize { get; private set; }
		public uint HeapHandle { get; private set; }
		public uint SourceId { get; private set; }

        public static IEnumerable<HeapAlloc> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HeapAlloc> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HeapAlloc> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HeapAlloc");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HeapAlloc
                {
                     AllocAddress = (uint) (managementObject.Properties["AllocAddress"]?.Value ?? default(uint)),
		 AllocSize = (dynamic) (managementObject.Properties["AllocSize"]?.Value ?? default(dynamic)),
		 HeapHandle = (uint) (managementObject.Properties["HeapHandle"]?.Value ?? default(uint)),
		 SourceId = (uint) (managementObject.Properties["SourceId"]?.Value ?? default(uint))
                };
        }
    }
}