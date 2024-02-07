using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.SqlExpress
{
    /// <summary>
    /// </summary>
    public sealed class SqlExpressBrokerStatistics
    {
		public ulong ActivationErrorsTotal { get; private set; }
		public ulong BrokerTransactionRollbacks { get; private set; }
		public string Caption { get; private set; }
		public ulong CorruptedMessagesTotal { get; private set; }
		public ulong DequeuedTransmissionQMsgsPersec { get; private set; }
		public string Description { get; private set; }
		public ulong DialogTimerEventCount { get; private set; }
		public ulong DroppedMessagesTotal { get; private set; }
		public ulong EnqueuedLocalMessagesPersec { get; private set; }
		public ulong EnqueuedLocalMessagesTotal { get; private set; }
		public ulong EnqueuedMessagesPersec { get; private set; }
		public ulong EnqueuedMessagesTotal { get; private set; }
		public ulong EnqueuedP10MessagesPersec { get; private set; }
		public ulong EnqueuedP1MessagesPersec { get; private set; }
		public ulong EnqueuedP2MessagesPersec { get; private set; }
		public ulong EnqueuedP3MessagesPersec { get; private set; }
		public ulong EnqueuedP4MessagesPersec { get; private set; }
		public ulong EnqueuedP5MessagesPersec { get; private set; }
		public ulong EnqueuedP6MessagesPersec { get; private set; }
		public ulong EnqueuedP7MessagesPersec { get; private set; }
		public ulong EnqueuedP8MessagesPersec { get; private set; }
		public ulong EnqueuedP9MessagesPersec { get; private set; }
		public ulong EnqueuedTransmissionQMsgsPersec { get; private set; }
		public ulong EnqueuedTransportMsgFragsPersec { get; private set; }
		public ulong EnqueuedTransportMsgFragTot { get; private set; }
		public ulong EnqueuedTransportMsgsPersec { get; private set; }
		public ulong EnqueuedTransportMsgsTotal { get; private set; }
		public ulong ForwardedMessagesPersec { get; private set; }
		public ulong ForwardedMessagesTotal { get; private set; }
		public ulong ForwardedMsgBytesPersec { get; private set; }
		public ulong ForwardedMsgByteTotal { get; private set; }
		public ulong ForwardedMsgDiscardedTotal { get; private set; }
		public ulong ForwardedMsgsDiscardedPersec { get; private set; }
		public ulong ForwardedPendingMsgBytes { get; private set; }
		public ulong ForwardedPendingMsgCount { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public ulong SqlreceivEsPersec { get; private set; }
		public ulong SqlreceiveTotal { get; private set; }
		public ulong SqlsenDsPersec { get; private set; }
		public ulong SqlsendTotal { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<SqlExpressBrokerStatistics> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SqlExpressBrokerStatistics> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SqlExpressBrokerStatistics> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_MSSQLSQLEXPRESS_MSSQLSQLEXPRESSBrokerStatistics");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SqlExpressBrokerStatistics
                {
                     ActivationErrorsTotal = (ulong) (managementObject.Properties["ActivationErrorsTotal"]?.Value ?? default(ulong)),
		 BrokerTransactionRollbacks = (ulong) (managementObject.Properties["BrokerTransactionRollbacks"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CorruptedMessagesTotal = (ulong) (managementObject.Properties["CorruptedMessagesTotal"]?.Value ?? default(ulong)),
		 DequeuedTransmissionQMsgsPersec = (ulong) (managementObject.Properties["DequeuedTransmissionQMsgsPersec"]?.Value ?? default(ulong)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DialogTimerEventCount = (ulong) (managementObject.Properties["DialogTimerEventCount"]?.Value ?? default(ulong)),
		 DroppedMessagesTotal = (ulong) (managementObject.Properties["DroppedMessagesTotal"]?.Value ?? default(ulong)),
		 EnqueuedLocalMessagesPersec = (ulong) (managementObject.Properties["EnqueuedLocalMessagesPersec"]?.Value ?? default(ulong)),
		 EnqueuedLocalMessagesTotal = (ulong) (managementObject.Properties["EnqueuedLocalMessagesTotal"]?.Value ?? default(ulong)),
		 EnqueuedMessagesPersec = (ulong) (managementObject.Properties["EnqueuedMessagesPersec"]?.Value ?? default(ulong)),
		 EnqueuedMessagesTotal = (ulong) (managementObject.Properties["EnqueuedMessagesTotal"]?.Value ?? default(ulong)),
		 EnqueuedP10MessagesPersec = (ulong) (managementObject.Properties["EnqueuedP10MessagesPersec"]?.Value ?? default(ulong)),
		 EnqueuedP1MessagesPersec = (ulong) (managementObject.Properties["EnqueuedP1MessagesPersec"]?.Value ?? default(ulong)),
		 EnqueuedP2MessagesPersec = (ulong) (managementObject.Properties["EnqueuedP2MessagesPersec"]?.Value ?? default(ulong)),
		 EnqueuedP3MessagesPersec = (ulong) (managementObject.Properties["EnqueuedP3MessagesPersec"]?.Value ?? default(ulong)),
		 EnqueuedP4MessagesPersec = (ulong) (managementObject.Properties["EnqueuedP4MessagesPersec"]?.Value ?? default(ulong)),
		 EnqueuedP5MessagesPersec = (ulong) (managementObject.Properties["EnqueuedP5MessagesPersec"]?.Value ?? default(ulong)),
		 EnqueuedP6MessagesPersec = (ulong) (managementObject.Properties["EnqueuedP6MessagesPersec"]?.Value ?? default(ulong)),
		 EnqueuedP7MessagesPersec = (ulong) (managementObject.Properties["EnqueuedP7MessagesPersec"]?.Value ?? default(ulong)),
		 EnqueuedP8MessagesPersec = (ulong) (managementObject.Properties["EnqueuedP8MessagesPersec"]?.Value ?? default(ulong)),
		 EnqueuedP9MessagesPersec = (ulong) (managementObject.Properties["EnqueuedP9MessagesPersec"]?.Value ?? default(ulong)),
		 EnqueuedTransmissionQMsgsPersec = (ulong) (managementObject.Properties["EnqueuedTransmissionQMsgsPersec"]?.Value ?? default(ulong)),
		 EnqueuedTransportMsgFragsPersec = (ulong) (managementObject.Properties["EnqueuedTransportMsgFragsPersec"]?.Value ?? default(ulong)),
		 EnqueuedTransportMsgFragTot = (ulong) (managementObject.Properties["EnqueuedTransportMsgFragTot"]?.Value ?? default(ulong)),
		 EnqueuedTransportMsgsPersec = (ulong) (managementObject.Properties["EnqueuedTransportMsgsPersec"]?.Value ?? default(ulong)),
		 EnqueuedTransportMsgsTotal = (ulong) (managementObject.Properties["EnqueuedTransportMsgsTotal"]?.Value ?? default(ulong)),
		 ForwardedMessagesPersec = (ulong) (managementObject.Properties["ForwardedMessagesPersec"]?.Value ?? default(ulong)),
		 ForwardedMessagesTotal = (ulong) (managementObject.Properties["ForwardedMessagesTotal"]?.Value ?? default(ulong)),
		 ForwardedMsgBytesPersec = (ulong) (managementObject.Properties["ForwardedMsgBytesPersec"]?.Value ?? default(ulong)),
		 ForwardedMsgByteTotal = (ulong) (managementObject.Properties["ForwardedMsgByteTotal"]?.Value ?? default(ulong)),
		 ForwardedMsgDiscardedTotal = (ulong) (managementObject.Properties["ForwardedMsgDiscardedTotal"]?.Value ?? default(ulong)),
		 ForwardedMsgsDiscardedPersec = (ulong) (managementObject.Properties["ForwardedMsgsDiscardedPersec"]?.Value ?? default(ulong)),
		 ForwardedPendingMsgBytes = (ulong) (managementObject.Properties["ForwardedPendingMsgBytes"]?.Value ?? default(ulong)),
		 ForwardedPendingMsgCount = (ulong) (managementObject.Properties["ForwardedPendingMsgCount"]?.Value ?? default(ulong)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 SqlreceivEsPersec = (ulong) (managementObject.Properties["SQLRECEIVEsPersec"]?.Value ?? default(ulong)),
		 SqlreceiveTotal = (ulong) (managementObject.Properties["SQLRECEIVETotal"]?.Value ?? default(ulong)),
		 SqlsenDsPersec = (ulong) (managementObject.Properties["SQLSENDsPersec"]?.Value ?? default(ulong)),
		 SqlsendTotal = (ulong) (managementObject.Properties["SQLSENDTotal"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}