using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.HBA.Msfc
{
    /// <summary>
    /// </summary>
    public sealed class LinkEvent
    {
		public bool Active { get; private set; }
		public byte[] AdapterWwn { get; private set; }
		public uint EventType { get; private set; }
		public string InstanceName { get; private set; }
		public byte[] RlirBuffer { get; private set; }
		public uint RlirBufferSize { get; private set; }
		public byte[] SecurityDescriptor { get; private set; }
		public ulong TimeCreated { get; private set; }

        public static IEnumerable<LinkEvent> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<LinkEvent> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<LinkEvent> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSFC_LinkEvent");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new LinkEvent
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 AdapterWwn = (byte[]) (managementObject.Properties["AdapterWWN"]?.Value ?? new byte[0]),
		 EventType = (uint) (managementObject.Properties["EventType"]?.Value ?? default(uint)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 RlirBuffer = (byte[]) (managementObject.Properties["RLIRBuffer"]?.Value ?? new byte[0]),
		 RlirBufferSize = (uint) (managementObject.Properties["RLIRBufferSize"]?.Value ?? default(uint)),
		 SecurityDescriptor = (byte[]) (managementObject.Properties["SECURITY_DESCRIPTOR"]?.Value ?? new byte[0]),
		 TimeCreated = (ulong) (managementObject.Properties["TIME_CREATED"]?.Value ?? default(ulong))
                };
        }
    }
}