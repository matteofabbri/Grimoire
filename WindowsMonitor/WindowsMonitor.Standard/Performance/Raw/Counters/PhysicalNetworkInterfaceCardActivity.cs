
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.Counters
{
    /// <summary>
    /// </summary>
    public sealed class PhysicalNetworkInterfaceCardActivity
    {
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public uint DevicePowerState { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public uint LowPowerTransitionsLifetime { get; private set; }
		public string Name { get; private set; }
		public ulong PercentTimeSuspendedInstantaneous { get; private set; }
		public ulong PercentTimeSuspendedLifetime { get; private set; }
		public ulong PercentTimeSuspendedLifetimeBase { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<PhysicalNetworkInterfaceCardActivity> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<PhysicalNetworkInterfaceCardActivity> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<PhysicalNetworkInterfaceCardActivity> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_Counters_PhysicalNetworkInterfaceCardActivity");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new PhysicalNetworkInterfaceCardActivity
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DevicePowerState = (uint) (managementObject.Properties["DevicePowerState"]?.Value ?? default(uint)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 LowPowerTransitionsLifetime = (uint) (managementObject.Properties["LowPowerTransitionsLifetime"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 PercentTimeSuspendedInstantaneous = (ulong) (managementObject.Properties["PercentTimeSuspendedInstantaneous"]?.Value ?? default(ulong)),
		 PercentTimeSuspendedLifetime = (ulong) (managementObject.Properties["PercentTimeSuspendedLifetime"]?.Value ?? default(ulong)),
		 PercentTimeSuspendedLifetimeBase = (ulong) (managementObject.Properties["PercentTimeSuspendedLifetime_Base"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}