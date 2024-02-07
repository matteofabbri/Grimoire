using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network.TokenRing
{
    /// <summary>
    /// </summary>
    public sealed class TokenRingCurrentFunctional
    {
		public bool Active { get; private set; }
		public string InstanceName { get; private set; }
		public uint NdisTokenRingCurrentFunctional { get; private set; }

        public static IEnumerable<TokenRingCurrentFunctional> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<TokenRingCurrentFunctional> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<TokenRingCurrentFunctional> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_TokenRingCurrentFunctional");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new TokenRingCurrentFunctional
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 NdisTokenRingCurrentFunctional = (uint) (managementObject.Properties["NdisTokenRingCurrentFunctional"]?.Value ?? default(uint))
                };
        }
    }
}