using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.Xtp
{
    /// <summary>
    /// </summary>
    public sealed class XtpDatabaseEngineXtpCursors
    {
		public string Caption { get; private set; }
		public uint CursordeletesPersec { get; private set; }
		public uint CursorinsertsPersec { get; private set; }
		public uint CursorscansstartedPersec { get; private set; }
		public uint CursoruniqueviolationsPersec { get; private set; }
		public uint CursorupdatesPersec { get; private set; }
		public uint CursorwriteconflictsPersec { get; private set; }
		public string Description { get; private set; }
		public uint DustycornerscanretriesPersecuserissued { get; private set; }
		public uint ExpiredrowsremovedPersec { get; private set; }
		public uint ExpiredrowstouchedPersec { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public uint RowsreturnedPersec { get; private set; }
		public uint RowstouchedPersec { get; private set; }
		public uint TentativelydeletedrowstouchedPersec { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<XtpDatabaseEngineXtpCursors> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<XtpDatabaseEngineXtpCursors> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<XtpDatabaseEngineXtpCursors> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_XTPDatabaseEngine_XTPCursors");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new XtpDatabaseEngineXtpCursors
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CursordeletesPersec = (uint) (managementObject.Properties["CursordeletesPersec"]?.Value ?? default(uint)),
		 CursorinsertsPersec = (uint) (managementObject.Properties["CursorinsertsPersec"]?.Value ?? default(uint)),
		 CursorscansstartedPersec = (uint) (managementObject.Properties["CursorscansstartedPersec"]?.Value ?? default(uint)),
		 CursoruniqueviolationsPersec = (uint) (managementObject.Properties["CursoruniqueviolationsPersec"]?.Value ?? default(uint)),
		 CursorupdatesPersec = (uint) (managementObject.Properties["CursorupdatesPersec"]?.Value ?? default(uint)),
		 CursorwriteconflictsPersec = (uint) (managementObject.Properties["CursorwriteconflictsPersec"]?.Value ?? default(uint)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DustycornerscanretriesPersecuserissued = (uint) (managementObject.Properties["DustycornerscanretriesPersecuserissued"]?.Value ?? default(uint)),
		 ExpiredrowsremovedPersec = (uint) (managementObject.Properties["ExpiredrowsremovedPersec"]?.Value ?? default(uint)),
		 ExpiredrowstouchedPersec = (uint) (managementObject.Properties["ExpiredrowstouchedPersec"]?.Value ?? default(uint)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 RowsreturnedPersec = (uint) (managementObject.Properties["RowsreturnedPersec"]?.Value ?? default(uint)),
		 RowstouchedPersec = (uint) (managementObject.Properties["RowstouchedPersec"]?.Value ?? default(uint)),
		 TentativelydeletedrowstouchedPersec = (uint) (managementObject.Properties["TentativelydeletedrowstouchedPersec"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}