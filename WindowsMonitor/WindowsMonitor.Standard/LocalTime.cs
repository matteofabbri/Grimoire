using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor
{
    /// <summary>
    /// </summary>
    public sealed class LocalTime
    {
		public uint Day { get; private set; }
		public uint DayOfWeek { get; private set; }
		public uint Hour { get; private set; }
		public uint Milliseconds { get; private set; }
		public uint Minute { get; private set; }
		public uint Month { get; private set; }
		public uint Quarter { get; private set; }
		public uint Second { get; private set; }
		public uint WeekInMonth { get; private set; }
		public uint Year { get; private set; }

        public static IEnumerable<LocalTime> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<LocalTime> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<LocalTime> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_LocalTime");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new LocalTime
                {
                     Day = (uint) (managementObject.Properties["Day"]?.Value ?? default(uint)),
		 DayOfWeek = (uint) (managementObject.Properties["DayOfWeek"]?.Value ?? default(uint)),
		 Hour = (uint) (managementObject.Properties["Hour"]?.Value ?? default(uint)),
		 Milliseconds = (uint) (managementObject.Properties["Milliseconds"]?.Value ?? default(uint)),
		 Minute = (uint) (managementObject.Properties["Minute"]?.Value ?? default(uint)),
		 Month = (uint) (managementObject.Properties["Month"]?.Value ?? default(uint)),
		 Quarter = (uint) (managementObject.Properties["Quarter"]?.Value ?? default(uint)),
		 Second = (uint) (managementObject.Properties["Second"]?.Value ?? default(uint)),
		 WeekInMonth = (uint) (managementObject.Properties["WeekInMonth"]?.Value ?? default(uint)),
		 Year = (uint) (managementObject.Properties["Year"]?.Value ?? default(uint))
                };
        }
    }
}