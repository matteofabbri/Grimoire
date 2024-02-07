using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Heap
{
    /// <summary>
    /// </summary>
    public sealed class HeapSubsegmentInitialize
    {
		public uint AffinityIndex { get; private set; }
		public dynamic BlockCount { get; private set; }
		public dynamic BlockSize { get; private set; }
		public uint HeapHandle { get; private set; }
		public uint SubSegment { get; private set; }

        public static IEnumerable<HeapSubsegmentInitialize> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HeapSubsegmentInitialize> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HeapSubsegmentInitialize> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HeapSubsegmentInitialize");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HeapSubsegmentInitialize
                {
                     AffinityIndex = (uint) (managementObject.Properties["AffinityIndex"]?.Value ?? default(uint)),
		 BlockCount = (dynamic) (managementObject.Properties["BlockCount"]?.Value ?? default(dynamic)),
		 BlockSize = (dynamic) (managementObject.Properties["BlockSize"]?.Value ?? default(dynamic)),
		 HeapHandle = (uint) (managementObject.Properties["HeapHandle"]?.Value ?? default(uint)),
		 SubSegment = (uint) (managementObject.Properties["SubSegment"]?.Value ?? default(uint))
                };
        }
    }
}