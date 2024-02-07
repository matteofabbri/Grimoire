using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted.DotNet
{
    /// <summary>
    /// </summary>
    public sealed class NetDataProviderForSqlServer
    {
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public uint HardConnectsPerSecond { get; private set; }
		public uint HardDisconnectsPerSecond { get; private set; }
		public string Name { get; private set; }
		public uint NumberOfActiveConnectionPoolGroups { get; private set; }
		public uint NumberOfActiveConnectionPools { get; private set; }
		public uint NumberOfActiveConnections { get; private set; }
		public uint NumberOfFreeConnections { get; private set; }
		public uint NumberOfInactiveConnectionPoolGroups { get; private set; }
		public uint NumberOfInactiveConnectionPools { get; private set; }
		public uint NumberOfNonPooledConnections { get; private set; }
		public uint NumberOfPooledConnections { get; private set; }
		public uint NumberOfReclaimedConnections { get; private set; }
		public uint NumberOfStasisConnections { get; private set; }
		public uint SoftConnectsPerSecond { get; private set; }
		public uint SoftDisconnectsPerSecond { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<NetDataProviderForSqlServer> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<NetDataProviderForSqlServer> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<NetDataProviderForSqlServer> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_NETDataProviderforSqlServer_NETDataProviderforSqlServer");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new NetDataProviderForSqlServer
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 HardConnectsPerSecond = (uint) (managementObject.Properties["HardConnectsPerSecond"]?.Value ?? default(uint)),
		 HardDisconnectsPerSecond = (uint) (managementObject.Properties["HardDisconnectsPerSecond"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 NumberOfActiveConnectionPoolGroups = (uint) (managementObject.Properties["NumberOfActiveConnectionPoolGroups"]?.Value ?? default(uint)),
		 NumberOfActiveConnectionPools = (uint) (managementObject.Properties["NumberOfActiveConnectionPools"]?.Value ?? default(uint)),
		 NumberOfActiveConnections = (uint) (managementObject.Properties["NumberOfActiveConnections"]?.Value ?? default(uint)),
		 NumberOfFreeConnections = (uint) (managementObject.Properties["NumberOfFreeConnections"]?.Value ?? default(uint)),
		 NumberOfInactiveConnectionPoolGroups = (uint) (managementObject.Properties["NumberOfInactiveConnectionPoolGroups"]?.Value ?? default(uint)),
		 NumberOfInactiveConnectionPools = (uint) (managementObject.Properties["NumberOfInactiveConnectionPools"]?.Value ?? default(uint)),
		 NumberOfNonPooledConnections = (uint) (managementObject.Properties["NumberOfNonPooledConnections"]?.Value ?? default(uint)),
		 NumberOfPooledConnections = (uint) (managementObject.Properties["NumberOfPooledConnections"]?.Value ?? default(uint)),
		 NumberOfReclaimedConnections = (uint) (managementObject.Properties["NumberOfReclaimedConnections"]?.Value ?? default(uint)),
		 NumberOfStasisConnections = (uint) (managementObject.Properties["NumberOfStasisConnections"]?.Value ?? default(uint)),
		 SoftConnectsPerSecond = (uint) (managementObject.Properties["SoftConnectsPerSecond"]?.Value ?? default(uint)),
		 SoftDisconnectsPerSecond = (uint) (managementObject.Properties["SoftDisconnectsPerSecond"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}