using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Heap
{
    /// <summary>
    /// </summary>
    public sealed class HeapCommitDecommit
    {
		public uint Block { get; private set; }
		public uint Caller { get; private set; }
		public uint HeapHandle { get; private set; }
		public dynamic Size { get; private set; }

        public static IEnumerable<HeapCommitDecommit> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HeapCommitDecommit> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HeapCommitDecommit> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HeapCommitDecommit");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HeapCommitDecommit
                {
                     Block = (uint) (managementObject.Properties["Block"]?.Value ?? default(uint)),
		 Caller = (uint) (managementObject.Properties["Caller"]?.Value ?? default(uint)),
		 HeapHandle = (uint) (managementObject.Properties["HeapHandle"]?.Value ?? default(uint)),
		 Size = (dynamic) (managementObject.Properties["Size"]?.Value ?? default(dynamic))
                };
        }
    }
}