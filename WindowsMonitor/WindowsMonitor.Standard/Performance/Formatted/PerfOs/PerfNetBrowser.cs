using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted.PerfOs
{
    /// <summary>
    /// </summary>
    public sealed class PerfNetBrowser
    {
		public ulong AnnouncementsDomainPersec { get; private set; }
		public ulong AnnouncementsServerPersec { get; private set; }
		public ulong AnnouncementsTotalPersec { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public uint DuplicateMasterAnnouncements { get; private set; }
		public uint ElectionPacketsPersec { get; private set; }
		public uint EnumerationsDomainPersec { get; private set; }
		public uint EnumerationsOtherPersec { get; private set; }
		public uint EnumerationsServerPersec { get; private set; }
		public uint EnumerationsTotalPersec { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public ulong IllegalDatagramsPersec { get; private set; }
		public uint MailslotAllocationsFailed { get; private set; }
		public uint MailslotOpensFailedPersec { get; private set; }
		public uint MailslotReceivesFailed { get; private set; }
		public uint MailslotWritesFailed { get; private set; }
		public uint MailslotWritesPersec { get; private set; }
		public uint MissedMailslotDatagrams { get; private set; }
		public uint MissedServerAnnouncements { get; private set; }
		public uint MissedServerListRequests { get; private set; }
		public string Name { get; private set; }
		public uint ServerAnnounceAllocationsFailedPersec { get; private set; }
		public uint ServerListRequestsPersec { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<PerfNetBrowser> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<PerfNetBrowser> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<PerfNetBrowser> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_PerfNet_Browser");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new PerfNetBrowser
                {
                     AnnouncementsDomainPersec = (ulong) (managementObject.Properties["AnnouncementsDomainPersec"]?.Value ?? default(ulong)),
		 AnnouncementsServerPersec = (ulong) (managementObject.Properties["AnnouncementsServerPersec"]?.Value ?? default(ulong)),
		 AnnouncementsTotalPersec = (ulong) (managementObject.Properties["AnnouncementsTotalPersec"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DuplicateMasterAnnouncements = (uint) (managementObject.Properties["DuplicateMasterAnnouncements"]?.Value ?? default(uint)),
		 ElectionPacketsPersec = (uint) (managementObject.Properties["ElectionPacketsPersec"]?.Value ?? default(uint)),
		 EnumerationsDomainPersec = (uint) (managementObject.Properties["EnumerationsDomainPersec"]?.Value ?? default(uint)),
		 EnumerationsOtherPersec = (uint) (managementObject.Properties["EnumerationsOtherPersec"]?.Value ?? default(uint)),
		 EnumerationsServerPersec = (uint) (managementObject.Properties["EnumerationsServerPersec"]?.Value ?? default(uint)),
		 EnumerationsTotalPersec = (uint) (managementObject.Properties["EnumerationsTotalPersec"]?.Value ?? default(uint)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 IllegalDatagramsPersec = (ulong) (managementObject.Properties["IllegalDatagramsPersec"]?.Value ?? default(ulong)),
		 MailslotAllocationsFailed = (uint) (managementObject.Properties["MailslotAllocationsFailed"]?.Value ?? default(uint)),
		 MailslotOpensFailedPersec = (uint) (managementObject.Properties["MailslotOpensFailedPersec"]?.Value ?? default(uint)),
		 MailslotReceivesFailed = (uint) (managementObject.Properties["MailslotReceivesFailed"]?.Value ?? default(uint)),
		 MailslotWritesFailed = (uint) (managementObject.Properties["MailslotWritesFailed"]?.Value ?? default(uint)),
		 MailslotWritesPersec = (uint) (managementObject.Properties["MailslotWritesPersec"]?.Value ?? default(uint)),
		 MissedMailslotDatagrams = (uint) (managementObject.Properties["MissedMailslotDatagrams"]?.Value ?? default(uint)),
		 MissedServerAnnouncements = (uint) (managementObject.Properties["MissedServerAnnouncements"]?.Value ?? default(uint)),
		 MissedServerListRequests = (uint) (managementObject.Properties["MissedServerListRequests"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 ServerAnnounceAllocationsFailedPersec = (uint) (managementObject.Properties["ServerAnnounceAllocationsFailedPersec"]?.Value ?? default(uint)),
		 ServerListRequestsPersec = (uint) (managementObject.Properties["ServerListRequestsPersec"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}