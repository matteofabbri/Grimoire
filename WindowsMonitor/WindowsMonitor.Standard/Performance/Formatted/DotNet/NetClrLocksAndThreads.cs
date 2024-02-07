using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted.DotNet
{
    /// <summary>
    /// </summary>
    public sealed class NetClrLocksAndThreads
    {
		public string Caption { get; private set; }
		public uint ContentionRatePersec { get; private set; }
		public uint CurrentQueueLength { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public uint NumberofcurrentlogicalThreads { get; private set; }
		public uint NumberofcurrentphysicalThreads { get; private set; }
		public uint Numberofcurrentrecognizedthreads { get; private set; }
		public uint Numberoftotalrecognizedthreads { get; private set; }
		public uint QueueLengthPeak { get; private set; }
		public uint QueueLengthPersec { get; private set; }
		public uint RateofrecognizedthreadsPersec { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public uint TotalNumberofContentions { get; private set; }

        public static IEnumerable<NetClrLocksAndThreads> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<NetClrLocksAndThreads> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<NetClrLocksAndThreads> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_NETFramework_NETCLRLocksAndThreads");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new NetClrLocksAndThreads
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 ContentionRatePersec = (uint) (managementObject.Properties["ContentionRatePersec"]?.Value ?? default(uint)),
		 CurrentQueueLength = (uint) (managementObject.Properties["CurrentQueueLength"]?.Value ?? default(uint)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 NumberofcurrentlogicalThreads = (uint) (managementObject.Properties["NumberofcurrentlogicalThreads"]?.Value ?? default(uint)),
		 NumberofcurrentphysicalThreads = (uint) (managementObject.Properties["NumberofcurrentphysicalThreads"]?.Value ?? default(uint)),
		 Numberofcurrentrecognizedthreads = (uint) (managementObject.Properties["Numberofcurrentrecognizedthreads"]?.Value ?? default(uint)),
		 Numberoftotalrecognizedthreads = (uint) (managementObject.Properties["Numberoftotalrecognizedthreads"]?.Value ?? default(uint)),
		 QueueLengthPeak = (uint) (managementObject.Properties["QueueLengthPeak"]?.Value ?? default(uint)),
		 QueueLengthPersec = (uint) (managementObject.Properties["QueueLengthPersec"]?.Value ?? default(uint)),
		 RateofrecognizedthreadsPersec = (uint) (managementObject.Properties["rateofrecognizedthreadsPersec"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 TotalNumberofContentions = (uint) (managementObject.Properties["TotalNumberofContentions"]?.Value ?? default(uint))
                };
        }
    }
}