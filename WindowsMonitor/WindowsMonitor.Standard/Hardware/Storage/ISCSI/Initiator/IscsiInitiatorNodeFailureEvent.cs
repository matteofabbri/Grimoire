using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.ISCSI.Initiator
{
    /// <summary>
    /// </summary>
    public sealed class IscsiInitiatorNodeFailureEvent
    {
		public bool Active { get; private set; }
		public ulong FailureTime { get; private set; }
		public byte FailureType { get; private set; }
		public string InstanceName { get; private set; }
		public byte[] SecurityDescriptor { get; private set; }
		public dynamic TargetFailureAddr { get; private set; }
		public string TargetFailureName { get; private set; }
		public ulong TimeCreated { get; private set; }

        public static IEnumerable<IscsiInitiatorNodeFailureEvent> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<IscsiInitiatorNodeFailureEvent> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<IscsiInitiatorNodeFailureEvent> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSiSCSI_InitiatorNodeFailureEvent");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new IscsiInitiatorNodeFailureEvent
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 FailureTime = (ulong) (managementObject.Properties["FailureTime"]?.Value ?? default(ulong)),
		 FailureType = (byte) (managementObject.Properties["FailureType"]?.Value ?? default(byte)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 SecurityDescriptor = (byte[]) (managementObject.Properties["SECURITY_DESCRIPTOR"]?.Value ?? new byte[0]),
		 TargetFailureAddr = (dynamic) (managementObject.Properties["TargetFailureAddr"]?.Value ?? default(dynamic)),
		 TargetFailureName = (string) (managementObject.Properties["TargetFailureName"]?.Value ?? default(string)),
		 TimeCreated = (ulong) (managementObject.Properties["TIME_CREATED"]?.Value ?? default(ulong))
                };
        }
    }
}