using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows
{
    /// <summary>
    /// </summary>
    public sealed class Process
    {
		public string Caption { get; private set; }
		public string CreationClassName { get; private set; }
		public DateTime CreationDate { get; private set; }
		public string CsCreationClassName { get; private set; }
		public string CsName { get; private set; }
		public string Description { get; private set; }
		public ushort ExecutionState { get; private set; }
		public string Handle { get; private set; }
		public DateTime InstallDate { get; private set; }
		public ulong KernelModeTime { get; private set; }
		public string Name { get; private set; }
		public string OsCreationClassName { get; private set; }
		public string OsName { get; private set; }
		public uint Priority { get; private set; }
		public string Status { get; private set; }
		public DateTime TerminationDate { get; private set; }
		public ulong UserModeTime { get; private set; }
		public ulong WorkingSetSize { get; private set; }

        public static IEnumerable<Process> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<Process> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<Process> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_Process");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new Process
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CreationClassName = (string) (managementObject.Properties["CreationClassName"]?.Value),
		 CreationDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["CreationDate"]?.Value as string ?? "00010102000000.000000+060"),
		 CsCreationClassName = (string) (managementObject.Properties["CSCreationClassName"]?.Value),
		 CsName = (string) (managementObject.Properties["CSName"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 ExecutionState = (ushort) (managementObject.Properties["ExecutionState"]?.Value ?? default(ushort)),
		 Handle = (string) (managementObject.Properties["Handle"]?.Value),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 KernelModeTime = (ulong) (managementObject.Properties["KernelModeTime"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 OsCreationClassName = (string) (managementObject.Properties["OSCreationClassName"]?.Value),
		 OsName = (string) (managementObject.Properties["OSName"]?.Value),
		 Priority = (uint) (managementObject.Properties["Priority"]?.Value ?? default(uint)),
		 Status = (string) (managementObject.Properties["Status"]?.Value),
		 TerminationDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["TerminationDate"]?.Value as string ?? "00010102000000.000000+060"),
		 UserModeTime = (ulong) (managementObject.Properties["UserModeTime"]?.Value ?? default(ulong)),
		 WorkingSetSize = (ulong) (managementObject.Properties["WorkingSetSize"]?.Value ?? default(ulong))
                };
        }
    }
}