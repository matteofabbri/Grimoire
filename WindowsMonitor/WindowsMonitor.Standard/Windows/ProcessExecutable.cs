using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows
{
    /// <summary>
    /// </summary>
    public sealed class ProcessExecutable
    {
		public string Antecedent { get; private set; }
		public ulong BaseAddress { get; private set; }
		public string Dependent { get; private set; }
		public uint GlobalProcessCount { get; private set; }
		public uint ModuleInstance { get; private set; }
		public uint ProcessCount { get; private set; }

        public static IEnumerable<ProcessExecutable> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ProcessExecutable> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ProcessExecutable> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_ProcessExecutable");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ProcessExecutable
                {
                     Antecedent =  (managementObject.Properties["Antecedent"]?.Value?.ToString()),
		 BaseAddress = (ulong) (managementObject.Properties["BaseAddress"]?.Value ?? default(ulong)),
		 Dependent =  (managementObject.Properties["Dependent"]?.Value?.ToString()),
		 GlobalProcessCount = (uint) (managementObject.Properties["GlobalProcessCount"]?.Value ?? default(uint)),
		 ModuleInstance = (uint) (managementObject.Properties["ModuleInstance"]?.Value ?? default(uint)),
		 ProcessCount = (uint) (managementObject.Properties["ProcessCount"]?.Value ?? default(uint))
                };
        }
    }
}