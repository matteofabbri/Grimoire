using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.Network.Teredo
{
    /// <summary>
    /// </summary>
    public sealed class CountersTeredoRelay
    {
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public uint InTeredoRelayErrorPacketsDestinationError { get; private set; }
		public uint InTeredoRelayErrorPacketsHeaderError { get; private set; }
		public uint InTeredoRelayErrorPacketsSourceError { get; private set; }
		public uint InTeredoRelayErrorPacketsTotal { get; private set; }
		public uint InTeredoRelaySuccessPacketsBubbles { get; private set; }
		public ulong InTeredoRelaySuccessPacketsDataPackets { get; private set; }
		public ulong InTeredoRelaySuccessPacketsDataPacketsKernelMode { get; private set; }
		public ulong InTeredoRelaySuccessPacketsDataPacketsUserMode { get; private set; }
		public ulong InTeredoRelaySuccessPacketsTotal { get; private set; }
		public uint InTeredoRelayTotalPacketsSuccessError { get; private set; }
		public uint InTeredoRelayTotalPacketsSuccessErrorPersec { get; private set; }
		public string Name { get; private set; }
		public uint OutTeredoRelayErrorPackets { get; private set; }
		public uint OutTeredoRelayErrorPacketsDestinationError { get; private set; }
		public uint OutTeredoRelayErrorPacketsHeaderError { get; private set; }
		public uint OutTeredoRelayErrorPacketsSourceError { get; private set; }
		public ulong OutTeredoRelaySuccessPackets { get; private set; }
		public uint OutTeredoRelaySuccessPacketsBubbles { get; private set; }
		public ulong OutTeredoRelaySuccessPacketsDataPackets { get; private set; }
		public ulong OutTeredoRelaySuccessPacketsDataPacketsKernelMode { get; private set; }
		public ulong OutTeredoRelaySuccessPacketsDataPacketsUserMode { get; private set; }
		public uint OutTeredoRelayTotalPacketsSuccessError { get; private set; }
		public uint OutTeredoRelayTotalPacketsSuccessErrorPersec { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<CountersTeredoRelay> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<CountersTeredoRelay> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<CountersTeredoRelay> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_Counters_TeredoRelay");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new CountersTeredoRelay
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 InTeredoRelayErrorPacketsDestinationError = (uint) (managementObject.Properties["InTeredoRelayErrorPacketsDestinationError"]?.Value ?? default(uint)),
		 InTeredoRelayErrorPacketsHeaderError = (uint) (managementObject.Properties["InTeredoRelayErrorPacketsHeaderError"]?.Value ?? default(uint)),
		 InTeredoRelayErrorPacketsSourceError = (uint) (managementObject.Properties["InTeredoRelayErrorPacketsSourceError"]?.Value ?? default(uint)),
		 InTeredoRelayErrorPacketsTotal = (uint) (managementObject.Properties["InTeredoRelayErrorPacketsTotal"]?.Value ?? default(uint)),
		 InTeredoRelaySuccessPacketsBubbles = (uint) (managementObject.Properties["InTeredoRelaySuccessPacketsBubbles"]?.Value ?? default(uint)),
		 InTeredoRelaySuccessPacketsDataPackets = (ulong) (managementObject.Properties["InTeredoRelaySuccessPacketsDataPackets"]?.Value ?? default(ulong)),
		 InTeredoRelaySuccessPacketsDataPacketsKernelMode = (ulong) (managementObject.Properties["InTeredoRelaySuccessPacketsDataPacketsKernelMode"]?.Value ?? default(ulong)),
		 InTeredoRelaySuccessPacketsDataPacketsUserMode = (ulong) (managementObject.Properties["InTeredoRelaySuccessPacketsDataPacketsUserMode"]?.Value ?? default(ulong)),
		 InTeredoRelaySuccessPacketsTotal = (ulong) (managementObject.Properties["InTeredoRelaySuccessPacketsTotal"]?.Value ?? default(ulong)),
		 InTeredoRelayTotalPacketsSuccessError = (uint) (managementObject.Properties["InTeredoRelayTotalPacketsSuccessError"]?.Value ?? default(uint)),
		 InTeredoRelayTotalPacketsSuccessErrorPersec = (uint) (managementObject.Properties["InTeredoRelayTotalPacketsSuccessErrorPersec"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 OutTeredoRelayErrorPackets = (uint) (managementObject.Properties["OutTeredoRelayErrorPackets"]?.Value ?? default(uint)),
		 OutTeredoRelayErrorPacketsDestinationError = (uint) (managementObject.Properties["OutTeredoRelayErrorPacketsDestinationError"]?.Value ?? default(uint)),
		 OutTeredoRelayErrorPacketsHeaderError = (uint) (managementObject.Properties["OutTeredoRelayErrorPacketsHeaderError"]?.Value ?? default(uint)),
		 OutTeredoRelayErrorPacketsSourceError = (uint) (managementObject.Properties["OutTeredoRelayErrorPacketsSourceError"]?.Value ?? default(uint)),
		 OutTeredoRelaySuccessPackets = (ulong) (managementObject.Properties["OutTeredoRelaySuccessPackets"]?.Value ?? default(ulong)),
		 OutTeredoRelaySuccessPacketsBubbles = (uint) (managementObject.Properties["OutTeredoRelaySuccessPacketsBubbles"]?.Value ?? default(uint)),
		 OutTeredoRelaySuccessPacketsDataPackets = (ulong) (managementObject.Properties["OutTeredoRelaySuccessPacketsDataPackets"]?.Value ?? default(ulong)),
		 OutTeredoRelaySuccessPacketsDataPacketsKernelMode = (ulong) (managementObject.Properties["OutTeredoRelaySuccessPacketsDataPacketsKernelMode"]?.Value ?? default(ulong)),
		 OutTeredoRelaySuccessPacketsDataPacketsUserMode = (ulong) (managementObject.Properties["OutTeredoRelaySuccessPacketsDataPacketsUserMode"]?.Value ?? default(ulong)),
		 OutTeredoRelayTotalPacketsSuccessError = (uint) (managementObject.Properties["OutTeredoRelayTotalPacketsSuccessError"]?.Value ?? default(uint)),
		 OutTeredoRelayTotalPacketsSuccessErrorPersec = (uint) (managementObject.Properties["OutTeredoRelayTotalPacketsSuccessErrorPersec"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}