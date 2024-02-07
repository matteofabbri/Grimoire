using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.MSStorageDriver
{
    /// <summary>
    /// </summary>
    public sealed class ScsiRequestBlock
    {
		public byte[] Cdb { get; private set; }
		public byte CdbLength { get; private set; }
		public ulong DataBuffer { get; private set; }
		public uint DataTransferLength { get; private set; }
		public byte Function { get; private set; }
		public uint InternalStatus { get; private set; }
		public ushort Length { get; private set; }
		public byte Lun { get; private set; }
		public ulong NextSrb { get; private set; }
		public ulong OriginalRequest { get; private set; }
		public byte PathId { get; private set; }
		public byte QueueAction { get; private set; }
		public byte QueueTag { get; private set; }
		public uint Reserved { get; private set; }
		public byte ScsiStatus { get; private set; }
		public ulong SenseInfoBuffer { get; private set; }
		public byte SenseInfoBufferLength { get; private set; }
		public ulong SrbExtension { get; private set; }
		public uint SrbFlags { get; private set; }
		public byte SrbStatus { get; private set; }
		public byte TargetId { get; private set; }
		public uint TimeOutValue { get; private set; }

        public static IEnumerable<ScsiRequestBlock> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ScsiRequestBlock> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ScsiRequestBlock> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSStorageDriver_ScsiRequestBlock");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ScsiRequestBlock
                {
                     Cdb = (byte[]) (managementObject.Properties["cdb"]?.Value ?? new byte[0]),
		 CdbLength = (byte) (managementObject.Properties["cdbLength"]?.Value ?? default(byte)),
		 DataBuffer = (ulong) (managementObject.Properties["dataBuffer"]?.Value ?? default(ulong)),
		 DataTransferLength = (uint) (managementObject.Properties["dataTransferLength"]?.Value ?? default(uint)),
		 Function = (byte) (managementObject.Properties["function"]?.Value ?? default(byte)),
		 InternalStatus = (uint) (managementObject.Properties["internalStatus"]?.Value ?? default(uint)),
		 Length = (ushort) (managementObject.Properties["length"]?.Value ?? default(ushort)),
		 Lun = (byte) (managementObject.Properties["lun"]?.Value ?? default(byte)),
		 NextSrb = (ulong) (managementObject.Properties["nextSRB"]?.Value ?? default(ulong)),
		 OriginalRequest = (ulong) (managementObject.Properties["originalRequest"]?.Value ?? default(ulong)),
		 PathId = (byte) (managementObject.Properties["pathID"]?.Value ?? default(byte)),
		 QueueAction = (byte) (managementObject.Properties["queueAction"]?.Value ?? default(byte)),
		 QueueTag = (byte) (managementObject.Properties["queueTag"]?.Value ?? default(byte)),
		 Reserved = (uint) (managementObject.Properties["reserved"]?.Value ?? default(uint)),
		 ScsiStatus = (byte) (managementObject.Properties["scsiStatus"]?.Value ?? default(byte)),
		 SenseInfoBuffer = (ulong) (managementObject.Properties["senseInfoBuffer"]?.Value ?? default(ulong)),
		 SenseInfoBufferLength = (byte) (managementObject.Properties["senseInfoBufferLength"]?.Value ?? default(byte)),
		 SrbExtension = (ulong) (managementObject.Properties["srbExtension"]?.Value ?? default(ulong)),
		 SrbFlags = (uint) (managementObject.Properties["srbFlags"]?.Value ?? default(uint)),
		 SrbStatus = (byte) (managementObject.Properties["srbStatus"]?.Value ?? default(byte)),
		 TargetId = (byte) (managementObject.Properties["targetID"]?.Value ?? default(byte)),
		 TimeOutValue = (uint) (managementObject.Properties["timeOutValue"]?.Value ?? default(uint))
                };
        }
    }
}