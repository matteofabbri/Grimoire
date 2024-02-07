using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Kernel
{
    /// <summary>
    /// </summary>
    public sealed class KernelIdleStates
    {
		public bool Active { get; private set; }
		public uint Count { get; private set; }
		public string InstanceName { get; private set; }
		public uint OldState { get; private set; }
		public dynamic[] State { get; private set; }
		public ulong TargetProcessors { get; private set; }
		public uint TargetState { get; private set; }
		public uint Type { get; private set; }

        public static IEnumerable<KernelIdleStates> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<KernelIdleStates> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<KernelIdleStates> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM KernelIdleStates");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new KernelIdleStates
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 Count = (uint) (managementObject.Properties["Count"]?.Value ?? default(uint)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 OldState = (uint) (managementObject.Properties["OldState"]?.Value ?? default(uint)),
		 State = (dynamic[]) (managementObject.Properties["State"]?.Value ?? new dynamic[0]),
		 TargetProcessors = (ulong) (managementObject.Properties["TargetProcessors"]?.Value ?? default(ulong)),
		 TargetState = (uint) (managementObject.Properties["TargetState"]?.Value ?? default(uint)),
		 Type = (uint) (managementObject.Properties["Type"]?.Value ?? default(uint))
                };
        }
    }
}