using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Processors
{
    /// <summary>
    /// </summary>
    public sealed class ProcessorBiosInfo
    {
		public bool Active { get; private set; }
		public uint ApicId { get; private set; }
		public string InstanceName { get; private set; }
		public uint NtNumber { get; private set; }
		public uint PBlk { get; private set; }
		public uint PBlkLen { get; private set; }
		public dynamic Pct { get; private set; }
		public uint ProcessorId { get; private set; }
		public dynamic Pss { get; private set; }

        public static IEnumerable<ProcessorBiosInfo> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ProcessorBiosInfo> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ProcessorBiosInfo> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM ProcessorBiosInfo");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ProcessorBiosInfo
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 ApicId = (uint) (managementObject.Properties["ApicId"]?.Value ?? default(uint)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 NtNumber = (uint) (managementObject.Properties["NtNumber"]?.Value ?? default(uint)),
		 PBlk = (uint) (managementObject.Properties["PBlk"]?.Value ?? default(uint)),
		 PBlkLen = (uint) (managementObject.Properties["PBlkLen"]?.Value ?? default(uint)),
		 Pct = (dynamic) (managementObject.Properties["Pct"]?.Value ?? default(dynamic)),
		 ProcessorId = (uint) (managementObject.Properties["ProcessorId"]?.Value ?? default(uint)),
		 Pss = (dynamic) (managementObject.Properties["Pss"]?.Value ?? default(dynamic))
                };
        }
    }
}