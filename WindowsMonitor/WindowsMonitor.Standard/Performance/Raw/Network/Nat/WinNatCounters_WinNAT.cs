using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.Network.Nat
{
    /// <summary>
    /// </summary>
    public sealed class WinNatCountersWinNat
    {
		public string Caption { get; private set; }
		public uint CurrentSessionCount { get; private set; }
		public string Description { get; private set; }
		public uint DroppedIcmPerrorpackets { get; private set; }
		public uint DroppedIcmPerrorpacketsPersec { get; private set; }
		public uint DroppedPackets { get; private set; }
		public uint DroppedPacketsPersec { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public uint InterRoutingDomainHairpinnedPackets { get; private set; }
		public uint InterRoutingDomainHairpinnedPacketsPersec { get; private set; }
		public uint IntraRoutingDomainHairpinnedPackets { get; private set; }
		public uint IntraRoutingDomainHairpinnedPacketsPersec { get; private set; }
		public string Name { get; private set; }
		public uint PacketsExternaltoInternal { get; private set; }
		public uint PacketsInternaltoExternal { get; private set; }
		public uint PacketsPersecExternaltoInternal { get; private set; }
		public uint PacketsPersecInternaltoExternal { get; private set; }
		public uint SessionsPersec { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<WinNatCountersWinNat> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<WinNatCountersWinNat> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<WinNatCountersWinNat> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_WinNatCounters_WinNAT");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new WinNatCountersWinNat
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CurrentSessionCount = (uint) (managementObject.Properties["CurrentSessionCount"]?.Value ?? default(uint)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DroppedIcmPerrorpackets = (uint) (managementObject.Properties["DroppedICMPerrorpackets"]?.Value ?? default(uint)),
		 DroppedIcmPerrorpacketsPersec = (uint) (managementObject.Properties["DroppedICMPerrorpacketsPersec"]?.Value ?? default(uint)),
		 DroppedPackets = (uint) (managementObject.Properties["DroppedPackets"]?.Value ?? default(uint)),
		 DroppedPacketsPersec = (uint) (managementObject.Properties["DroppedPacketsPersec"]?.Value ?? default(uint)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 InterRoutingDomainHairpinnedPackets = (uint) (managementObject.Properties["InterRoutingDomainHairpinnedPackets"]?.Value ?? default(uint)),
		 InterRoutingDomainHairpinnedPacketsPersec = (uint) (managementObject.Properties["InterRoutingDomainHairpinnedPacketsPersec"]?.Value ?? default(uint)),
		 IntraRoutingDomainHairpinnedPackets = (uint) (managementObject.Properties["IntraRoutingDomainHairpinnedPackets"]?.Value ?? default(uint)),
		 IntraRoutingDomainHairpinnedPacketsPersec = (uint) (managementObject.Properties["IntraRoutingDomainHairpinnedPacketsPersec"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 PacketsExternaltoInternal = (uint) (managementObject.Properties["PacketsExternaltoInternal"]?.Value ?? default(uint)),
		 PacketsInternaltoExternal = (uint) (managementObject.Properties["PacketsInternaltoExternal"]?.Value ?? default(uint)),
		 PacketsPersecExternaltoInternal = (uint) (managementObject.Properties["PacketsPersecExternaltoInternal"]?.Value ?? default(uint)),
		 PacketsPersecInternaltoExternal = (uint) (managementObject.Properties["PacketsPersecInternaltoExternal"]?.Value ?? default(uint)),
		 SessionsPersec = (uint) (managementObject.Properties["SessionsPersec"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}