using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Drivers
{
    /// <summary>
    /// </summary>
    public sealed class DriverMajorFunctionReturn
    {
		public uint Flags { get; private set; }
		public uint Irp { get; private set; }
		public uint UniqMatchId { get; private set; }

        public static IEnumerable<DriverMajorFunctionReturn> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<DriverMajorFunctionReturn> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<DriverMajorFunctionReturn> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM DriverMajorFunctionReturn");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new DriverMajorFunctionReturn
                {
                     Flags = (uint) (managementObject.Properties["Flags"]?.Value ?? default(uint)),
		 Irp = (uint) (managementObject.Properties["Irp"]?.Value ?? default(uint)),
		 UniqMatchId = (uint) (managementObject.Properties["UniqMatchId"]?.Value ?? default(uint))
                };
        }
    }
}