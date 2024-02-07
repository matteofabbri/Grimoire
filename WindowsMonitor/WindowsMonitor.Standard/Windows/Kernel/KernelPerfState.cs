using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Kernel
{
    /// <summary>
    /// </summary>
    public sealed class KernelPerfState
    {
		public ulong Control { get; private set; }
		public byte DecreaseLevel { get; private set; }
		public uint DecreaseTime { get; private set; }
		public uint Frequency { get; private set; }
		public uint HitCount { get; private set; }
		public byte IncreaseLevel { get; private set; }
		public uint IncreaseTime { get; private set; }
		public byte PercentFrequency { get; private set; }
		public uint Power { get; private set; }
		public uint Reserved1 { get; private set; }
		public ulong Reserved2 { get; private set; }
		public ulong Reserved3 { get; private set; }
		public ulong Status { get; private set; }
		public byte Type { get; private set; }

        public static IEnumerable<KernelPerfState> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<KernelPerfState> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<KernelPerfState> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM KernelPerfState");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new KernelPerfState
                {
                     Control = (ulong) (managementObject.Properties["Control"]?.Value ?? default(ulong)),
		 DecreaseLevel = (byte) (managementObject.Properties["DecreaseLevel"]?.Value ?? default(byte)),
		 DecreaseTime = (uint) (managementObject.Properties["DecreaseTime"]?.Value ?? default(uint)),
		 Frequency = (uint) (managementObject.Properties["Frequency"]?.Value ?? default(uint)),
		 HitCount = (uint) (managementObject.Properties["HitCount"]?.Value ?? default(uint)),
		 IncreaseLevel = (byte) (managementObject.Properties["IncreaseLevel"]?.Value ?? default(byte)),
		 IncreaseTime = (uint) (managementObject.Properties["IncreaseTime"]?.Value ?? default(uint)),
		 PercentFrequency = (byte) (managementObject.Properties["PercentFrequency"]?.Value ?? default(byte)),
		 Power = (uint) (managementObject.Properties["Power"]?.Value ?? default(uint)),
		 Reserved1 = (uint) (managementObject.Properties["Reserved1"]?.Value ?? default(uint)),
		 Reserved2 = (ulong) (managementObject.Properties["Reserved2"]?.Value ?? default(ulong)),
		 Reserved3 = (ulong) (managementObject.Properties["Reserved3"]?.Value ?? default(ulong)),
		 Status = (ulong) (managementObject.Properties["Status"]?.Value ?? default(ulong)),
		 Type = (byte) (managementObject.Properties["Type"]?.Value ?? default(byte))
                };
        }
    }
}