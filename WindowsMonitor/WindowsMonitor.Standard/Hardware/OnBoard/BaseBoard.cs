using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.OnBoard
{
    /// <summary>
    /// </summary>
    public sealed class BaseBoard
    {
		public string Caption { get; private set; }
		public string[] ConfigOptions { get; private set; }
		public string CreationClassName { get; private set; }
		public float Depth { get; private set; }
		public string Description { get; private set; }
		public float Height { get; private set; }
		public bool HostingBoard { get; private set; }
		public bool HotSwappable { get; private set; }
		public DateTime InstallDate { get; private set; }
		public string Manufacturer { get; private set; }
		public string Model { get; private set; }
		public string Name { get; private set; }
		public string OtherIdentifyingInfo { get; private set; }
		public string PartNumber { get; private set; }
		public bool PoweredOn { get; private set; }
		public string Product { get; private set; }
		public bool Removable { get; private set; }
		public bool Replaceable { get; private set; }
		public string RequirementsDescription { get; private set; }
		public bool RequiresDaughterBoard { get; private set; }
		public string SerialNumber { get; private set; }
		public string Sku { get; private set; }
		public string SlotLayout { get; private set; }
		public bool SpecialRequirements { get; private set; }
		public string Status { get; private set; }
		public string Tag { get; private set; }
		public string Version { get; private set; }
		public float Weight { get; private set; }
		public float Width { get; private set; }

        public static IEnumerable<BaseBoard> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<BaseBoard> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<BaseBoard> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_BaseBoard");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new BaseBoard
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 ConfigOptions = (string[]) (managementObject.Properties["ConfigOptions"]?.Value ?? new string[0]),
		 CreationClassName = (string) (managementObject.Properties["CreationClassName"]?.Value),
		 Depth = (float) (managementObject.Properties["Depth"]?.Value ?? default(float)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 Height = (float) (managementObject.Properties["Height"]?.Value ?? default(float)),
		 HostingBoard = (bool) (managementObject.Properties["HostingBoard"]?.Value ?? default(bool)),
		 HotSwappable = (bool) (managementObject.Properties["HotSwappable"]?.Value ?? default(bool)),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 Manufacturer = (string) (managementObject.Properties["Manufacturer"]?.Value),
		 Model = (string) (managementObject.Properties["Model"]?.Value),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 OtherIdentifyingInfo = (string) (managementObject.Properties["OtherIdentifyingInfo"]?.Value),
		 PartNumber = (string) (managementObject.Properties["PartNumber"]?.Value),
		 PoweredOn = (bool) (managementObject.Properties["PoweredOn"]?.Value ?? default(bool)),
		 Product = (string) (managementObject.Properties["Product"]?.Value),
		 Removable = (bool) (managementObject.Properties["Removable"]?.Value ?? default(bool)),
		 Replaceable = (bool) (managementObject.Properties["Replaceable"]?.Value ?? default(bool)),
		 RequirementsDescription = (string) (managementObject.Properties["RequirementsDescription"]?.Value),
		 RequiresDaughterBoard = (bool) (managementObject.Properties["RequiresDaughterBoard"]?.Value ?? default(bool)),
		 SerialNumber = (string) (managementObject.Properties["SerialNumber"]?.Value),
		 Sku = (string) (managementObject.Properties["SKU"]?.Value),
		 SlotLayout = (string) (managementObject.Properties["SlotLayout"]?.Value),
		 SpecialRequirements = (bool) (managementObject.Properties["SpecialRequirements"]?.Value ?? default(bool)),
		 Status = (string) (managementObject.Properties["Status"]?.Value),
		 Tag = (string) (managementObject.Properties["Tag"]?.Value),
		 Version = (string) (managementObject.Properties["Version"]?.Value),
		 Weight = (float) (managementObject.Properties["Weight"]?.Value ?? default(float)),
		 Width = (float) (managementObject.Properties["Width"]?.Value ?? default(float))
                };
        }
    }
}