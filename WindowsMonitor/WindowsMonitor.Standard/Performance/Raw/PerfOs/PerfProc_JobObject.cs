using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.PerfOs
{
    /// <summary>
    /// </summary>
    public sealed class PerfProcJobObject
    {
		public string Caption { get; private set; }
		public ulong CurrentPercentKernelModeTime { get; private set; }
		public ulong CurrentPercentProcessorTime { get; private set; }
		public ulong CurrentPercentUserModeTime { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public uint PagesPerSec { get; private set; }
		public uint ProcessCountActive { get; private set; }
		public uint ProcessCountTerminated { get; private set; }
		public uint ProcessCountTotal { get; private set; }
		public ulong ThisPeriodmSecKernelMode { get; private set; }
		public ulong ThisPeriodmSecProcessor { get; private set; }
		public ulong ThisPeriodmSecUserMode { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public ulong TotalmSecKernelMode { get; private set; }
		public ulong TotalmSecProcessor { get; private set; }
		public ulong TotalmSecUserMode { get; private set; }

        public static IEnumerable<PerfProcJobObject> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<PerfProcJobObject> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<PerfProcJobObject> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_PerfProc_JobObject");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new PerfProcJobObject
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CurrentPercentKernelModeTime = (ulong) (managementObject.Properties["CurrentPercentKernelModeTime"]?.Value ?? default(ulong)),
		 CurrentPercentProcessorTime = (ulong) (managementObject.Properties["CurrentPercentProcessorTime"]?.Value ?? default(ulong)),
		 CurrentPercentUserModeTime = (ulong) (managementObject.Properties["CurrentPercentUserModeTime"]?.Value ?? default(ulong)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 PagesPerSec = (uint) (managementObject.Properties["PagesPerSec"]?.Value ?? default(uint)),
		 ProcessCountActive = (uint) (managementObject.Properties["ProcessCountActive"]?.Value ?? default(uint)),
		 ProcessCountTerminated = (uint) (managementObject.Properties["ProcessCountTerminated"]?.Value ?? default(uint)),
		 ProcessCountTotal = (uint) (managementObject.Properties["ProcessCountTotal"]?.Value ?? default(uint)),
		 ThisPeriodmSecKernelMode = (ulong) (managementObject.Properties["ThisPeriodmSecKernelMode"]?.Value ?? default(ulong)),
		 ThisPeriodmSecProcessor = (ulong) (managementObject.Properties["ThisPeriodmSecProcessor"]?.Value ?? default(ulong)),
		 ThisPeriodmSecUserMode = (ulong) (managementObject.Properties["ThisPeriodmSecUserMode"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 TotalmSecKernelMode = (ulong) (managementObject.Properties["TotalmSecKernelMode"]?.Value ?? default(ulong)),
		 TotalmSecProcessor = (ulong) (managementObject.Properties["TotalmSecProcessor"]?.Value ?? default(ulong)),
		 TotalmSecUserMode = (ulong) (managementObject.Properties["TotalmSecUserMode"]?.Value ?? default(ulong))
                };
        }
    }
}