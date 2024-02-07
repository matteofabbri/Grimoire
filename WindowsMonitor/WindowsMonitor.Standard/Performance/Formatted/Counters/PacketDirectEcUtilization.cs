using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted.Counters
{
    /// <summary>
    /// </summary>
    public sealed class PacketDirectEcUtilization
    {
        public uint BusyWaitIterationsPersec { get; private set; }
        public string Caption { get; private set; }
        public string Description { get; private set; }
        public ulong FrequencyObject { get; private set; }
        public ulong FrequencyPerfTime { get; private set; }
        public ulong FrequencySys100Ns { get; private set; }
        public uint IterationsPersec { get; private set; }
        public string Name { get; private set; }
        public ulong PercentBusyWaitingTime { get; private set; }
        public uint PercentBusyWaitIterations { get; private set; }
        public ulong PercentIdleTime { get; private set; }
        public ulong PercentProcessingTime { get; private set; }
        public uint ProcessorNumber { get; private set; }
        public uint RxQueueCount { get; private set; }
        public ulong TimestampObject { get; private set; }
        public ulong TimestampPerfTime { get; private set; }
        public ulong TimestampSys100Ns { get; private set; }
        public ulong TotalBusyWaitIterations { get; private set; }
        public ulong TotalIterations { get; private set; }
        public uint TxQueueCount { get; private set; }

        public static IEnumerable<PacketDirectEcUtilization> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<PacketDirectEcUtilization> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<PacketDirectEcUtilization> Retrieve(ManagementScope managementScope)
        {
            var objectQuery =
                new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_Counters_PacketDirectECUtilization");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new PacketDirectEcUtilization
                {
                    BusyWaitIterationsPersec =
                        (uint) (managementObject.Properties["BusyWaitIterationsPersec"]?.Value ?? default(uint)),
                    Caption = (string) managementObject.Properties["Caption"]?.Value,
                    Description = (string) managementObject.Properties["Description"]?.Value,
                    FrequencyObject =
                        (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
                    FrequencyPerfTime =
                        (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
                    FrequencySys100Ns =
                        (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
                    IterationsPersec = (uint) (managementObject.Properties["IterationsPersec"]?.Value ?? default(uint)),
                    Name = (string) managementObject.Properties["Name"]?.Value,
                    PercentBusyWaitingTime =
                        (ulong) (managementObject.Properties["PercentBusyWaitingTime"]?.Value ?? default(ulong)),
                    PercentBusyWaitIterations =
                        (uint) (managementObject.Properties["PercentBusyWaitIterations"]?.Value ?? default(uint)),
                    PercentIdleTime = (ulong) (managementObject.Properties["PercentIdleTime"]?.Value ?? default(ulong)),
                    PercentProcessingTime =
                        (ulong) (managementObject.Properties["PercentProcessingTime"]?.Value ?? default(ulong)),
                    ProcessorNumber = (uint) (managementObject.Properties["ProcessorNumber"]?.Value ?? default(uint)),
                    RxQueueCount = (uint) (managementObject.Properties["RXQueueCount"]?.Value ?? default(uint)),
                    TimestampObject =
                        (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
                    TimestampPerfTime =
                        (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
                    TimestampSys100Ns =
                        (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
                    TotalBusyWaitIterations =
                        (ulong) (managementObject.Properties["TotalBusyWaitIterations"]?.Value ?? default(ulong)),
                    TotalIterations = (ulong) (managementObject.Properties["TotalIterations"]?.Value ?? default(ulong)),
                    TxQueueCount = (uint) (managementObject.Properties["TXQueueCount"]?.Value ?? default(uint))
                };
        }
    }
}