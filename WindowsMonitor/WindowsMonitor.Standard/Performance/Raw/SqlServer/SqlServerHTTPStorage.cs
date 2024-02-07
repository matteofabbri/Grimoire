using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.SqlServer
{
    /// <summary>
    /// </summary>
    public sealed class SqlServerHttpStorage
    {
		public ulong AvgBytesPerRead { get; private set; }
		public uint AvgBytesPerReadBase { get; private set; }
		public ulong AvgBytesPerTransfer { get; private set; }
		public uint AvgBytesPerTransferBase { get; private set; }
		public ulong AvgBytesPerWrite { get; private set; }
		public uint AvgBytesPerWriteBase { get; private set; }
		public ulong AvgmicrosecPerRead { get; private set; }
		public uint AvgmicrosecPerReadBase { get; private set; }
		public ulong AvgmicrosecPerReadComp { get; private set; }
		public uint AvgmicrosecPerReadCompBase { get; private set; }
		public ulong AvgmicrosecPerTransfer { get; private set; }
		public uint AvgmicrosecPerTransferBase { get; private set; }
		public ulong AvgmicrosecPerWrite { get; private set; }
		public uint AvgmicrosecPerWriteBase { get; private set; }
		public ulong AvgmicrosecPerWriteComp { get; private set; }
		public uint AvgmicrosecPerWriteCompBase { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public ulong HttpStorageIOfailedPersec { get; private set; }
		public ulong HttpStorageIOretryPersec { get; private set; }
		public string Name { get; private set; }
		public ulong OutstandingHttpStorageIo { get; private set; }
		public ulong ReadBytesPerSec { get; private set; }
		public ulong ReadsPerSec { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public ulong TotalBytesPerSec { get; private set; }
		public ulong TransfersPerSec { get; private set; }
		public ulong WriteBytesPerSec { get; private set; }
		public ulong WritesPerSec { get; private set; }

        public static IEnumerable<SqlServerHttpStorage> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SqlServerHttpStorage> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SqlServerHttpStorage> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_MSSQLSERVER_SQLServerHTTPStorage");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SqlServerHttpStorage
                {
                     AvgBytesPerRead = (ulong) (managementObject.Properties["AvgBytesPerRead"]?.Value ?? default(ulong)),
		 AvgBytesPerReadBase = (uint) (managementObject.Properties["AvgBytesPerRead_Base"]?.Value ?? default(uint)),
		 AvgBytesPerTransfer = (ulong) (managementObject.Properties["AvgBytesPerTransfer"]?.Value ?? default(ulong)),
		 AvgBytesPerTransferBase = (uint) (managementObject.Properties["AvgBytesPerTransfer_Base"]?.Value ?? default(uint)),
		 AvgBytesPerWrite = (ulong) (managementObject.Properties["AvgBytesPerWrite"]?.Value ?? default(ulong)),
		 AvgBytesPerWriteBase = (uint) (managementObject.Properties["AvgBytesPerWrite_Base"]?.Value ?? default(uint)),
		 AvgmicrosecPerRead = (ulong) (managementObject.Properties["AvgmicrosecPerRead"]?.Value ?? default(ulong)),
		 AvgmicrosecPerReadBase = (uint) (managementObject.Properties["AvgmicrosecPerRead_Base"]?.Value ?? default(uint)),
		 AvgmicrosecPerReadComp = (ulong) (managementObject.Properties["AvgmicrosecPerReadComp"]?.Value ?? default(ulong)),
		 AvgmicrosecPerReadCompBase = (uint) (managementObject.Properties["AvgmicrosecPerReadComp_Base"]?.Value ?? default(uint)),
		 AvgmicrosecPerTransfer = (ulong) (managementObject.Properties["AvgmicrosecPerTransfer"]?.Value ?? default(ulong)),
		 AvgmicrosecPerTransferBase = (uint) (managementObject.Properties["AvgmicrosecPerTransfer_Base"]?.Value ?? default(uint)),
		 AvgmicrosecPerWrite = (ulong) (managementObject.Properties["AvgmicrosecPerWrite"]?.Value ?? default(ulong)),
		 AvgmicrosecPerWriteBase = (uint) (managementObject.Properties["AvgmicrosecPerWrite_Base"]?.Value ?? default(uint)),
		 AvgmicrosecPerWriteComp = (ulong) (managementObject.Properties["AvgmicrosecPerWriteComp"]?.Value ?? default(ulong)),
		 AvgmicrosecPerWriteCompBase = (uint) (managementObject.Properties["AvgmicrosecPerWriteComp_Base"]?.Value ?? default(uint)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 HttpStorageIOfailedPersec = (ulong) (managementObject.Properties["HTTPStorageIOfailedPersec"]?.Value ?? default(ulong)),
		 HttpStorageIOretryPersec = (ulong) (managementObject.Properties["HTTPStorageIOretryPersec"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 OutstandingHttpStorageIo = (ulong) (managementObject.Properties["OutstandingHTTPStorageIO"]?.Value ?? default(ulong)),
		 ReadBytesPerSec = (ulong) (managementObject.Properties["ReadBytesPerSec"]?.Value ?? default(ulong)),
		 ReadsPerSec = (ulong) (managementObject.Properties["ReadsPerSec"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 TotalBytesPerSec = (ulong) (managementObject.Properties["TotalBytesPerSec"]?.Value ?? default(ulong)),
		 TransfersPerSec = (ulong) (managementObject.Properties["TransfersPerSec"]?.Value ?? default(ulong)),
		 WriteBytesPerSec = (ulong) (managementObject.Properties["WriteBytesPerSec"]?.Value ?? default(ulong)),
		 WritesPerSec = (ulong) (managementObject.Properties["WritesPerSec"]?.Value ?? default(ulong))
                };
        }
    }
}