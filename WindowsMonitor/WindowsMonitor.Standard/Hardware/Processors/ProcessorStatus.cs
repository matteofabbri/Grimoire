using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Processors
{
    /// <summary>
    /// </summary>
    public sealed class ProcessorStatus
    {
		public bool Active { get; private set; }
		public uint CurrentPerfState { get; private set; }
		public string InstanceName { get; private set; }
		public uint LastRequestedThrottle { get; private set; }
		public uint LastTransitionResult { get; private set; }
		public uint LowestPerfState { get; private set; }
		public dynamic PerfStates { get; private set; }
		public uint ThrottleValue { get; private set; }
		public uint UsingLegacyInterface { get; private set; }

        public static IEnumerable<ProcessorStatus> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ProcessorStatus> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ProcessorStatus> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM ProcessorStatus");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ProcessorStatus
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 CurrentPerfState = (uint) (managementObject.Properties["CurrentPerfState"]?.Value ?? default(uint)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 LastRequestedThrottle = (uint) (managementObject.Properties["LastRequestedThrottle"]?.Value ?? default(uint)),
		 LastTransitionResult = (uint) (managementObject.Properties["LastTransitionResult"]?.Value ?? default(uint)),
		 LowestPerfState = (uint) (managementObject.Properties["LowestPerfState"]?.Value ?? default(uint)),
		 PerfStates = (dynamic) (managementObject.Properties["PerfStates"]?.Value ?? default(dynamic)),
		 ThrottleValue = (uint) (managementObject.Properties["ThrottleValue"]?.Value ?? default(uint)),
		 UsingLegacyInterface = (uint) (managementObject.Properties["UsingLegacyInterface"]?.Value ?? default(uint))
                };
        }
    }
}