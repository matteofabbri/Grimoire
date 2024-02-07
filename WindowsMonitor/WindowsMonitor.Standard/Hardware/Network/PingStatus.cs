using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network
{
    /// <summary>
    /// </summary>
    public sealed class PingStatus
    {
		public string Address { get; private set; }
		public uint BufferSize { get; private set; }
		public bool NoFragmentation { get; private set; }
		public uint PrimaryAddressResolutionStatus { get; private set; }
		public string ProtocolAddress { get; private set; }
		public string ProtocolAddressResolved { get; private set; }
		public uint RecordRoute { get; private set; }
		public bool ReplyInconsistency { get; private set; }
		public uint ReplySize { get; private set; }
		public bool ResolveAddressNames { get; private set; }
		public uint ResponseTime { get; private set; }
		public uint ResponseTimeToLive { get; private set; }
		public string[] RouteRecord { get; private set; }
		public string[] RouteRecordResolved { get; private set; }
		public string SourceRoute { get; private set; }
		public uint SourceRouteType { get; private set; }
		public uint StatusCode { get; private set; }
		public uint Timeout { get; private set; }
		public uint[] TimeStampRecord { get; private set; }
		public string[] TimeStampRecordAddress { get; private set; }
		public string[] TimeStampRecordAddressResolved { get; private set; }
		public uint TimestampRoute { get; private set; }
		public uint TimeToLive { get; private set; }
		public uint TypeofService { get; private set; }

        public static IEnumerable<PingStatus> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<PingStatus> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<PingStatus> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PingStatus");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new PingStatus
                {
                     Address = (string) (managementObject.Properties["Address"]?.Value),
		 BufferSize = (uint) (managementObject.Properties["BufferSize"]?.Value ?? default(uint)),
		 NoFragmentation = (bool) (managementObject.Properties["NoFragmentation"]?.Value ?? default(bool)),
		 PrimaryAddressResolutionStatus = (uint) (managementObject.Properties["PrimaryAddressResolutionStatus"]?.Value ?? default(uint)),
		 ProtocolAddress = (string) (managementObject.Properties["ProtocolAddress"]?.Value),
		 ProtocolAddressResolved = (string) (managementObject.Properties["ProtocolAddressResolved"]?.Value),
		 RecordRoute = (uint) (managementObject.Properties["RecordRoute"]?.Value ?? default(uint)),
		 ReplyInconsistency = (bool) (managementObject.Properties["ReplyInconsistency"]?.Value ?? default(bool)),
		 ReplySize = (uint) (managementObject.Properties["ReplySize"]?.Value ?? default(uint)),
		 ResolveAddressNames = (bool) (managementObject.Properties["ResolveAddressNames"]?.Value ?? default(bool)),
		 ResponseTime = (uint) (managementObject.Properties["ResponseTime"]?.Value ?? default(uint)),
		 ResponseTimeToLive = (uint) (managementObject.Properties["ResponseTimeToLive"]?.Value ?? default(uint)),
		 RouteRecord = (string[]) (managementObject.Properties["RouteRecord"]?.Value ?? new string[0]),
		 RouteRecordResolved = (string[]) (managementObject.Properties["RouteRecordResolved"]?.Value ?? new string[0]),
		 SourceRoute = (string) (managementObject.Properties["SourceRoute"]?.Value),
		 SourceRouteType = (uint) (managementObject.Properties["SourceRouteType"]?.Value ?? default(uint)),
		 StatusCode = (uint) (managementObject.Properties["StatusCode"]?.Value ?? default(uint)),
		 Timeout = (uint) (managementObject.Properties["Timeout"]?.Value ?? default(uint)),
		 TimeStampRecord = (uint[]) (managementObject.Properties["TimeStampRecord"]?.Value ?? new uint[0]),
		 TimeStampRecordAddress = (string[]) (managementObject.Properties["TimeStampRecordAddress"]?.Value ?? new string[0]),
		 TimeStampRecordAddressResolved = (string[]) (managementObject.Properties["TimeStampRecordAddressResolved"]?.Value ?? new string[0]),
		 TimestampRoute = (uint) (managementObject.Properties["TimestampRoute"]?.Value ?? default(uint)),
		 TimeToLive = (uint) (managementObject.Properties["TimeToLive"]?.Value ?? default(uint)),
		 TypeofService = (uint) (managementObject.Properties["TypeofService"]?.Value ?? default(uint))
                };
        }
    }
}