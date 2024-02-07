using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw
{
    /// <summary>
    /// </summary>
    public sealed class MsdrdaMsftdb2AccessLibrary
    {
		public uint AvgHostProcessingTime { get; private set; }
		public uint AvgHostProcessingTimeBase { get; private set; }
		public ulong BytesReceivedPerSecond { get; private set; }
		public ulong BytesSentPerSecond { get; private set; }
		public string Caption { get; private set; }
		public uint CommitsPerSecond { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public uint OledbAvgDataAccessTime { get; private set; }
		public uint OledbAvgDataAccessTimeBase { get; private set; }
		public uint OledbAvgExecutionTime { get; private set; }
		public uint OledbAvgExecutionTimeBase { get; private set; }
		public uint OledbAvgFetchTime { get; private set; }
		public uint OledbAvgFetchTimeBase { get; private set; }
		public uint OledbAvgPrepareTime { get; private set; }
		public uint OledbAvgPrepareTimeBase { get; private set; }
		public uint OledbExecutesPerSecond { get; private set; }
		public uint OledbGetDatacallsPerSecond { get; private set; }
		public uint OledbPreparesPerSecond { get; private set; }
		public uint OledbRowsFetchedPerSecond { get; private set; }
		public uint OpenConnections { get; private set; }
		public uint OpenStatements { get; private set; }
		public ulong PacketsReceivedPerSecond { get; private set; }
		public ulong PacketsSentPerSecond { get; private set; }
		public uint RollbacksPerSecond { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public uint TransactionsPerSecond { get; private set; }

        public static IEnumerable<MsdrdaMsftdb2AccessLibrary> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<MsdrdaMsftdb2AccessLibrary> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<MsdrdaMsftdb2AccessLibrary> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_msdrda_MSFTDB2AccessLibrary");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new MsdrdaMsftdb2AccessLibrary
                {
                     AvgHostProcessingTime = (uint) (managementObject.Properties["AvgHostProcessingTime"]?.Value ?? default(uint)),
		 AvgHostProcessingTimeBase = (uint) (managementObject.Properties["AvgHostProcessingTime_Base"]?.Value ?? default(uint)),
		 BytesReceivedPerSecond = (ulong) (managementObject.Properties["BytesReceivedPerSecond"]?.Value ?? default(ulong)),
		 BytesSentPerSecond = (ulong) (managementObject.Properties["BytesSentPerSecond"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CommitsPerSecond = (uint) (managementObject.Properties["CommitsPerSecond"]?.Value ?? default(uint)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 OledbAvgDataAccessTime = (uint) (managementObject.Properties["OLEDBAvgDataAccessTime"]?.Value ?? default(uint)),
		 OledbAvgDataAccessTimeBase = (uint) (managementObject.Properties["OLEDBAvgDataAccessTime_Base"]?.Value ?? default(uint)),
		 OledbAvgExecutionTime = (uint) (managementObject.Properties["OLEDBAvgExecutionTime"]?.Value ?? default(uint)),
		 OledbAvgExecutionTimeBase = (uint) (managementObject.Properties["OLEDBAvgExecutionTime_Base"]?.Value ?? default(uint)),
		 OledbAvgFetchTime = (uint) (managementObject.Properties["OLEDBAvgFetchTime"]?.Value ?? default(uint)),
		 OledbAvgFetchTimeBase = (uint) (managementObject.Properties["OLEDBAvgFetchTime_Base"]?.Value ?? default(uint)),
		 OledbAvgPrepareTime = (uint) (managementObject.Properties["OLEDBAvgPrepareTime"]?.Value ?? default(uint)),
		 OledbAvgPrepareTimeBase = (uint) (managementObject.Properties["OLEDBAvgPrepareTime_Base"]?.Value ?? default(uint)),
		 OledbExecutesPerSecond = (uint) (managementObject.Properties["OLEDBExecutesPerSecond"]?.Value ?? default(uint)),
		 OledbGetDatacallsPerSecond = (uint) (managementObject.Properties["OLEDBGetDatacallsPerSecond"]?.Value ?? default(uint)),
		 OledbPreparesPerSecond = (uint) (managementObject.Properties["OLEDBPreparesPerSecond"]?.Value ?? default(uint)),
		 OledbRowsFetchedPerSecond = (uint) (managementObject.Properties["OLEDBRowsFetchedPerSecond"]?.Value ?? default(uint)),
		 OpenConnections = (uint) (managementObject.Properties["OpenConnections"]?.Value ?? default(uint)),
		 OpenStatements = (uint) (managementObject.Properties["OpenStatements"]?.Value ?? default(uint)),
		 PacketsReceivedPerSecond = (ulong) (managementObject.Properties["PacketsReceivedPerSecond"]?.Value ?? default(ulong)),
		 PacketsSentPerSecond = (ulong) (managementObject.Properties["PacketsSentPerSecond"]?.Value ?? default(ulong)),
		 RollbacksPerSecond = (uint) (managementObject.Properties["RollbacksPerSecond"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 TransactionsPerSecond = (uint) (managementObject.Properties["TransactionsPerSecond"]?.Value ?? default(uint))
                };
        }
    }
}