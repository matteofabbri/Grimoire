using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted.HyperV
{
    /// <summary>
    /// </summary>
    public sealed class HyperVHypervisorRootPartition
    {
		public ulong AddressSpaces { get; private set; }
		public ulong AttachedDevices { get; private set; }
		public string Caption { get; private set; }
		public ulong DepositedPages { get; private set; }
		public string Description { get; private set; }
		public ulong DeviceDmaErrors { get; private set; }
		public ulong DeviceInterruptErrors { get; private set; }
		public ulong DeviceInterruptMappings { get; private set; }
		public ulong DeviceInterruptThrottleEvents { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public ulong GpaPages { get; private set; }
		public ulong GpaSpaceModificationsPersec { get; private set; }
		public ulong IotlbFlushCost { get; private set; }
		public ulong IotlbFlushesPersec { get; private set; }
		public string Name { get; private set; }
		public ulong NestedTlbFreeListSize { get; private set; }
		public ulong NestedTlbSize { get; private set; }
		public ulong NestedTlbTrimmedPagesPersec { get; private set; }
		public ulong RecommendedNestedTlbSize { get; private set; }
		public ulong RecommendedVirtualTlbSize { get; private set; }
		public ulong SkippedTimerTicks { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public ulong Value1Gdevicepages { get; private set; }
		public ulong Value1GgpApages { get; private set; }
		public ulong Value2Mdevicepages { get; private set; }
		public ulong Value2MgpApages { get; private set; }
		public ulong Value4Kdevicepages { get; private set; }
		public ulong Value4KgpApages { get; private set; }
		public ulong VirtualProcessors { get; private set; }
		public ulong VirtualTlbFlushEntiresPersec { get; private set; }
		public ulong VirtualTlbPages { get; private set; }

        public static IEnumerable<HyperVHypervisorRootPartition> Retrieve(string remote, string username, string password)
        {
            var options = new ConnectionOptions
            {
                Impersonation = ImpersonationLevel.Impersonate,
                Username = username,
                Password = password
            };

            var managementScope = new ManagementScope(new ManagementPath($"\\\\{remote}\\root\\cimv2"), options);
            managementScope.Connect();

            return Retrieve(managementScope);
        }

        public static IEnumerable<HyperVHypervisorRootPartition> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HyperVHypervisorRootPartition> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_HvStats_HyperVHypervisorRootPartition");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HyperVHypervisorRootPartition
                {
                     AddressSpaces = (ulong) (managementObject.Properties["AddressSpaces"]?.Value ?? default(ulong)),
		 AttachedDevices = (ulong) (managementObject.Properties["AttachedDevices"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 DepositedPages = (ulong) (managementObject.Properties["DepositedPages"]?.Value ?? default(ulong)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DeviceDmaErrors = (ulong) (managementObject.Properties["DeviceDMAErrors"]?.Value ?? default(ulong)),
		 DeviceInterruptErrors = (ulong) (managementObject.Properties["DeviceInterruptErrors"]?.Value ?? default(ulong)),
		 DeviceInterruptMappings = (ulong) (managementObject.Properties["DeviceInterruptMappings"]?.Value ?? default(ulong)),
		 DeviceInterruptThrottleEvents = (ulong) (managementObject.Properties["DeviceInterruptThrottleEvents"]?.Value ?? default(ulong)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 GpaPages = (ulong) (managementObject.Properties["GPAPages"]?.Value ?? default(ulong)),
		 GpaSpaceModificationsPersec = (ulong) (managementObject.Properties["GPASpaceModificationsPersec"]?.Value ?? default(ulong)),
		 IotlbFlushCost = (ulong) (managementObject.Properties["IOTLBFlushCost"]?.Value ?? default(ulong)),
		 IotlbFlushesPersec = (ulong) (managementObject.Properties["IOTLBFlushesPersec"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 NestedTlbFreeListSize = (ulong) (managementObject.Properties["NestedTLBFreeListSize"]?.Value ?? default(ulong)),
		 NestedTlbSize = (ulong) (managementObject.Properties["NestedTLBSize"]?.Value ?? default(ulong)),
		 NestedTlbTrimmedPagesPersec = (ulong) (managementObject.Properties["NestedTLBTrimmedPagesPersec"]?.Value ?? default(ulong)),
		 RecommendedNestedTlbSize = (ulong) (managementObject.Properties["RecommendedNestedTLBSize"]?.Value ?? default(ulong)),
		 RecommendedVirtualTlbSize = (ulong) (managementObject.Properties["RecommendedVirtualTLBSize"]?.Value ?? default(ulong)),
		 SkippedTimerTicks = (ulong) (managementObject.Properties["SkippedTimerTicks"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 Value1Gdevicepages = (ulong) (managementObject.Properties["Value1Gdevicepages"]?.Value ?? default(ulong)),
		 Value1GgpApages = (ulong) (managementObject.Properties["Value1GGPApages"]?.Value ?? default(ulong)),
		 Value2Mdevicepages = (ulong) (managementObject.Properties["Value2Mdevicepages"]?.Value ?? default(ulong)),
		 Value2MgpApages = (ulong) (managementObject.Properties["Value2MGPApages"]?.Value ?? default(ulong)),
		 Value4Kdevicepages = (ulong) (managementObject.Properties["Value4Kdevicepages"]?.Value ?? default(ulong)),
		 Value4KgpApages = (ulong) (managementObject.Properties["Value4KGPApages"]?.Value ?? default(ulong)),
		 VirtualProcessors = (ulong) (managementObject.Properties["VirtualProcessors"]?.Value ?? default(ulong)),
		 VirtualTlbFlushEntiresPersec = (ulong) (managementObject.Properties["VirtualTLBFlushEntiresPersec"]?.Value ?? default(ulong)),
		 VirtualTlbPages = (ulong) (managementObject.Properties["VirtualTLBPages"]?.Value ?? default(ulong))
                };
        }
    }
}