using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network.Ntlm
{
    /// <summary>
    /// </summary>
    public sealed class NtlmServerAcceptEnd
    {
		public uint InContext { get; private set; }
		public uint OutContext { get; private set; }
		public uint StageHint { get; private set; }
		public uint Status { get; private set; }

        public static IEnumerable<NtlmServerAcceptEnd> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<NtlmServerAcceptEnd> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<NtlmServerAcceptEnd> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM NtlmServerAccept_End");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new NtlmServerAcceptEnd
                {
                     InContext = (uint) (managementObject.Properties["InContext"]?.Value ?? default(uint)),
		 OutContext = (uint) (managementObject.Properties["OutContext"]?.Value ?? default(uint)),
		 StageHint = (uint) (managementObject.Properties["StageHint"]?.Value ?? default(uint)),
		 Status = (uint) (managementObject.Properties["Status"]?.Value ?? default(uint))
                };
        }
    }
}