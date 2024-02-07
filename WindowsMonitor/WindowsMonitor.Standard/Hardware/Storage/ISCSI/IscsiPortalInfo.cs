using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.ISCSI
{
    /// <summary>
    /// </summary>
    public sealed class IscsiPortalInfo
    {
		public uint Index { get; private set; }
		public dynamic IpAddr { get; private set; }
		public uint Port { get; private set; }
		public ushort PortalTag { get; private set; }
		public byte PortalType { get; private set; }
		public byte Protocol { get; private set; }
		public byte Reserved1 { get; private set; }
		public byte Reserved2 { get; private set; }

        public static IEnumerable<IscsiPortalInfo> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<IscsiPortalInfo> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<IscsiPortalInfo> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM ISCSI_PortalInfo");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new IscsiPortalInfo
                {
                     Index = (uint) (managementObject.Properties["Index"]?.Value ?? default(uint)),
		 IpAddr = (dynamic) (managementObject.Properties["IPAddr"]?.Value ?? default(dynamic)),
		 Port = (uint) (managementObject.Properties["Port"]?.Value ?? default(uint)),
		 PortalTag = (ushort) (managementObject.Properties["PortalTag"]?.Value ?? default(ushort)),
		 PortalType = (byte) (managementObject.Properties["PortalType"]?.Value ?? default(byte)),
		 Protocol = (byte) (managementObject.Properties["Protocol"]?.Value ?? default(byte)),
		 Reserved1 = (byte) (managementObject.Properties["Reserved1"]?.Value ?? default(byte)),
		 Reserved2 = (byte) (managementObject.Properties["Reserved2"]?.Value ?? default(byte))
                };
        }
    }
}