using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Audio.HdAudio
{
    /// <summary>
    /// </summary>
    public sealed class HdAudioDmaEngineErrorStatus
    {
		public uint DescriptorError { get; private set; }
		public uint FifoError { get; private set; }

        public static IEnumerable<HdAudioDmaEngineErrorStatus> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HdAudioDmaEngineErrorStatus> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HdAudioDmaEngineErrorStatus> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HDAudioDmaEngineErrorStatus");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HdAudioDmaEngineErrorStatus
                {
                     DescriptorError = (uint) (managementObject.Properties["DescriptorError"]?.Value ?? default(uint)),
		 FifoError = (uint) (managementObject.Properties["FifoError"]?.Value ?? default(uint))
                };
        }
    }
}