using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Registry
{
    /// <summary>
    /// </summary>
    public sealed class SmsGuestVirtualMachine
    {
		public string InstanceKey { get; private set; }
		public string PhysicalHostName { get; private set; }
		public string PhysicalHostNameFullyQualified { get; private set; }

        public static IEnumerable<SmsGuestVirtualMachine> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SmsGuestVirtualMachine> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SmsGuestVirtualMachine> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32Reg_SMSGuestVirtualMachine");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SmsGuestVirtualMachine
                {
                     InstanceKey = (string) (managementObject.Properties["InstanceKey"]?.Value),
		 PhysicalHostName = (string) (managementObject.Properties["PhysicalHostName"]?.Value),
		 PhysicalHostNameFullyQualified = (string) (managementObject.Properties["PhysicalHostNameFullyQualified"]?.Value)
                };
        }
    }
}