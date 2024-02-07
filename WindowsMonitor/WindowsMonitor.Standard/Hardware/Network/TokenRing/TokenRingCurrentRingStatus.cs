using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network.TokenRing
{
    /// <summary>
    /// </summary>
    public sealed class TokenRingCurrentRingStatus
    {
		public bool Active { get; private set; }
		public string InstanceName { get; private set; }
		public uint NdisTokenRingCurrentRingStatus { get; private set; }

        public static IEnumerable<TokenRingCurrentRingStatus> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<TokenRingCurrentRingStatus> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<TokenRingCurrentRingStatus> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_TokenRingCurrentRingStatus");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new TokenRingCurrentRingStatus
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 NdisTokenRingCurrentRingStatus = (uint) (managementObject.Properties["NdisTokenRingCurrentRingStatus"]?.Value ?? default(uint))
                };
        }
    }
}