using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.Network.Teredo
{
    /// <summary>
    /// </summary>
    public sealed class CountersTeredoClient
    {
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public uint InTeredoBubble { get; private set; }
		public ulong InTeredoData { get; private set; }
		public ulong InTeredoDataKernelMode { get; private set; }
		public ulong InTeredoDataUserMode { get; private set; }
		public uint InTeredoInvalid { get; private set; }
		public uint InTeredoRouterAdvertisement { get; private set; }
		public string Name { get; private set; }
		public uint OutTeredoBubble { get; private set; }
		public ulong OutTeredoData { get; private set; }
		public ulong OutTeredoDataKernelMode { get; private set; }
		public ulong OutTeredoDataUserMode { get; private set; }
		public uint OutTeredoRouterSolicitation { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<CountersTeredoClient> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<CountersTeredoClient> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<CountersTeredoClient> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_Counters_TeredoClient");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new CountersTeredoClient
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 InTeredoBubble = (uint) (managementObject.Properties["InTeredoBubble"]?.Value ?? default(uint)),
		 InTeredoData = (ulong) (managementObject.Properties["InTeredoData"]?.Value ?? default(ulong)),
		 InTeredoDataKernelMode = (ulong) (managementObject.Properties["InTeredoDataKernelMode"]?.Value ?? default(ulong)),
		 InTeredoDataUserMode = (ulong) (managementObject.Properties["InTeredoDataUserMode"]?.Value ?? default(ulong)),
		 InTeredoInvalid = (uint) (managementObject.Properties["InTeredoInvalid"]?.Value ?? default(uint)),
		 InTeredoRouterAdvertisement = (uint) (managementObject.Properties["InTeredoRouterAdvertisement"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 OutTeredoBubble = (uint) (managementObject.Properties["OutTeredoBubble"]?.Value ?? default(uint)),
		 OutTeredoData = (ulong) (managementObject.Properties["OutTeredoData"]?.Value ?? default(ulong)),
		 OutTeredoDataKernelMode = (ulong) (managementObject.Properties["OutTeredoDataKernelMode"]?.Value ?? default(ulong)),
		 OutTeredoDataUserMode = (ulong) (managementObject.Properties["OutTeredoDataUserMode"]?.Value ?? default(ulong)),
		 OutTeredoRouterSolicitation = (uint) (managementObject.Properties["OutTeredoRouterSolicitation"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}