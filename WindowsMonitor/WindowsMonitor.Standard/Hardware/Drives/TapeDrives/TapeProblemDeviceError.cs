using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Drives.TapeDrives
{
    /// <summary>
    /// </summary>
    public sealed class TapeProblemDeviceError
    {
		public bool Active { get; private set; }
		public bool DriveHardwareError { get; private set; }
		public bool DriveRequiresCleaning { get; private set; }
		public bool HardError { get; private set; }
		public string InstanceName { get; private set; }
		public bool MediaLife { get; private set; }
		public bool ReadFailure { get; private set; }
		public bool ReadWarning { get; private set; }
		public bool ScsiInterfaceError { get; private set; }
		public bool TapeSnapped { get; private set; }
		public bool TimetoCleanDrive { get; private set; }
		public bool UnsupportedFormat { get; private set; }
		public bool WriteFailure { get; private set; }
		public bool WriteWarning { get; private set; }

        public static IEnumerable<TapeProblemDeviceError> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<TapeProblemDeviceError> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<TapeProblemDeviceError> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSTapeProblemDeviceError");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new TapeProblemDeviceError
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 DriveHardwareError = (bool) (managementObject.Properties["DriveHardwareError"]?.Value ?? default(bool)),
		 DriveRequiresCleaning = (bool) (managementObject.Properties["DriveRequiresCleaning"]?.Value ?? default(bool)),
		 HardError = (bool) (managementObject.Properties["HardError"]?.Value ?? default(bool)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 MediaLife = (bool) (managementObject.Properties["MediaLife"]?.Value ?? default(bool)),
		 ReadFailure = (bool) (managementObject.Properties["ReadFailure"]?.Value ?? default(bool)),
		 ReadWarning = (bool) (managementObject.Properties["ReadWarning"]?.Value ?? default(bool)),
		 ScsiInterfaceError = (bool) (managementObject.Properties["ScsiInterfaceError"]?.Value ?? default(bool)),
		 TapeSnapped = (bool) (managementObject.Properties["TapeSnapped"]?.Value ?? default(bool)),
		 TimetoCleanDrive = (bool) (managementObject.Properties["TimetoCleanDrive"]?.Value ?? default(bool)),
		 UnsupportedFormat = (bool) (managementObject.Properties["UnsupportedFormat"]?.Value ?? default(bool)),
		 WriteFailure = (bool) (managementObject.Properties["WriteFailure"]?.Value ?? default(bool)),
		 WriteWarning = (bool) (managementObject.Properties["WriteWarning"]?.Value ?? default(bool))
                };
        }
    }
}