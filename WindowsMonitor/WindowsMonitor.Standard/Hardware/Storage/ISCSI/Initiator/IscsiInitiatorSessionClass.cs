using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.ISCSI.Initiator
{
    /// <summary>
    /// </summary>
    public sealed class IscsiInitiatorSessionClass
    {
		public dynamic[] ConnectionInformation { get; private set; }
		public dynamic[] Devices { get; private set; }
		public string InitiatorName { get; private set; }
		public byte[] Isid { get; private set; }
		public string SessionId { get; private set; }
		public string TargetName { get; private set; }
		public string TargetNodeName { get; private set; }
		public byte[] Tsid { get; private set; }

        public static IEnumerable<IscsiInitiatorSessionClass> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<IscsiInitiatorSessionClass> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<IscsiInitiatorSessionClass> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSiSCSIInitiator_SessionClass");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new IscsiInitiatorSessionClass
                {
                     ConnectionInformation = (dynamic[]) (managementObject.Properties["ConnectionInformation"]?.Value ?? new dynamic[0]),
		 Devices = (dynamic[]) (managementObject.Properties["Devices"]?.Value ?? new dynamic[0]),
		 InitiatorName = (string) (managementObject.Properties["InitiatorName"]?.Value ?? default(string)),
		 Isid = (byte[]) (managementObject.Properties["ISID"]?.Value ?? new byte[0]),
		 SessionId = (string) (managementObject.Properties["SessionId"]?.Value ?? default(string)),
		 TargetName = (string) (managementObject.Properties["TargetName"]?.Value ?? default(string)),
		 TargetNodeName = (string) (managementObject.Properties["TargetNodeName"]?.Value ?? default(string)),
		 Tsid = (byte[]) (managementObject.Properties["TSID"]?.Value ?? new byte[0])
                };
        }
    }
}