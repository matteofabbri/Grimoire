using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.ISCSI
{
    /// <summary>
    /// </summary>
    public sealed class IscsiBootConfiguration
    {
		public bool Active { get; private set; }
		public bool DiscoverBootDevice { get; private set; }
		public string InitiatorNode { get; private set; }
		public string InstanceName { get; private set; }
		public dynamic LoginOptions { get; private set; }
		public ulong Lun { get; private set; }
		public byte[] Password { get; private set; }
		public uint PasswordSize { get; private set; }
		public ulong SecurityFlags { get; private set; }
		public string TargetName { get; private set; }
		public dynamic TargetPortal { get; private set; }
		public byte[] Username { get; private set; }
		public uint UsernameSize { get; private set; }

        public static IEnumerable<IscsiBootConfiguration> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<IscsiBootConfiguration> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<IscsiBootConfiguration> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSiSCSI_BootConfiguration");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new IscsiBootConfiguration
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 DiscoverBootDevice = (bool) (managementObject.Properties["DiscoverBootDevice"]?.Value ?? default(bool)),
		 InitiatorNode = (string) (managementObject.Properties["InitiatorNode"]?.Value ?? default(string)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 LoginOptions = (dynamic) (managementObject.Properties["LoginOptions"]?.Value ?? default(dynamic)),
		 Lun = (ulong) (managementObject.Properties["LUN"]?.Value ?? default(ulong)),
		 Password = (byte[]) (managementObject.Properties["Password"]?.Value ?? new byte[0]),
		 PasswordSize = (uint) (managementObject.Properties["PasswordSize"]?.Value ?? default(uint)),
		 SecurityFlags = (ulong) (managementObject.Properties["SecurityFlags"]?.Value ?? default(ulong)),
		 TargetName = (string) (managementObject.Properties["TargetName"]?.Value ?? default(string)),
		 TargetPortal = (dynamic) (managementObject.Properties["TargetPortal"]?.Value ?? default(dynamic)),
		 Username = (byte[]) (managementObject.Properties["Username"]?.Value ?? new byte[0]),
		 UsernameSize = (uint) (managementObject.Properties["UsernameSize"]?.Value ?? default(uint))
                };
        }
    }
}