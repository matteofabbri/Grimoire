using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network
{
    /// <summary>
    /// </summary>
    public sealed class OutputInfo
    {
		public uint DataOffset { get; private set; }
		public uint Flags { get; private set; }
		public dynamic Header { get; private set; }
		public byte Padding1 { get; private set; }
		public ushort Padding2 { get; private set; }
		public byte SupportedRevision { get; private set; }

        public static IEnumerable<OutputInfo> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<OutputInfo> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<OutputInfo> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_WmiOutputInfo");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new OutputInfo
                {
                     DataOffset = (uint) (managementObject.Properties["DataOffset"]?.Value ?? default(uint)),
		 Flags = (uint) (managementObject.Properties["Flags"]?.Value ?? default(uint)),
		 Header = (dynamic) (managementObject.Properties["Header"]?.Value ?? default(dynamic)),
		 Padding1 = (byte) (managementObject.Properties["Padding1"]?.Value ?? default(byte)),
		 Padding2 = (ushort) (managementObject.Properties["Padding2"]?.Value ?? default(ushort)),
		 SupportedRevision = (byte) (managementObject.Properties["SupportedRevision"]?.Value ?? default(byte))
                };
        }
    }
}