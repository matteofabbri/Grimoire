using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.ShadowCopy
{
    /// <summary>
    /// </summary>
    public sealed class ShadowCopy
    {
		public string Caption { get; private set; }
		public bool ClientAccessible { get; private set; }
		public uint Count { get; private set; }
		public string Description { get; private set; }
		public string DeviceObject { get; private set; }
		public bool Differential { get; private set; }
		public bool ExposedLocally { get; private set; }
		public string ExposedName { get; private set; }
		public string ExposedPath { get; private set; }
		public bool ExposedRemotely { get; private set; }
		public bool HardwareAssisted { get; private set; }
		public string Id { get; private set; }
		public bool Imported { get; private set; }
		public DateTime InstallDate { get; private set; }
		public string Name { get; private set; }
		public bool NoAutoRelease { get; private set; }
		public bool NotSurfaced { get; private set; }
		public bool NoWriters { get; private set; }
		public string OriginatingMachine { get; private set; }
		public bool Persistent { get; private set; }
		public bool Plex { get; private set; }
		public string ProviderId { get; private set; }
		public string ServiceMachine { get; private set; }
		public string SetId { get; private set; }
		public uint State { get; private set; }
		public string Status { get; private set; }
		public bool Transportable { get; private set; }
		public string VolumeName { get; private set; }

        public static IEnumerable<ShadowCopy> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ShadowCopy> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ShadowCopy> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_ShadowCopy");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ShadowCopy
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 ClientAccessible = (bool) (managementObject.Properties["ClientAccessible"]?.Value ?? default(bool)),
		 Count = (uint) (managementObject.Properties["Count"]?.Value ?? default(uint)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DeviceObject = (string) (managementObject.Properties["DeviceObject"]?.Value),
		 Differential = (bool) (managementObject.Properties["Differential"]?.Value ?? default(bool)),
		 ExposedLocally = (bool) (managementObject.Properties["ExposedLocally"]?.Value ?? default(bool)),
		 ExposedName = (string) (managementObject.Properties["ExposedName"]?.Value),
		 ExposedPath = (string) (managementObject.Properties["ExposedPath"]?.Value),
		 ExposedRemotely = (bool) (managementObject.Properties["ExposedRemotely"]?.Value ?? default(bool)),
		 HardwareAssisted = (bool) (managementObject.Properties["HardwareAssisted"]?.Value ?? default(bool)),
		 Id = (string) (managementObject.Properties["ID"]?.Value),
		 Imported = (bool) (managementObject.Properties["Imported"]?.Value ?? default(bool)),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 NoAutoRelease = (bool) (managementObject.Properties["NoAutoRelease"]?.Value ?? default(bool)),
		 NotSurfaced = (bool) (managementObject.Properties["NotSurfaced"]?.Value ?? default(bool)),
		 NoWriters = (bool) (managementObject.Properties["NoWriters"]?.Value ?? default(bool)),
		 OriginatingMachine = (string) (managementObject.Properties["OriginatingMachine"]?.Value),
		 Persistent = (bool) (managementObject.Properties["Persistent"]?.Value ?? default(bool)),
		 Plex = (bool) (managementObject.Properties["Plex"]?.Value ?? default(bool)),
		 ProviderId = (string) (managementObject.Properties["ProviderID"]?.Value),
		 ServiceMachine = (string) (managementObject.Properties["ServiceMachine"]?.Value),
		 SetId = (string) (managementObject.Properties["SetID"]?.Value),
		 State = (uint) (managementObject.Properties["State"]?.Value ?? default(uint)),
		 Status = (string) (managementObject.Properties["Status"]?.Value),
		 Transportable = (bool) (managementObject.Properties["Transportable"]?.Value ?? default(bool)),
		 VolumeName = (string) (managementObject.Properties["VolumeName"]?.Value)
                };
        }
    }
}