using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.ISCSI
{
    /// <summary>
    /// </summary>
    public sealed class IscsiEventlog
    {
		public bool Active { get; private set; }
		public byte[] AdditionalData { get; private set; }
		public string InstanceName { get; private set; }
		public uint LogToEventlog { get; private set; }
		public byte[] SecurityDescriptor { get; private set; }
		public uint Size { get; private set; }
		public ulong TimeCreated { get; private set; }
		public uint Type { get; private set; }

        public static IEnumerable<IscsiEventlog> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<IscsiEventlog> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<IscsiEventlog> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSiSCSI_Eventlog");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new IscsiEventlog
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 AdditionalData = (byte[]) (managementObject.Properties["AdditionalData"]?.Value ?? new byte[0]),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 LogToEventlog = (uint) (managementObject.Properties["LogToEventlog"]?.Value ?? default(uint)),
		 SecurityDescriptor = (byte[]) (managementObject.Properties["SECURITY_DESCRIPTOR"]?.Value ?? new byte[0]),
		 Size = (uint) (managementObject.Properties["Size"]?.Value ?? default(uint)),
		 TimeCreated = (ulong) (managementObject.Properties["TIME_CREATED"]?.Value ?? default(ulong)),
		 Type = (uint) (managementObject.Properties["Type"]?.Value ?? default(uint))
                };
        }
    }
}