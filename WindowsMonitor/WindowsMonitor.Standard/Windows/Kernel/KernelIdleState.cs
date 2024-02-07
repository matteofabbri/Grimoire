using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Kernel
{
    /// <summary>
    /// </summary>
    public sealed class KernelIdleState
    {
		public uint Context { get; private set; }
		public byte DemotePercent { get; private set; }
		public uint IdleHandler { get; private set; }
		public uint Latency { get; private set; }
		public uint Power { get; private set; }
		public byte PromotePercent { get; private set; }
		public byte Reserved { get; private set; }
		public uint Reserved1 { get; private set; }
		public uint StateFlags { get; private set; }
		public byte StateType { get; private set; }
		public uint TimeCheck { get; private set; }

        public static IEnumerable<KernelIdleState> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<KernelIdleState> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<KernelIdleState> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM KernelIdleState");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new KernelIdleState
                {
                     Context = (uint) (managementObject.Properties["Context"]?.Value ?? default(uint)),
		 DemotePercent = (byte) (managementObject.Properties["DemotePercent"]?.Value ?? default(byte)),
		 IdleHandler = (uint) (managementObject.Properties["IdleHandler"]?.Value ?? default(uint)),
		 Latency = (uint) (managementObject.Properties["Latency"]?.Value ?? default(uint)),
		 Power = (uint) (managementObject.Properties["Power"]?.Value ?? default(uint)),
		 PromotePercent = (byte) (managementObject.Properties["PromotePercent"]?.Value ?? default(byte)),
		 Reserved = (byte) (managementObject.Properties["Reserved"]?.Value ?? default(byte)),
		 Reserved1 = (uint) (managementObject.Properties["Reserved1"]?.Value ?? default(uint)),
		 StateFlags = (uint) (managementObject.Properties["StateFlags"]?.Value ?? default(uint)),
		 StateType = (byte) (managementObject.Properties["StateType"]?.Value ?? default(byte)),
		 TimeCheck = (uint) (managementObject.Properties["TimeCheck"]?.Value ?? default(uint))
                };
        }
    }
}