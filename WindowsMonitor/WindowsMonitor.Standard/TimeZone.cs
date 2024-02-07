using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor
{
    /// <summary>
    /// </summary>
    public sealed class TimeZone
    {
		public int Bias { get; private set; }
		public string Caption { get; private set; }
		public int DaylightBias { get; private set; }
		public uint DaylightDay { get; private set; }
		public byte DaylightDayOfWeek { get; private set; }
		public uint DaylightHour { get; private set; }
		public uint DaylightMillisecond { get; private set; }
		public uint DaylightMinute { get; private set; }
		public uint DaylightMonth { get; private set; }
		public string DaylightName { get; private set; }
		public uint DaylightSecond { get; private set; }
		public uint DaylightYear { get; private set; }
		public string Description { get; private set; }
		public string SettingId { get; private set; }
		public uint StandardBias { get; private set; }
		public uint StandardDay { get; private set; }
		public byte StandardDayOfWeek { get; private set; }
		public uint StandardHour { get; private set; }
		public uint StandardMillisecond { get; private set; }
		public uint StandardMinute { get; private set; }
		public uint StandardMonth { get; private set; }
		public string StandardName { get; private set; }
		public uint StandardSecond { get; private set; }
		public uint StandardYear { get; private set; }

        public static IEnumerable<TimeZone> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<TimeZone> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<TimeZone> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_TimeZone");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new TimeZone
                {
                     Bias = (int) (managementObject.Properties["Bias"]?.Value ?? default(int)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 DaylightBias = (int) (managementObject.Properties["DaylightBias"]?.Value ?? default(int)),
		 DaylightDay = (uint) (managementObject.Properties["DaylightDay"]?.Value ?? default(uint)),
		 DaylightDayOfWeek = (byte) (managementObject.Properties["DaylightDayOfWeek"]?.Value ?? default(byte)),
		 DaylightHour = (uint) (managementObject.Properties["DaylightHour"]?.Value ?? default(uint)),
		 DaylightMillisecond = (uint) (managementObject.Properties["DaylightMillisecond"]?.Value ?? default(uint)),
		 DaylightMinute = (uint) (managementObject.Properties["DaylightMinute"]?.Value ?? default(uint)),
		 DaylightMonth = (uint) (managementObject.Properties["DaylightMonth"]?.Value ?? default(uint)),
		 DaylightName = (string) (managementObject.Properties["DaylightName"]?.Value),
		 DaylightSecond = (uint) (managementObject.Properties["DaylightSecond"]?.Value ?? default(uint)),
		 DaylightYear = (uint) (managementObject.Properties["DaylightYear"]?.Value ?? default(uint)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 SettingId = (string) (managementObject.Properties["SettingID"]?.Value),
		 StandardBias = (uint) (managementObject.Properties["StandardBias"]?.Value ?? default(uint)),
		 StandardDay = (uint) (managementObject.Properties["StandardDay"]?.Value ?? default(uint)),
		 StandardDayOfWeek = (byte) (managementObject.Properties["StandardDayOfWeek"]?.Value ?? default(byte)),
		 StandardHour = (uint) (managementObject.Properties["StandardHour"]?.Value ?? default(uint)),
		 StandardMillisecond = (uint) (managementObject.Properties["StandardMillisecond"]?.Value ?? default(uint)),
		 StandardMinute = (uint) (managementObject.Properties["StandardMinute"]?.Value ?? default(uint)),
		 StandardMonth = (uint) (managementObject.Properties["StandardMonth"]?.Value ?? default(uint)),
		 StandardName = (string) (managementObject.Properties["StandardName"]?.Value),
		 StandardSecond = (uint) (managementObject.Properties["StandardSecond"]?.Value ?? default(uint)),
		 StandardYear = (uint) (managementObject.Properties["StandardYear"]?.Value ?? default(uint))
                };
        }
    }
}