using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Software
{
    /// <summary>
    /// </summary>
    public sealed class ProcessStopTrace
    {
		public uint ExitStatus { get; private set; }
		public uint ParentProcessId { get; private set; }
		public uint ProcessId { get; private set; }
		public string ProcessName { get; private set; }
		public byte[] SecurityDescriptor { get; private set; }
		public uint SessionId { get; private set; }
		public byte[] Sid { get; private set; }
		public ulong TimeCreated { get; private set; }

        public static IEnumerable<ProcessStopTrace> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ProcessStopTrace> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ProcessStopTrace> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_ProcessStopTrace");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ProcessStopTrace
                {
                     ExitStatus = (uint) (managementObject.Properties["ExitStatus"]?.Value ?? default(uint)),
		 ParentProcessId = (uint) (managementObject.Properties["ParentProcessID"]?.Value ?? default(uint)),
		 ProcessId = (uint) (managementObject.Properties["ProcessID"]?.Value ?? default(uint)),
		 ProcessName = (string) (managementObject.Properties["ProcessName"]?.Value),
		 SecurityDescriptor = (byte[]) (managementObject.Properties["SECURITY_DESCRIPTOR"]?.Value ?? new byte[0]),
		 SessionId = (uint) (managementObject.Properties["SessionID"]?.Value ?? default(uint)),
		 Sid = (byte[]) (managementObject.Properties["Sid"]?.Value ?? new byte[0]),
		 TimeCreated = (ulong) (managementObject.Properties["TIME_CREATED"]?.Value ?? default(ulong))
                };
        }
    }
}