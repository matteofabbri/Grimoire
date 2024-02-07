using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Drivers
{
    /// <summary>
    /// </summary>
    public sealed class DriverMajorFunctionCall
    {
		public uint FileObject { get; private set; }
		public uint Flags { get; private set; }
		public uint Irp { get; private set; }
		public uint MajorFunction { get; private set; }
		public uint MinorFunction { get; private set; }
		public uint RoutineAddr { get; private set; }
		public uint UniqMatchId { get; private set; }

        public static IEnumerable<DriverMajorFunctionCall> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<DriverMajorFunctionCall> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<DriverMajorFunctionCall> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM DriverMajorFunctionCall");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new DriverMajorFunctionCall
                {
                     FileObject = (uint) (managementObject.Properties["FileObject"]?.Value ?? default(uint)),
		 Flags = (uint) (managementObject.Properties["Flags"]?.Value ?? default(uint)),
		 Irp = (uint) (managementObject.Properties["Irp"]?.Value ?? default(uint)),
		 MajorFunction = (uint) (managementObject.Properties["MajorFunction"]?.Value ?? default(uint)),
		 MinorFunction = (uint) (managementObject.Properties["MinorFunction"]?.Value ?? default(uint)),
		 RoutineAddr = (uint) (managementObject.Properties["RoutineAddr"]?.Value ?? default(uint)),
		 UniqMatchId = (uint) (managementObject.Properties["UniqMatchId"]?.Value ?? default(uint))
                };
        }
    }
}