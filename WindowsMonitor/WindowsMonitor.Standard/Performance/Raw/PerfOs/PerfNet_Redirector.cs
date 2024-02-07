using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.PerfOs
{
    /// <summary>
    /// </summary>
    public sealed class PerfNetRedirector
    {
		public ulong BytesReceivedPersec { get; private set; }
		public ulong BytesTotalPersec { get; private set; }
		public ulong BytesTransmittedPersec { get; private set; }
		public string Caption { get; private set; }
		public uint ConnectsCore { get; private set; }
		public uint ConnectsLanManager20 { get; private set; }
		public uint ConnectsLanManager21 { get; private set; }
		public uint ConnectsWindowsNt { get; private set; }
		public uint CurrentCommands { get; private set; }
		public string Description { get; private set; }
		public uint FileDataOperationsPersec { get; private set; }
		public uint FileReadOperationsPersec { get; private set; }
		public uint FileWriteOperationsPersec { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public uint NetworkErrorsPersec { get; private set; }
		public ulong PacketsPersec { get; private set; }
		public ulong PacketsReceivedPersec { get; private set; }
		public ulong PacketsTransmittedPersec { get; private set; }
		public ulong ReadBytesCachePersec { get; private set; }
		public ulong ReadBytesNetworkPersec { get; private set; }
		public ulong ReadBytesNonPagingPersec { get; private set; }
		public ulong ReadBytesPagingPersec { get; private set; }
		public uint ReadOperationsRandomPersec { get; private set; }
		public uint ReadPacketsPersec { get; private set; }
		public uint ReadPacketsSmallPersec { get; private set; }
		public uint ReadsDeniedPersec { get; private set; }
		public uint ReadsLargePersec { get; private set; }
		public uint ServerDisconnects { get; private set; }
		public uint ServerReconnects { get; private set; }
		public uint ServerSessions { get; private set; }
		public uint ServerSessionsHung { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public ulong WriteBytesCachePersec { get; private set; }
		public ulong WriteBytesNetworkPersec { get; private set; }
		public ulong WriteBytesNonPagingPersec { get; private set; }
		public ulong WriteBytesPagingPersec { get; private set; }
		public uint WriteOperationsRandomPersec { get; private set; }
		public uint WritePacketsPersec { get; private set; }
		public uint WritePacketsSmallPersec { get; private set; }
		public uint WritesDeniedPersec { get; private set; }
		public uint WritesLargePersec { get; private set; }

        public static IEnumerable<PerfNetRedirector> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<PerfNetRedirector> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<PerfNetRedirector> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_PerfNet_Redirector");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new PerfNetRedirector
                {
                     BytesReceivedPersec = (ulong) (managementObject.Properties["BytesReceivedPersec"]?.Value ?? default(ulong)),
		 BytesTotalPersec = (ulong) (managementObject.Properties["BytesTotalPersec"]?.Value ?? default(ulong)),
		 BytesTransmittedPersec = (ulong) (managementObject.Properties["BytesTransmittedPersec"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 ConnectsCore = (uint) (managementObject.Properties["ConnectsCore"]?.Value ?? default(uint)),
		 ConnectsLanManager20 = (uint) (managementObject.Properties["ConnectsLanManager20"]?.Value ?? default(uint)),
		 ConnectsLanManager21 = (uint) (managementObject.Properties["ConnectsLanManager21"]?.Value ?? default(uint)),
		 ConnectsWindowsNt = (uint) (managementObject.Properties["ConnectsWindowsNT"]?.Value ?? default(uint)),
		 CurrentCommands = (uint) (managementObject.Properties["CurrentCommands"]?.Value ?? default(uint)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FileDataOperationsPersec = (uint) (managementObject.Properties["FileDataOperationsPersec"]?.Value ?? default(uint)),
		 FileReadOperationsPersec = (uint) (managementObject.Properties["FileReadOperationsPersec"]?.Value ?? default(uint)),
		 FileWriteOperationsPersec = (uint) (managementObject.Properties["FileWriteOperationsPersec"]?.Value ?? default(uint)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 NetworkErrorsPersec = (uint) (managementObject.Properties["NetworkErrorsPersec"]?.Value ?? default(uint)),
		 PacketsPersec = (ulong) (managementObject.Properties["PacketsPersec"]?.Value ?? default(ulong)),
		 PacketsReceivedPersec = (ulong) (managementObject.Properties["PacketsReceivedPersec"]?.Value ?? default(ulong)),
		 PacketsTransmittedPersec = (ulong) (managementObject.Properties["PacketsTransmittedPersec"]?.Value ?? default(ulong)),
		 ReadBytesCachePersec = (ulong) (managementObject.Properties["ReadBytesCachePersec"]?.Value ?? default(ulong)),
		 ReadBytesNetworkPersec = (ulong) (managementObject.Properties["ReadBytesNetworkPersec"]?.Value ?? default(ulong)),
		 ReadBytesNonPagingPersec = (ulong) (managementObject.Properties["ReadBytesNonPagingPersec"]?.Value ?? default(ulong)),
		 ReadBytesPagingPersec = (ulong) (managementObject.Properties["ReadBytesPagingPersec"]?.Value ?? default(ulong)),
		 ReadOperationsRandomPersec = (uint) (managementObject.Properties["ReadOperationsRandomPersec"]?.Value ?? default(uint)),
		 ReadPacketsPersec = (uint) (managementObject.Properties["ReadPacketsPersec"]?.Value ?? default(uint)),
		 ReadPacketsSmallPersec = (uint) (managementObject.Properties["ReadPacketsSmallPersec"]?.Value ?? default(uint)),
		 ReadsDeniedPersec = (uint) (managementObject.Properties["ReadsDeniedPersec"]?.Value ?? default(uint)),
		 ReadsLargePersec = (uint) (managementObject.Properties["ReadsLargePersec"]?.Value ?? default(uint)),
		 ServerDisconnects = (uint) (managementObject.Properties["ServerDisconnects"]?.Value ?? default(uint)),
		 ServerReconnects = (uint) (managementObject.Properties["ServerReconnects"]?.Value ?? default(uint)),
		 ServerSessions = (uint) (managementObject.Properties["ServerSessions"]?.Value ?? default(uint)),
		 ServerSessionsHung = (uint) (managementObject.Properties["ServerSessionsHung"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 WriteBytesCachePersec = (ulong) (managementObject.Properties["WriteBytesCachePersec"]?.Value ?? default(ulong)),
		 WriteBytesNetworkPersec = (ulong) (managementObject.Properties["WriteBytesNetworkPersec"]?.Value ?? default(ulong)),
		 WriteBytesNonPagingPersec = (ulong) (managementObject.Properties["WriteBytesNonPagingPersec"]?.Value ?? default(ulong)),
		 WriteBytesPagingPersec = (ulong) (managementObject.Properties["WriteBytesPagingPersec"]?.Value ?? default(ulong)),
		 WriteOperationsRandomPersec = (uint) (managementObject.Properties["WriteOperationsRandomPersec"]?.Value ?? default(uint)),
		 WritePacketsPersec = (uint) (managementObject.Properties["WritePacketsPersec"]?.Value ?? default(uint)),
		 WritePacketsSmallPersec = (uint) (managementObject.Properties["WritePacketsSmallPersec"]?.Value ?? default(uint)),
		 WritesDeniedPersec = (uint) (managementObject.Properties["WritesDeniedPersec"]?.Value ?? default(uint)),
		 WritesLargePersec = (uint) (managementObject.Properties["WritesLargePersec"]?.Value ?? default(uint))
                };
        }
    }
}