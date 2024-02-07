using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network
{
    /// <summary>
    /// </summary>
    public sealed class ReceiveFilterParameters
    {
		public dynamic[] FieldParameters { get; private set; }
		public uint FieldParametersArrayElementSize { get; private set; }
		public uint FieldParametersArrayNumElements { get; private set; }
		public uint FieldParametersArrayOffset { get; private set; }
		public uint FilterId { get; private set; }
		public uint FilterType { get; private set; }
		public uint Flags { get; private set; }
		public dynamic Header { get; private set; }
		public uint QueueId { get; private set; }
		public uint RequestedFilterIdBitCount { get; private set; }

        public static IEnumerable<ReceiveFilterParameters> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ReceiveFilterParameters> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ReceiveFilterParameters> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_ReceiveFilterParameters");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ReceiveFilterParameters
                {
                     FieldParameters = (dynamic[]) (managementObject.Properties["FieldParameters"]?.Value ?? new dynamic[0]),
		 FieldParametersArrayElementSize = (uint) (managementObject.Properties["FieldParametersArrayElementSize"]?.Value ?? default(uint)),
		 FieldParametersArrayNumElements = (uint) (managementObject.Properties["FieldParametersArrayNumElements"]?.Value ?? default(uint)),
		 FieldParametersArrayOffset = (uint) (managementObject.Properties["FieldParametersArrayOffset"]?.Value ?? default(uint)),
		 FilterId = (uint) (managementObject.Properties["FilterId"]?.Value ?? default(uint)),
		 FilterType = (uint) (managementObject.Properties["FilterType"]?.Value ?? default(uint)),
		 Flags = (uint) (managementObject.Properties["Flags"]?.Value ?? default(uint)),
		 Header = (dynamic) (managementObject.Properties["Header"]?.Value ?? default(dynamic)),
		 QueueId = (uint) (managementObject.Properties["QueueId"]?.Value ?? default(uint)),
		 RequestedFilterIdBitCount = (uint) (managementObject.Properties["RequestedFilterIdBitCount"]?.Value ?? default(uint))
                };
        }
    }
}