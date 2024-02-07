using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Drives.TapeDrives
{
    /// <summary>
    /// </summary>
    public sealed class TapeSymbolicName
    {
		public bool Active { get; private set; }
		public string InstanceName { get; private set; }
		public string SymbolicName { get; private set; }

        public static IEnumerable<TapeSymbolicName> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<TapeSymbolicName> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<TapeSymbolicName> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSTapeSymbolicName");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new TapeSymbolicName
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 SymbolicName = (string) (managementObject.Properties["TapeSymbolicName"]?.Value ?? default(string))
                };
        }
    }
}