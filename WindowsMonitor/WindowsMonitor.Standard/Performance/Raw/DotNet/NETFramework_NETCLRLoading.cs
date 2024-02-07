using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.DotNet
{
    /// <summary>
    /// </summary>
    public sealed class NetFrameworkNetclrLoading
    {
		public uint AssemblySearchLength { get; private set; }
		public uint BytesinLoaderHeap { get; private set; }
		public string Caption { get; private set; }
		public uint Currentappdomains { get; private set; }
		public uint CurrentAssemblies { get; private set; }
		public uint CurrentClassesLoaded { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public ulong PercentTimeLoading { get; private set; }
		public uint Rateofappdomains { get; private set; }
		public uint Rateofappdomainsunloaded { get; private set; }
		public uint RateofAssemblies { get; private set; }
		public uint RateofClassesLoaded { get; private set; }
		public uint RateofLoadFailures { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public uint TotalAppdomains { get; private set; }
		public uint Totalappdomainsunloaded { get; private set; }
		public uint TotalAssemblies { get; private set; }
		public uint TotalClassesLoaded { get; private set; }
		public uint TotalNumberofLoadFailures { get; private set; }

        public static IEnumerable<NetFrameworkNetclrLoading> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<NetFrameworkNetclrLoading> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<NetFrameworkNetclrLoading> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_NETFramework_NETCLRLoading");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new NetFrameworkNetclrLoading
                {
                     AssemblySearchLength = (uint) (managementObject.Properties["AssemblySearchLength"]?.Value ?? default(uint)),
		 BytesinLoaderHeap = (uint) (managementObject.Properties["BytesinLoaderHeap"]?.Value ?? default(uint)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Currentappdomains = (uint) (managementObject.Properties["Currentappdomains"]?.Value ?? default(uint)),
		 CurrentAssemblies = (uint) (managementObject.Properties["CurrentAssemblies"]?.Value ?? default(uint)),
		 CurrentClassesLoaded = (uint) (managementObject.Properties["CurrentClassesLoaded"]?.Value ?? default(uint)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 PercentTimeLoading = (ulong) (managementObject.Properties["PercentTimeLoading"]?.Value ?? default(ulong)),
		 Rateofappdomains = (uint) (managementObject.Properties["Rateofappdomains"]?.Value ?? default(uint)),
		 Rateofappdomainsunloaded = (uint) (managementObject.Properties["Rateofappdomainsunloaded"]?.Value ?? default(uint)),
		 RateofAssemblies = (uint) (managementObject.Properties["RateofAssemblies"]?.Value ?? default(uint)),
		 RateofClassesLoaded = (uint) (managementObject.Properties["RateofClassesLoaded"]?.Value ?? default(uint)),
		 RateofLoadFailures = (uint) (managementObject.Properties["RateofLoadFailures"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 TotalAppdomains = (uint) (managementObject.Properties["TotalAppdomains"]?.Value ?? default(uint)),
		 Totalappdomainsunloaded = (uint) (managementObject.Properties["Totalappdomainsunloaded"]?.Value ?? default(uint)),
		 TotalAssemblies = (uint) (managementObject.Properties["TotalAssemblies"]?.Value ?? default(uint)),
		 TotalClassesLoaded = (uint) (managementObject.Properties["TotalClassesLoaded"]?.Value ?? default(uint)),
		 TotalNumberofLoadFailures = (uint) (managementObject.Properties["TotalNumberofLoadFailures"]?.Value ?? default(uint))
                };
        }
    }
}