using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.SqlServer
{
    /// <summary>
    /// </summary>
    public sealed class SqlServer2016XtpioGovernor
    {
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public uint InsufficientCreditsWaitsPersec { get; private set; }
		public uint IoIssuedPersec { get; private set; }
		public uint LogBlocksPersec { get; private set; }
		public ulong MissedCreditSlots { get; private set; }
		public string Name { get; private set; }
		public uint StaleRateObjectWaitsPersec { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public ulong TotalRateObjectsPublished { get; private set; }

        public static IEnumerable<SqlServer2016XtpioGovernor> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SqlServer2016XtpioGovernor> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SqlServer2016XtpioGovernor> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_SQLServer2016XTPDatabaseEngine_SQLServer2016XTPIOGovernor");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SqlServer2016XtpioGovernor
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 InsufficientCreditsWaitsPersec = (uint) (managementObject.Properties["InsufficientCreditsWaitsPersec"]?.Value ?? default(uint)),
		 IoIssuedPersec = (uint) (managementObject.Properties["IoIssuedPersec"]?.Value ?? default(uint)),
		 LogBlocksPersec = (uint) (managementObject.Properties["LogBlocksPersec"]?.Value ?? default(uint)),
		 MissedCreditSlots = (ulong) (managementObject.Properties["MissedCreditSlots"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 StaleRateObjectWaitsPersec = (uint) (managementObject.Properties["StaleRateObjectWaitsPersec"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 TotalRateObjectsPublished = (ulong) (managementObject.Properties["TotalRateObjectsPublished"]?.Value ?? default(ulong))
                };
        }
    }
}