using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted.DotNet
{
    /// <summary>
    /// </summary>
    public sealed class NetClrData
    {
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public uint SqlClientCurrentNumberconnectionpools { get; private set; }
		public uint SqlClientCurrentNumberpooledandnonpooledconnections { get; private set; }
		public uint SqlClientCurrentNumberpooledconnections { get; private set; }
		public uint SqlClientPeakNumberpooledconnections { get; private set; }
		public uint SqlClientTotalNumberfailedcommands { get; private set; }
		public uint SqlClientTotalNumberfailedconnects { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<NetClrData> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<NetClrData> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<NetClrData> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_NETCLRData_NETCLRData");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new NetClrData
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 SqlClientCurrentNumberconnectionpools = (uint) (managementObject.Properties["SqlClientCurrentNumberconnectionpools"]?.Value ?? default(uint)),
		 SqlClientCurrentNumberpooledandnonpooledconnections = (uint) (managementObject.Properties["SqlClientCurrentNumberpooledandnonpooledconnections"]?.Value ?? default(uint)),
		 SqlClientCurrentNumberpooledconnections = (uint) (managementObject.Properties["SqlClientCurrentNumberpooledconnections"]?.Value ?? default(uint)),
		 SqlClientPeakNumberpooledconnections = (uint) (managementObject.Properties["SqlClientPeakNumberpooledconnections"]?.Value ?? default(uint)),
		 SqlClientTotalNumberfailedcommands = (uint) (managementObject.Properties["SqlClientTotalNumberfailedcommands"]?.Value ?? default(uint)),
		 SqlClientTotalNumberfailedconnects = (uint) (managementObject.Properties["SqlClientTotalNumberfailedconnects"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}