using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Users
{
    /// <summary>
    /// </summary>
    public sealed class LogonSession
    {
		public string AuthenticationPackage { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public DateTime InstallDate { get; private set; }
		public string LogonId { get; private set; }
		public uint LogonType { get; private set; }
		public string Name { get; private set; }
		public DateTime StartTime { get; private set; }
		public string Status { get; private set; }

        public static IEnumerable<LogonSession> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<LogonSession> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<LogonSession> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_LogonSession");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new LogonSession
                {
                     AuthenticationPackage = (string) (managementObject.Properties["AuthenticationPackage"]?.Value),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 LogonId = (string) (managementObject.Properties["LogonId"]?.Value),
		 LogonType = (uint) (managementObject.Properties["LogonType"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 StartTime = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["StartTime"]?.Value as string ?? "00010102000000.000000+060"),
		 Status = (string) (managementObject.Properties["Status"]?.Value)
                };
        }
    }
}