using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Processors
{
    /// <summary>
    /// </summary>
    public sealed class ProcessorBiosCStates
    {
		public bool Active { get; private set; }
		public dynamic Cst { get; private set; }
		public uint CStateVersionInUse { get; private set; }
		public ushort FadtC2Latency { get; private set; }
		public ushort FadtC3Latency { get; private set; }
		public string InstanceName { get; private set; }
		public uint NtNumber { get; private set; }
		public uint Reserved1 { get; private set; }
		public uint Reserved2 { get; private set; }
		public ulong Reserved3 { get; private set; }

        public static IEnumerable<ProcessorBiosCStates> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ProcessorBiosCStates> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ProcessorBiosCStates> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM ProcessorBiosCStates");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ProcessorBiosCStates
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 Cst = (dynamic) (managementObject.Properties["Cst"]?.Value ?? default(dynamic)),
		 CStateVersionInUse = (uint) (managementObject.Properties["CStateVersionInUse"]?.Value ?? default(uint)),
		 FadtC2Latency = (ushort) (managementObject.Properties["FadtC2Latency"]?.Value ?? default(ushort)),
		 FadtC3Latency = (ushort) (managementObject.Properties["FadtC3Latency"]?.Value ?? default(ushort)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 NtNumber = (uint) (managementObject.Properties["NtNumber"]?.Value ?? default(uint)),
		 Reserved1 = (uint) (managementObject.Properties["Reserved1"]?.Value ?? default(uint)),
		 Reserved2 = (uint) (managementObject.Properties["Reserved2"]?.Value ?? default(uint)),
		 Reserved3 = (ulong) (managementObject.Properties["Reserved3"]?.Value ?? default(ulong))
                };
        }
    }
}