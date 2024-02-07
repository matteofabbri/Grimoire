using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network
{
    /// <summary>
    /// </summary>
    public sealed class EnumAdapter
    {
		public string DeviceName { get; private set; }
		public dynamic Header { get; private set; }
		public uint IfIndex { get; private set; }
		public ulong NetLuid { get; private set; }

        public static IEnumerable<EnumAdapter> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<EnumAdapter> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<EnumAdapter> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_WmiEnumAdapter");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new EnumAdapter
                {
                     DeviceName = (string) (managementObject.Properties["DeviceName"]?.Value ?? default(string)),
		 Header = (dynamic) (managementObject.Properties["Header"]?.Value ?? default(dynamic)),
		 IfIndex = (uint) (managementObject.Properties["IfIndex"]?.Value ?? default(uint)),
		 NetLuid = (ulong) (managementObject.Properties["NetLuid"]?.Value ?? default(ulong))
                };
        }
    }
}