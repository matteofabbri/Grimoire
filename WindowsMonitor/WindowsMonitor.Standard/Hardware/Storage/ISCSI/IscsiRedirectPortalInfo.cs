using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.ISCSI
{
    /// <summary>
    /// </summary>
    public sealed class IscsiRedirectPortalInfo
    {
		public dynamic OriginalIpAddr { get; private set; }
		public uint OriginalPort { get; private set; }
		public byte Redirected { get; private set; }
		public dynamic RedirectedIpAddr { get; private set; }
		public uint RedirectedPort { get; private set; }
		public byte TemporaryRedirect { get; private set; }
		public ulong UniqueConnectionId { get; private set; }

        public static IEnumerable<IscsiRedirectPortalInfo> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<IscsiRedirectPortalInfo> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<IscsiRedirectPortalInfo> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM ISCSI_RedirectPortalInfo");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new IscsiRedirectPortalInfo
                {
                     OriginalIpAddr = (dynamic) (managementObject.Properties["OriginalIPAddr"]?.Value ?? default(dynamic)),
		 OriginalPort = (uint) (managementObject.Properties["OriginalPort"]?.Value ?? default(uint)),
		 Redirected = (byte) (managementObject.Properties["Redirected"]?.Value ?? default(byte)),
		 RedirectedIpAddr = (dynamic) (managementObject.Properties["RedirectedIPAddr"]?.Value ?? default(dynamic)),
		 RedirectedPort = (uint) (managementObject.Properties["RedirectedPort"]?.Value ?? default(uint)),
		 TemporaryRedirect = (byte) (managementObject.Properties["TemporaryRedirect"]?.Value ?? default(byte)),
		 UniqueConnectionId = (ulong) (managementObject.Properties["UniqueConnectionId"]?.Value ?? default(ulong))
                };
        }
    }
}