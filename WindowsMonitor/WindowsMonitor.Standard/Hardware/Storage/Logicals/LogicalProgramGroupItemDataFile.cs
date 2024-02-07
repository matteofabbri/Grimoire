using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.Logicals
{
    /// <summary>
    /// </summary>
    public sealed class LogicalProgramGroupItemDataFile
    {
		public string Antecedent { get; private set; }
		public string Dependent { get; private set; }

        public static IEnumerable<LogicalProgramGroupItemDataFile> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<LogicalProgramGroupItemDataFile> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<LogicalProgramGroupItemDataFile> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_LogicalProgramGroupItemDataFile");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new LogicalProgramGroupItemDataFile
                {
                     Antecedent =  (managementObject.Properties["Antecedent"]?.Value?.ToString()),
		 Dependent =  (managementObject.Properties["Dependent"]?.Value?.ToString())
                };
        }
    }
}