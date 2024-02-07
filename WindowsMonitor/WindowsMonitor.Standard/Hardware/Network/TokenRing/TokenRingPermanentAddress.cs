using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network.TokenRing
{
    /// <summary>
    /// </summary>
    public sealed class TokenRingPermanentAddress
    {
		public bool Active { get; private set; }
		public string InstanceName { get; private set; }
		public dynamic NdisPermanentAddress { get; private set; }

        public static IEnumerable<TokenRingPermanentAddress> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<TokenRingPermanentAddress> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<TokenRingPermanentAddress> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSNdis_TokenRingPermanentAddress");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new TokenRingPermanentAddress
                {
                     Active = (bool) (managementObject.Properties["Active"]?.Value ?? default(bool)),
		 InstanceName = (string) (managementObject.Properties["InstanceName"]?.Value ?? default(string)),
		 NdisPermanentAddress = (dynamic) (managementObject.Properties["NdisPermanentAddress"]?.Value ?? default(dynamic))
                };
        }
    }
}