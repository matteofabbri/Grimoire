using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.SerialPort
{
    /// <summary>
    /// </summary>
    public sealed class SerialInterface
    {
		public ushort AccessState { get; private set; }
		public string Antecedent { get; private set; }
		public string Dependent { get; private set; }
		public ushort FlowControlInfo { get; private set; }
		public uint NegotiatedDataWidth { get; private set; }
		public ulong NegotiatedSpeed { get; private set; }
		public uint NumberOfHardResets { get; private set; }
		public uint NumberOfSoftResets { get; private set; }
		public ushort NumberOfStopBits { get; private set; }
		public ushort ParityInfo { get; private set; }

        public static IEnumerable<SerialInterface> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SerialInterface> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SerialInterface> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_SerialInterface");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SerialInterface
                {
                     AccessState = (ushort) (managementObject.Properties["AccessState"]?.Value ?? default(ushort)),
		 Antecedent = (string) (managementObject.Properties["Antecedent"]?.Value ?? default(string)),
		 Dependent = (string) (managementObject.Properties["Dependent"]?.Value ?? default(string)),
		 FlowControlInfo = (ushort) (managementObject.Properties["FlowControlInfo"]?.Value ?? default(ushort)),
		 NegotiatedDataWidth = (uint) (managementObject.Properties["NegotiatedDataWidth"]?.Value ?? default(uint)),
		 NegotiatedSpeed = (ulong) (managementObject.Properties["NegotiatedSpeed"]?.Value ?? default(ulong)),
		 NumberOfHardResets = (uint) (managementObject.Properties["NumberOfHardResets"]?.Value ?? default(uint)),
		 NumberOfSoftResets = (uint) (managementObject.Properties["NumberOfSoftResets"]?.Value ?? default(uint)),
		 NumberOfStopBits = (ushort) (managementObject.Properties["NumberOfStopBits"]?.Value ?? default(ushort)),
		 ParityInfo = (ushort) (managementObject.Properties["ParityInfo"]?.Value ?? default(ushort))
                };
        }
    }
}