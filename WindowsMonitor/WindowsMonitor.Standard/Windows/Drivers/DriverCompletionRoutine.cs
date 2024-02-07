using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Drivers
{
    /// <summary>
    /// </summary>
    public sealed class DriverCompletionRoutine
    {
		public uint Flags { get; private set; }
		public uint IrpPtr { get; private set; }
		public uint Routine { get; private set; }
		public uint UniqMatchId { get; private set; }

        public static IEnumerable<DriverCompletionRoutine> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<DriverCompletionRoutine> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<DriverCompletionRoutine> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM DriverCompletionRoutine");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new DriverCompletionRoutine
                {
                     Flags = (uint) (managementObject.Properties["Flags"]?.Value ?? default(uint)),
		 IrpPtr = (uint) (managementObject.Properties["IrpPtr"]?.Value ?? default(uint)),
		 Routine = (uint) (managementObject.Properties["Routine"]?.Value ?? default(uint)),
		 UniqMatchId = (uint) (managementObject.Properties["UniqMatchId"]?.Value ?? default(uint))
                };
        }
    }
}