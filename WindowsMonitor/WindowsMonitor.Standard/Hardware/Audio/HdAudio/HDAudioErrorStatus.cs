using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Audio.HdAudio
{
    /// <summary>
    /// </summary>
    public sealed class HdAudioErrorStatus
    {
		public bool Active { get; private set; }
		public dynamic ControllerErrorStatus { get; private set; }
		public dynamic[] EngineErrorStatus { get; private set; }
		public string InstanceName { get; private set; }
		public uint NumEngines { get; private set; }

        public static IEnumerable<HdAudioErrorStatus> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HdAudioErrorStatus> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HdAudioErrorStatus> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HDAudioErrorStatus");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HdAudioErrorStatus
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 ControllerErrorStatus = (dynamic) (managementObject.Properties["ControllerErrorStatus"]?.Value ?? default(dynamic)),
		 EngineErrorStatus = (dynamic[]) (managementObject.Properties["EngineErrorStatus"]?.Value ?? new dynamic[0]),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 NumEngines = (uint) (managementObject.Properties["NumEngines"]?.Value ?? default(uint))
                };
        }
    }
}