using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Bios
{
    /// <summary>
    /// </summary>
    public sealed class SmBiosSmBiosEventlog
    {
		public byte AccessMethod { get; private set; }
		public uint AccessMethodAddress { get; private set; }
		public bool Active { get; private set; }
		public string InstanceName { get; private set; }
		public byte LengthEachLogTypeDesc { get; private set; }
		public byte[] ListLogTypeDesc { get; private set; }
		public byte[] LogArea { get; private set; }
		public ushort LogAreaLength { get; private set; }
		public uint LogChangeToken { get; private set; }
		public ushort LogDataStart { get; private set; }
		public bool LogHeaderDescExists { get; private set; }
		public byte LogHeaderFormat { get; private set; }
		public ushort LogHeaderStart { get; private set; }
		public byte LogStatus { get; private set; }
		public ushort LogTypeDescLength { get; private set; }
		public byte NumberLogTypeDesc { get; private set; }
		public byte Reserved { get; private set; }

        public static IEnumerable<SmBiosSmBiosEventlog> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SmBiosSmBiosEventlog> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SmBiosSmBiosEventlog> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSSmBios_SMBiosEventlog");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SmBiosSmBiosEventlog
                {
                     AccessMethod = (byte) (managementObject.Properties["AccessMethod"]?.Value ?? default(byte)),
		 AccessMethodAddress = (uint) (managementObject.Properties["AccessMethodAddress"]?.Value ?? default(uint)),
		 Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 LengthEachLogTypeDesc = (byte) (managementObject.Properties["LengthEachLogTypeDesc"]?.Value ?? default(byte)),
		 ListLogTypeDesc = (byte[]) (managementObject.Properties["ListLogTypeDesc"]?.Value ?? new byte[0]),
		 LogArea = (byte[]) (managementObject.Properties["LogArea"]?.Value ?? new byte[0]),
		 LogAreaLength = (ushort) (managementObject.Properties["LogAreaLength"]?.Value ?? default(ushort)),
		 LogChangeToken = (uint) (managementObject.Properties["LogChangeToken"]?.Value ?? default(uint)),
		 LogDataStart = (ushort) (managementObject.Properties["LogDataStart"]?.Value ?? default(ushort)),
		 LogHeaderDescExists = (bool) (managementObject.Properties["LogHeaderDescExists"]?.Value ?? default(bool)),
		 LogHeaderFormat = (byte) (managementObject.Properties["LogHeaderFormat"]?.Value ?? default(byte)),
		 LogHeaderStart = (ushort) (managementObject.Properties["LogHeaderStart"]?.Value ?? default(ushort)),
		 LogStatus = (byte) (managementObject.Properties["LogStatus"]?.Value ?? default(byte)),
		 LogTypeDescLength = (ushort) (managementObject.Properties["LogTypeDescLength"]?.Value ?? default(ushort)),
		 NumberLogTypeDesc = (byte) (managementObject.Properties["NumberLogTypeDesc"]?.Value ?? default(byte)),
		 Reserved = (byte) (managementObject.Properties["Reserved"]?.Value ?? default(byte))
                };
        }
    }
}