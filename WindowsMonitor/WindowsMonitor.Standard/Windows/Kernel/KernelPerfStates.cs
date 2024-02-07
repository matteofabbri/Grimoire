using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Kernel
{
    /// <summary>
    /// </summary>
    public sealed class KernelPerfStates
    {
		public bool Active { get; private set; }
		public byte BusyAdjThreshold { get; private set; }
		public uint Count { get; private set; }
		public uint CurrentState { get; private set; }
		public uint FeedbackHandler { get; private set; }
		public string InstanceName { get; private set; }
		public uint LowestPerfState { get; private set; }
		public uint MaxFrequency { get; private set; }
		public uint MaxPerfState { get; private set; }
		public uint MinPerfState { get; private set; }
		public byte PolicyType { get; private set; }
		public uint PStateContext { get; private set; }
		public uint PStateHandler { get; private set; }
		public byte Reserved { get; private set; }
		public uint Reserved1 { get; private set; }
		public ulong Reserved2 { get; private set; }
		public dynamic[] State { get; private set; }
		public ulong TargetProcessors { get; private set; }
		public uint ThermalConstraint { get; private set; }
		public uint TimerInterval { get; private set; }
		public uint StateContext { get; private set; }
		public uint StateHandler { get; private set; }
		public byte Type { get; private set; }

        public static IEnumerable<KernelPerfStates> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<KernelPerfStates> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<KernelPerfStates> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM KernelPerfStates");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new KernelPerfStates
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 BusyAdjThreshold = (byte) (managementObject.Properties["BusyAdjThreshold"]?.Value ?? default(byte)),
		 Count = (uint) (managementObject.Properties["Count"]?.Value ?? default(uint)),
		 CurrentState = (uint) (managementObject.Properties["CurrentState"]?.Value ?? default(uint)),
		 FeedbackHandler = (uint) (managementObject.Properties["FeedbackHandler"]?.Value ?? default(uint)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 LowestPerfState = (uint) (managementObject.Properties["LowestPerfState"]?.Value ?? default(uint)),
		 MaxFrequency = (uint) (managementObject.Properties["MaxFrequency"]?.Value ?? default(uint)),
		 MaxPerfState = (uint) (managementObject.Properties["MaxPerfState"]?.Value ?? default(uint)),
		 MinPerfState = (uint) (managementObject.Properties["MinPerfState"]?.Value ?? default(uint)),
		 PolicyType = (byte) (managementObject.Properties["PolicyType"]?.Value ?? default(byte)),
		 PStateContext = (uint) (managementObject.Properties["PStateContext"]?.Value ?? default(uint)),
		 PStateHandler = (uint) (managementObject.Properties["PStateHandler"]?.Value ?? default(uint)),
		 Reserved = (byte) (managementObject.Properties["Reserved"]?.Value ?? default(byte)),
		 Reserved1 = (uint) (managementObject.Properties["Reserved1"]?.Value ?? default(uint)),
		 Reserved2 = (ulong) (managementObject.Properties["Reserved2"]?.Value ?? default(ulong)),
		 State = (dynamic[]) (managementObject.Properties["State"]?.Value ?? new dynamic[0]),
		 TargetProcessors = (ulong) (managementObject.Properties["TargetProcessors"]?.Value ?? default(ulong)),
		 ThermalConstraint = (uint) (managementObject.Properties["ThermalConstraint"]?.Value ?? default(uint)),
		 TimerInterval = (uint) (managementObject.Properties["TimerInterval"]?.Value ?? default(uint)),
		 StateContext = (uint) (managementObject.Properties["TStateContext"]?.Value ?? default(uint)),
		 StateHandler = (uint) (managementObject.Properties["TStateHandler"]?.Value ?? default(uint)),
		 Type = (byte) (managementObject.Properties["Type"]?.Value ?? default(byte))
                };
        }
    }
}