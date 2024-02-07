using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.Counters
{
    /// <summary>
    /// </summary>
    public sealed class Synchronization
    {
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public uint ExecResourceAcquiresAcqExclLitePersec { get; private set; }
		public uint ExecResourceAcquiresAcqShrdLitePersec { get; private set; }
		public uint ExecResourceAcquiresAcqShrdStarveExclPersec { get; private set; }
		public uint ExecResourceAcquiresAcqShrdWaitForExclPersec { get; private set; }
		public uint ExecResourceAttemptsAcqExclLitePersec { get; private set; }
		public uint ExecResourceAttemptsAcqShrdLitePersec { get; private set; }
		public uint ExecResourceAttemptsAcqShrdStarveExclPersec { get; private set; }
		public uint ExecResourceAttemptsAcqShrdWaitForExclPersec { get; private set; }
		public uint ExecResourceBoostExclOwnerPersec { get; private set; }
		public uint ExecResourceBoostSharedOwnersPersec { get; private set; }
		public uint ExecResourceContentionAcqExclLitePersec { get; private set; }
		public uint ExecResourceContentionAcqShrdLitePersec { get; private set; }
		public uint ExecResourceContentionAcqShrdStarveExclPersec { get; private set; }
		public uint ExecResourceContentionAcqShrdWaitForExclPersec { get; private set; }
		public uint ExecResourcenoWaitsAcqExclLitePersec { get; private set; }
		public uint ExecResourcenoWaitsAcqShrdLitePersec { get; private set; }
		public uint ExecResourcenoWaitsAcqShrdStarveExclPersec { get; private set; }
		public uint ExecResourcenoWaitsAcqShrdWaitForExclPersec { get; private set; }
		public uint ExecResourceRecursiveExclAcquiresAcqExclLitePersec { get; private set; }
		public uint ExecResourceRecursiveExclAcquiresAcqShrdLitePersec { get; private set; }
		public uint ExecResourceRecursiveExclAcquiresAcqShrdStarveExclPersec { get; private set; }
		public uint ExecResourceRecursiveExclAcquiresAcqShrdWaitForExclPersec { get; private set; }
		public uint ExecResourceRecursiveShAcquiresAcqShrdLitePersec { get; private set; }
		public uint ExecResourceRecursiveShAcquiresAcqShrdStarveExclPersec { get; private set; }
		public uint ExecResourceRecursiveShAcquiresAcqShrdWaitForExclPersec { get; private set; }
		public uint ExecResourceSetOwnerPointerExclusivePersec { get; private set; }
		public uint ExecResourceSetOwnerPointerSharedExistingOwnerPersec { get; private set; }
		public uint ExecResourceSetOwnerPointerSharedNewOwnerPersec { get; private set; }
		public uint ExecResourceTotalAcquiresPersec { get; private set; }
		public uint ExecResourceTotalContentionsPersec { get; private set; }
		public uint ExecResourceTotalConvExclusiveToSharedPersec { get; private set; }
		public uint ExecResourceTotalDeletePersec { get; private set; }
		public uint ExecResourceTotalExclusiveReleasesPersec { get; private set; }
		public uint ExecResourceTotalInitializePersec { get; private set; }
		public uint ExecResourceTotalReInitializePersec { get; private set; }
		public uint ExecResourceTotalSharedReleasesPersec { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public uint IpiSendBroadcastRequestsPersec { get; private set; }
		public uint IpiSendRoutineRequestsPersec { get; private set; }
		public uint IpiSendSoftwareInterruptsPersec { get; private set; }
		public string Name { get; private set; }
		public uint SpinlockAcquiresPersec { get; private set; }
		public uint SpinlockContentionsPersec { get; private set; }
		public uint SpinlockSpinsPersec { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<Synchronization> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<Synchronization> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<Synchronization> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_Counters_Synchronization");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new Synchronization
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 ExecResourceAcquiresAcqExclLitePersec = (uint) (managementObject.Properties["ExecResourceAcquiresAcqExclLitePersec"]?.Value ?? default(uint)),
		 ExecResourceAcquiresAcqShrdLitePersec = (uint) (managementObject.Properties["ExecResourceAcquiresAcqShrdLitePersec"]?.Value ?? default(uint)),
		 ExecResourceAcquiresAcqShrdStarveExclPersec = (uint) (managementObject.Properties["ExecResourceAcquiresAcqShrdStarveExclPersec"]?.Value ?? default(uint)),
		 ExecResourceAcquiresAcqShrdWaitForExclPersec = (uint) (managementObject.Properties["ExecResourceAcquiresAcqShrdWaitForExclPersec"]?.Value ?? default(uint)),
		 ExecResourceAttemptsAcqExclLitePersec = (uint) (managementObject.Properties["ExecResourceAttemptsAcqExclLitePersec"]?.Value ?? default(uint)),
		 ExecResourceAttemptsAcqShrdLitePersec = (uint) (managementObject.Properties["ExecResourceAttemptsAcqShrdLitePersec"]?.Value ?? default(uint)),
		 ExecResourceAttemptsAcqShrdStarveExclPersec = (uint) (managementObject.Properties["ExecResourceAttemptsAcqShrdStarveExclPersec"]?.Value ?? default(uint)),
		 ExecResourceAttemptsAcqShrdWaitForExclPersec = (uint) (managementObject.Properties["ExecResourceAttemptsAcqShrdWaitForExclPersec"]?.Value ?? default(uint)),
		 ExecResourceBoostExclOwnerPersec = (uint) (managementObject.Properties["ExecResourceBoostExclOwnerPersec"]?.Value ?? default(uint)),
		 ExecResourceBoostSharedOwnersPersec = (uint) (managementObject.Properties["ExecResourceBoostSharedOwnersPersec"]?.Value ?? default(uint)),
		 ExecResourceContentionAcqExclLitePersec = (uint) (managementObject.Properties["ExecResourceContentionAcqExclLitePersec"]?.Value ?? default(uint)),
		 ExecResourceContentionAcqShrdLitePersec = (uint) (managementObject.Properties["ExecResourceContentionAcqShrdLitePersec"]?.Value ?? default(uint)),
		 ExecResourceContentionAcqShrdStarveExclPersec = (uint) (managementObject.Properties["ExecResourceContentionAcqShrdStarveExclPersec"]?.Value ?? default(uint)),
		 ExecResourceContentionAcqShrdWaitForExclPersec = (uint) (managementObject.Properties["ExecResourceContentionAcqShrdWaitForExclPersec"]?.Value ?? default(uint)),
		 ExecResourcenoWaitsAcqExclLitePersec = (uint) (managementObject.Properties["ExecResourcenoWaitsAcqExclLitePersec"]?.Value ?? default(uint)),
		 ExecResourcenoWaitsAcqShrdLitePersec = (uint) (managementObject.Properties["ExecResourcenoWaitsAcqShrdLitePersec"]?.Value ?? default(uint)),
		 ExecResourcenoWaitsAcqShrdStarveExclPersec = (uint) (managementObject.Properties["ExecResourcenoWaitsAcqShrdStarveExclPersec"]?.Value ?? default(uint)),
		 ExecResourcenoWaitsAcqShrdWaitForExclPersec = (uint) (managementObject.Properties["ExecResourcenoWaitsAcqShrdWaitForExclPersec"]?.Value ?? default(uint)),
		 ExecResourceRecursiveExclAcquiresAcqExclLitePersec = (uint) (managementObject.Properties["ExecResourceRecursiveExclAcquiresAcqExclLitePersec"]?.Value ?? default(uint)),
		 ExecResourceRecursiveExclAcquiresAcqShrdLitePersec = (uint) (managementObject.Properties["ExecResourceRecursiveExclAcquiresAcqShrdLitePersec"]?.Value ?? default(uint)),
		 ExecResourceRecursiveExclAcquiresAcqShrdStarveExclPersec = (uint) (managementObject.Properties["ExecResourceRecursiveExclAcquiresAcqShrdStarveExclPersec"]?.Value ?? default(uint)),
		 ExecResourceRecursiveExclAcquiresAcqShrdWaitForExclPersec = (uint) (managementObject.Properties["ExecResourceRecursiveExclAcquiresAcqShrdWaitForExclPersec"]?.Value ?? default(uint)),
		 ExecResourceRecursiveShAcquiresAcqShrdLitePersec = (uint) (managementObject.Properties["ExecResourceRecursiveShAcquiresAcqShrdLitePersec"]?.Value ?? default(uint)),
		 ExecResourceRecursiveShAcquiresAcqShrdStarveExclPersec = (uint) (managementObject.Properties["ExecResourceRecursiveShAcquiresAcqShrdStarveExclPersec"]?.Value ?? default(uint)),
		 ExecResourceRecursiveShAcquiresAcqShrdWaitForExclPersec = (uint) (managementObject.Properties["ExecResourceRecursiveShAcquiresAcqShrdWaitForExclPersec"]?.Value ?? default(uint)),
		 ExecResourceSetOwnerPointerExclusivePersec = (uint) (managementObject.Properties["ExecResourceSetOwnerPointerExclusivePersec"]?.Value ?? default(uint)),
		 ExecResourceSetOwnerPointerSharedExistingOwnerPersec = (uint) (managementObject.Properties["ExecResourceSetOwnerPointerSharedExistingOwnerPersec"]?.Value ?? default(uint)),
		 ExecResourceSetOwnerPointerSharedNewOwnerPersec = (uint) (managementObject.Properties["ExecResourceSetOwnerPointerSharedNewOwnerPersec"]?.Value ?? default(uint)),
		 ExecResourceTotalAcquiresPersec = (uint) (managementObject.Properties["ExecResourceTotalAcquiresPersec"]?.Value ?? default(uint)),
		 ExecResourceTotalContentionsPersec = (uint) (managementObject.Properties["ExecResourceTotalContentionsPersec"]?.Value ?? default(uint)),
		 ExecResourceTotalConvExclusiveToSharedPersec = (uint) (managementObject.Properties["ExecResourceTotalConvExclusiveToSharedPersec"]?.Value ?? default(uint)),
		 ExecResourceTotalDeletePersec = (uint) (managementObject.Properties["ExecResourceTotalDeletePersec"]?.Value ?? default(uint)),
		 ExecResourceTotalExclusiveReleasesPersec = (uint) (managementObject.Properties["ExecResourceTotalExclusiveReleasesPersec"]?.Value ?? default(uint)),
		 ExecResourceTotalInitializePersec = (uint) (managementObject.Properties["ExecResourceTotalInitializePersec"]?.Value ?? default(uint)),
		 ExecResourceTotalReInitializePersec = (uint) (managementObject.Properties["ExecResourceTotalReInitializePersec"]?.Value ?? default(uint)),
		 ExecResourceTotalSharedReleasesPersec = (uint) (managementObject.Properties["ExecResourceTotalSharedReleasesPersec"]?.Value ?? default(uint)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 IpiSendBroadcastRequestsPersec = (uint) (managementObject.Properties["IPISendBroadcastRequestsPersec"]?.Value ?? default(uint)),
		 IpiSendRoutineRequestsPersec = (uint) (managementObject.Properties["IPISendRoutineRequestsPersec"]?.Value ?? default(uint)),
		 IpiSendSoftwareInterruptsPersec = (uint) (managementObject.Properties["IPISendSoftwareInterruptsPersec"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 SpinlockAcquiresPersec = (uint) (managementObject.Properties["SpinlockAcquiresPersec"]?.Value ?? default(uint)),
		 SpinlockContentionsPersec = (uint) (managementObject.Properties["SpinlockContentionsPersec"]?.Value ?? default(uint)),
		 SpinlockSpinsPersec = (uint) (managementObject.Properties["SpinlockSpinsPersec"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}