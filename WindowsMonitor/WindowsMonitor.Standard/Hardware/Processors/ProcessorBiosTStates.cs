using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Processors
{
    /// <summary>
    /// </summary>
    public sealed class ProcessorBiosTStates
    {
		public bool Active { get; private set; }
		public byte FadtDutyOffset { get; private set; }
		public byte FadtDutyWidth { get; private set; }
		public string InstanceName { get; private set; }
		public uint NtNumber { get; private set; }
		public dynamic Ptc { get; private set; }
		public uint Reserved1 { get; private set; }
		public uint Reserved2 { get; private set; }
		public ulong Reserved3 { get; private set; }
		public uint Tpc { get; private set; }
		public dynamic Tss { get; private set; }
		public uint StateVersionInUse { get; private set; }

        public static IEnumerable<ProcessorBiosTStates> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ProcessorBiosTStates> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ProcessorBiosTStates> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM ProcessorBiosTStates");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ProcessorBiosTStates
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 FadtDutyOffset = (byte) (managementObject.Properties["FadtDutyOffset"]?.Value ?? default(byte)),
		 FadtDutyWidth = (byte) (managementObject.Properties["FadtDutyWidth"]?.Value ?? default(byte)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 NtNumber = (uint) (managementObject.Properties["NtNumber"]?.Value ?? default(uint)),
		 Ptc = (dynamic) (managementObject.Properties["Ptc"]?.Value ?? default(dynamic)),
		 Reserved1 = (uint) (managementObject.Properties["Reserved1"]?.Value ?? default(uint)),
		 Reserved2 = (uint) (managementObject.Properties["Reserved2"]?.Value ?? default(uint)),
		 Reserved3 = (ulong) (managementObject.Properties["Reserved3"]?.Value ?? default(ulong)),
		 Tpc = (uint) (managementObject.Properties["Tpc"]?.Value ?? default(uint)),
		 Tss = (dynamic) (managementObject.Properties["Tss"]?.Value ?? default(dynamic)),
		 StateVersionInUse = (uint) (managementObject.Properties["TStateVersionInUse"]?.Value ?? default(uint))
                };
        }
    }
}