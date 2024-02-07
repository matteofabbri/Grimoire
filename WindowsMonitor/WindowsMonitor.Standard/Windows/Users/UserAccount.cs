using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Users
{
    /// <summary>
    /// </summary>
    public sealed class UserAccount
    {
		public uint AccountType { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public bool Disabled { get; private set; }
		public string Domain { get; private set; }
		public string FullName { get; private set; }
		public DateTime InstallDate { get; private set; }
		public bool LocalAccount { get; private set; }
		public bool Lockout { get; private set; }
		public string Name { get; private set; }
		public bool PasswordChangeable { get; private set; }
		public bool PasswordExpires { get; private set; }
		public bool PasswordRequired { get; private set; }
		public string Sid { get; private set; }
		public byte SidType { get; private set; }
		public string Status { get; private set; }

        public static IEnumerable<UserAccount> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<UserAccount> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<UserAccount> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_UserAccount");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new UserAccount
                {
                     AccountType = (uint) (managementObject.Properties["AccountType"]?.Value ?? default(uint)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 Disabled = (bool) (managementObject.Properties["Disabled"]?.Value ?? default(bool)),
		 Domain = (string) (managementObject.Properties["Domain"]?.Value),
		 FullName = (string) (managementObject.Properties["FullName"]?.Value),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 LocalAccount = (bool) (managementObject.Properties["LocalAccount"]?.Value ?? default(bool)),
		 Lockout = (bool) (managementObject.Properties["Lockout"]?.Value ?? default(bool)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 PasswordChangeable = (bool) (managementObject.Properties["PasswordChangeable"]?.Value ?? default(bool)),
		 PasswordExpires = (bool) (managementObject.Properties["PasswordExpires"]?.Value ?? default(bool)),
		 PasswordRequired = (bool) (managementObject.Properties["PasswordRequired"]?.Value ?? default(bool)),
		 Sid = (string) (managementObject.Properties["SID"]?.Value),
		 SidType = (byte) (managementObject.Properties["SIDType"]?.Value ?? default(byte)),
		 Status = (string) (managementObject.Properties["Status"]?.Value)
                };
        }
    }
}