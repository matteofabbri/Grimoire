using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Threading
{
    /// <summary>
    /// </summary>
    public sealed class Thread
    {
		public string Caption { get; private set; }
		public string CreationClassName { get; private set; }
		public string CsCreationClassName { get; private set; }
		public string CsName { get; private set; }
		public string Description { get; private set; }
		public ulong ElapsedTime { get; private set; }
		public ushort ExecutionState { get; private set; }
		public string Handle { get; private set; }
		public DateTime InstallDate { get; private set; }
		public ulong KernelModeTime { get; private set; }
		public string Name { get; private set; }
		public string OsCreationClassName { get; private set; }
		public string OsName { get; private set; }
		public uint Priority { get; private set; }
		public uint PriorityBase { get; private set; }
		public string ProcessCreationClassName { get; private set; }
		public string ProcessHandle { get; private set; }
		public uint StartAddress { get; private set; }
		public string Status { get; private set; }
		public uint ThreadState { get; private set; }
		public uint ThreadWaitReason { get; private set; }
		public ulong UserModeTime { get; private set; }

        public static IEnumerable<Thread> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<Thread> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<Thread> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_Thread");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new Thread
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CreationClassName = (string) (managementObject.Properties["CreationClassName"]?.Value),
		 CsCreationClassName = (string) (managementObject.Properties["CSCreationClassName"]?.Value),
		 CsName = (string) (managementObject.Properties["CSName"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 ElapsedTime = (ulong) (managementObject.Properties["ElapsedTime"]?.Value ?? default(ulong)),
		 ExecutionState = (ushort) (managementObject.Properties["ExecutionState"]?.Value ?? default(ushort)),
		 Handle = (string) (managementObject.Properties["Handle"]?.Value),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 KernelModeTime = (ulong) (managementObject.Properties["KernelModeTime"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 OsCreationClassName = (string) (managementObject.Properties["OSCreationClassName"]?.Value),
		 OsName = (string) (managementObject.Properties["OSName"]?.Value),
		 Priority = (uint) (managementObject.Properties["Priority"]?.Value ?? default(uint)),
		 PriorityBase = (uint) (managementObject.Properties["PriorityBase"]?.Value ?? default(uint)),
		 ProcessCreationClassName = (string) (managementObject.Properties["ProcessCreationClassName"]?.Value),
		 ProcessHandle = (string) (managementObject.Properties["ProcessHandle"]?.Value),
		 StartAddress = (uint) (managementObject.Properties["StartAddress"]?.Value ?? default(uint)),
		 Status = (string) (managementObject.Properties["Status"]?.Value),
		 ThreadState = (uint) (managementObject.Properties["ThreadState"]?.Value ?? default(uint)),
		 ThreadWaitReason = (uint) (managementObject.Properties["ThreadWaitReason"]?.Value ?? default(uint)),
		 UserModeTime = (ulong) (managementObject.Properties["UserModeTime"]?.Value ?? default(ulong))
                };
        }
    }
}