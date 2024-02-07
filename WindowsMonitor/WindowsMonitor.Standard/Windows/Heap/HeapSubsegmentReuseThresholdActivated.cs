using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Heap
{
    /// <summary>
    /// </summary>
    public sealed class HeapSubsegmentReuseThresholdActivated
    {
		public uint BucketIndex { get; private set; }
		public uint Heap { get; private set; }
		public uint SubSegment { get; private set; }

        public static IEnumerable<HeapSubsegmentReuseThresholdActivated> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HeapSubsegmentReuseThresholdActivated> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HeapSubsegmentReuseThresholdActivated> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HeapSubsegmentReuseThresholdActivated");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HeapSubsegmentReuseThresholdActivated
                {
                     BucketIndex = (uint) (managementObject.Properties["BucketIndex"]?.Value ?? default(uint)),
		 Heap = (uint) (managementObject.Properties["Heap"]?.Value ?? default(uint)),
		 SubSegment = (uint) (managementObject.Properties["SubSegment"]?.Value ?? default(uint))
                };
        }
    }
}