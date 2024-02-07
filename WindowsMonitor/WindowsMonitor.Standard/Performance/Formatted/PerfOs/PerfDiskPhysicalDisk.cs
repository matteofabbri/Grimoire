using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted.PerfOs
{
    /// <summary>
    /// </summary>
    public sealed class PerfDiskPhysicalDisk
    {
		public ulong AvgDiskBytesPerRead { get; private set; }
		public ulong AvgDiskBytesPerTransfer { get; private set; }
		public ulong AvgDiskBytesPerWrite { get; private set; }
		public ulong AvgDiskQueueLength { get; private set; }
		public ulong AvgDiskReadQueueLength { get; private set; }
		public uint AvgDisksecPerRead { get; private set; }
		public uint AvgDisksecPerTransfer { get; private set; }
		public uint AvgDisksecPerWrite { get; private set; }
		public ulong AvgDiskWriteQueueLength { get; private set; }
		public string Caption { get; private set; }
		public uint CurrentDiskQueueLength { get; private set; }
		public string Description { get; private set; }
		public ulong DiskBytesPersec { get; private set; }
		public ulong DiskReadBytesPersec { get; private set; }
		public uint DiskReadsPersec { get; private set; }
		public uint DiskTransfersPersec { get; private set; }
		public ulong DiskWriteBytesPersec { get; private set; }
		public uint DiskWritesPersec { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public ulong PercentDiskReadTime { get; private set; }
		public ulong PercentDiskTime { get; private set; }
		public ulong PercentDiskWriteTime { get; private set; }
		public ulong PercentIdleTime { get; private set; }
		public uint SplitIoPerSec { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<PerfDiskPhysicalDisk> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<PerfDiskPhysicalDisk> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<PerfDiskPhysicalDisk> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_PerfDisk_PhysicalDisk");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new PerfDiskPhysicalDisk
                {
                     AvgDiskBytesPerRead = (ulong) (managementObject.Properties["AvgDiskBytesPerRead"]?.Value ?? default(ulong)),
		 AvgDiskBytesPerTransfer = (ulong) (managementObject.Properties["AvgDiskBytesPerTransfer"]?.Value ?? default(ulong)),
		 AvgDiskBytesPerWrite = (ulong) (managementObject.Properties["AvgDiskBytesPerWrite"]?.Value ?? default(ulong)),
		 AvgDiskQueueLength = (ulong) (managementObject.Properties["AvgDiskQueueLength"]?.Value ?? default(ulong)),
		 AvgDiskReadQueueLength = (ulong) (managementObject.Properties["AvgDiskReadQueueLength"]?.Value ?? default(ulong)),
		 AvgDisksecPerRead = (uint) (managementObject.Properties["AvgDisksecPerRead"]?.Value ?? default(uint)),
		 AvgDisksecPerTransfer = (uint) (managementObject.Properties["AvgDisksecPerTransfer"]?.Value ?? default(uint)),
		 AvgDisksecPerWrite = (uint) (managementObject.Properties["AvgDisksecPerWrite"]?.Value ?? default(uint)),
		 AvgDiskWriteQueueLength = (ulong) (managementObject.Properties["AvgDiskWriteQueueLength"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CurrentDiskQueueLength = (uint) (managementObject.Properties["CurrentDiskQueueLength"]?.Value ?? default(uint)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DiskBytesPersec = (ulong) (managementObject.Properties["DiskBytesPersec"]?.Value ?? default(ulong)),
		 DiskReadBytesPersec = (ulong) (managementObject.Properties["DiskReadBytesPersec"]?.Value ?? default(ulong)),
		 DiskReadsPersec = (uint) (managementObject.Properties["DiskReadsPersec"]?.Value ?? default(uint)),
		 DiskTransfersPersec = (uint) (managementObject.Properties["DiskTransfersPersec"]?.Value ?? default(uint)),
		 DiskWriteBytesPersec = (ulong) (managementObject.Properties["DiskWriteBytesPersec"]?.Value ?? default(ulong)),
		 DiskWritesPersec = (uint) (managementObject.Properties["DiskWritesPersec"]?.Value ?? default(uint)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 PercentDiskReadTime = (ulong) (managementObject.Properties["PercentDiskReadTime"]?.Value ?? default(ulong)),
		 PercentDiskTime = (ulong) (managementObject.Properties["PercentDiskTime"]?.Value ?? default(ulong)),
		 PercentDiskWriteTime = (ulong) (managementObject.Properties["PercentDiskWriteTime"]?.Value ?? default(ulong)),
		 PercentIdleTime = (ulong) (managementObject.Properties["PercentIdleTime"]?.Value ?? default(ulong)),
		 SplitIoPerSec = (uint) (managementObject.Properties["SplitIOPerSec"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}