using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network
{
    /// <summary>
    /// </summary>
    public sealed class NetworkLoginProfile
    {
		public DateTime AccountExpires { get; private set; }
		public uint AuthorizationFlags { get; private set; }
		public uint BadPasswordCount { get; private set; }
		public string Caption { get; private set; }
		public uint CodePage { get; private set; }
		public string Comment { get; private set; }
		public uint CountryCode { get; private set; }
		public string Description { get; private set; }
		public uint Flags { get; private set; }
		public string FullName { get; private set; }
		public string HomeDirectory { get; private set; }
		public string HomeDirectoryDrive { get; private set; }
		public DateTime LastLogoff { get; private set; }
		public DateTime LastLogon { get; private set; }
		public string LogonHours { get; private set; }
		public string LogonServer { get; private set; }
		public ulong MaximumStorage { get; private set; }
		public string Name { get; private set; }
		public uint NumberOfLogons { get; private set; }
		public string Parameters { get; private set; }
		public DateTime PasswordAge { get; private set; }
		public DateTime PasswordExpires { get; private set; }
		public uint PrimaryGroupId { get; private set; }
		public uint Privileges { get; private set; }
		public string Profile { get; private set; }
		public string ScriptPath { get; private set; }
		public string SettingId { get; private set; }
		public uint UnitsPerWeek { get; private set; }
		public string UserComment { get; private set; }
		public uint UserId { get; private set; }
		public string UserType { get; private set; }
		public string Workstations { get; private set; }

        public static IEnumerable<NetworkLoginProfile> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<NetworkLoginProfile> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<NetworkLoginProfile> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_NetworkLoginProfile");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new NetworkLoginProfile
                {
                     AccountExpires = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["AccountExpires"]?.Value as string ?? "00010102000000.000000+060"),
		 AuthorizationFlags = (uint) (managementObject.Properties["AuthorizationFlags"]?.Value ?? default(uint)),
		 BadPasswordCount = (uint) (managementObject.Properties["BadPasswordCount"]?.Value ?? default(uint)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 CodePage = (uint) (managementObject.Properties["CodePage"]?.Value ?? default(uint)),
		 Comment = (string) (managementObject.Properties["Comment"]?.Value),
		 CountryCode = (uint) (managementObject.Properties["CountryCode"]?.Value ?? default(uint)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 Flags = (uint) (managementObject.Properties["Flags"]?.Value ?? default(uint)),
		 FullName = (string) (managementObject.Properties["FullName"]?.Value),
		 HomeDirectory = (string) (managementObject.Properties["HomeDirectory"]?.Value),
		 HomeDirectoryDrive = (string) (managementObject.Properties["HomeDirectoryDrive"]?.Value),
		 LastLogoff = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["LastLogoff"]?.Value as string ?? "00010102000000.000000+060"),
		 LastLogon = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["LastLogon"]?.Value as string ?? "00010102000000.000000+060"),
		 LogonHours = (string) (managementObject.Properties["LogonHours"]?.Value),
		 LogonServer = (string) (managementObject.Properties["LogonServer"]?.Value),
		 MaximumStorage = (ulong) (managementObject.Properties["MaximumStorage"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 NumberOfLogons = (uint) (managementObject.Properties["NumberOfLogons"]?.Value ?? default(uint)),
		 Parameters = (string) (managementObject.Properties["Parameters"]?.Value),
		 PasswordAge = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["PasswordAge"]?.Value as string ?? "00010102000000.000000+060"),
		 PasswordExpires = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["PasswordExpires"]?.Value as string ?? "00010102000000.000000+060"),
		 PrimaryGroupId = (uint) (managementObject.Properties["PrimaryGroupId"]?.Value ?? default(uint)),
		 Privileges = (uint) (managementObject.Properties["Privileges"]?.Value ?? default(uint)),
		 Profile = (string) (managementObject.Properties["Profile"]?.Value),
		 ScriptPath = (string) (managementObject.Properties["ScriptPath"]?.Value),
		 SettingId = (string) (managementObject.Properties["SettingID"]?.Value),
		 UnitsPerWeek = (uint) (managementObject.Properties["UnitsPerWeek"]?.Value ?? default(uint)),
		 UserComment = (string) (managementObject.Properties["UserComment"]?.Value),
		 UserId = (uint) (managementObject.Properties["UserId"]?.Value ?? default(uint)),
		 UserType = (string) (managementObject.Properties["UserType"]?.Value),
		 Workstations = (string) (managementObject.Properties["Workstations"]?.Value)
                };
        }
    }
}