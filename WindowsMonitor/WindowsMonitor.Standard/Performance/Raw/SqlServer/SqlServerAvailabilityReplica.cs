using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.SqlServer
{
    /// <summary>
    /// </summary>
    public sealed class SqlServerAvailabilityReplica
    {
		public ulong BytesReceivedfromReplicaPersec { get; private set; }
		public ulong BytesSenttoReplicaPersec { get; private set; }
		public ulong BytesSenttoTransportPersec { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong FlowControlPersec { get; private set; }
		public ulong FlowControlTimemsPersec { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public ulong ReceivesfromReplicaPersec { get; private set; }
		public ulong ResentMessagesPersec { get; private set; }
		public ulong SendstoReplicaPersec { get; private set; }
		public ulong SendstoTransportPersec { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<SqlServerAvailabilityReplica> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SqlServerAvailabilityReplica> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SqlServerAvailabilityReplica> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_MSSQLSERVER_SQLServerAvailabilityReplica");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SqlServerAvailabilityReplica
                {
                     BytesReceivedfromReplicaPersec = (ulong) (managementObject.Properties["BytesReceivedfromReplicaPersec"]?.Value ?? default(ulong)),
		 BytesSenttoReplicaPersec = (ulong) (managementObject.Properties["BytesSenttoReplicaPersec"]?.Value ?? default(ulong)),
		 BytesSenttoTransportPersec = (ulong) (managementObject.Properties["BytesSenttoTransportPersec"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FlowControlPersec = (ulong) (managementObject.Properties["FlowControlPersec"]?.Value ?? default(ulong)),
		 FlowControlTimemsPersec = (ulong) (managementObject.Properties["FlowControlTimemsPersec"]?.Value ?? default(ulong)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 ReceivesfromReplicaPersec = (ulong) (managementObject.Properties["ReceivesfromReplicaPersec"]?.Value ?? default(ulong)),
		 ResentMessagesPersec = (ulong) (managementObject.Properties["ResentMessagesPersec"]?.Value ?? default(ulong)),
		 SendstoReplicaPersec = (ulong) (managementObject.Properties["SendstoReplicaPersec"]?.Value ?? default(ulong)),
		 SendstoTransportPersec = (ulong) (managementObject.Properties["SendstoTransportPersec"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}