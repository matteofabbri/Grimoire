using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Users.Nt
{
    /// <summary>
    /// </summary>
    public sealed class NtLogEvent
    {
		public ushort Category { get; private set; }
		public string CategoryString { get; private set; }
		public string ComputerName { get; private set; }
		public byte[] Data { get; private set; }
		public ushort EventCode { get; private set; }
		public uint EventIdentifier { get; private set; }
		public byte EventType { get; private set; }
		public string[] InsertionStrings { get; private set; }
		public string Logfile { get; private set; }
		public string Message { get; private set; }
		public uint RecordNumber { get; private set; }
		public string SourceName { get; private set; }
		public DateTime TimeGenerated { get; private set; }
		public DateTime TimeWritten { get; private set; }
		public string Type { get; private set; }
		public string User { get; private set; }

        public static IEnumerable<NtLogEvent> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<NtLogEvent> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<NtLogEvent> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_NTLogEvent");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new NtLogEvent
                {
                     Category = (ushort) (managementObject.Properties["Category"]?.Value ?? default(ushort)),
		 CategoryString = (string) (managementObject.Properties["CategoryString"]?.Value),
		 ComputerName = (string) (managementObject.Properties["ComputerName"]?.Value),
		 Data = (byte[]) (managementObject.Properties["Data"]?.Value ?? new byte[0]),
		 EventCode = (ushort) (managementObject.Properties["EventCode"]?.Value ?? default(ushort)),
		 EventIdentifier = (uint) (managementObject.Properties["EventIdentifier"]?.Value ?? default(uint)),
		 EventType = (byte) (managementObject.Properties["EventType"]?.Value ?? default(byte)),
		 InsertionStrings = (string[]) (managementObject.Properties["InsertionStrings"]?.Value ?? new string[0]),
		 Logfile = (string) (managementObject.Properties["Logfile"]?.Value),
		 Message = (string) (managementObject.Properties["Message"]?.Value),
		 RecordNumber = (uint) (managementObject.Properties["RecordNumber"]?.Value ?? default(uint)),
		 SourceName = (string) (managementObject.Properties["SourceName"]?.Value),
		 TimeGenerated = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["TimeGenerated"]?.Value as string ?? "00010102000000.000000+060"),
		 TimeWritten = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["TimeWritten"]?.Value as string ?? "00010102000000.000000+060"),
		 Type = (string) (managementObject.Properties["Type"]?.Value),
		 User = (string) (managementObject.Properties["User"]?.Value)
                };
        }
    }
}