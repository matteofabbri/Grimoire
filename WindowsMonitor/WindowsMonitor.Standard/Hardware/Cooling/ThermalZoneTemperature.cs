using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Cooling
{
    /// <summary>
    /// </summary>
    public sealed class ThermalZoneTemperature
    {
		public bool Active { get; private set; }
		public uint[] ActiveTripPoint { get; private set; }
		public uint ActiveTripPointCount { get; private set; }
		public uint CriticalTripPoint { get; private set; }
		public uint CurrentTemperature { get; private set; }
		public string InstanceName { get; private set; }
		public uint PassiveTripPoint { get; private set; }
		public uint Reserved { get; private set; }
		public uint SamplingPeriod { get; private set; }
		public uint ThermalConstant1 { get; private set; }
		public uint ThermalConstant2 { get; private set; }
		public uint ThermalStamp { get; private set; }

        public static IEnumerable<ThermalZoneTemperature> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ThermalZoneTemperature> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ThermalZoneTemperature> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSAcpi_ThermalZoneTemperature");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ThermalZoneTemperature
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 ActiveTripPoint = (uint[]) (managementObject.Properties["ActiveTripPoint"]?.Value ?? new uint[0]),
		 ActiveTripPointCount = (uint) (managementObject.Properties["ActiveTripPointCount"]?.Value ?? default(uint)),
		 CriticalTripPoint = (uint) (managementObject.Properties["CriticalTripPoint"]?.Value ?? default(uint)),
		 CurrentTemperature = (uint) (managementObject.Properties["CurrentTemperature"]?.Value ?? default(uint)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 PassiveTripPoint = (uint) (managementObject.Properties["PassiveTripPoint"]?.Value ?? default(uint)),
		 Reserved = (uint) (managementObject.Properties["Reserved"]?.Value ?? default(uint)),
		 SamplingPeriod = (uint) (managementObject.Properties["SamplingPeriod"]?.Value ?? default(uint)),
		 ThermalConstant1 = (uint) (managementObject.Properties["ThermalConstant1"]?.Value ?? default(uint)),
		 ThermalConstant2 = (uint) (managementObject.Properties["ThermalConstant2"]?.Value ?? default(uint)),
		 ThermalStamp = (uint) (managementObject.Properties["ThermalStamp"]?.Value ?? default(uint))
                };
        }
    }
}