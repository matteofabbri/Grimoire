using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.MSStorageDriver
{
    /// <summary>
    /// </summary>
    public sealed class AtapiSmartData
    {
		public bool Active { get; private set; }
		public byte Checksum { get; private set; }
		public byte ErrorLogCapability { get; private set; }
		public byte ExtendedPollTimeInMinutes { get; private set; }
		public string InstanceName { get; private set; }
		public uint Length { get; private set; }
		public byte OfflineCollectCapability { get; private set; }
		public byte OfflineCollectionStatus { get; private set; }
		public byte[] Reserved { get; private set; }
		public byte SelfTestStatus { get; private set; }
		public byte ShortPollTimeInMinutes { get; private set; }
		public ushort SmartCapability { get; private set; }
		public ushort TotalTime { get; private set; }
		public byte[] VendorSpecific { get; private set; }
		public byte VendorSpecific2 { get; private set; }
		public byte VendorSpecific3 { get; private set; }
		public byte[] VendorSpecific4 { get; private set; }

        public static IEnumerable<AtapiSmartData> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<AtapiSmartData> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<AtapiSmartData> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSStorageDriver_ATAPISmartData");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new AtapiSmartData
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 Checksum = (byte) (managementObject.Properties["Checksum"]?.Value ?? default(byte)),
		 ErrorLogCapability = (byte) (managementObject.Properties["ErrorLogCapability"]?.Value ?? default(byte)),
		 ExtendedPollTimeInMinutes = (byte) (managementObject.Properties["ExtendedPollTimeInMinutes"]?.Value ?? default(byte)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 Length = (uint) (managementObject.Properties["Length"]?.Value ?? default(uint)),
		 OfflineCollectCapability = (byte) (managementObject.Properties["OfflineCollectCapability"]?.Value ?? default(byte)),
		 OfflineCollectionStatus = (byte) (managementObject.Properties["OfflineCollectionStatus"]?.Value ?? default(byte)),
		 Reserved = (byte[]) (managementObject.Properties["Reserved"]?.Value ?? new byte[0]),
		 SelfTestStatus = (byte) (managementObject.Properties["SelfTestStatus"]?.Value ?? default(byte)),
		 ShortPollTimeInMinutes = (byte) (managementObject.Properties["ShortPollTimeInMinutes"]?.Value ?? default(byte)),
		 SmartCapability = (ushort) (managementObject.Properties["SmartCapability"]?.Value ?? default(ushort)),
		 TotalTime = (ushort) (managementObject.Properties["TotalTime"]?.Value ?? default(ushort)),
		 VendorSpecific = (byte[]) (managementObject.Properties["VendorSpecific"]?.Value ?? new byte[0]),
		 VendorSpecific2 = (byte) (managementObject.Properties["VendorSpecific2"]?.Value ?? default(byte)),
		 VendorSpecific3 = (byte) (managementObject.Properties["VendorSpecific3"]?.Value ?? default(byte)),
		 VendorSpecific4 = (byte[]) (managementObject.Properties["VendorSpecific4"]?.Value ?? new byte[0])
                };
        }
    }
}