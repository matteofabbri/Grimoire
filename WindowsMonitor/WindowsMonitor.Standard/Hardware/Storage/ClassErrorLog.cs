using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.MSStorageDriver
{
    /// <summary>
    /// </summary>
    public sealed class ClassErrorLog
    {
		public bool Active { get; private set; }
		public string InstanceName { get; private set; }
		public dynamic[] LogEntries { get; private set; }
		public uint NumEntries { get; private set; }

        public static IEnumerable<ClassErrorLog> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ClassErrorLog> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ClassErrorLog> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSStorageDriver_ClassErrorLog");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ClassErrorLog
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 LogEntries = (dynamic[]) (managementObject.Properties["logEntries"]?.Value ?? new dynamic[0]),
		 NumEntries = (uint) (managementObject.Properties["numEntries"]?.Value ?? default(uint))
                };
        }
    }
}