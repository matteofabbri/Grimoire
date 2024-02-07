using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Jobs
{
    /// <summary>
    /// </summary>
    public sealed class NamedJobObjectActgInfo
    {
		public uint ActiveProcesses { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public string Name { get; private set; }
		public ulong OtherOperationCount { get; private set; }
		public ulong OtherTransferCount { get; private set; }
		public uint PeakJobMemoryUsed { get; private set; }
		public uint PeakProcessMemoryUsed { get; private set; }
		public ulong ReadOperationCount { get; private set; }
		public ulong ReadTransferCount { get; private set; }
		public ulong ThisPeriodTotalKernelTime { get; private set; }
		public ulong ThisPeriodTotalUserTime { get; private set; }
		public ulong TotalKernelTime { get; private set; }
		public uint TotalPageFaultCount { get; private set; }
		public uint TotalProcesses { get; private set; }
		public uint TotalTerminatedProcesses { get; private set; }
		public ulong TotalUserTime { get; private set; }
		public ulong WriteOperationCount { get; private set; }
		public ulong WriteTransferCount { get; private set; }

        public static IEnumerable<NamedJobObjectActgInfo> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<NamedJobObjectActgInfo> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<NamedJobObjectActgInfo> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_NamedJobObjectActgInfo");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new NamedJobObjectActgInfo
                {
                     ActiveProcesses = (uint) (managementObject.Properties["ActiveProcesses"]?.Value ?? default(uint)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 OtherOperationCount = (ulong) (managementObject.Properties["OtherOperationCount"]?.Value ?? default(ulong)),
		 OtherTransferCount = (ulong) (managementObject.Properties["OtherTransferCount"]?.Value ?? default(ulong)),
		 PeakJobMemoryUsed = (uint) (managementObject.Properties["PeakJobMemoryUsed"]?.Value ?? default(uint)),
		 PeakProcessMemoryUsed = (uint) (managementObject.Properties["PeakProcessMemoryUsed"]?.Value ?? default(uint)),
		 ReadOperationCount = (ulong) (managementObject.Properties["ReadOperationCount"]?.Value ?? default(ulong)),
		 ReadTransferCount = (ulong) (managementObject.Properties["ReadTransferCount"]?.Value ?? default(ulong)),
		 ThisPeriodTotalKernelTime = (ulong) (managementObject.Properties["ThisPeriodTotalKernelTime"]?.Value ?? default(ulong)),
		 ThisPeriodTotalUserTime = (ulong) (managementObject.Properties["ThisPeriodTotalUserTime"]?.Value ?? default(ulong)),
		 TotalKernelTime = (ulong) (managementObject.Properties["TotalKernelTime"]?.Value ?? default(ulong)),
		 TotalPageFaultCount = (uint) (managementObject.Properties["TotalPageFaultCount"]?.Value ?? default(uint)),
		 TotalProcesses = (uint) (managementObject.Properties["TotalProcesses"]?.Value ?? default(uint)),
		 TotalTerminatedProcesses = (uint) (managementObject.Properties["TotalTerminatedProcesses"]?.Value ?? default(uint)),
		 TotalUserTime = (ulong) (managementObject.Properties["TotalUserTime"]?.Value ?? default(ulong)),
		 WriteOperationCount = (ulong) (managementObject.Properties["WriteOperationCount"]?.Value ?? default(ulong)),
		 WriteTransferCount = (ulong) (managementObject.Properties["WriteTransferCount"]?.Value ?? default(ulong))
                };
        }
    }
}