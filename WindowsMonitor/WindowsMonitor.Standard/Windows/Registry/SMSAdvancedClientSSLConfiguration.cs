using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Registry
{
    /// <summary>
    /// </summary>
    public sealed class SmsAdvancedClientSslConfiguration
    {
		public string CertificateSelectionCriteria { get; private set; }
		public string CertificateStore { get; private set; }
		public uint ClientAlwaysOnInternet { get; private set; }
		public uint HttpsStateFlags { get; private set; }
		public string InstanceKey { get; private set; }
		public string InternetMpHostName { get; private set; }
		public uint SelectFirstCertificate { get; private set; }

        public static IEnumerable<SmsAdvancedClientSslConfiguration> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SmsAdvancedClientSslConfiguration> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SmsAdvancedClientSslConfiguration> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32Reg_SMSAdvancedClientSSLConfiguration");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SmsAdvancedClientSslConfiguration
                {
                     CertificateSelectionCriteria = (string) (managementObject.Properties["CertificateSelectionCriteria"]?.Value),
		 CertificateStore = (string) (managementObject.Properties["CertificateStore"]?.Value),
		 ClientAlwaysOnInternet = (uint) (managementObject.Properties["ClientAlwaysOnInternet"]?.Value ?? default(uint)),
		 HttpsStateFlags = (uint) (managementObject.Properties["HttpsStateFlags"]?.Value ?? default(uint)),
		 InstanceKey = (string) (managementObject.Properties["InstanceKey"]?.Value),
		 InternetMpHostName = (string) (managementObject.Properties["InternetMPHostName"]?.Value),
		 SelectFirstCertificate = (uint) (managementObject.Properties["SelectFirstCertificate"]?.Value ?? default(uint))
                };
        }
    }
}