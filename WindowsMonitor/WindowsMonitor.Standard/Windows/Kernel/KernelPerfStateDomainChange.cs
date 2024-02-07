using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Kernel
{
    /// <summary>
    /// </summary>
    public sealed class KernelPerfStateDomainChange
    {
		public bool Active { get; private set; }
		public string InstanceName { get; private set; }
		public uint Latency { get; private set; }
		public ulong Processors { get; private set; }
		public byte[] SecurityDescriptor { get; private set; }
		public uint Speed { get; private set; }
		public uint State { get; private set; }
		public ulong TimeCreated { get; private set; }

        public static IEnumerable<KernelPerfStateDomainChange> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<KernelPerfStateDomainChange> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<KernelPerfStateDomainChange> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM KernelPerfStateDomainChange");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new KernelPerfStateDomainChange
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 Latency = (uint) (managementObject.Properties["Latency"]?.Value ?? default(uint)),
		 Processors = (ulong) (managementObject.Properties["Processors"]?.Value ?? default(ulong)),
		 SecurityDescriptor = (byte[]) (managementObject.Properties["SECURITY_DESCRIPTOR"]?.Value ?? new byte[0]),
		 Speed = (uint) (managementObject.Properties["Speed"]?.Value ?? default(uint)),
		 State = (uint) (managementObject.Properties["State"]?.Value ?? default(uint)),
		 TimeCreated = (ulong) (managementObject.Properties["TIME_CREATED"]?.Value ?? default(ulong))
                };
        }
    }
}