using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware
{
    /// <summary>
    /// </summary>
    public sealed class DmaChannel
    {
		public ushort AddressSize { get; private set; }
		public ushort Availability { get; private set; }
		public bool BurstMode { get; private set; }
		public ushort ByteMode { get; private set; }
		public string Caption { get; private set; }
		public ushort ChannelTiming { get; private set; }
		public string CreationClassName { get; private set; }
		public string CsCreationClassName { get; private set; }
		public string CsName { get; private set; }
		public string Description { get; private set; }
		public uint Channel { get; private set; }
		public DateTime InstallDate { get; private set; }
		public uint MaxTransferSize { get; private set; }
		public string Name { get; private set; }
		public uint Port { get; private set; }
		public string Status { get; private set; }
		public ushort[] TransferWidths { get; private set; }
		public ushort TypeCTiming { get; private set; }
		public ushort WordMode { get; private set; }

        public static IEnumerable<DmaChannel> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<DmaChannel> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<DmaChannel> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_DMAChannel");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new DmaChannel
                {
                     AddressSize = (ushort) (managementObject.Properties["AddressSize"]?.Value ?? default(ushort)),
		 Availability = (ushort) (managementObject.Properties["Availability"]?.Value ?? default(ushort)),
		 BurstMode = (bool) (managementObject.Properties["BurstMode"]?.Value ?? default(bool)),
		 ByteMode = (ushort) (managementObject.Properties["ByteMode"]?.Value ?? default(ushort)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 ChannelTiming = (ushort) (managementObject.Properties["ChannelTiming"]?.Value ?? default(ushort)),
		 CreationClassName = (string) (managementObject.Properties["CreationClassName"]?.Value),
		 CsCreationClassName = (string) (managementObject.Properties["CSCreationClassName"]?.Value),
		 CsName = (string) (managementObject.Properties["CSName"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 Channel = (uint) (managementObject.Properties["DMAChannel"]?.Value ?? default(uint)),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 MaxTransferSize = (uint) (managementObject.Properties["MaxTransferSize"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 Port = (uint) (managementObject.Properties["Port"]?.Value ?? default(uint)),
		 Status = (string) (managementObject.Properties["Status"]?.Value),
		 TransferWidths = (ushort[]) (managementObject.Properties["TransferWidths"]?.Value ?? new ushort[0]),
		 TypeCTiming = (ushort) (managementObject.Properties["TypeCTiming"]?.Value ?? default(ushort)),
		 WordMode = (ushort) (managementObject.Properties["WordMode"]?.Value ?? default(ushort))
                };
        }
    }
}