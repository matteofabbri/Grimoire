using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Audio.HdAudio
{
    /// <summary>
    /// </summary>
    public sealed class HdAudioControllerErrorStatus
    {
		public uint CorbMemoryError { get; private set; }
		public uint RirbFifoOverrun { get; private set; }

        public static IEnumerable<HdAudioControllerErrorStatus> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HdAudioControllerErrorStatus> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HdAudioControllerErrorStatus> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HDAudioControllerErrorStatus");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HdAudioControllerErrorStatus
                {
                     CorbMemoryError = (uint) (managementObject.Properties["CorbMemoryError"]?.Value ?? default(uint)),
		 RirbFifoOverrun = (uint) (managementObject.Properties["RirbFifoOverrun"]?.Value ?? default(uint))
                };
        }
    }
}