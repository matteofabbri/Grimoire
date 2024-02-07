using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Bios
{
    /// <summary>
    /// </summary>
    public sealed class SmBiosRawSmBiosTables
    {
		public bool Active { get; private set; }
		public byte DmiRevision { get; private set; }
		public string InstanceName { get; private set; }
		public uint Size { get; private set; }
		public byte[] SmBiosData { get; private set; }
		public byte SmbiosMajorVersion { get; private set; }
		public byte SmbiosMinorVersion { get; private set; }
		public bool Used20CallingMethod { get; private set; }

        public static IEnumerable<SmBiosRawSmBiosTables> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SmBiosRawSmBiosTables> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SmBiosRawSmBiosTables> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSSmBios_RawSMBiosTables");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SmBiosRawSmBiosTables
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 DmiRevision = (byte) (managementObject.Properties["DmiRevision"]?.Value ?? default(byte)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 Size = (uint) (managementObject.Properties["Size"]?.Value ?? default(uint)),
		 SmBiosData = (byte[]) (managementObject.Properties["SMBiosData"]?.Value ?? new byte[0]),
		 SmbiosMajorVersion = (byte) (managementObject.Properties["SmbiosMajorVersion"]?.Value ?? default(byte)),
		 SmbiosMinorVersion = (byte) (managementObject.Properties["SmbiosMinorVersion"]?.Value ?? default(byte)),
		 Used20CallingMethod = (bool) (managementObject.Properties["Used20CallingMethod"]?.Value ?? default(bool))
                };
        }
    }
}