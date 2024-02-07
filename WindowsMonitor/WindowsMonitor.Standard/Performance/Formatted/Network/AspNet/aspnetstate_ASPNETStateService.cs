using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted.Network.AspNet
{
    /// <summary>
    /// </summary>
    public sealed class AspnetstateAspnetStateService
    {
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public uint StateServerSessionsAbandoned { get; private set; }
		public uint StateServerSessionsActive { get; private set; }
		public uint StateServerSessionsTimedOut { get; private set; }
		public uint StateServerSessionsTotal { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<AspnetstateAspnetStateService> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<AspnetstateAspnetStateService> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<AspnetstateAspnetStateService> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_aspnetstate_ASPNETStateService");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new AspnetstateAspnetStateService
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 StateServerSessionsAbandoned = (uint) (managementObject.Properties["StateServerSessionsAbandoned"]?.Value ?? default(uint)),
		 StateServerSessionsActive = (uint) (managementObject.Properties["StateServerSessionsActive"]?.Value ?? default(uint)),
		 StateServerSessionsTimedOut = (uint) (managementObject.Properties["StateServerSessionsTimedOut"]?.Value ?? default(uint)),
		 StateServerSessionsTotal = (uint) (managementObject.Properties["StateServerSessionsTotal"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}