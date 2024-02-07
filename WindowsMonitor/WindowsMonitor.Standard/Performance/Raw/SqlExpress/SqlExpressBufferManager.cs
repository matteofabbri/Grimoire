using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.SqlExpress
{
    /// <summary>
    /// </summary>
    public sealed class SqlExpressBufferManager
    {
		public ulong BackgroundwriterpagesPersec { get; private set; }
		public ulong Buffercachehitratio { get; private set; }
		public ulong BuffercachehitratioBase { get; private set; }
		public string Caption { get; private set; }
		public ulong CheckpointpagesPersec { get; private set; }
		public ulong Databasepages { get; private set; }
		public string Description { get; private set; }
		public ulong Extensionallocatedpages { get; private set; }
		public ulong Extensionfreepages { get; private set; }
		public ulong Extensioninuseaspercentage { get; private set; }
		public ulong ExtensionoutstandingIOcounter { get; private set; }
		public ulong ExtensionpageevictionsPersec { get; private set; }
		public ulong ExtensionpagereadsPersec { get; private set; }
		public ulong Extensionpageunreferencedtime { get; private set; }
		public ulong ExtensionpagewritesPersec { get; private set; }
		public ulong FreeliststallsPersec { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public ulong IntegralControllerSlope { get; private set; }
		public ulong LazywritesPersec { get; private set; }
		public string Name { get; private set; }
		public ulong Pagelifeexpectancy { get; private set; }
		public ulong PagelookupsPersec { get; private set; }
		public ulong PagereadsPersec { get; private set; }
		public ulong PagewritesPersec { get; private set; }
		public ulong ReadaheadpagesPersec { get; private set; }
		public ulong ReadaheadtimePersec { get; private set; }
		public ulong Targetpages { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<SqlExpressBufferManager> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SqlExpressBufferManager> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SqlExpressBufferManager> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_MSSQLSQLEXPRESS_MSSQLSQLEXPRESSBufferManager");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SqlExpressBufferManager
                {
                     BackgroundwriterpagesPersec = (ulong) (managementObject.Properties["BackgroundwriterpagesPersec"]?.Value ?? default(ulong)),
		 Buffercachehitratio = (ulong) (managementObject.Properties["Buffercachehitratio"]?.Value ?? default(ulong)),
		 BuffercachehitratioBase = (ulong) (managementObject.Properties["Buffercachehitratio_Base"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CheckpointpagesPersec = (ulong) (managementObject.Properties["CheckpointpagesPersec"]?.Value ?? default(ulong)),
		 Databasepages = (ulong) (managementObject.Properties["Databasepages"]?.Value ?? default(ulong)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 Extensionallocatedpages = (ulong) (managementObject.Properties["Extensionallocatedpages"]?.Value ?? default(ulong)),
		 Extensionfreepages = (ulong) (managementObject.Properties["Extensionfreepages"]?.Value ?? default(ulong)),
		 Extensioninuseaspercentage = (ulong) (managementObject.Properties["Extensioninuseaspercentage"]?.Value ?? default(ulong)),
		 ExtensionoutstandingIOcounter = (ulong) (managementObject.Properties["ExtensionoutstandingIOcounter"]?.Value ?? default(ulong)),
		 ExtensionpageevictionsPersec = (ulong) (managementObject.Properties["ExtensionpageevictionsPersec"]?.Value ?? default(ulong)),
		 ExtensionpagereadsPersec = (ulong) (managementObject.Properties["ExtensionpagereadsPersec"]?.Value ?? default(ulong)),
		 Extensionpageunreferencedtime = (ulong) (managementObject.Properties["Extensionpageunreferencedtime"]?.Value ?? default(ulong)),
		 ExtensionpagewritesPersec = (ulong) (managementObject.Properties["ExtensionpagewritesPersec"]?.Value ?? default(ulong)),
		 FreeliststallsPersec = (ulong) (managementObject.Properties["FreeliststallsPersec"]?.Value ?? default(ulong)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 IntegralControllerSlope = (ulong) (managementObject.Properties["IntegralControllerSlope"]?.Value ?? default(ulong)),
		 LazywritesPersec = (ulong) (managementObject.Properties["LazywritesPersec"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 Pagelifeexpectancy = (ulong) (managementObject.Properties["Pagelifeexpectancy"]?.Value ?? default(ulong)),
		 PagelookupsPersec = (ulong) (managementObject.Properties["PagelookupsPersec"]?.Value ?? default(ulong)),
		 PagereadsPersec = (ulong) (managementObject.Properties["PagereadsPersec"]?.Value ?? default(ulong)),
		 PagewritesPersec = (ulong) (managementObject.Properties["PagewritesPersec"]?.Value ?? default(ulong)),
		 ReadaheadpagesPersec = (ulong) (managementObject.Properties["ReadaheadpagesPersec"]?.Value ?? default(ulong)),
		 ReadaheadtimePersec = (ulong) (managementObject.Properties["ReadaheadtimePersec"]?.Value ?? default(ulong)),
		 Targetpages = (ulong) (managementObject.Properties["Targetpages"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}