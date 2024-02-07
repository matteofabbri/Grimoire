using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Heap
{
    /// <summary>
    /// </summary>
    public sealed class HeapAffinitySlotChanged
    {
		public uint Heap { get; private set; }
		public uint SlotIndex { get; private set; }
		public uint SubSegment { get; private set; }

        public static IEnumerable<HeapAffinitySlotChanged> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HeapAffinitySlotChanged> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HeapAffinitySlotChanged> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HeapAffinitySlotChanged");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HeapAffinitySlotChanged
                {
                     Heap = (uint) (managementObject.Properties["Heap"]?.Value ?? default(uint)),
		 SlotIndex = (uint) (managementObject.Properties["SlotIndex"]?.Value ?? default(uint)),
		 SubSegment = (uint) (managementObject.Properties["SubSegment"]?.Value ?? default(uint))
                };
        }
    }
}