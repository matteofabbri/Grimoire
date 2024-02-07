using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Heap
{
    /// <summary>
    /// </summary>
    public sealed class HeapStats
    {
		public ulong FinalizationPromotedCount { get; private set; }
		public ulong FinalizationPromotedSize { get; private set; }
		public uint GcHandleCount { get; private set; }
		public ulong GenerationSize0 { get; private set; }
		public ulong GenerationSize1 { get; private set; }
		public ulong GenerationSize2 { get; private set; }
		public ulong GenerationSize3 { get; private set; }
		public uint PinnedObjectCount { get; private set; }
		public uint SinkBlockCount { get; private set; }
		public ulong TotalPromotedSize0 { get; private set; }
		public ulong TotalPromotedSize1 { get; private set; }
		public ulong TotalPromotedSize2 { get; private set; }
		public ulong TotalPromotedSize3 { get; private set; }

        public static IEnumerable<HeapStats> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HeapStats> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HeapStats> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HeapStats");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HeapStats
                {
                     FinalizationPromotedCount = (ulong) (managementObject.Properties["FinalizationPromotedCount"]?.Value ?? default(ulong)),
		 FinalizationPromotedSize = (ulong) (managementObject.Properties["FinalizationPromotedSize"]?.Value ?? default(ulong)),
		 GcHandleCount = (uint) (managementObject.Properties["GCHandleCount"]?.Value ?? default(uint)),
		 GenerationSize0 = (ulong) (managementObject.Properties["GenerationSize0"]?.Value ?? default(ulong)),
		 GenerationSize1 = (ulong) (managementObject.Properties["GenerationSize1"]?.Value ?? default(ulong)),
		 GenerationSize2 = (ulong) (managementObject.Properties["GenerationSize2"]?.Value ?? default(ulong)),
		 GenerationSize3 = (ulong) (managementObject.Properties["GenerationSize3"]?.Value ?? default(ulong)),
		 PinnedObjectCount = (uint) (managementObject.Properties["PinnedObjectCount"]?.Value ?? default(uint)),
		 SinkBlockCount = (uint) (managementObject.Properties["SinkBlockCount"]?.Value ?? default(uint)),
		 TotalPromotedSize0 = (ulong) (managementObject.Properties["TotalPromotedSize0"]?.Value ?? default(ulong)),
		 TotalPromotedSize1 = (ulong) (managementObject.Properties["TotalPromotedSize1"]?.Value ?? default(ulong)),
		 TotalPromotedSize2 = (ulong) (managementObject.Properties["TotalPromotedSize2"]?.Value ?? default(ulong)),
		 TotalPromotedSize3 = (ulong) (managementObject.Properties["TotalPromotedSize3"]?.Value ?? default(ulong))
                };
        }
    }
}