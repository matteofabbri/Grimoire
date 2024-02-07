using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted
{
    /// <summary>
    /// </summary>
    public sealed class MsdtcBridge3000
    {
		public uint Averageparticipantcommitresponsetime { get; private set; }
		public uint Averageparticipantprepareresponsetime { get; private set; }
		public string Caption { get; private set; }
		public uint CommitretrycountPersec { get; private set; }
		public string Description { get; private set; }
		public uint FaultsreceivedcountPersec { get; private set; }
		public uint FaultssentcountPersec { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public uint MessagesendfailuresPersec { get; private set; }
		public string Name { get; private set; }
		public uint PreparedretrycountPersec { get; private set; }
		public uint PrepareretrycountPersec { get; private set; }
		public uint ReplayretrycountPersec { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<MsdtcBridge3000> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<MsdtcBridge3000> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<MsdtcBridge3000> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_MSDTCBridge3000_MSDTCBridge3000");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new MsdtcBridge3000
                {
                     Averageparticipantcommitresponsetime = (uint) (managementObject.Properties["Averageparticipantcommitresponsetime"]?.Value ?? default(uint)),
		 Averageparticipantprepareresponsetime = (uint) (managementObject.Properties["Averageparticipantprepareresponsetime"]?.Value ?? default(uint)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CommitretrycountPersec = (uint) (managementObject.Properties["CommitretrycountPersec"]?.Value ?? default(uint)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FaultsreceivedcountPersec = (uint) (managementObject.Properties["FaultsreceivedcountPersec"]?.Value ?? default(uint)),
		 FaultssentcountPersec = (uint) (managementObject.Properties["FaultssentcountPersec"]?.Value ?? default(uint)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 MessagesendfailuresPersec = (uint) (managementObject.Properties["MessagesendfailuresPersec"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 PreparedretrycountPersec = (uint) (managementObject.Properties["PreparedretrycountPersec"]?.Value ?? default(uint)),
		 PrepareretrycountPersec = (uint) (managementObject.Properties["PrepareretrycountPersec"]?.Value ?? default(uint)),
		 ReplayretrycountPersec = (uint) (managementObject.Properties["ReplayretrycountPersec"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}