using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.SMHBA
{
    /// <summary>
    /// </summary>
    public sealed class ProtocolStatistics
    {
		public long ControlRequests { get; private set; }
		public long InputMegabytes { get; private set; }
		public long InputRequests { get; private set; }
		public long OutputMegabytes { get; private set; }
		public long OutputRequests { get; private set; }
		public long SecondsSinceLastReset { get; private set; }

        public static IEnumerable<ProtocolStatistics> Retrieve(string remote, string username, string password)
        {
            var options = new ConnectionOptions
            {
                Impersonation = ImpersonationLevel.Impersonate,
                Username = username,
                Password = password
            };

            var managementScope = new ManagementScope(new ManagementPath($"\\\\{remote}\\root\\wmi"), options);
            managementScope.Connect();

            return Retrieve(managementScope);
        }

        public static IEnumerable<ProtocolStatistics> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ProtocolStatistics> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MS_SMHBA_PROTOCOLSTATISTICS");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ProtocolStatistics
                {
                     ControlRequests = (long) (managementObject.Properties["ControlRequests"]?.Value ?? default(long)),
		 InputMegabytes = (long) (managementObject.Properties["InputMegabytes"]?.Value ?? default(long)),
		 InputRequests = (long) (managementObject.Properties["InputRequests"]?.Value ?? default(long)),
		 OutputMegabytes = (long) (managementObject.Properties["OutputMegabytes"]?.Value ?? default(long)),
		 OutputRequests = (long) (managementObject.Properties["OutputRequests"]?.Value ?? default(long)),
		 SecondsSinceLastReset = (long) (managementObject.Properties["SecondsSinceLastReset"]?.Value ?? default(long))
                };
        }
    }
}