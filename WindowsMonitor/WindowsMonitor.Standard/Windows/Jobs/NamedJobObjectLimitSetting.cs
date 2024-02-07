using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Jobs
{
    /// <summary>
    /// </summary>
    public sealed class NamedJobObjectLimitSetting
    {
		public uint ActiveProcessLimit { get; private set; }
		public uint Affinity { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public uint JobMemoryLimit { get; private set; }
		public uint LimitFlags { get; private set; }
		public uint MaximumWorkingSetSize { get; private set; }
		public uint MinimumWorkingSetSize { get; private set; }
		public ulong PerJobUserTimeLimit { get; private set; }
		public ulong PerProcessUserTimeLimit { get; private set; }
		public uint PriorityClass { get; private set; }
		public uint ProcessMemoryLimit { get; private set; }
		public uint SchedulingClass { get; private set; }
		public string SettingId { get; private set; }

        public static IEnumerable<NamedJobObjectLimitSetting> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<NamedJobObjectLimitSetting> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<NamedJobObjectLimitSetting> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_NamedJobObjectLimitSetting");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new NamedJobObjectLimitSetting
                {
                     ActiveProcessLimit = (uint) (managementObject.Properties["ActiveProcessLimit"]?.Value ?? default(uint)),
		 Affinity = (uint) (managementObject.Properties["Affinity"]?.Value ?? default(uint)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 JobMemoryLimit = (uint) (managementObject.Properties["JobMemoryLimit"]?.Value ?? default(uint)),
		 LimitFlags = (uint) (managementObject.Properties["LimitFlags"]?.Value ?? default(uint)),
		 MaximumWorkingSetSize = (uint) (managementObject.Properties["MaximumWorkingSetSize"]?.Value ?? default(uint)),
		 MinimumWorkingSetSize = (uint) (managementObject.Properties["MinimumWorkingSetSize"]?.Value ?? default(uint)),
		 PerJobUserTimeLimit = (ulong) (managementObject.Properties["PerJobUserTimeLimit"]?.Value ?? default(ulong)),
		 PerProcessUserTimeLimit = (ulong) (managementObject.Properties["PerProcessUserTimeLimit"]?.Value ?? default(ulong)),
		 PriorityClass = (uint) (managementObject.Properties["PriorityClass"]?.Value ?? default(uint)),
		 ProcessMemoryLimit = (uint) (managementObject.Properties["ProcessMemoryLimit"]?.Value ?? default(uint)),
		 SchedulingClass = (uint) (managementObject.Properties["SchedulingClass"]?.Value ?? default(uint)),
		 SettingId = (string) (managementObject.Properties["SettingID"]?.Value)
                };
        }
    }
}