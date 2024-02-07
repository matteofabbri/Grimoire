using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Drives.TapeDrives
{
    /// <summary>
    /// </summary>
    public sealed class TapeProblemIoError
    {
		public bool Active { get; private set; }
		public string InstanceName { get; private set; }
		public uint NonMediumErrors { get; private set; }
		public uint ReadCorrectedWithDelay { get; private set; }
		public uint ReadCorrectedWithoutDelay { get; private set; }
		public uint ReadCorrectionAlgorithmProcessed { get; private set; }
		public uint ReadTotalCorrectedErrors { get; private set; }
		public uint ReadTotalErrors { get; private set; }
		public uint ReadTotalUncorrectedErrors { get; private set; }
		public uint WriteCorrectedWithDelay { get; private set; }
		public uint WriteCorrectedWithoutDelay { get; private set; }
		public uint WriteCorrectionAlgorithmProcessed { get; private set; }
		public uint WriteTotalCorrectedErrors { get; private set; }
		public uint WriteTotalErrors { get; private set; }
		public uint WriteTotalUncorrectedErrors { get; private set; }

        public static IEnumerable<TapeProblemIoError> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<TapeProblemIoError> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<TapeProblemIoError> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSTapeProblemIoError");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new TapeProblemIoError
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 NonMediumErrors = (uint) (managementObject.Properties["NonMediumErrors"]?.Value ?? default(uint)),
		 ReadCorrectedWithDelay = (uint) (managementObject.Properties["ReadCorrectedWithDelay"]?.Value ?? default(uint)),
		 ReadCorrectedWithoutDelay = (uint) (managementObject.Properties["ReadCorrectedWithoutDelay"]?.Value ?? default(uint)),
		 ReadCorrectionAlgorithmProcessed = (uint) (managementObject.Properties["ReadCorrectionAlgorithmProcessed"]?.Value ?? default(uint)),
		 ReadTotalCorrectedErrors = (uint) (managementObject.Properties["ReadTotalCorrectedErrors"]?.Value ?? default(uint)),
		 ReadTotalErrors = (uint) (managementObject.Properties["ReadTotalErrors"]?.Value ?? default(uint)),
		 ReadTotalUncorrectedErrors = (uint) (managementObject.Properties["ReadTotalUncorrectedErrors"]?.Value ?? default(uint)),
		 WriteCorrectedWithDelay = (uint) (managementObject.Properties["WriteCorrectedWithDelay"]?.Value ?? default(uint)),
		 WriteCorrectedWithoutDelay = (uint) (managementObject.Properties["WriteCorrectedWithoutDelay"]?.Value ?? default(uint)),
		 WriteCorrectionAlgorithmProcessed = (uint) (managementObject.Properties["WriteCorrectionAlgorithmProcessed"]?.Value ?? default(uint)),
		 WriteTotalCorrectedErrors = (uint) (managementObject.Properties["WriteTotalCorrectedErrors"]?.Value ?? default(uint)),
		 WriteTotalErrors = (uint) (managementObject.Properties["WriteTotalErrors"]?.Value ?? default(uint)),
		 WriteTotalUncorrectedErrors = (uint) (managementObject.Properties["WriteTotalUncorrectedErrors"]?.Value ?? default(uint))
                };
        }
    }
}