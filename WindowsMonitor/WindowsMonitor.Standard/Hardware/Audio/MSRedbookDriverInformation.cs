using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Audio
{
    /// <summary>
    /// </summary>
    public sealed class MsRedbookDriverInformation
    {
		public bool Active { get; private set; }
		public bool CddaAccurate { get; private set; }
		public bool CddaSupported { get; private set; }
		public string InstanceName { get; private set; }
		public uint MaximumSectorsPerRead { get; private set; }
		public uint NumberOfBuffers { get; private set; }
		public bool PlayEnabled { get; private set; }
		public bool Reserved1 { get; private set; }
		public uint SectorsPerRead { get; private set; }
		public uint SectorsPerReadMask { get; private set; }

        public static IEnumerable<MsRedbookDriverInformation> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<MsRedbookDriverInformation> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<MsRedbookDriverInformation> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSRedbook_DriverInformation");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new MsRedbookDriverInformation
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 CddaAccurate = (bool) (managementObject.Properties["CDDAAccurate"]?.Value ?? default(bool)),
		 CddaSupported = (bool) (managementObject.Properties["CDDASupported"]?.Value ?? default(bool)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 MaximumSectorsPerRead = (uint) (managementObject.Properties["MaximumSectorsPerRead"]?.Value ?? default(uint)),
		 NumberOfBuffers = (uint) (managementObject.Properties["NumberOfBuffers"]?.Value ?? default(uint)),
		 PlayEnabled = (bool) (managementObject.Properties["PlayEnabled"]?.Value ?? default(bool)),
		 Reserved1 = (bool) (managementObject.Properties["Reserved1"]?.Value ?? default(bool)),
		 SectorsPerRead = (uint) (managementObject.Properties["SectorsPerRead"]?.Value ?? default(uint)),
		 SectorsPerReadMask = (uint) (managementObject.Properties["SectorsPerReadMask"]?.Value ?? default(uint))
                };
        }
    }
}