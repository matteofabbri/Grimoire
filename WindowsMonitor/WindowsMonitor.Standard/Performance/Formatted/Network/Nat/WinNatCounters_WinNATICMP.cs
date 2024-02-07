using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted.Network.Nat
{
    /// <summary>
    /// </summary>
    public sealed class WinNatCountersWinNaticmp
    {
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public uint NumberOfBindings { get; private set; }
		public uint NumberOfSessions { get; private set; }
		public uint NumExtToIntTranslations { get; private set; }
		public uint NumIntToExtTranslations { get; private set; }
		public uint NumPacketsDropped { get; private set; }
		public uint NumSessionsTimedOut { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<WinNatCountersWinNaticmp> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<WinNatCountersWinNaticmp> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<WinNatCountersWinNaticmp> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_WinNatCounters_WinNATICMP");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new WinNatCountersWinNaticmp
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 NumberOfBindings = (uint) (managementObject.Properties["NumberOfBindings"]?.Value ?? default(uint)),
		 NumberOfSessions = (uint) (managementObject.Properties["NumberOfSessions"]?.Value ?? default(uint)),
		 NumExtToIntTranslations = (uint) (managementObject.Properties["NumExtToIntTranslations"]?.Value ?? default(uint)),
		 NumIntToExtTranslations = (uint) (managementObject.Properties["NumIntToExtTranslations"]?.Value ?? default(uint)),
		 NumPacketsDropped = (uint) (managementObject.Properties["NumPacketsDropped"]?.Value ?? default(uint)),
		 NumSessionsTimedOut = (uint) (managementObject.Properties["NumSessionsTimedOut"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}