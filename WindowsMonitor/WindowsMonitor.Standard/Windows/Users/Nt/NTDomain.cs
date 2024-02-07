using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Users.Nt
{
    /// <summary>
    /// </summary>
    public sealed class NtDomain
    {
		public string Caption { get; private set; }
		public string ClientSiteName { get; private set; }
		public string CreationClassName { get; private set; }
		public string DcSiteName { get; private set; }
		public string Description { get; private set; }
		public string DnsForestName { get; private set; }
		public string DomainControllerAddress { get; private set; }
		public int DomainControllerAddressType { get; private set; }
		public string DomainControllerName { get; private set; }
		public string DomainGuid { get; private set; }
		public string DomainName { get; private set; }
		public bool DsDirectoryServiceFlag { get; private set; }
		public bool DsDnsControllerFlag { get; private set; }
		public bool DsDnsDomainFlag { get; private set; }
		public bool DsDnsForestFlag { get; private set; }
		public bool DsGlobalCatalogFlag { get; private set; }
		public bool DsKerberosDistributionCenterFlag { get; private set; }
		public bool DsPrimaryDomainControllerFlag { get; private set; }
		public bool DsTimeServiceFlag { get; private set; }
		public bool DsWritableFlag { get; private set; }
		public DateTime InstallDate { get; private set; }
		public string Name { get; private set; }
		public string NameFormat { get; private set; }
		public string PrimaryOwnerContact { get; private set; }
		public string PrimaryOwnerName { get; private set; }
		public string[] Roles { get; private set; }
		public string Status { get; private set; }

        public static IEnumerable<NtDomain> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<NtDomain> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<NtDomain> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_NTDomain");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new NtDomain
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 ClientSiteName = (string) (managementObject.Properties["ClientSiteName"]?.Value),
		 CreationClassName = (string) (managementObject.Properties["CreationClassName"]?.Value),
		 DcSiteName = (string) (managementObject.Properties["DcSiteName"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DnsForestName = (string) (managementObject.Properties["DnsForestName"]?.Value),
		 DomainControllerAddress = (string) (managementObject.Properties["DomainControllerAddress"]?.Value),
		 DomainControllerAddressType = (int) (managementObject.Properties["DomainControllerAddressType"]?.Value ?? default(int)),
		 DomainControllerName = (string) (managementObject.Properties["DomainControllerName"]?.Value),
		 DomainGuid = (string) (managementObject.Properties["DomainGuid"]?.Value),
		 DomainName = (string) (managementObject.Properties["DomainName"]?.Value),
		 DsDirectoryServiceFlag = (bool) (managementObject.Properties["DSDirectoryServiceFlag"]?.Value ?? default(bool)),
		 DsDnsControllerFlag = (bool) (managementObject.Properties["DSDnsControllerFlag"]?.Value ?? default(bool)),
		 DsDnsDomainFlag = (bool) (managementObject.Properties["DSDnsDomainFlag"]?.Value ?? default(bool)),
		 DsDnsForestFlag = (bool) (managementObject.Properties["DSDnsForestFlag"]?.Value ?? default(bool)),
		 DsGlobalCatalogFlag = (bool) (managementObject.Properties["DSGlobalCatalogFlag"]?.Value ?? default(bool)),
		 DsKerberosDistributionCenterFlag = (bool) (managementObject.Properties["DSKerberosDistributionCenterFlag"]?.Value ?? default(bool)),
		 DsPrimaryDomainControllerFlag = (bool) (managementObject.Properties["DSPrimaryDomainControllerFlag"]?.Value ?? default(bool)),
		 DsTimeServiceFlag = (bool) (managementObject.Properties["DSTimeServiceFlag"]?.Value ?? default(bool)),
		 DsWritableFlag = (bool) (managementObject.Properties["DSWritableFlag"]?.Value ?? default(bool)),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 NameFormat = (string) (managementObject.Properties["NameFormat"]?.Value),
		 PrimaryOwnerContact = (string) (managementObject.Properties["PrimaryOwnerContact"]?.Value),
		 PrimaryOwnerName = (string) (managementObject.Properties["PrimaryOwnerName"]?.Value),
		 Roles = (string[]) (managementObject.Properties["Roles"]?.Value ?? new string[0]),
		 Status = (string) (managementObject.Properties["Status"]?.Value)
                };
        }
    }
}