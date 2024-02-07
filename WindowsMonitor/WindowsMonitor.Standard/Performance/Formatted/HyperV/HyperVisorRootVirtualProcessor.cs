using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted.HyperV
{
    /// <summary>
    /// </summary>
    public sealed class HyperVisorRootVirtualProcessor
    {
		public ulong AddressDomainFlushesPersec { get; private set; }
		public ulong AddressSpaceEvictionsPersec { get; private set; }
		public ulong AddressSpaceFlushesPersec { get; private set; }
		public ulong AddressSpaceSwitchesPersec { get; private set; }
		public ulong ApiceoiAccessesPersec { get; private set; }
		public ulong ApicipIsSentPersec { get; private set; }
		public ulong ApicmmioAccessesPersec { get; private set; }
		public ulong ApicSelfIpIsSentPersec { get; private set; }
		public ulong ApictprAccessesPersec { get; private set; }
		public string Caption { get; private set; }
		public ulong ControlRegisterAccessesCost { get; private set; }
		public ulong ControlRegisterAccessesForwardedPersec { get; private set; }
		public ulong ControlRegisterAccessesForwardingCost { get; private set; }
		public ulong ControlRegisterAccessesPersec { get; private set; }
		public ulong CpuidInstructionsCost { get; private set; }
		public ulong CpuidInstructionsForwardedPersec { get; private set; }
		public ulong CpuidInstructionsForwardingCost { get; private set; }
		public ulong CpuidInstructionsPersec { get; private set; }
		public ulong CpuWaitTimePerDispatch { get; private set; }
		public ulong DebugRegisterAccessesCost { get; private set; }
		public ulong DebugRegisterAccessesForwardedPersec { get; private set; }
		public ulong DebugRegisterAccessesForwardingCost { get; private set; }
		public ulong DebugRegisterAccessesPersec { get; private set; }
		public string Description { get; private set; }
		public ulong EmulatedInstructionsCost { get; private set; }
		public ulong EmulatedInstructionsForwardedPersec { get; private set; }
		public ulong EmulatedInstructionsForwardingCost { get; private set; }
		public ulong EmulatedInstructionsPersec { get; private set; }
		public ulong ExtendedHypercallInterceptMessagesPersec { get; private set; }
		public ulong ExtendedHypercallsPersec { get; private set; }
		public ulong ExternalInterruptsCost { get; private set; }
		public ulong ExternalInterruptsForwardedPersec { get; private set; }
		public ulong ExternalInterruptsPersec { get; private set; }
		public ulong FlushPhysicalAddressListHypercallsPersec { get; private set; }
		public ulong FlushPhysicalAddressSpaceHypercallsPersec { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public ulong GlobalGvaRangeFlushesPersec { get; private set; }
		public ulong GlobalIotlbFlushCost { get; private set; }
		public ulong GlobalIotlbFlushesPersec { get; private set; }
		public ulong GpaSpaceHypercallsPersec { get; private set; }
		public ulong GuestPageTableMapsPersec { get; private set; }
		public ulong HardwareInterruptsPersec { get; private set; }
		public ulong HltInstructionsCost { get; private set; }
		public ulong HltInstructionsForwardedPersec { get; private set; }
		public ulong HltInstructionsForwardingCost { get; private set; }
		public ulong HltInstructionsPersec { get; private set; }
		public ulong HypercallsCost { get; private set; }
		public ulong HypercallsForwardedPersec { get; private set; }
		public ulong HypercallsForwardingCost { get; private set; }
		public ulong HypercallsPersec { get; private set; }
		public ulong InvEptAllContextEmulationInterceptsPersec { get; private set; }
		public ulong InvEptAllContextInstructionEmulationCost { get; private set; }
		public ulong InvEptSingleContextEmulationInterceptsPersec { get; private set; }
		public ulong InvEptSingleContextInstructionEmulationCost { get; private set; }
		public ulong InvVpidAllContextEmulationInterceptsPersec { get; private set; }
		public ulong InvVpidAllContextInstructionEmulationCost { get; private set; }
		public ulong InvVpidSingleAddressEmulationInterceptsPersec { get; private set; }
		public ulong InvVpidSingleAddressInstructionEmulationCost { get; private set; }
		public ulong InvVpidSingleContextEmulationInterceptsPersec { get; private set; }
		public ulong InvVpidSingleContextInstructionEmulationCost { get; private set; }
		public ulong IoInstructionsCost { get; private set; }
		public ulong IoInstructionsForwardedPersec { get; private set; }
		public ulong IoInstructionsForwardingCost { get; private set; }
		public ulong IoInstructionsPersec { get; private set; }
		public ulong IoInterceptMessagesPersec { get; private set; }
		public ulong LargePageTlbFillsPersec { get; private set; }
		public ulong LocalFlushedGvaRangesPersec { get; private set; }
		public ulong LocalIotlbFlushCost { get; private set; }
		public ulong LocalIotlbFlushesPersec { get; private set; }
		public ulong LogicalProcessorDispatchesPersec { get; private set; }
		public ulong LogicalProcessorHypercallsPersec { get; private set; }
		public ulong LogicalProcessorMigrationsPersec { get; private set; }
		public ulong LongSpinWaitHypercallsPersec { get; private set; }
		public ulong MbecNestedPageTableSwitchesPersec { get; private set; }
		public ulong MemoryInterceptMessagesPersec { get; private set; }
		public ulong MsrAccessesCost { get; private set; }
		public ulong MsrAccessesForwardedPersec { get; private set; }
		public ulong MsrAccessesForwardingCost { get; private set; }
		public ulong MsrAccessesPersec { get; private set; }
		public ulong MwaitInstructionsCost { get; private set; }
		public ulong MwaitInstructionsForwardedPersec { get; private set; }
		public ulong MwaitInstructionsForwardingCost { get; private set; }
		public ulong MwaitInstructionsPersec { get; private set; }
		public string Name { get; private set; }
		public ulong NestedPageFaultInterceptsCost { get; private set; }
		public ulong NestedPageFaultInterceptsPersec { get; private set; }
		public ulong NestedSlatHardPageFaultsCost { get; private set; }
		public ulong NestedSlatHardPageFaultsPersec { get; private set; }
		public ulong NestedSlatSoftPageFaultsCost { get; private set; }
		public ulong NestedSlatSoftPageFaultsPersec { get; private set; }
		public ulong NestedTlbPageTableEvictionsPersec { get; private set; }
		public ulong NestedTlbPageTableReclamationsPersec { get; private set; }
		public ulong NestedVmEntriesCost { get; private set; }
		public ulong NestedVmEntriesPersec { get; private set; }
		public ulong OtherHypercallsPersec { get; private set; }
		public ulong OtherInterceptsCost { get; private set; }
		public ulong OtherInterceptsForwardedPersec { get; private set; }
		public ulong OtherInterceptsForwardingCost { get; private set; }
		public ulong OtherInterceptsPersec { get; private set; }
		public ulong OtherMessagesPersec { get; private set; }
		public ulong OtherReflectedGuestExceptionsPersec { get; private set; }
		public ulong PageFaultInterceptsCost { get; private set; }
		public ulong PageFaultInterceptsForwardedPersec { get; private set; }
		public ulong PageFaultInterceptsForwardingCost { get; private set; }
		public ulong PageFaultInterceptsPersec { get; private set; }
		public ulong PageInvalidationsCost { get; private set; }
		public ulong PageInvalidationsForwardedPersec { get; private set; }
		public ulong PageInvalidationsForwardingCost { get; private set; }
		public ulong PageInvalidationsPersec { get; private set; }
		public ulong PageTableAllocationsPersec { get; private set; }
		public ulong PageTableEvictionsPersec { get; private set; }
		public ulong PageTableReclamationsPersec { get; private set; }
		public ulong PageTableResetsPersec { get; private set; }
		public ulong PageTableValidationsPersec { get; private set; }
		public ulong PageTableWriteInterceptsPersec { get; private set; }
		public ulong PendingInterruptsCost { get; private set; }
		public ulong PendingInterruptsForwardedPersec { get; private set; }
		public ulong PendingInterruptsForwardingCost { get; private set; }
		public ulong PendingInterruptsPersec { get; private set; }
		public ulong PercentGuestRunTime { get; private set; }
		public ulong PercentHypervisorRunTime { get; private set; }
		public ulong PercentRemoteRunTime { get; private set; }
		public ulong PercentTotalRunTime { get; private set; }
		public ulong ReflectedGuestPageFaultsPersec { get; private set; }
		public ulong SmallPageTlbFillsPersec { get; private set; }
		public ulong SyntheticInterruptHypercallsPersec { get; private set; }
		public ulong SyntheticInterruptsPersec { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public ulong TotalInterceptsCost { get; private set; }
		public ulong TotalInterceptsPersec { get; private set; }
		public ulong TotalMessagesPersec { get; private set; }
		public ulong TotalVirtualizationInstructionsEmulatedPersec { get; private set; }
		public ulong TotalVirtualizationInstructionsEmulationCost { get; private set; }
		public ulong VirtualInterruptHypercallsPersec { get; private set; }
		public ulong VirtualInterruptsPersec { get; private set; }
		public ulong VirtualMmuHypercallsPersec { get; private set; }
		public ulong VirtualProcessorHypercallsPersec { get; private set; }
		public ulong VmclearEmulationInterceptsPersec { get; private set; }
		public ulong VmclearInstructionEmulationCost { get; private set; }
		public ulong VmptrldEmulationInterceptsPersec { get; private set; }
		public ulong VmptrldInstructionEmulationCost { get; private set; }
		public ulong VmptrstEmulationInterceptsPersec { get; private set; }
		public ulong VmptrstInstructionEmulationCost { get; private set; }
		public ulong VmreadEmulationInterceptsPersec { get; private set; }
		public ulong VmreadInstructionEmulationCost { get; private set; }
		public ulong VmwriteEmulationInterceptsPersec { get; private set; }
		public ulong VmwriteInstructionEmulationCost { get; private set; }
		public ulong VmxoffEmulationInterceptsPersec { get; private set; }
		public ulong VmxoffInstructionEmulationCost { get; private set; }
		public ulong VmxonEmulationInterceptsPersec { get; private set; }
		public ulong VmxonInstructionEmulationCost { get; private set; }

        public static IEnumerable<HyperVisorRootVirtualProcessor> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HyperVisorRootVirtualProcessor> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HyperVisorRootVirtualProcessor> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_HvStats_HyperVHypervisorRootVirtualProcessor");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HyperVisorRootVirtualProcessor
                {
                     AddressDomainFlushesPersec = (ulong) (managementObject.Properties["AddressDomainFlushesPersec"]?.Value ?? default(ulong)),
		 AddressSpaceEvictionsPersec = (ulong) (managementObject.Properties["AddressSpaceEvictionsPersec"]?.Value ?? default(ulong)),
		 AddressSpaceFlushesPersec = (ulong) (managementObject.Properties["AddressSpaceFlushesPersec"]?.Value ?? default(ulong)),
		 AddressSpaceSwitchesPersec = (ulong) (managementObject.Properties["AddressSpaceSwitchesPersec"]?.Value ?? default(ulong)),
		 ApiceoiAccessesPersec = (ulong) (managementObject.Properties["APICEOIAccessesPersec"]?.Value ?? default(ulong)),
		 ApicipIsSentPersec = (ulong) (managementObject.Properties["APICIPIsSentPersec"]?.Value ?? default(ulong)),
		 ApicmmioAccessesPersec = (ulong) (managementObject.Properties["APICMMIOAccessesPersec"]?.Value ?? default(ulong)),
		 ApicSelfIpIsSentPersec = (ulong) (managementObject.Properties["APICSelfIPIsSentPersec"]?.Value ?? default(ulong)),
		 ApictprAccessesPersec = (ulong) (managementObject.Properties["APICTPRAccessesPersec"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 ControlRegisterAccessesCost = (ulong) (managementObject.Properties["ControlRegisterAccessesCost"]?.Value ?? default(ulong)),
		 ControlRegisterAccessesForwardedPersec = (ulong) (managementObject.Properties["ControlRegisterAccessesForwardedPersec"]?.Value ?? default(ulong)),
		 ControlRegisterAccessesForwardingCost = (ulong) (managementObject.Properties["ControlRegisterAccessesForwardingCost"]?.Value ?? default(ulong)),
		 ControlRegisterAccessesPersec = (ulong) (managementObject.Properties["ControlRegisterAccessesPersec"]?.Value ?? default(ulong)),
		 CpuidInstructionsCost = (ulong) (managementObject.Properties["CPUIDInstructionsCost"]?.Value ?? default(ulong)),
		 CpuidInstructionsForwardedPersec = (ulong) (managementObject.Properties["CPUIDInstructionsForwardedPersec"]?.Value ?? default(ulong)),
		 CpuidInstructionsForwardingCost = (ulong) (managementObject.Properties["CPUIDInstructionsForwardingCost"]?.Value ?? default(ulong)),
		 CpuidInstructionsPersec = (ulong) (managementObject.Properties["CPUIDInstructionsPersec"]?.Value ?? default(ulong)),
		 CpuWaitTimePerDispatch = (ulong) (managementObject.Properties["CPUWaitTimePerDispatch"]?.Value ?? default(ulong)),
		 DebugRegisterAccessesCost = (ulong) (managementObject.Properties["DebugRegisterAccessesCost"]?.Value ?? default(ulong)),
		 DebugRegisterAccessesForwardedPersec = (ulong) (managementObject.Properties["DebugRegisterAccessesForwardedPersec"]?.Value ?? default(ulong)),
		 DebugRegisterAccessesForwardingCost = (ulong) (managementObject.Properties["DebugRegisterAccessesForwardingCost"]?.Value ?? default(ulong)),
		 DebugRegisterAccessesPersec = (ulong) (managementObject.Properties["DebugRegisterAccessesPersec"]?.Value ?? default(ulong)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 EmulatedInstructionsCost = (ulong) (managementObject.Properties["EmulatedInstructionsCost"]?.Value ?? default(ulong)),
		 EmulatedInstructionsForwardedPersec = (ulong) (managementObject.Properties["EmulatedInstructionsForwardedPersec"]?.Value ?? default(ulong)),
		 EmulatedInstructionsForwardingCost = (ulong) (managementObject.Properties["EmulatedInstructionsForwardingCost"]?.Value ?? default(ulong)),
		 EmulatedInstructionsPersec = (ulong) (managementObject.Properties["EmulatedInstructionsPersec"]?.Value ?? default(ulong)),
		 ExtendedHypercallInterceptMessagesPersec = (ulong) (managementObject.Properties["ExtendedHypercallInterceptMessagesPersec"]?.Value ?? default(ulong)),
		 ExtendedHypercallsPersec = (ulong) (managementObject.Properties["ExtendedHypercallsPersec"]?.Value ?? default(ulong)),
		 ExternalInterruptsCost = (ulong) (managementObject.Properties["ExternalInterruptsCost"]?.Value ?? default(ulong)),
		 ExternalInterruptsForwardedPersec = (ulong) (managementObject.Properties["ExternalInterruptsForwardedPersec"]?.Value ?? default(ulong)),
		 ExternalInterruptsPersec = (ulong) (managementObject.Properties["ExternalInterruptsPersec"]?.Value ?? default(ulong)),
		 FlushPhysicalAddressListHypercallsPersec = (ulong) (managementObject.Properties["FlushPhysicalAddressListHypercallsPersec"]?.Value ?? default(ulong)),
		 FlushPhysicalAddressSpaceHypercallsPersec = (ulong) (managementObject.Properties["FlushPhysicalAddressSpaceHypercallsPersec"]?.Value ?? default(ulong)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 GlobalGvaRangeFlushesPersec = (ulong) (managementObject.Properties["GlobalGVARangeFlushesPersec"]?.Value ?? default(ulong)),
		 GlobalIotlbFlushCost = (ulong) (managementObject.Properties["GlobalIOTLBFlushCost"]?.Value ?? default(ulong)),
		 GlobalIotlbFlushesPersec = (ulong) (managementObject.Properties["GlobalIOTLBFlushesPersec"]?.Value ?? default(ulong)),
		 GpaSpaceHypercallsPersec = (ulong) (managementObject.Properties["GPASpaceHypercallsPersec"]?.Value ?? default(ulong)),
		 GuestPageTableMapsPersec = (ulong) (managementObject.Properties["GuestPageTableMapsPersec"]?.Value ?? default(ulong)),
		 HardwareInterruptsPersec = (ulong) (managementObject.Properties["HardwareInterruptsPersec"]?.Value ?? default(ulong)),
		 HltInstructionsCost = (ulong) (managementObject.Properties["HLTInstructionsCost"]?.Value ?? default(ulong)),
		 HltInstructionsForwardedPersec = (ulong) (managementObject.Properties["HLTInstructionsForwardedPersec"]?.Value ?? default(ulong)),
		 HltInstructionsForwardingCost = (ulong) (managementObject.Properties["HLTInstructionsForwardingCost"]?.Value ?? default(ulong)),
		 HltInstructionsPersec = (ulong) (managementObject.Properties["HLTInstructionsPersec"]?.Value ?? default(ulong)),
		 HypercallsCost = (ulong) (managementObject.Properties["HypercallsCost"]?.Value ?? default(ulong)),
		 HypercallsForwardedPersec = (ulong) (managementObject.Properties["HypercallsForwardedPersec"]?.Value ?? default(ulong)),
		 HypercallsForwardingCost = (ulong) (managementObject.Properties["HypercallsForwardingCost"]?.Value ?? default(ulong)),
		 HypercallsPersec = (ulong) (managementObject.Properties["HypercallsPersec"]?.Value ?? default(ulong)),
		 InvEptAllContextEmulationInterceptsPersec = (ulong) (managementObject.Properties["InvEptAllContextEmulationInterceptsPersec"]?.Value ?? default(ulong)),
		 InvEptAllContextInstructionEmulationCost = (ulong) (managementObject.Properties["InvEptAllContextInstructionEmulationCost"]?.Value ?? default(ulong)),
		 InvEptSingleContextEmulationInterceptsPersec = (ulong) (managementObject.Properties["InvEptSingleContextEmulationInterceptsPersec"]?.Value ?? default(ulong)),
		 InvEptSingleContextInstructionEmulationCost = (ulong) (managementObject.Properties["InvEptSingleContextInstructionEmulationCost"]?.Value ?? default(ulong)),
		 InvVpidAllContextEmulationInterceptsPersec = (ulong) (managementObject.Properties["InvVpidAllContextEmulationInterceptsPersec"]?.Value ?? default(ulong)),
		 InvVpidAllContextInstructionEmulationCost = (ulong) (managementObject.Properties["InvVpidAllContextInstructionEmulationCost"]?.Value ?? default(ulong)),
		 InvVpidSingleAddressEmulationInterceptsPersec = (ulong) (managementObject.Properties["InvVpidSingleAddressEmulationInterceptsPersec"]?.Value ?? default(ulong)),
		 InvVpidSingleAddressInstructionEmulationCost = (ulong) (managementObject.Properties["InvVpidSingleAddressInstructionEmulationCost"]?.Value ?? default(ulong)),
		 InvVpidSingleContextEmulationInterceptsPersec = (ulong) (managementObject.Properties["InvVpidSingleContextEmulationInterceptsPersec"]?.Value ?? default(ulong)),
		 InvVpidSingleContextInstructionEmulationCost = (ulong) (managementObject.Properties["InvVpidSingleContextInstructionEmulationCost"]?.Value ?? default(ulong)),
		 IoInstructionsCost = (ulong) (managementObject.Properties["IOInstructionsCost"]?.Value ?? default(ulong)),
		 IoInstructionsForwardedPersec = (ulong) (managementObject.Properties["IOInstructionsForwardedPersec"]?.Value ?? default(ulong)),
		 IoInstructionsForwardingCost = (ulong) (managementObject.Properties["IOInstructionsForwardingCost"]?.Value ?? default(ulong)),
		 IoInstructionsPersec = (ulong) (managementObject.Properties["IOInstructionsPersec"]?.Value ?? default(ulong)),
		 IoInterceptMessagesPersec = (ulong) (managementObject.Properties["IOInterceptMessagesPersec"]?.Value ?? default(ulong)),
		 LargePageTlbFillsPersec = (ulong) (managementObject.Properties["LargePageTLBFillsPersec"]?.Value ?? default(ulong)),
		 LocalFlushedGvaRangesPersec = (ulong) (managementObject.Properties["LocalFlushedGVARangesPersec"]?.Value ?? default(ulong)),
		 LocalIotlbFlushCost = (ulong) (managementObject.Properties["LocalIOTLBFlushCost"]?.Value ?? default(ulong)),
		 LocalIotlbFlushesPersec = (ulong) (managementObject.Properties["LocalIOTLBFlushesPersec"]?.Value ?? default(ulong)),
		 LogicalProcessorDispatchesPersec = (ulong) (managementObject.Properties["LogicalProcessorDispatchesPersec"]?.Value ?? default(ulong)),
		 LogicalProcessorHypercallsPersec = (ulong) (managementObject.Properties["LogicalProcessorHypercallsPersec"]?.Value ?? default(ulong)),
		 LogicalProcessorMigrationsPersec = (ulong) (managementObject.Properties["LogicalProcessorMigrationsPersec"]?.Value ?? default(ulong)),
		 LongSpinWaitHypercallsPersec = (ulong) (managementObject.Properties["LongSpinWaitHypercallsPersec"]?.Value ?? default(ulong)),
		 MbecNestedPageTableSwitchesPersec = (ulong) (managementObject.Properties["MBECNestedPageTableSwitchesPersec"]?.Value ?? default(ulong)),
		 MemoryInterceptMessagesPersec = (ulong) (managementObject.Properties["MemoryInterceptMessagesPersec"]?.Value ?? default(ulong)),
		 MsrAccessesCost = (ulong) (managementObject.Properties["MSRAccessesCost"]?.Value ?? default(ulong)),
		 MsrAccessesForwardedPersec = (ulong) (managementObject.Properties["MSRAccessesForwardedPersec"]?.Value ?? default(ulong)),
		 MsrAccessesForwardingCost = (ulong) (managementObject.Properties["MSRAccessesForwardingCost"]?.Value ?? default(ulong)),
		 MsrAccessesPersec = (ulong) (managementObject.Properties["MSRAccessesPersec"]?.Value ?? default(ulong)),
		 MwaitInstructionsCost = (ulong) (managementObject.Properties["MWAITInstructionsCost"]?.Value ?? default(ulong)),
		 MwaitInstructionsForwardedPersec = (ulong) (managementObject.Properties["MWAITInstructionsForwardedPersec"]?.Value ?? default(ulong)),
		 MwaitInstructionsForwardingCost = (ulong) (managementObject.Properties["MWAITInstructionsForwardingCost"]?.Value ?? default(ulong)),
		 MwaitInstructionsPersec = (ulong) (managementObject.Properties["MWAITInstructionsPersec"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 NestedPageFaultInterceptsCost = (ulong) (managementObject.Properties["NestedPageFaultInterceptsCost"]?.Value ?? default(ulong)),
		 NestedPageFaultInterceptsPersec = (ulong) (managementObject.Properties["NestedPageFaultInterceptsPersec"]?.Value ?? default(ulong)),
		 NestedSlatHardPageFaultsCost = (ulong) (managementObject.Properties["NestedSLATHardPageFaultsCost"]?.Value ?? default(ulong)),
		 NestedSlatHardPageFaultsPersec = (ulong) (managementObject.Properties["NestedSLATHardPageFaultsPersec"]?.Value ?? default(ulong)),
		 NestedSlatSoftPageFaultsCost = (ulong) (managementObject.Properties["NestedSLATSoftPageFaultsCost"]?.Value ?? default(ulong)),
		 NestedSlatSoftPageFaultsPersec = (ulong) (managementObject.Properties["NestedSLATSoftPageFaultsPersec"]?.Value ?? default(ulong)),
		 NestedTlbPageTableEvictionsPersec = (ulong) (managementObject.Properties["NestedTLBPageTableEvictionsPersec"]?.Value ?? default(ulong)),
		 NestedTlbPageTableReclamationsPersec = (ulong) (managementObject.Properties["NestedTLBPageTableReclamationsPersec"]?.Value ?? default(ulong)),
		 NestedVmEntriesCost = (ulong) (managementObject.Properties["NestedVMEntriesCost"]?.Value ?? default(ulong)),
		 NestedVmEntriesPersec = (ulong) (managementObject.Properties["NestedVMEntriesPersec"]?.Value ?? default(ulong)),
		 OtherHypercallsPersec = (ulong) (managementObject.Properties["OtherHypercallsPersec"]?.Value ?? default(ulong)),
		 OtherInterceptsCost = (ulong) (managementObject.Properties["OtherInterceptsCost"]?.Value ?? default(ulong)),
		 OtherInterceptsForwardedPersec = (ulong) (managementObject.Properties["OtherInterceptsForwardedPersec"]?.Value ?? default(ulong)),
		 OtherInterceptsForwardingCost = (ulong) (managementObject.Properties["OtherInterceptsForwardingCost"]?.Value ?? default(ulong)),
		 OtherInterceptsPersec = (ulong) (managementObject.Properties["OtherInterceptsPersec"]?.Value ?? default(ulong)),
		 OtherMessagesPersec = (ulong) (managementObject.Properties["OtherMessagesPersec"]?.Value ?? default(ulong)),
		 OtherReflectedGuestExceptionsPersec = (ulong) (managementObject.Properties["OtherReflectedGuestExceptionsPersec"]?.Value ?? default(ulong)),
		 PageFaultInterceptsCost = (ulong) (managementObject.Properties["PageFaultInterceptsCost"]?.Value ?? default(ulong)),
		 PageFaultInterceptsForwardedPersec = (ulong) (managementObject.Properties["PageFaultInterceptsForwardedPersec"]?.Value ?? default(ulong)),
		 PageFaultInterceptsForwardingCost = (ulong) (managementObject.Properties["PageFaultInterceptsForwardingCost"]?.Value ?? default(ulong)),
		 PageFaultInterceptsPersec = (ulong) (managementObject.Properties["PageFaultInterceptsPersec"]?.Value ?? default(ulong)),
		 PageInvalidationsCost = (ulong) (managementObject.Properties["PageInvalidationsCost"]?.Value ?? default(ulong)),
		 PageInvalidationsForwardedPersec = (ulong) (managementObject.Properties["PageInvalidationsForwardedPersec"]?.Value ?? default(ulong)),
		 PageInvalidationsForwardingCost = (ulong) (managementObject.Properties["PageInvalidationsForwardingCost"]?.Value ?? default(ulong)),
		 PageInvalidationsPersec = (ulong) (managementObject.Properties["PageInvalidationsPersec"]?.Value ?? default(ulong)),
		 PageTableAllocationsPersec = (ulong) (managementObject.Properties["PageTableAllocationsPersec"]?.Value ?? default(ulong)),
		 PageTableEvictionsPersec = (ulong) (managementObject.Properties["PageTableEvictionsPersec"]?.Value ?? default(ulong)),
		 PageTableReclamationsPersec = (ulong) (managementObject.Properties["PageTableReclamationsPersec"]?.Value ?? default(ulong)),
		 PageTableResetsPersec = (ulong) (managementObject.Properties["PageTableResetsPersec"]?.Value ?? default(ulong)),
		 PageTableValidationsPersec = (ulong) (managementObject.Properties["PageTableValidationsPersec"]?.Value ?? default(ulong)),
		 PageTableWriteInterceptsPersec = (ulong) (managementObject.Properties["PageTableWriteInterceptsPersec"]?.Value ?? default(ulong)),
		 PendingInterruptsCost = (ulong) (managementObject.Properties["PendingInterruptsCost"]?.Value ?? default(ulong)),
		 PendingInterruptsForwardedPersec = (ulong) (managementObject.Properties["PendingInterruptsForwardedPersec"]?.Value ?? default(ulong)),
		 PendingInterruptsForwardingCost = (ulong) (managementObject.Properties["PendingInterruptsForwardingCost"]?.Value ?? default(ulong)),
		 PendingInterruptsPersec = (ulong) (managementObject.Properties["PendingInterruptsPersec"]?.Value ?? default(ulong)),
		 PercentGuestRunTime = (ulong) (managementObject.Properties["PercentGuestRunTime"]?.Value ?? default(ulong)),
		 PercentHypervisorRunTime = (ulong) (managementObject.Properties["PercentHypervisorRunTime"]?.Value ?? default(ulong)),
		 PercentRemoteRunTime = (ulong) (managementObject.Properties["PercentRemoteRunTime"]?.Value ?? default(ulong)),
		 PercentTotalRunTime = (ulong) (managementObject.Properties["PercentTotalRunTime"]?.Value ?? default(ulong)),
		 ReflectedGuestPageFaultsPersec = (ulong) (managementObject.Properties["ReflectedGuestPageFaultsPersec"]?.Value ?? default(ulong)),
		 SmallPageTlbFillsPersec = (ulong) (managementObject.Properties["SmallPageTLBFillsPersec"]?.Value ?? default(ulong)),
		 SyntheticInterruptHypercallsPersec = (ulong) (managementObject.Properties["SyntheticInterruptHypercallsPersec"]?.Value ?? default(ulong)),
		 SyntheticInterruptsPersec = (ulong) (managementObject.Properties["SyntheticInterruptsPersec"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 TotalInterceptsCost = (ulong) (managementObject.Properties["TotalInterceptsCost"]?.Value ?? default(ulong)),
		 TotalInterceptsPersec = (ulong) (managementObject.Properties["TotalInterceptsPersec"]?.Value ?? default(ulong)),
		 TotalMessagesPersec = (ulong) (managementObject.Properties["TotalMessagesPersec"]?.Value ?? default(ulong)),
		 TotalVirtualizationInstructionsEmulatedPersec = (ulong) (managementObject.Properties["TotalVirtualizationInstructionsEmulatedPersec"]?.Value ?? default(ulong)),
		 TotalVirtualizationInstructionsEmulationCost = (ulong) (managementObject.Properties["TotalVirtualizationInstructionsEmulationCost"]?.Value ?? default(ulong)),
		 VirtualInterruptHypercallsPersec = (ulong) (managementObject.Properties["VirtualInterruptHypercallsPersec"]?.Value ?? default(ulong)),
		 VirtualInterruptsPersec = (ulong) (managementObject.Properties["VirtualInterruptsPersec"]?.Value ?? default(ulong)),
		 VirtualMmuHypercallsPersec = (ulong) (managementObject.Properties["VirtualMMUHypercallsPersec"]?.Value ?? default(ulong)),
		 VirtualProcessorHypercallsPersec = (ulong) (managementObject.Properties["VirtualProcessorHypercallsPersec"]?.Value ?? default(ulong)),
		 VmclearEmulationInterceptsPersec = (ulong) (managementObject.Properties["VMCLEAREmulationInterceptsPersec"]?.Value ?? default(ulong)),
		 VmclearInstructionEmulationCost = (ulong) (managementObject.Properties["VMCLEARInstructionEmulationCost"]?.Value ?? default(ulong)),
		 VmptrldEmulationInterceptsPersec = (ulong) (managementObject.Properties["VMPTRLDEmulationInterceptsPersec"]?.Value ?? default(ulong)),
		 VmptrldInstructionEmulationCost = (ulong) (managementObject.Properties["VMPTRLDInstructionEmulationCost"]?.Value ?? default(ulong)),
		 VmptrstEmulationInterceptsPersec = (ulong) (managementObject.Properties["VMPTRSTEmulationInterceptsPersec"]?.Value ?? default(ulong)),
		 VmptrstInstructionEmulationCost = (ulong) (managementObject.Properties["VMPTRSTInstructionEmulationCost"]?.Value ?? default(ulong)),
		 VmreadEmulationInterceptsPersec = (ulong) (managementObject.Properties["VMREADEmulationInterceptsPersec"]?.Value ?? default(ulong)),
		 VmreadInstructionEmulationCost = (ulong) (managementObject.Properties["VMREADInstructionEmulationCost"]?.Value ?? default(ulong)),
		 VmwriteEmulationInterceptsPersec = (ulong) (managementObject.Properties["VMWRITEEmulationInterceptsPersec"]?.Value ?? default(ulong)),
		 VmwriteInstructionEmulationCost = (ulong) (managementObject.Properties["VMWRITEInstructionEmulationCost"]?.Value ?? default(ulong)),
		 VmxoffEmulationInterceptsPersec = (ulong) (managementObject.Properties["VMXOFFEmulationInterceptsPersec"]?.Value ?? default(ulong)),
		 VmxoffInstructionEmulationCost = (ulong) (managementObject.Properties["VMXOFFInstructionEmulationCost"]?.Value ?? default(ulong)),
		 VmxonEmulationInterceptsPersec = (ulong) (managementObject.Properties["VMXONEmulationInterceptsPersec"]?.Value ?? default(ulong)),
		 VmxonInstructionEmulationCost = (ulong) (managementObject.Properties["VMXONInstructionEmulationCost"]?.Value ?? default(ulong))
                };
        }
    }
}