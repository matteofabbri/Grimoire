using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Drives.Win32DiskDrives
{
    /// <summary>
    /// </summary>
    public sealed class Win32DiskQuota
    {
		public ulong DiskSpaceUsed { get; private set; }
		public ulong Limit { get; private set; }
		public string QuotaVolume { get; private set; }
		public uint Status { get; private set; }
		public string User { get; private set; }
		public ulong WarningLimit { get; private set; }

        public static IEnumerable<Win32DiskQuota> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<Win32DiskQuota> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<Win32DiskQuota> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_DiskQuota");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new Win32DiskQuota
                {
                     DiskSpaceUsed = (ulong) (managementObject.Properties["DiskSpaceUsed"]?.Value ?? default(ulong)),
		 Limit = (ulong) (managementObject.Properties["Limit"]?.Value ?? default(ulong)),
		 QuotaVolume =  (managementObject.Properties["QuotaVolume"]?.Value?.ToString()),
		 Status = (uint) (managementObject.Properties["Status"]?.Value ?? default(uint)),
		 User =  (managementObject.Properties["User"]?.Value?.ToString()),
		 WarningLimit = (ulong) (managementObject.Properties["WarningLimit"]?.Value ?? default(ulong))
                };
        }
    }
}