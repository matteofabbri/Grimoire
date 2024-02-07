using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows
{
    /// <summary>
    /// </summary>
    public sealed class SystemAccount
    {
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public string Domain { get; private set; }
		public DateTime InstallDate { get; private set; }
		public bool LocalAccount { get; private set; }
		public string Name { get; private set; }
		public string Sid { get; private set; }
		public byte SidType { get; private set; }
		public string Status { get; private set; }

        public static IEnumerable<SystemAccount> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SystemAccount> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SystemAccount> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_SystemAccount");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SystemAccount
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 Domain = (string) (managementObject.Properties["Domain"]?.Value),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 LocalAccount = (bool) (managementObject.Properties["LocalAccount"]?.Value ?? default(bool)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 Sid = (string) (managementObject.Properties["SID"]?.Value),
		 SidType = (byte) (managementObject.Properties["SIDType"]?.Value ?? default(byte)),
		 Status = (string) (managementObject.Properties["Status"]?.Value)
                };
        }
    }
}