using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.Network.Teredo
{
    /// <summary>
    /// </summary>
    public sealed class CountersTeredoServer
    {
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public uint InTeredoServerErrorPacketsAuthenticationError { get; private set; }
		public uint InTeredoServerErrorPacketsDestinationError { get; private set; }
		public uint InTeredoServerErrorPacketsHeaderError { get; private set; }
		public uint InTeredoServerErrorPacketsSourceError { get; private set; }
		public uint InTeredoServerErrorPacketsTotal { get; private set; }
		public uint InTeredoServerSuccessPacketsBubbles { get; private set; }
		public uint InTeredoServerSuccessPacketsEcho { get; private set; }
		public uint InTeredoServerSuccessPacketsRsPrimary { get; private set; }
		public uint InTeredoServerSuccessPacketsRsSecondary { get; private set; }
		public uint InTeredoServerSuccessPacketsTotal { get; private set; }
		public uint InTeredoServerTotalPacketsSuccessError { get; private set; }
		public uint InTeredoServerTotalPacketsSuccessErrorPersec { get; private set; }
		public string Name { get; private set; }
		public uint OutTeredoServerRaPrimary { get; private set; }
		public uint OutTeredoServerRaSecondary { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<CountersTeredoServer> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<CountersTeredoServer> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<CountersTeredoServer> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_Counters_TeredoServer");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new CountersTeredoServer
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 InTeredoServerErrorPacketsAuthenticationError = (uint) (managementObject.Properties["InTeredoServerErrorPacketsAuthenticationError"]?.Value ?? default(uint)),
		 InTeredoServerErrorPacketsDestinationError = (uint) (managementObject.Properties["InTeredoServerErrorPacketsDestinationError"]?.Value ?? default(uint)),
		 InTeredoServerErrorPacketsHeaderError = (uint) (managementObject.Properties["InTeredoServerErrorPacketsHeaderError"]?.Value ?? default(uint)),
		 InTeredoServerErrorPacketsSourceError = (uint) (managementObject.Properties["InTeredoServerErrorPacketsSourceError"]?.Value ?? default(uint)),
		 InTeredoServerErrorPacketsTotal = (uint) (managementObject.Properties["InTeredoServerErrorPacketsTotal"]?.Value ?? default(uint)),
		 InTeredoServerSuccessPacketsBubbles = (uint) (managementObject.Properties["InTeredoServerSuccessPacketsBubbles"]?.Value ?? default(uint)),
		 InTeredoServerSuccessPacketsEcho = (uint) (managementObject.Properties["InTeredoServerSuccessPacketsEcho"]?.Value ?? default(uint)),
		 InTeredoServerSuccessPacketsRsPrimary = (uint) (managementObject.Properties["InTeredoServerSuccessPacketsRSPrimary"]?.Value ?? default(uint)),
		 InTeredoServerSuccessPacketsRsSecondary = (uint) (managementObject.Properties["InTeredoServerSuccessPacketsRSSecondary"]?.Value ?? default(uint)),
		 InTeredoServerSuccessPacketsTotal = (uint) (managementObject.Properties["InTeredoServerSuccessPacketsTotal"]?.Value ?? default(uint)),
		 InTeredoServerTotalPacketsSuccessError = (uint) (managementObject.Properties["InTeredoServerTotalPacketsSuccessError"]?.Value ?? default(uint)),
		 InTeredoServerTotalPacketsSuccessErrorPersec = (uint) (managementObject.Properties["InTeredoServerTotalPacketsSuccessErrorPersec"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 OutTeredoServerRaPrimary = (uint) (managementObject.Properties["OutTeredoServerRAPrimary"]?.Value ?? default(uint)),
		 OutTeredoServerRaSecondary = (uint) (managementObject.Properties["OutTeredoServerRASecondary"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}