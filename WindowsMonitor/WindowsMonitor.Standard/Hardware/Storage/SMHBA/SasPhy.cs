using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.SMHBA
{
    /// <summary>
    /// </summary>
    public sealed class SasPhy
    {
		public byte[] DomainPortWwn { get; private set; }
		public uint HardwareMaxLinkRate { get; private set; }
		public uint HardwareMinLinkRate { get; private set; }
		public uint NegotiatedLinkRate { get; private set; }
		public byte PhyIdentifier { get; private set; }
		public uint ProgrammedMaxLinkRate { get; private set; }
		public uint ProgrammedMinLinkRate { get; private set; }

        public static IEnumerable<SasPhy> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SasPhy> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SasPhy> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MS_SMHBA_SAS_PHY");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SasPhy
                {
                     DomainPortWwn = (byte[]) (managementObject.Properties["domainPortWWN"]?.Value ?? new byte[0]),
		 HardwareMaxLinkRate = (uint) (managementObject.Properties["HardwareMaxLinkRate"]?.Value ?? default(uint)),
		 HardwareMinLinkRate = (uint) (managementObject.Properties["HardwareMinLinkRate"]?.Value ?? default(uint)),
		 NegotiatedLinkRate = (uint) (managementObject.Properties["NegotiatedLinkRate"]?.Value ?? default(uint)),
		 PhyIdentifier = (byte) (managementObject.Properties["PhyIdentifier"]?.Value ?? default(byte)),
		 ProgrammedMaxLinkRate = (uint) (managementObject.Properties["ProgrammedMaxLinkRate"]?.Value ?? default(uint)),
		 ProgrammedMinLinkRate = (uint) (managementObject.Properties["ProgrammedMinLinkRate"]?.Value ?? default(uint))
                };
        }
    }
}