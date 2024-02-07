using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Threading
{
    /// <summary>
    /// </summary>
    public sealed class ThreadTrace
    {
		public uint ProcessId { get; private set; }
		public byte[] SecurityDescriptor { get; private set; }
		public uint ThreadId { get; private set; }
		public ulong TimeCreated { get; private set; }

        public static IEnumerable<ThreadTrace> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ThreadTrace> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ThreadTrace> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_ThreadTrace");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ThreadTrace
                {
                     ProcessId = (uint) (managementObject.Properties["ProcessID"]?.Value ?? default(uint)),
		 SecurityDescriptor = (byte[]) (managementObject.Properties["SECURITY_DESCRIPTOR"]?.Value ?? new byte[0]),
		 ThreadId = (uint) (managementObject.Properties["ThreadID"]?.Value ?? default(uint)),
		 TimeCreated = (ulong) (managementObject.Properties["TIME_CREATED"]?.Value ?? default(ulong))
                };
        }
    }
}