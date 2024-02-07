using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.HBA.Msfc
{
    /// <summary>
    /// </summary>
    public sealed class TargetEvent
    {
		public bool Active { get; private set; }
		public byte[] DiscoveredPortWwn { get; private set; }
		public uint EventType { get; private set; }
		public string InstanceName { get; private set; }
		public byte[] PortWwn { get; private set; }
		public byte[] SecurityDescriptor { get; private set; }
		public ulong TimeCreated { get; private set; }

        public static IEnumerable<TargetEvent> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<TargetEvent> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<TargetEvent> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSFC_TargetEvent");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new TargetEvent
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 DiscoveredPortWwn = (byte[]) (managementObject.Properties["DiscoveredPortWWN"]?.Value ?? new byte[0]),
		 EventType = (uint) (managementObject.Properties["EventType"]?.Value ?? default(uint)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 PortWwn = (byte[]) (managementObject.Properties["PortWWN"]?.Value ?? new byte[0]),
		 SecurityDescriptor = (byte[]) (managementObject.Properties["SECURITY_DESCRIPTOR"]?.Value ?? new byte[0]),
		 TimeCreated = (ulong) (managementObject.Properties["TIME_CREATED"]?.Value ?? default(ulong))
                };
        }
    }
}