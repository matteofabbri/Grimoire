using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.ParallelPort
{
    /// <summary>
    /// </summary>
    public sealed class ParallelDeviceBytesTransferred
    {
		public bool Active { get; private set; }
		public long BoundedEcpReadCount { get; private set; }
		public long BoundedEcpWriteCount { get; private set; }
		public long ByteReadCount { get; private set; }
		public long ChannelNibbleReadCount { get; private set; }
		public uint Flags1 { get; private set; }
		public uint Flags2 { get; private set; }
		public long HwEcpReadCount { get; private set; }
		public long HwEcpWriteCount { get; private set; }
		public long HwEppReadCount { get; private set; }
		public long HwEppWriteCount { get; private set; }
		public string InstanceName { get; private set; }
		public long NibbleReadCount { get; private set; }
		public uint[] Spare { get; private set; }
		public long SppWriteCount { get; private set; }
		public long SwEcpReadCount { get; private set; }
		public long SwEcpWriteCount { get; private set; }
		public long SwEppReadCount { get; private set; }
		public long SwEppWriteCount { get; private set; }

        public static IEnumerable<ParallelDeviceBytesTransferred> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ParallelDeviceBytesTransferred> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ParallelDeviceBytesTransferred> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSParallel_DeviceBytesTransferred");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ParallelDeviceBytesTransferred
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 BoundedEcpReadCount = (long) (managementObject.Properties["BoundedEcpReadCount"]?.Value ?? default(long)),
		 BoundedEcpWriteCount = (long) (managementObject.Properties["BoundedEcpWriteCount"]?.Value ?? default(long)),
		 ByteReadCount = (long) (managementObject.Properties["ByteReadCount"]?.Value ?? default(long)),
		 ChannelNibbleReadCount = (long) (managementObject.Properties["ChannelNibbleReadCount"]?.Value ?? default(long)),
		 Flags1 = (uint) (managementObject.Properties["Flags1"]?.Value ?? default(uint)),
		 Flags2 = (uint) (managementObject.Properties["Flags2"]?.Value ?? default(uint)),
		 HwEcpReadCount = (long) (managementObject.Properties["HwEcpReadCount"]?.Value ?? default(long)),
		 HwEcpWriteCount = (long) (managementObject.Properties["HwEcpWriteCount"]?.Value ?? default(long)),
		 HwEppReadCount = (long) (managementObject.Properties["HwEppReadCount"]?.Value ?? default(long)),
		 HwEppWriteCount = (long) (managementObject.Properties["HwEppWriteCount"]?.Value ?? default(long)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 NibbleReadCount = (long) (managementObject.Properties["NibbleReadCount"]?.Value ?? default(long)),
		 Spare = (uint[]) (managementObject.Properties["spare"]?.Value ?? new uint[0]),
		 SppWriteCount = (long) (managementObject.Properties["SppWriteCount"]?.Value ?? default(long)),
		 SwEcpReadCount = (long) (managementObject.Properties["SwEcpReadCount"]?.Value ?? default(long)),
		 SwEcpWriteCount = (long) (managementObject.Properties["SwEcpWriteCount"]?.Value ?? default(long)),
		 SwEppReadCount = (long) (managementObject.Properties["SwEppReadCount"]?.Value ?? default(long)),
		 SwEppWriteCount = (long) (managementObject.Properties["SwEppWriteCount"]?.Value ?? default(long))
                };
        }
    }
}