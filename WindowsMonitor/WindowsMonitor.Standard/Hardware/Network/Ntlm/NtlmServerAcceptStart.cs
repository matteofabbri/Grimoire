using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network.Ntlm
{
    /// <summary>
    /// </summary>
    public sealed class NtlmServerAcceptStart
    {
		public uint InContext { get; private set; }
		public uint StageHint { get; private set; }

        public static IEnumerable<NtlmServerAcceptStart> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<NtlmServerAcceptStart> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<NtlmServerAcceptStart> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM NtlmServerAccept_Start");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new NtlmServerAcceptStart
                {
                     InContext = (uint) (managementObject.Properties["InContext"]?.Value ?? default(uint)),
		 StageHint = (uint) (managementObject.Properties["StageHint"]?.Value ?? default(uint))
                };
        }
    }
}