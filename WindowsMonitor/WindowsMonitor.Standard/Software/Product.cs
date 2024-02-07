using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Software
{
    /// <summary>
    /// </summary>
    public sealed class Product
    {
		public ushort AssignmentType { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public string HelpLink { get; private set; }
		public string HelpTelephone { get; private set; }
		public string IdentifyingNumber { get; private set; }
		public string InstallDate { get; private set; }
		public DateTime InstallDate2 { get; private set; }
		public string InstallLocation { get; private set; }
		public string InstallSource { get; private set; }
		public string InstallState { get; private set; }
		public string Language { get; private set; }
		public string LocalPackage { get; private set; }
		public string Name { get; private set; }
		public string PackageCache { get; private set; }
		public string PackageCode { get; private set; }
		public string PackageName { get; private set; }
		public string ProductId { get; private set; }
		public string RegCompany { get; private set; }
		public string RegOwner { get; private set; }
		public string SkuNumber { get; private set; }
		public string Transforms { get; private set; }
		public string UrlInfoAbout { get; private set; }
		public string UrlUpdateInfo { get; private set; }
		public string Vendor { get; private set; }
		public string Version { get; private set; }
		public uint WordCount { get; private set; }

        public static IEnumerable<Product> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<Product> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<Product> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_Product");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new Product
                {
                     AssignmentType = (ushort) (managementObject.Properties["AssignmentType"]?.Value ?? default(ushort)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 HelpLink = (string) (managementObject.Properties["HelpLink"]?.Value),
		 HelpTelephone = (string) (managementObject.Properties["HelpTelephone"]?.Value),
		 IdentifyingNumber = (string) (managementObject.Properties["IdentifyingNumber"]?.Value),
		 InstallDate = (string) (managementObject.Properties["InstallDate"]?.Value),
		 InstallDate2 = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate2"]?.Value as string ?? "00010102000000.000000+060"),
		 InstallLocation = (string) (managementObject.Properties["InstallLocation"]?.Value),
		 InstallSource = (string) (managementObject.Properties["InstallSource"]?.Value),
		 InstallState =  (managementObject.Properties["InstallState"]?.Value?.ToString()),
		 Language = (string) (managementObject.Properties["Language"]?.Value),
		 LocalPackage = (string) (managementObject.Properties["LocalPackage"]?.Value),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 PackageCache = (string) (managementObject.Properties["PackageCache"]?.Value),
		 PackageCode = (string) (managementObject.Properties["PackageCode"]?.Value),
		 PackageName = (string) (managementObject.Properties["PackageName"]?.Value),
		 ProductId = (string) (managementObject.Properties["ProductID"]?.Value),
		 RegCompany = (string) (managementObject.Properties["RegCompany"]?.Value),
		 RegOwner = (string) (managementObject.Properties["RegOwner"]?.Value),
		 SkuNumber = (string) (managementObject.Properties["SKUNumber"]?.Value),
		 Transforms = (string) (managementObject.Properties["Transforms"]?.Value),
		 UrlInfoAbout = (string) (managementObject.Properties["URLInfoAbout"]?.Value),
		 UrlUpdateInfo = (string) (managementObject.Properties["URLUpdateInfo"]?.Value),
		 Vendor = (string) (managementObject.Properties["Vendor"]?.Value),
		 Version = (string) (managementObject.Properties["Version"]?.Value),
		 WordCount = (uint) (managementObject.Properties["WordCount"]?.Value ?? default(uint))
                };
        }
    }
}