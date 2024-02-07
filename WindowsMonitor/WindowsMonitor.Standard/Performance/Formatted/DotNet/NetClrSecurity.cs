using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted.DotNet
{
    /// <summary>
    /// </summary>
    public sealed class NetClrSecurity
    {
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public uint NumberLinkTimeChecks { get; private set; }
		public uint PercentTimeinRTchecks { get; private set; }
		public ulong PercentTimeSigAuthenticating { get; private set; }
		public uint StackWalkDepth { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public uint TotalRuntimeChecks { get; private set; }

        public static IEnumerable<NetClrSecurity> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<NetClrSecurity> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<NetClrSecurity> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_NETFramework_NETCLRSecurity");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new NetClrSecurity
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 NumberLinkTimeChecks = (uint) (managementObject.Properties["NumberLinkTimeChecks"]?.Value ?? default(uint)),
		 PercentTimeinRTchecks = (uint) (managementObject.Properties["PercentTimeinRTchecks"]?.Value ?? default(uint)),
		 PercentTimeSigAuthenticating = (ulong) (managementObject.Properties["PercentTimeSigAuthenticating"]?.Value ?? default(ulong)),
		 StackWalkDepth = (uint) (managementObject.Properties["StackWalkDepth"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 TotalRuntimeChecks = (uint) (managementObject.Properties["TotalRuntimeChecks"]?.Value ?? default(uint))
                };
        }
    }
}