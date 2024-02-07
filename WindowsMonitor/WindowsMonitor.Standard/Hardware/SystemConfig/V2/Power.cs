using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.SystemConfig.V2
{
    /// <summary>
    /// </summary>
    public sealed class Power
    {
		public uint Flags { get; private set; }
		public byte Pad1 { get; private set; }
		public byte Pad2 { get; private set; }
		public byte Pad3 { get; private set; }
		public byte S1 { get; private set; }
		public byte S2 { get; private set; }
		public byte S3 { get; private set; }
		public byte S4 { get; private set; }
		public byte S5 { get; private set; }

        public static IEnumerable<Power> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<Power> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<Power> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM SystemConfig_V2_Power");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new Power
                {
                     Flags = (uint) (managementObject.Properties["Flags"]?.Value ?? default(uint)),
		 Pad1 = (byte) (managementObject.Properties["Pad1"]?.Value ?? default(byte)),
		 Pad2 = (byte) (managementObject.Properties["Pad2"]?.Value ?? default(byte)),
		 Pad3 = (byte) (managementObject.Properties["Pad3"]?.Value ?? default(byte)),
		 S1 = (byte) (managementObject.Properties["S1"]?.Value ?? default(byte)),
		 S2 = (byte) (managementObject.Properties["S2"]?.Value ?? default(byte)),
		 S3 = (byte) (managementObject.Properties["S3"]?.Value ?? default(byte)),
		 S4 = (byte) (managementObject.Properties["S4"]?.Value ?? default(byte)),
		 S5 = (byte) (managementObject.Properties["S5"]?.Value ?? default(byte))
                };
        }
    }
}