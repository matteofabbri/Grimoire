using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted.Xtp
{
    /// <summary>
    /// </summary>
    public sealed class XtpDatabaseEngineXtpPhantomProcessor
    {
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public uint DustycornerscanretriesPersecPhantomissued { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public uint PhantomexpiredrowsremovedPersec { get; private set; }
		public uint PhantomexpiredrowstouchedPersec { get; private set; }
		public uint PhantomexpiringrowstouchedPersec { get; private set; }
		public uint PhantomrowstouchedPersec { get; private set; }
		public uint PhantomscansstartedPersec { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<XtpDatabaseEngineXtpPhantomProcessor> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<XtpDatabaseEngineXtpPhantomProcessor> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<XtpDatabaseEngineXtpPhantomProcessor> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_XTPDatabaseEngine_XTPPhantomProcessor");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new XtpDatabaseEngineXtpPhantomProcessor
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DustycornerscanretriesPersecPhantomissued = (uint) (managementObject.Properties["DustycornerscanretriesPersecPhantomissued"]?.Value ?? default(uint)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 PhantomexpiredrowsremovedPersec = (uint) (managementObject.Properties["PhantomexpiredrowsremovedPersec"]?.Value ?? default(uint)),
		 PhantomexpiredrowstouchedPersec = (uint) (managementObject.Properties["PhantomexpiredrowstouchedPersec"]?.Value ?? default(uint)),
		 PhantomexpiringrowstouchedPersec = (uint) (managementObject.Properties["PhantomexpiringrowstouchedPersec"]?.Value ?? default(uint)),
		 PhantomrowstouchedPersec = (uint) (managementObject.Properties["PhantomrowstouchedPersec"]?.Value ?? default(uint)),
		 PhantomscansstartedPersec = (uint) (managementObject.Properties["PhantomscansstartedPersec"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}