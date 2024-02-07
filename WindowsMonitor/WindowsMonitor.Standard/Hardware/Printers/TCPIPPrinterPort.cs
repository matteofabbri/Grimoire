using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Printers
{
    /// <summary>
    /// </summary>
    public sealed class TcpipPrinterPort
    {
		public bool ByteCount { get; private set; }
		public string Caption { get; private set; }
		public string CreationClassName { get; private set; }
		public string Description { get; private set; }
		public string HostAddress { get; private set; }
		public DateTime InstallDate { get; private set; }
		public string Name { get; private set; }
		public uint PortNumber { get; private set; }
		public uint Protocol { get; private set; }
		public string Queue { get; private set; }
		public string SnmpCommunity { get; private set; }
		public uint SnmpDevIndex { get; private set; }
		public bool SnmpEnabled { get; private set; }
		public string Status { get; private set; }
		public string SystemCreationClassName { get; private set; }
		public string SystemName { get; private set; }
		public uint Type { get; private set; }

        public static IEnumerable<TcpipPrinterPort> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<TcpipPrinterPort> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<TcpipPrinterPort> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_TCPIPPrinterPort");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new TcpipPrinterPort
                {
                     ByteCount = (bool) (managementObject.Properties["ByteCount"]?.Value ?? default(bool)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CreationClassName = (string) (managementObject.Properties["CreationClassName"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 HostAddress = (string) (managementObject.Properties["HostAddress"]?.Value),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 PortNumber = (uint) (managementObject.Properties["PortNumber"]?.Value ?? default(uint)),
		 Protocol = (uint) (managementObject.Properties["Protocol"]?.Value ?? default(uint)),
		 Queue = (string) (managementObject.Properties["Queue"]?.Value),
		 SnmpCommunity = (string) (managementObject.Properties["SNMPCommunity"]?.Value),
		 SnmpDevIndex = (uint) (managementObject.Properties["SNMPDevIndex"]?.Value ?? default(uint)),
		 SnmpEnabled = (bool) (managementObject.Properties["SNMPEnabled"]?.Value ?? default(bool)),
		 Status = (string) (managementObject.Properties["Status"]?.Value),
		 SystemCreationClassName = (string) (managementObject.Properties["SystemCreationClassName"]?.Value),
		 SystemName = (string) (managementObject.Properties["SystemName"]?.Value),
		 Type = (uint) (managementObject.Properties["Type"]?.Value ?? default(uint))
                };
        }
    }
}