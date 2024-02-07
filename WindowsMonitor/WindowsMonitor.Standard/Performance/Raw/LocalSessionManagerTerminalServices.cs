using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw
{
    /// <summary>
    /// </summary>
    public sealed class LocalSessionManagerTerminalServices
    {
        public uint ActiveSessions { get; private set; }
        public string Caption { get; private set; }
        public string Description { get; private set; }
        public ulong FrequencyObject { get; private set; }
        public ulong FrequencyPerfTime { get; private set; }
        public ulong FrequencySys100Ns { get; private set; }
        public uint InactiveSessions { get; private set; }
        public string Name { get; private set; }
        public ulong TimestampObject { get; private set; }
        public ulong TimestampPerfTime { get; private set; }
        public ulong TimestampSys100Ns { get; private set; }
        public uint TotalSessions { get; private set; }

        public static IEnumerable<LocalSessionManagerTerminalServices> Retrieve(string remote, string username,
            string password)
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

        public static IEnumerable<LocalSessionManagerTerminalServices> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<LocalSessionManagerTerminalServices> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_LocalSessionManager_TerminalServices");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new LocalSessionManagerTerminalServices
                {
                    ActiveSessions = (uint) (managementObject.Properties["ActiveSessions"]?.Value ?? default(uint)),
                    Caption = (string) managementObject.Properties["Caption"]?.Value,
                    Description = (string) managementObject.Properties["Description"]?.Value,
                    FrequencyObject =
                        (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
                    FrequencyPerfTime =
                        (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
                    FrequencySys100Ns =
                        (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
                    InactiveSessions = (uint) (managementObject.Properties["InactiveSessions"]?.Value ?? default(uint)),
                    Name = (string) managementObject.Properties["Name"]?.Value,
                    TimestampObject =
                        (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
                    TimestampPerfTime =
                        (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
                    TimestampSys100Ns =
                        (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
                    TotalSessions = (uint) (managementObject.Properties["TotalSessions"]?.Value ?? default(uint))
                };
        }
    }
}