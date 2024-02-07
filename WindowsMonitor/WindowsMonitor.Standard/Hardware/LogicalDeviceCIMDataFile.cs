using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware
{
    /// <summary>
    /// </summary>
    public sealed class LogicalDeviceCimDataFile
    {
		public string Antecedent { get; private set; }
		public string Dependent { get; private set; }
		public ushort Purpose { get; private set; }
		public string PurposeDescription { get; private set; }

        public static IEnumerable<LogicalDeviceCimDataFile> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<LogicalDeviceCimDataFile> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<LogicalDeviceCimDataFile> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_CIMLogicalDeviceCIMDataFile");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new LogicalDeviceCimDataFile
                {
                     Antecedent =  (managementObject.Properties["Antecedent"]?.Value?.ToString()),
		 Dependent =  (managementObject.Properties["Dependent"]?.Value?.ToString()),
		 Purpose = (ushort) (managementObject.Properties["Purpose"]?.Value ?? default(ushort)),
		 PurposeDescription = (string) (managementObject.Properties["PurposeDescription"]?.Value)
                };
        }
    }
}