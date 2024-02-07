using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.SqlExpress
{
    /// <summary>
    /// </summary>
    public sealed class SqlExpressMemoryBrokerClerks
    {
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public ulong Internalbenefit { get; private set; }
		public ulong Memorybrokerclerksize { get; private set; }
		public string Name { get; private set; }
		public ulong Periodicevictionspages { get; private set; }
		public ulong PressureevictionspagesPersec { get; private set; }
		public ulong Simulationbenefit { get; private set; }
		public ulong Simulationsize { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<SqlExpressMemoryBrokerClerks> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SqlExpressMemoryBrokerClerks> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SqlExpressMemoryBrokerClerks> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_MSSQLSQLEXPRESS_MSSQLSQLEXPRESSMemoryBrokerClerks");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SqlExpressMemoryBrokerClerks
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Internalbenefit = (ulong) (managementObject.Properties["Internalbenefit"]?.Value ?? default(ulong)),
		 Memorybrokerclerksize = (ulong) (managementObject.Properties["Memorybrokerclerksize"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 Periodicevictionspages = (ulong) (managementObject.Properties["Periodicevictionspages"]?.Value ?? default(ulong)),
		 PressureevictionspagesPersec = (ulong) (managementObject.Properties["PressureevictionspagesPersec"]?.Value ?? default(ulong)),
		 Simulationbenefit = (ulong) (managementObject.Properties["Simulationbenefit"]?.Value ?? default(ulong)),
		 Simulationsize = (ulong) (managementObject.Properties["Simulationsize"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}