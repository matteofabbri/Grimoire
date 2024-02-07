using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.HBA.Msfc
{
    /// <summary>
    /// </summary>
    public sealed class ChapParameters
    {
		public byte SecretEncoding { get; private set; }
		public byte[] SharedSecret { get; private set; }
		public uint SharedSecretLength { get; private set; }

        public static IEnumerable<ChapParameters> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ChapParameters> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ChapParameters> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSFC_DH_Chap_Parameters");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ChapParameters
                {
                     SecretEncoding = (byte) (managementObject.Properties["SecretEncoding"]?.Value ?? default(byte)),
		 SharedSecret = (byte[]) (managementObject.Properties["SharedSecret"]?.Value ?? new byte[0]),
		 SharedSecretLength = (uint) (managementObject.Properties["SharedSecretLength"]?.Value ?? default(uint))
                };
        }
    }
}