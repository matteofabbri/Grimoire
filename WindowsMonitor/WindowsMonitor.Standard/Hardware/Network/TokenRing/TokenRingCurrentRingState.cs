using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network.TokenRing
{
    /// <summary>
    /// </summary>
    public sealed class TokenRingCurrentRingState
    {
		public bool Active { get; private set; }
		public string InstanceName { get; private set; }
		public uint NdisTokenRingCurrentRingState { get; private set; }

        public static IEnumerable<TokenRingCurrentRingState> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<TokenRingCurrentRingState> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<TokenRingCurrentRingState> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_TokenRingCurrentRingState");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new TokenRingCurrentRingState
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 NdisTokenRingCurrentRingState = (uint) (managementObject.Properties["NdisTokenRingCurrentRingState"]?.Value ?? default(uint))
                };
        }
    }
}