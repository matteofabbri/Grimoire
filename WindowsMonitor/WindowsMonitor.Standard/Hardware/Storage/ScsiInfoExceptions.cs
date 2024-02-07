using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.MSStorageDriver
{
    /// <summary>
    /// </summary>
    public sealed class ScsiInfoExceptions
    {
		public bool Active { get; private set; }
		public byte Flags { get; private set; }
		public string InstanceName { get; private set; }
		public uint IntervalTimer { get; private set; }
		public byte Mrie { get; private set; }
		public byte Padding { get; private set; }
		public bool PageSavable { get; private set; }
		public uint ReportCount { get; private set; }

        public static IEnumerable<ScsiInfoExceptions> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ScsiInfoExceptions> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ScsiInfoExceptions> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSStorageDriver_ScsiInfoExceptions");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ScsiInfoExceptions
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 Flags = (byte) (managementObject.Properties["Flags"]?.Value ?? default(byte)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 IntervalTimer = (uint) (managementObject.Properties["IntervalTimer"]?.Value ?? default(uint)),
		 Mrie = (byte) (managementObject.Properties["MRIE"]?.Value ?? default(byte)),
		 Padding = (byte) (managementObject.Properties["Padding"]?.Value ?? default(byte)),
		 PageSavable = (bool) (managementObject.Properties["PageSavable"]?.Value ?? default(bool)),
		 ReportCount = (uint) (managementObject.Properties["ReportCount"]?.Value ?? default(uint))
                };
        }
    }
}