using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw
{
    /// <summary>
    /// </summary>
    public sealed class LsaSecuritySystemWideStatistics
    {
		public uint ActiveSchannelSessionCacheEntries { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public uint DigestAuthentications { get; private set; }
		public uint ForwardedKerberosRequests { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public uint KdCarmoredAsRequests { get; private set; }
		public uint KdCarmoredTgsRequests { get; private set; }
		public uint KdcasRequests { get; private set; }
		public uint KdCclaimsawareAsRequests { get; private set; }
		public uint KdCclaimsawareserviceassertedidentityTgSrequests { get; private set; }
		public uint KdCclaimsawareTgsRequests { get; private set; }
		public uint KdCclassictypeconstraineddelegationTgsRequests { get; private set; }
		public uint KdCkeytrustAsRequests { get; private set; }
		public uint KdCresourcetypeconstraineddelegationTgsRequests { get; private set; }
		public uint KdctgsRequests { get; private set; }
		public uint KerberosAuthentications { get; private set; }
		public string Name { get; private set; }
		public uint NtlmAuthentications { get; private set; }
		public uint SchannelSessionCacheEntries { get; private set; }
		public uint SslClientSideFullHandshakes { get; private set; }
		public uint SslClientSideReconnectHandshakes { get; private set; }
		public uint SslServerSideFullHandshakes { get; private set; }
		public uint SslServerSideReconnectHandshakes { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<LsaSecuritySystemWideStatistics> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<LsaSecuritySystemWideStatistics> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<LsaSecuritySystemWideStatistics> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_Lsa_SecuritySystemWideStatistics");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new LsaSecuritySystemWideStatistics
                {
                     ActiveSchannelSessionCacheEntries = (uint) (managementObject.Properties["ActiveSchannelSessionCacheEntries"]?.Value ?? default(uint)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DigestAuthentications = (uint) (managementObject.Properties["DigestAuthentications"]?.Value ?? default(uint)),
		 ForwardedKerberosRequests = (uint) (managementObject.Properties["ForwardedKerberosRequests"]?.Value ?? default(uint)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 KdCarmoredAsRequests = (uint) (managementObject.Properties["KDCarmoredASRequests"]?.Value ?? default(uint)),
		 KdCarmoredTgsRequests = (uint) (managementObject.Properties["KDCarmoredTGSRequests"]?.Value ?? default(uint)),
		 KdcasRequests = (uint) (managementObject.Properties["KDCASRequests"]?.Value ?? default(uint)),
		 KdCclaimsawareAsRequests = (uint) (managementObject.Properties["KDCclaimsawareASRequests"]?.Value ?? default(uint)),
		 KdCclaimsawareserviceassertedidentityTgSrequests = (uint) (managementObject.Properties["KDCclaimsawareserviceassertedidentityTGSrequests"]?.Value ?? default(uint)),
		 KdCclaimsawareTgsRequests = (uint) (managementObject.Properties["KDCclaimsawareTGSRequests"]?.Value ?? default(uint)),
		 KdCclassictypeconstraineddelegationTgsRequests = (uint) (managementObject.Properties["KDCclassictypeconstraineddelegationTGSRequests"]?.Value ?? default(uint)),
		 KdCkeytrustAsRequests = (uint) (managementObject.Properties["KDCkeytrustASRequests"]?.Value ?? default(uint)),
		 KdCresourcetypeconstraineddelegationTgsRequests = (uint) (managementObject.Properties["KDCresourcetypeconstraineddelegationTGSRequests"]?.Value ?? default(uint)),
		 KdctgsRequests = (uint) (managementObject.Properties["KDCTGSRequests"]?.Value ?? default(uint)),
		 KerberosAuthentications = (uint) (managementObject.Properties["KerberosAuthentications"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 NtlmAuthentications = (uint) (managementObject.Properties["NTLMAuthentications"]?.Value ?? default(uint)),
		 SchannelSessionCacheEntries = (uint) (managementObject.Properties["SchannelSessionCacheEntries"]?.Value ?? default(uint)),
		 SslClientSideFullHandshakes = (uint) (managementObject.Properties["SSLClientSideFullHandshakes"]?.Value ?? default(uint)),
		 SslClientSideReconnectHandshakes = (uint) (managementObject.Properties["SSLClientSideReconnectHandshakes"]?.Value ?? default(uint)),
		 SslServerSideFullHandshakes = (uint) (managementObject.Properties["SSLServerSideFullHandshakes"]?.Value ?? default(uint)),
		 SslServerSideReconnectHandshakes = (uint) (managementObject.Properties["SSLServerSideReconnectHandshakes"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}