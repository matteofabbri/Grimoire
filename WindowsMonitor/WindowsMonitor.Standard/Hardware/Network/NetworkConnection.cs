using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network
{
    /// <summary>
    /// </summary>
    public sealed class NetworkConnection
    {
		public uint AccessMask { get; private set; }
		public string Caption { get; private set; }
		public string Comment { get; private set; }
		public string ConnectionState { get; private set; }
		public string ConnectionType { get; private set; }
		public string Description { get; private set; }
		public string DisplayType { get; private set; }
		public DateTime InstallDate { get; private set; }
		public string LocalName { get; private set; }
		public string Name { get; private set; }
		public bool Persistent { get; private set; }
		public string ProviderName { get; private set; }
		public string RemoteName { get; private set; }
		public string RemotePath { get; private set; }
		public string ResourceType { get; private set; }
		public string Status { get; private set; }
		public string UserName { get; private set; }

        public static IEnumerable<NetworkConnection> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<NetworkConnection> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<NetworkConnection> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_NetworkConnection");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new NetworkConnection
                {
                     AccessMask = (uint) (managementObject.Properties["AccessMask"]?.Value ?? default(uint)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Comment = (string) (managementObject.Properties["Comment"]?.Value),
		 ConnectionState = (string) (managementObject.Properties["ConnectionState"]?.Value),
		 ConnectionType = (string) (managementObject.Properties["ConnectionType"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DisplayType = (string) (managementObject.Properties["DisplayType"]?.Value),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 LocalName = (string) (managementObject.Properties["LocalName"]?.Value),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 Persistent = (bool) (managementObject.Properties["Persistent"]?.Value ?? default(bool)),
		 ProviderName = (string) (managementObject.Properties["ProviderName"]?.Value),
		 RemoteName = (string) (managementObject.Properties["RemoteName"]?.Value),
		 RemotePath = (string) (managementObject.Properties["RemotePath"]?.Value),
		 ResourceType = (string) (managementObject.Properties["ResourceType"]?.Value),
		 Status = (string) (managementObject.Properties["Status"]?.Value),
		 UserName = (string) (managementObject.Properties["UserName"]?.Value)
                };
        }
    }
}