using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.MSStorageDriver
{
    /// <summary>
    /// </summary>
    public sealed class ClassErrorLogEntry
    {
		public bool ErrorPaging { get; private set; }
		public byte ErrorReserved { get; private set; }
		public bool ErrorRetried { get; private set; }
		public bool ErrorUnhandled { get; private set; }
		public DateTime EventTime { get; private set; }
		public uint PortNumber { get; private set; }
		public byte[] Reserved { get; private set; }
		public dynamic SenseData { get; private set; }
		public dynamic Srb { get; private set; }
		public ulong TickCount { get; private set; }

        public static IEnumerable<ClassErrorLogEntry> Retrieve(string remote, string username, string password)
        {
            var options = new ConnectionOptions
            {
                Impersonation = ImpersonationLevel.Impersonate,
                Username = username,
                Password = password
            };

            var managementScope = new ManagementScope(new ManagementPath($"\\\\{remote}\\root\\wmi"), options);
            managementScope.Connect();

            return Retrieve(managementScope);
        }

        public static IEnumerable<ClassErrorLogEntry> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ClassErrorLogEntry> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSStorageDriver_ClassErrorLogEntry");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ClassErrorLogEntry
                {
                     ErrorPaging = (bool) (managementObject.Properties["errorPaging"]?.Value ?? default(bool)),
		 ErrorReserved = (byte) (managementObject.Properties["errorReserved"]?.Value ?? default(byte)),
		 ErrorRetried = (bool) (managementObject.Properties["errorRetried"]?.Value ?? default(bool)),
		 ErrorUnhandled = (bool) (managementObject.Properties["errorUnhandled"]?.Value ?? default(bool)),
		 EventTime = (DateTime) (managementObject.Properties["eventTime"]?.Value ?? default(DateTime)),
		 PortNumber = (uint) (managementObject.Properties["portNumber"]?.Value ?? default(uint)),
		 Reserved = (byte[]) (managementObject.Properties["reserved"]?.Value ?? new byte[0]),
		 SenseData = (dynamic) (managementObject.Properties["senseData"]?.Value ?? default(dynamic)),
		 Srb = (dynamic) (managementObject.Properties["srb"]?.Value ?? default(dynamic)),
		 TickCount = (ulong) (managementObject.Properties["tickCount"]?.Value ?? default(ulong))
                };
        }
    }
}