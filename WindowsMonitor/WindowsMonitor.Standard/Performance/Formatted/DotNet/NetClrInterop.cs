using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted.DotNet
{
    /// <summary>
    /// </summary>
    public sealed class NetClrInterop
    {
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public uint NumberofCcWs { get; private set; }
		public uint Numberofmarshalling { get; private set; }
		public uint NumberofStubs { get; private set; }
		public uint NumberofTlBexportsPersec { get; private set; }
		public uint NumberofTlBimportsPersec { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<NetClrInterop> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<NetClrInterop> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<NetClrInterop> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_NETFramework_NETCLRInterop");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new NetClrInterop
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 NumberofCcWs = (uint) (managementObject.Properties["NumberofCCWs"]?.Value ?? default(uint)),
		 Numberofmarshalling = (uint) (managementObject.Properties["Numberofmarshalling"]?.Value ?? default(uint)),
		 NumberofStubs = (uint) (managementObject.Properties["NumberofStubs"]?.Value ?? default(uint)),
		 NumberofTlBexportsPersec = (uint) (managementObject.Properties["NumberofTLBexportsPersec"]?.Value ?? default(uint)),
		 NumberofTlBimportsPersec = (uint) (managementObject.Properties["NumberofTLBimportsPersec"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}