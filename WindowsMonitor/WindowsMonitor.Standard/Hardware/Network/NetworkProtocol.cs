using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network
{
    /// <summary>
    /// </summary>
    public sealed class NetworkProtocol
    {
		public string Caption { get; private set; }
		public bool ConnectionlessService { get; private set; }
		public string Description { get; private set; }
		public bool GuaranteesDelivery { get; private set; }
		public bool GuaranteesSequencing { get; private set; }
		public DateTime InstallDate { get; private set; }
		public uint MaximumAddressSize { get; private set; }
		public uint MaximumMessageSize { get; private set; }
		public bool MessageOriented { get; private set; }
		public uint MinimumAddressSize { get; private set; }
		public string Name { get; private set; }
		public bool PseudoStreamOriented { get; private set; }
		public string Status { get; private set; }
		public bool SupportsBroadcasting { get; private set; }
		public bool SupportsConnectData { get; private set; }
		public bool SupportsDisconnectData { get; private set; }
		public bool SupportsEncryption { get; private set; }
		public bool SupportsExpeditedData { get; private set; }
		public bool SupportsFragmentation { get; private set; }
		public bool SupportsGracefulClosing { get; private set; }
		public bool SupportsGuaranteedBandwidth { get; private set; }
		public bool SupportsMulticasting { get; private set; }
		public bool SupportsQualityofService { get; private set; }

        public static IEnumerable<NetworkProtocol> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<NetworkProtocol> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<NetworkProtocol> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_NetworkProtocol");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new NetworkProtocol
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 ConnectionlessService = (bool) (managementObject.Properties["ConnectionlessService"]?.Value ?? default(bool)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 GuaranteesDelivery = (bool) (managementObject.Properties["GuaranteesDelivery"]?.Value ?? default(bool)),
		 GuaranteesSequencing = (bool) (managementObject.Properties["GuaranteesSequencing"]?.Value ?? default(bool)),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 MaximumAddressSize = (uint) (managementObject.Properties["MaximumAddressSize"]?.Value ?? default(uint)),
		 MaximumMessageSize = (uint) (managementObject.Properties["MaximumMessageSize"]?.Value ?? default(uint)),
		 MessageOriented = (bool) (managementObject.Properties["MessageOriented"]?.Value ?? default(bool)),
		 MinimumAddressSize = (uint) (managementObject.Properties["MinimumAddressSize"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 PseudoStreamOriented = (bool) (managementObject.Properties["PseudoStreamOriented"]?.Value ?? default(bool)),
		 Status = (string) (managementObject.Properties["Status"]?.Value),
		 SupportsBroadcasting = (bool) (managementObject.Properties["SupportsBroadcasting"]?.Value ?? default(bool)),
		 SupportsConnectData = (bool) (managementObject.Properties["SupportsConnectData"]?.Value ?? default(bool)),
		 SupportsDisconnectData = (bool) (managementObject.Properties["SupportsDisconnectData"]?.Value ?? default(bool)),
		 SupportsEncryption = (bool) (managementObject.Properties["SupportsEncryption"]?.Value ?? default(bool)),
		 SupportsExpeditedData = (bool) (managementObject.Properties["SupportsExpeditedData"]?.Value ?? default(bool)),
		 SupportsFragmentation = (bool) (managementObject.Properties["SupportsFragmentation"]?.Value ?? default(bool)),
		 SupportsGracefulClosing = (bool) (managementObject.Properties["SupportsGracefulClosing"]?.Value ?? default(bool)),
		 SupportsGuaranteedBandwidth = (bool) (managementObject.Properties["SupportsGuaranteedBandwidth"]?.Value ?? default(bool)),
		 SupportsMulticasting = (bool) (managementObject.Properties["SupportsMulticasting"]?.Value ?? default(bool)),
		 SupportsQualityofService = (bool) (managementObject.Properties["SupportsQualityofService"]?.Value ?? default(bool))
                };
        }
    }
}