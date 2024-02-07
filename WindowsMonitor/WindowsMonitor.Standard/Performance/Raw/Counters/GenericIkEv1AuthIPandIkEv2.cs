using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.Counters
{
    /// <summary>
    /// </summary>
    public sealed class GenericIkEv1AuthIPandIkEv2
    {
		public uint AuthIpMainModeNegotiationTime { get; private set; }
		public uint AuthIpQuickModeNegotiationTime { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public uint ExtendedModeNegotiationTime { get; private set; }
		public uint FailedNegotiations { get; private set; }
		public uint FailedNegotiationsPersec { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public uint IkEv1MainModeNegotiationTime { get; private set; }
		public uint IkEv1QuickModeNegotiationTime { get; private set; }
		public uint IkEv2MainModeNegotiationTime { get; private set; }
		public uint IkEv2QuickModeNegotiationTime { get; private set; }
		public uint InvalidPacketsReceivedPersec { get; private set; }
		public string Name { get; private set; }
		public uint PacketsReceivedPersec { get; private set; }
		public uint SuccessfulNegotiations { get; private set; }
		public uint SuccessfulNegotiationsPersec { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<GenericIkEv1AuthIPandIkEv2> Retrieve(string remote, string username, string password)
        {
            var options = new ConnectionOptions
            {
                Impersonation = ImpersonationLevel.Impersonate,
                Username = username,
                Password = password
            };

            var managementScope = new ManagementScope(new ManagementPath($"\\\\{remote}\\root\\cimv2"), options);
            managementScope.Connect();

            return Retrieve(managementScope);
        }

        public static IEnumerable<GenericIkEv1AuthIPandIkEv2> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<GenericIkEv1AuthIPandIkEv2> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_Counters_GenericIKEv1AuthIPandIKEv2");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new GenericIkEv1AuthIPandIkEv2
                {
                     AuthIpMainModeNegotiationTime = (uint) (managementObject.Properties["AuthIPMainModeNegotiationTime"]?.Value ?? default(uint)),
		 AuthIpQuickModeNegotiationTime = (uint) (managementObject.Properties["AuthIPQuickModeNegotiationTime"]?.Value ?? default(uint)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 ExtendedModeNegotiationTime = (uint) (managementObject.Properties["ExtendedModeNegotiationTime"]?.Value ?? default(uint)),
		 FailedNegotiations = (uint) (managementObject.Properties["FailedNegotiations"]?.Value ?? default(uint)),
		 FailedNegotiationsPersec = (uint) (managementObject.Properties["FailedNegotiationsPersec"]?.Value ?? default(uint)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 IkEv1MainModeNegotiationTime = (uint) (managementObject.Properties["IKEv1MainModeNegotiationTime"]?.Value ?? default(uint)),
		 IkEv1QuickModeNegotiationTime = (uint) (managementObject.Properties["IKEv1QuickModeNegotiationTime"]?.Value ?? default(uint)),
		 IkEv2MainModeNegotiationTime = (uint) (managementObject.Properties["IKEv2MainModeNegotiationTime"]?.Value ?? default(uint)),
		 IkEv2QuickModeNegotiationTime = (uint) (managementObject.Properties["IKEv2QuickModeNegotiationTime"]?.Value ?? default(uint)),
		 InvalidPacketsReceivedPersec = (uint) (managementObject.Properties["InvalidPacketsReceivedPersec"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 PacketsReceivedPersec = (uint) (managementObject.Properties["PacketsReceivedPersec"]?.Value ?? default(uint)),
		 SuccessfulNegotiations = (uint) (managementObject.Properties["SuccessfulNegotiations"]?.Value ?? default(uint)),
		 SuccessfulNegotiationsPersec = (uint) (managementObject.Properties["SuccessfulNegotiationsPersec"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}