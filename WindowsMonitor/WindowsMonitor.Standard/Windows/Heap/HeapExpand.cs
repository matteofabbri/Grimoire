using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Heap
{
    /// <summary>
    /// </summary>
    public sealed class HeapExpand
    {
		public dynamic AllocatedSpace { get; private set; }
		public uint CommitAddress { get; private set; }
		public dynamic CommittedSize { get; private set; }
		public dynamic CommittedSpace { get; private set; }
		public dynamic FreeSpace { get; private set; }
		public uint HeapHandle { get; private set; }
		public uint NoOfUcRs { get; private set; }
		public dynamic ReservedSpace { get; private set; }

        public static IEnumerable<HeapExpand> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HeapExpand> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HeapExpand> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HeapExpand");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HeapExpand
                {
                     AllocatedSpace = (dynamic) (managementObject.Properties["AllocatedSpace"]?.Value ?? default(dynamic)),
		 CommitAddress = (uint) (managementObject.Properties["CommitAddress"]?.Value ?? default(uint)),
		 CommittedSize = (dynamic) (managementObject.Properties["CommittedSize"]?.Value ?? default(dynamic)),
		 CommittedSpace = (dynamic) (managementObject.Properties["CommittedSpace"]?.Value ?? default(dynamic)),
		 FreeSpace = (dynamic) (managementObject.Properties["FreeSpace"]?.Value ?? default(dynamic)),
		 HeapHandle = (uint) (managementObject.Properties["HeapHandle"]?.Value ?? default(uint)),
		 NoOfUcRs = (uint) (managementObject.Properties["NoOfUCRs"]?.Value ?? default(uint)),
		 ReservedSpace = (dynamic) (managementObject.Properties["ReservedSpace"]?.Value ?? default(dynamic))
                };
        }
    }
}