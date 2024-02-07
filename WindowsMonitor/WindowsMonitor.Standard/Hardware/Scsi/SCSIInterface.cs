using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Scsi
{
    /// <summary>
    /// </summary>
    public sealed class ScsiInterface
    {
		public ushort AccessState { get; private set; }
		public string Antecedent { get; private set; }
		public string Dependent { get; private set; }
		public uint NegotiatedDataWidth { get; private set; }
		public ulong NegotiatedSpeed { get; private set; }
		public uint NumberOfHardResets { get; private set; }
		public uint NumberOfSoftResets { get; private set; }
		public uint ScsiRetries { get; private set; }
		public uint ScsiTimeouts { get; private set; }

        public static IEnumerable<ScsiInterface> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ScsiInterface> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ScsiInterface> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_SCSIInterface");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ScsiInterface
                {
                     AccessState = (ushort) (managementObject.Properties["AccessState"]?.Value ?? default(ushort)),
		 Antecedent = (string) (managementObject.Properties["Antecedent"]?.Value ?? default(string)),
		 Dependent = (string) (managementObject.Properties["Dependent"]?.Value ?? default(string)),
		 NegotiatedDataWidth = (uint) (managementObject.Properties["NegotiatedDataWidth"]?.Value ?? default(uint)),
		 NegotiatedSpeed = (ulong) (managementObject.Properties["NegotiatedSpeed"]?.Value ?? default(ulong)),
		 NumberOfHardResets = (uint) (managementObject.Properties["NumberOfHardResets"]?.Value ?? default(uint)),
		 NumberOfSoftResets = (uint) (managementObject.Properties["NumberOfSoftResets"]?.Value ?? default(uint)),
		 ScsiRetries = (uint) (managementObject.Properties["SCSIRetries"]?.Value ?? default(uint)),
		 ScsiTimeouts = (uint) (managementObject.Properties["SCSITimeouts"]?.Value ?? default(uint))
                };
        }
    }
}