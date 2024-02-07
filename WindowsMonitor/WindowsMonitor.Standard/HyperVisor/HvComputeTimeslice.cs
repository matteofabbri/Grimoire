using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.HyperVisor
{
    /// <summary>
    /// </summary>
    public sealed class HvComputeTimeslice
    {
		public ulong LocalRunListSize { get; private set; }
		public ulong NowTime { get; private set; }
		public ulong SchedulingInterval { get; private set; }
		public ulong TimeSlice { get; private set; }
		public ulong TimeSliceRatio { get; private set; }

        public static IEnumerable<HvComputeTimeslice> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<HvComputeTimeslice> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<HvComputeTimeslice> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM HvComputeTimeslice");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new HvComputeTimeslice
                {
                     LocalRunListSize = (ulong) (managementObject.Properties["LocalRunListSize"]?.Value ?? default(ulong)),
		 NowTime = (ulong) (managementObject.Properties["NowTime"]?.Value ?? default(ulong)),
		 SchedulingInterval = (ulong) (managementObject.Properties["SchedulingInterval"]?.Value ?? default(ulong)),
		 TimeSlice = (ulong) (managementObject.Properties["TimeSlice"]?.Value ?? default(ulong)),
		 TimeSliceRatio = (ulong) (managementObject.Properties["TimeSliceRatio"]?.Value ?? default(ulong))
                };
        }
    }
}