using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor
{
    /// <summary>
    /// </summary>
    public sealed class ReliabilityRecords
    {
		public string ComputerName { get; private set; }
		public uint EventIdentifier { get; private set; }
		public string[] InsertionStrings { get; private set; }
		public string Logfile { get; private set; }
		public string Message { get; private set; }
		public string ProductName { get; private set; }
		public uint RecordNumber { get; private set; }
		public string SourceName { get; private set; }
		public DateTime TimeGenerated { get; private set; }
		public string User { get; private set; }

        public static IEnumerable<ReliabilityRecords> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ReliabilityRecords> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ReliabilityRecords> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_ReliabilityRecords");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ReliabilityRecords
                {
                     ComputerName = (string) (managementObject.Properties["ComputerName"]?.Value),
		 EventIdentifier = (uint) (managementObject.Properties["EventIdentifier"]?.Value ?? default(uint)),
		 InsertionStrings = (string[]) (managementObject.Properties["InsertionStrings"]?.Value ?? new string[0]),
		 Logfile = (string) (managementObject.Properties["Logfile"]?.Value),
		 Message = (string) (managementObject.Properties["Message"]?.Value),
		 ProductName = (string) (managementObject.Properties["ProductName"]?.Value),
		 RecordNumber = (uint) (managementObject.Properties["RecordNumber"]?.Value ?? default(uint)),
		 SourceName = (string) (managementObject.Properties["SourceName"]?.Value),
		 TimeGenerated = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["TimeGenerated"]?.Value as string ?? "00010102000000.000000+060"),
		 User = (string) (managementObject.Properties["User"]?.Value)
                };
        }
    }
}