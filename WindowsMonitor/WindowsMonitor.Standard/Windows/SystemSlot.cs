using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows
{
    /// <summary>
    /// </summary>
    public sealed class SystemSlot
    {
		public uint BusNumber { get; private set; }
		public string Caption { get; private set; }
		public string ConnectorPinout { get; private set; }
		public ushort[] ConnectorType { get; private set; }
		public string CreationClassName { get; private set; }
		public ushort CurrentUsage { get; private set; }
		public string Description { get; private set; }
		public uint DeviceNumber { get; private set; }
		public uint FunctionNumber { get; private set; }
		public float HeightAllowed { get; private set; }
		public DateTime InstallDate { get; private set; }
		public float LengthAllowed { get; private set; }
		public string Manufacturer { get; private set; }
		public ushort MaxDataWidth { get; private set; }
		public string Model { get; private set; }
		public string Name { get; private set; }
		public ushort Number { get; private set; }
		public string OtherIdentifyingInfo { get; private set; }
		public string PartNumber { get; private set; }
		public bool PmeSignal { get; private set; }
		public bool PoweredOn { get; private set; }
		public string PurposeDescription { get; private set; }
		public uint SegmentGroupNumber { get; private set; }
		public string SerialNumber { get; private set; }
		public bool Shared { get; private set; }
		public string Sku { get; private set; }
		public string SlotDesignation { get; private set; }
		public bool SpecialPurpose { get; private set; }
		public string Status { get; private set; }
		public bool SupportsHotPlug { get; private set; }
		public string Tag { get; private set; }
		public uint ThermalRating { get; private set; }
		public ushort[] VccMixedVoltageSupport { get; private set; }
		public string Version { get; private set; }
		public ushort[] VppMixedVoltageSupport { get; private set; }

        public static IEnumerable<SystemSlot> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SystemSlot> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SystemSlot> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_SystemSlot");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SystemSlot
                {
                     BusNumber = (uint) (managementObject.Properties["BusNumber"]?.Value ?? default(uint)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 ConnectorPinout = (string) (managementObject.Properties["ConnectorPinout"]?.Value),
		 ConnectorType = (ushort[]) (managementObject.Properties["ConnectorType"]?.Value ?? new ushort[0]),
		 CreationClassName = (string) (managementObject.Properties["CreationClassName"]?.Value),
		 CurrentUsage = (ushort) (managementObject.Properties["CurrentUsage"]?.Value ?? default(ushort)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DeviceNumber = (uint) (managementObject.Properties["DeviceNumber"]?.Value ?? default(uint)),
		 FunctionNumber = (uint) (managementObject.Properties["FunctionNumber"]?.Value ?? default(uint)),
		 HeightAllowed = (float) (managementObject.Properties["HeightAllowed"]?.Value ?? default(float)),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 LengthAllowed = (float) (managementObject.Properties["LengthAllowed"]?.Value ?? default(float)),
		 Manufacturer = (string) (managementObject.Properties["Manufacturer"]?.Value),
		 MaxDataWidth = (ushort) (managementObject.Properties["MaxDataWidth"]?.Value ?? default(ushort)),
		 Model = (string) (managementObject.Properties["Model"]?.Value),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 Number = (ushort) (managementObject.Properties["Number"]?.Value ?? default(ushort)),
		 OtherIdentifyingInfo = (string) (managementObject.Properties["OtherIdentifyingInfo"]?.Value),
		 PartNumber = (string) (managementObject.Properties["PartNumber"]?.Value),
		 PmeSignal = (bool) (managementObject.Properties["PMESignal"]?.Value ?? default(bool)),
		 PoweredOn = (bool) (managementObject.Properties["PoweredOn"]?.Value ?? default(bool)),
		 PurposeDescription = (string) (managementObject.Properties["PurposeDescription"]?.Value),
		 SegmentGroupNumber = (uint) (managementObject.Properties["SegmentGroupNumber"]?.Value ?? default(uint)),
		 SerialNumber = (string) (managementObject.Properties["SerialNumber"]?.Value),
		 Shared = (bool) (managementObject.Properties["Shared"]?.Value ?? default(bool)),
		 Sku = (string) (managementObject.Properties["SKU"]?.Value),
		 SlotDesignation = (string) (managementObject.Properties["SlotDesignation"]?.Value),
		 SpecialPurpose = (bool) (managementObject.Properties["SpecialPurpose"]?.Value ?? default(bool)),
		 Status = (string) (managementObject.Properties["Status"]?.Value),
		 SupportsHotPlug = (bool) (managementObject.Properties["SupportsHotPlug"]?.Value ?? default(bool)),
		 Tag = (string) (managementObject.Properties["Tag"]?.Value),
		 ThermalRating = (uint) (managementObject.Properties["ThermalRating"]?.Value ?? default(uint)),
		 VccMixedVoltageSupport = (ushort[]) (managementObject.Properties["VccMixedVoltageSupport"]?.Value ?? new ushort[0]),
		 Version = (string) (managementObject.Properties["Version"]?.Value),
		 VppMixedVoltageSupport = (ushort[]) (managementObject.Properties["VppMixedVoltageSupport"]?.Value ?? new ushort[0])
                };
        }
    }
}