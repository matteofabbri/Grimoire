using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted.SqlExpress
{
    /// <summary>
    /// </summary>
    public sealed class SqlExpressGeneralStatistics
    {
		public ulong ActiveTempTables { get; private set; }
		public string Caption { get; private set; }
		public ulong ConnectionResetPersec { get; private set; }
		public string Description { get; private set; }
		public ulong EventNotificationsDelayedDrop { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public ulong HttpAuthenticatedRequests { get; private set; }
		public ulong LogicalConnections { get; private set; }
		public ulong LoginsPersec { get; private set; }
		public ulong LogoutsPersec { get; private set; }
		public ulong MarsDeadlocks { get; private set; }
		public string Name { get; private set; }
		public ulong Nonatomicyieldrate { get; private set; }
		public ulong Processesblocked { get; private set; }
		public ulong SoapEmptyRequests { get; private set; }
		public ulong SoapMethodInvocations { get; private set; }
		public ulong SoapSessionInitiateRequests { get; private set; }
		public ulong SoapSessionTerminateRequests { get; private set; }
		public ulong SoapsqlRequests { get; private set; }
		public ulong SoapwsdlRequests { get; private set; }
		public ulong SqlTraceIoProviderLockWaits { get; private set; }
		public ulong Tempdbrecoveryunitid { get; private set; }
		public ulong Tempdbrowsetid { get; private set; }
		public ulong TempTablesCreationRate { get; private set; }
		public ulong TempTablesForDestruction { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public ulong TraceEventNotificationQueue { get; private set; }
		public ulong Transactions { get; private set; }
		public ulong UserConnections { get; private set; }

        public static IEnumerable<SqlExpressGeneralStatistics> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SqlExpressGeneralStatistics> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SqlExpressGeneralStatistics> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_MSSQLSQLEXPRESS_MSSQLSQLEXPRESSGeneralStatistics");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SqlExpressGeneralStatistics
                {
                     ActiveTempTables = (ulong) (managementObject.Properties["ActiveTempTables"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 ConnectionResetPersec = (ulong) (managementObject.Properties["ConnectionResetPersec"]?.Value ?? default(ulong)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 EventNotificationsDelayedDrop = (ulong) (managementObject.Properties["EventNotificationsDelayedDrop"]?.Value ?? default(ulong)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 HttpAuthenticatedRequests = (ulong) (managementObject.Properties["HTTPAuthenticatedRequests"]?.Value ?? default(ulong)),
		 LogicalConnections = (ulong) (managementObject.Properties["LogicalConnections"]?.Value ?? default(ulong)),
		 LoginsPersec = (ulong) (managementObject.Properties["LoginsPersec"]?.Value ?? default(ulong)),
		 LogoutsPersec = (ulong) (managementObject.Properties["LogoutsPersec"]?.Value ?? default(ulong)),
		 MarsDeadlocks = (ulong) (managementObject.Properties["MarsDeadlocks"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 Nonatomicyieldrate = (ulong) (managementObject.Properties["Nonatomicyieldrate"]?.Value ?? default(ulong)),
		 Processesblocked = (ulong) (managementObject.Properties["Processesblocked"]?.Value ?? default(ulong)),
		 SoapEmptyRequests = (ulong) (managementObject.Properties["SOAPEmptyRequests"]?.Value ?? default(ulong)),
		 SoapMethodInvocations = (ulong) (managementObject.Properties["SOAPMethodInvocations"]?.Value ?? default(ulong)),
		 SoapSessionInitiateRequests = (ulong) (managementObject.Properties["SOAPSessionInitiateRequests"]?.Value ?? default(ulong)),
		 SoapSessionTerminateRequests = (ulong) (managementObject.Properties["SOAPSessionTerminateRequests"]?.Value ?? default(ulong)),
		 SoapsqlRequests = (ulong) (managementObject.Properties["SOAPSQLRequests"]?.Value ?? default(ulong)),
		 SoapwsdlRequests = (ulong) (managementObject.Properties["SOAPWSDLRequests"]?.Value ?? default(ulong)),
		 SqlTraceIoProviderLockWaits = (ulong) (managementObject.Properties["SQLTraceIOProviderLockWaits"]?.Value ?? default(ulong)),
		 Tempdbrecoveryunitid = (ulong) (managementObject.Properties["Tempdbrecoveryunitid"]?.Value ?? default(ulong)),
		 Tempdbrowsetid = (ulong) (managementObject.Properties["Tempdbrowsetid"]?.Value ?? default(ulong)),
		 TempTablesCreationRate = (ulong) (managementObject.Properties["TempTablesCreationRate"]?.Value ?? default(ulong)),
		 TempTablesForDestruction = (ulong) (managementObject.Properties["TempTablesForDestruction"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 TraceEventNotificationQueue = (ulong) (managementObject.Properties["TraceEventNotificationQueue"]?.Value ?? default(ulong)),
		 Transactions = (ulong) (managementObject.Properties["Transactions"]?.Value ?? default(ulong)),
		 UserConnections = (ulong) (managementObject.Properties["UserConnections"]?.Value ?? default(ulong))
                };
        }
    }
}