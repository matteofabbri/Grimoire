using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.Network.Http
{
    /// <summary>
    /// </summary>
    public sealed class CountersIphttpsGlobal
    {
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong DropsNeighborresolutiontimeouts { get; private set; }
		public ulong ErrorsAuthenticationErrors { get; private set; }
		public ulong ErrorsReceiveerrorsontheserver { get; private set; }
		public ulong ErrorsTransmiterrorsontheserver { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public ulong InTotalbytesreceived { get; private set; }
		public ulong InTotalpacketsreceived { get; private set; }
		public string Name { get; private set; }
		public ulong OutTotalbytesforwarded { get; private set; }
		public ulong OutTotalbytessent { get; private set; }
		public ulong OutTotalpacketssent { get; private set; }
		public ulong SessionsTotalsessions { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<CountersIphttpsGlobal> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<CountersIphttpsGlobal> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<CountersIphttpsGlobal> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_Counters_IPHTTPSGlobal");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new CountersIphttpsGlobal
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DropsNeighborresolutiontimeouts = (ulong) (managementObject.Properties["DropsNeighborresolutiontimeouts"]?.Value ?? default(ulong)),
		 ErrorsAuthenticationErrors = (ulong) (managementObject.Properties["ErrorsAuthenticationErrors"]?.Value ?? default(ulong)),
		 ErrorsReceiveerrorsontheserver = (ulong) (managementObject.Properties["ErrorsReceiveerrorsontheserver"]?.Value ?? default(ulong)),
		 ErrorsTransmiterrorsontheserver = (ulong) (managementObject.Properties["ErrorsTransmiterrorsontheserver"]?.Value ?? default(ulong)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 InTotalbytesreceived = (ulong) (managementObject.Properties["InTotalbytesreceived"]?.Value ?? default(ulong)),
		 InTotalpacketsreceived = (ulong) (managementObject.Properties["InTotalpacketsreceived"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 OutTotalbytesforwarded = (ulong) (managementObject.Properties["OutTotalbytesforwarded"]?.Value ?? default(ulong)),
		 OutTotalbytessent = (ulong) (managementObject.Properties["OutTotalbytessent"]?.Value ?? default(ulong)),
		 OutTotalpacketssent = (ulong) (managementObject.Properties["OutTotalpacketssent"]?.Value ?? default(ulong)),
		 SessionsTotalsessions = (ulong) (managementObject.Properties["SessionsTotalsessions"]?.Value ?? default(ulong)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}