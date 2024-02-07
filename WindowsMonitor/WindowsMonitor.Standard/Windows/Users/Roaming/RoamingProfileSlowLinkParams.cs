using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Users.Roaming
{
    /// <summary>
    /// </summary>
    public sealed class RoamingProfileSlowLinkParams
    {
		public uint ConnectionTransferRate { get; private set; }
		public ushort TimeOut { get; private set; }

        public static IEnumerable<RoamingProfileSlowLinkParams> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<RoamingProfileSlowLinkParams> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<RoamingProfileSlowLinkParams> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_RoamingProfileSlowLinkParams");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new RoamingProfileSlowLinkParams
                {
                     ConnectionTransferRate = (uint) (managementObject.Properties["ConnectionTransferRate"]?.Value ?? default(uint)),
		 TimeOut = (ushort) (managementObject.Properties["TimeOut"]?.Value ?? default(ushort))
                };
        }
    }
}