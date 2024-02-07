using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.SystemConfig.V1
{
    /// <summary>
    /// </summary>
    public sealed class Video
    {
		public char[] AdapterString { get; private set; }
		public char[] BiosString { get; private set; }
		public uint BitsPerPixel { get; private set; }
		public char[] ChipType { get; private set; }
		public char[] DacType { get; private set; }
		public char[] DeviceId { get; private set; }
		public uint Flags { get; private set; }
		public uint MemorySize { get; private set; }
		public uint StateFlags { get; private set; }
		public uint VRefresh { get; private set; }
		public uint XResolution { get; private set; }
		public uint YResolution { get; private set; }

        public static IEnumerable<Video> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<Video> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<Video> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM SystemConfig_V1_Video");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new Video
                {
                     AdapterString = (char[]) (managementObject.Properties["AdapterString"]?.Value ?? new char[0]),
		 BiosString = (char[]) (managementObject.Properties["BiosString"]?.Value ?? new char[0]),
		 BitsPerPixel = (uint) (managementObject.Properties["BitsPerPixel"]?.Value ?? default(uint)),
		 ChipType = (char[]) (managementObject.Properties["ChipType"]?.Value ?? new char[0]),
		 DacType = (char[]) (managementObject.Properties["DACType"]?.Value ?? new char[0]),
		 DeviceId = (char[]) (managementObject.Properties["DeviceId"]?.Value ?? new char[0]),
		 Flags = (uint) (managementObject.Properties["Flags"]?.Value ?? default(uint)),
		 MemorySize = (uint) (managementObject.Properties["MemorySize"]?.Value ?? default(uint)),
		 StateFlags = (uint) (managementObject.Properties["StateFlags"]?.Value ?? default(uint)),
		 VRefresh = (uint) (managementObject.Properties["VRefresh"]?.Value ?? default(uint)),
		 XResolution = (uint) (managementObject.Properties["XResolution"]?.Value ?? default(uint)),
		 YResolution = (uint) (managementObject.Properties["YResolution"]?.Value ?? default(uint))
                };
        }
    }
}