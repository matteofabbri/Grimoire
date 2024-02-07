using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network
{
    /// <summary>
    /// </summary>
    public sealed class ReceiveFilterFieldParameters
    {
		public byte[] FieldByteArrayValue { get; private set; }
		public uint Flags { get; private set; }
		public uint FrameHeader { get; private set; }
		public dynamic Header { get; private set; }
		public uint MacHeaderField { get; private set; }
		public uint ReceiveFilterTest { get; private set; }
		public byte[] ResultByteArrayValue { get; private set; }

        public static IEnumerable<ReceiveFilterFieldParameters> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ReceiveFilterFieldParameters> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ReceiveFilterFieldParameters> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_ReceiveFilterFieldParameters");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ReceiveFilterFieldParameters
                {
                     FieldByteArrayValue = (byte[]) (managementObject.Properties["FieldByteArrayValue"]?.Value ?? new byte[0]),
		 Flags = (uint) (managementObject.Properties["Flags"]?.Value ?? default(uint)),
		 FrameHeader = (uint) (managementObject.Properties["FrameHeader"]?.Value ?? default(uint)),
		 Header = (dynamic) (managementObject.Properties["Header"]?.Value ?? default(dynamic)),
		 MacHeaderField = (uint) (managementObject.Properties["MacHeaderField"]?.Value ?? default(uint)),
		 ReceiveFilterTest = (uint) (managementObject.Properties["ReceiveFilterTest"]?.Value ?? default(uint)),
		 ResultByteArrayValue = (byte[]) (managementObject.Properties["ResultByteArrayValue"]?.Value ?? new byte[0])
                };
        }
    }
}