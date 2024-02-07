using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.ISCSI
{
    /// <summary>
    /// </summary>
    public sealed class IscsiQmipsecStats
    {
		public bool Active { get; private set; }
		public ulong ActiveSa { get; private set; }
		public ulong ActiveTunnels { get; private set; }
		public ulong AuthenticatedBytesReceived { get; private set; }
		public ulong AuthenticatedBytesSent { get; private set; }
		public ulong BadSpiPackets { get; private set; }
		public string Caption { get; private set; }
		public ulong ConfidentialBytesReceived { get; private set; }
		public ulong ConfidentialBytesSent { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string InstanceName { get; private set; }
		public ulong KeyAdditions { get; private set; }
		public ulong KeyDeletions { get; private set; }
		public string Name { get; private set; }
		public ulong PacketsNotAuthenticated { get; private set; }
		public ulong PacketsNotDecrypted { get; private set; }
		public ulong PacketsWithReplayDetection { get; private set; }
		public ulong PendingKeyOperations { get; private set; }
		public ulong ReKeys { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public ulong TransportBytesReceived { get; private set; }
		public ulong TransportBytesSent { get; private set; }
		public ulong TunnelBytesReceived { get; private set; }
		public ulong TunnelBytesSent { get; private set; }

        public static IEnumerable<IscsiQmipsecStats> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<IscsiQmipsecStats> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<IscsiQmipsecStats> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSiSCSI_QMIPSECStats");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new IscsiQmipsecStats
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 ActiveSa = (ulong) (managementObject.Properties["ActiveSA"]?.Value ?? default(ulong)),
		 ActiveTunnels = (ulong) (managementObject.Properties["ActiveTunnels"]?.Value ?? default(ulong)),
		 AuthenticatedBytesReceived = (ulong) (managementObject.Properties["AuthenticatedBytesReceived"]?.Value ?? default(ulong)),
		 AuthenticatedBytesSent = (ulong) (managementObject.Properties["AuthenticatedBytesSent"]?.Value ?? default(ulong)),
		 BadSpiPackets = (ulong) (managementObject.Properties["BadSPIPackets"]?.Value ?? default(ulong)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value ?? default(string)),
		 ConfidentialBytesReceived = (ulong) (managementObject.Properties["ConfidentialBytesReceived"]?.Value ?? default(ulong)),
		 ConfidentialBytesSent = (ulong) (managementObject.Properties["ConfidentialBytesSent"]?.Value ?? default(ulong)),
		 Description = (string) (managementObject.Properties["Description"]?.Value ?? default(string)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 KeyAdditions = (ulong) (managementObject.Properties["KeyAdditions"]?.Value ?? default(ulong)),
		 KeyDeletions = (ulong) (managementObject.Properties["KeyDeletions"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value ?? default(string)),
		 PacketsNotAuthenticated = (ulong) (managementObject.Properties["PacketsNotAuthenticated"]?.Value ?? default(ulong)),
		 PacketsNotDecrypted = (ulong) (managementObject.Properties["PacketsNotDecrypted"]?.Value ?? default(ulong)),
		 PacketsWithReplayDetection = (ulong) (managementObject.Properties["PacketsWithReplayDetection"]?.Value ?? default(ulong)),
		 PendingKeyOperations = (ulong) (managementObject.Properties["PendingKeyOperations"]?.Value ?? default(ulong)),
		 ReKeys = (ulong) (managementObject.Properties["ReKeys"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 TransportBytesReceived = (ulong) (managementObject.Properties["TransportBytesReceived"]?.Value ?? default(ulong)),
		 TransportBytesSent = (ulong) (managementObject.Properties["TransportBytesSent"]?.Value ?? default(ulong)),
		 TunnelBytesReceived = (ulong) (managementObject.Properties["TunnelBytesReceived"]?.Value ?? default(ulong)),
		 TunnelBytesSent = (ulong) (managementObject.Properties["TunnelBytesSent"]?.Value ?? default(ulong))
                };
        }
    }
}