using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.Xtp
{
    /// <summary>
    /// </summary>
    public sealed class XtpDatabaseEngineXtpTransactions
    {
		public string Caption { get; private set; }
		public uint CascadingabortsPersec { get; private set; }
		public uint CommitdependenciestakenPersec { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public uint ReadonlytransactionspreparedPersec { get; private set; }
		public uint SavepointrefreshesPersec { get; private set; }
		public uint SavepointrollbacksPersec { get; private set; }
		public uint SavepointscreatedPersec { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public uint TransactionsabortedbyuserPersec { get; private set; }
		public uint TransactionsabortedPersec { get; private set; }
		public uint TransactionscreatedPersec { get; private set; }
		public uint TransactionvalidationfailuresPersec { get; private set; }

        public static IEnumerable<XtpDatabaseEngineXtpTransactions> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<XtpDatabaseEngineXtpTransactions> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<XtpDatabaseEngineXtpTransactions> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_XTPDatabaseEngine_XTPTransactions");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new XtpDatabaseEngineXtpTransactions
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CascadingabortsPersec = (uint) (managementObject.Properties["CascadingabortsPersec"]?.Value ?? default(uint)),
		 CommitdependenciestakenPersec = (uint) (managementObject.Properties["CommitdependenciestakenPersec"]?.Value ?? default(uint)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 ReadonlytransactionspreparedPersec = (uint) (managementObject.Properties["ReadonlytransactionspreparedPersec"]?.Value ?? default(uint)),
		 SavepointrefreshesPersec = (uint) (managementObject.Properties["SavepointrefreshesPersec"]?.Value ?? default(uint)),
		 SavepointrollbacksPersec = (uint) (managementObject.Properties["SavepointrollbacksPersec"]?.Value ?? default(uint)),
		 SavepointscreatedPersec = (uint) (managementObject.Properties["SavepointscreatedPersec"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 TransactionsabortedbyuserPersec = (uint) (managementObject.Properties["TransactionsabortedbyuserPersec"]?.Value ?? default(uint)),
		 TransactionsabortedPersec = (uint) (managementObject.Properties["TransactionsabortedPersec"]?.Value ?? default(uint)),
		 TransactionscreatedPersec = (uint) (managementObject.Properties["TransactionscreatedPersec"]?.Value ?? default(uint)),
		 TransactionvalidationfailuresPersec = (uint) (managementObject.Properties["TransactionvalidationfailuresPersec"]?.Value ?? default(uint))
                };
        }
    }
}